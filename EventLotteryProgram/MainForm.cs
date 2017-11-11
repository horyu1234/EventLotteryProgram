using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EventLotteryProgram
{
    public partial class MainForm : MetroForm
    {
        private const string ProgramVersion = "1.3.0";
        private readonly PrivateFontCollection _privateFonts = new PrivateFontCollection();
        private List<People> _peoples = new List<People>();
        private List<Prize> _prizes = new List<Prize>();
        private List<Prize> _lotteryPrizes = new List<Prize>();
        private List<People> _lotteryList = new List<People>();

        public MainForm()
        {
            AddFontFromResource("EventLotteryProgram.NanumSquareR.ttf");

            this.StyleManager = this.metroStyleManager;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            //            People people = new People();
            //            for (int i = 10; i <= 1000000; i++)
            //            {
            //                people.Name = "테스트";
            //                people.Phone = "010-00" + i + "-1234";
            //                _peoples.Add(people);
            //            }
        }

        private void AddFontFromResource(string resourceName)
        {
            var fontBytes = GetFontResourceBytes(resourceName);
            var fontData = Marshal.AllocCoTaskMem(fontBytes.Length);

            Marshal.Copy(fontBytes, 0, fontData, fontBytes.Length);
            _privateFonts.AddMemoryFont(fontData, fontBytes.Length);
            Marshal.FreeCoTaskMem(fontData);
        }

        private static byte[] GetFontResourceBytes(string fontResourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceStream = assembly.GetManifestResourceStream(fontResourceName);
            if (resourceStream == null)
                throw new Exception(string.Format("Unable to find font '{0}' in embedded resources.",
                    fontResourceName));
            var fontBytes = new byte[resourceStream.Length];
            resourceStream.Read(fontBytes, 0, (int) resourceStream.Length);
            resourceStream.Close();
            return fontBytes;
        }

        private void btn_edit_prize_Click(object sender, EventArgs e)
        {
            EditPrizeForm editPriceForm = new EditPrizeForm(this);
            editPriceForm.ShowDialog();
        }

        public List<Prize> GetPrize()
        {
            return this._prizes;
        }

        public void SetPrize(List<Prize> prizes)
        {
            this._prizes = prizes;
            UpdateTree();
        }

        public List<People> GetPeople()
        {
            return this._peoples;
        }

        public void SetPeople(List<People> peoples)
        {
            this._peoples = peoples;
        }

        private void UpdateTree(bool whenLottery = false)
        {
            this.treeView1.BeginUpdate();

            this.treeView1.Nodes.Clear();
            foreach (Prize prize in _prizes)
            {
                AddNode(prize, whenLottery);
            }

            this.treeView1.EndUpdate();
            this.treeView1.ExpandAll();
        }

        private void AddNode(Prize prizeIn, bool whenLottery)
        {
            Prize? priz = GetLotteryPrize(prizeIn);
            Prize prize;

            if (whenLottery)
            {
                if (!priz.HasValue)
                {
                    // ERROR
                    return;
                }

                prize = priz.Value;
            }
            else
            {
                prize = prizeIn;
            }

            string prizeText = prize.Name + " - " + prizeIn.Amount + "개";
            string prizeSupporterText = "서포터 - " + prize.Supporter;

            foreach (TreeNode node in this.treeView1.Nodes)
            {
                if (prizeSupporterText.Equals(node.Text))
                {
                    AddSubNode(whenLottery, prizeText, prize, node);
                    return;
                }
            }

            TreeNode treeNode = new TreeNode(prizeSupporterText);
            treeNode.NodeFont = new Font(this.treeView1.Font, FontStyle.Bold);

            AddSubNode(whenLottery, prizeText, prize, treeNode);

            this.treeView1.Nodes.Add(treeNode);
        }

        private void AddSubNode(bool whenLottery, string prizeText, Prize prize, TreeNode treeNode)
        {
            TreeNode treeNode2 = new TreeNode(prizeText);
            if (whenLottery && prize.To != null && prize.To.Count > 0 && _lotteryPrizes.Contains(prize))
            {
                foreach (People ppl in prize.To)
                {
                    string name = ppl.Name;
                    string phone = ppl.Phone;

                    if (this.cbx_hide.Checked)
                    {
                        phone = HidePrivacy(phone, 7);
                    }

                    treeNode2.Nodes.Add(name + " / " + phone);
                }
            }
            treeNode.Nodes.Add(treeNode2);
        }

        private string HidePrivacy(string phone, int amount)
        {
            string result = "";
            int i = 0;
            foreach (char c in phone)
            {
                i++;
                result += i > amount ? "*" : new string(new char[] {c});
            }
            return result;
        }

        private Prize? GetLotteryPrize(Prize prize)
        {
            foreach (Prize lotteryPriz in _lotteryPrizes)
            {
                if (lotteryPriz.Supporter.Equals(prize.Supporter) && lotteryPriz.Name.Equals(prize.Name))
                {
                    return lotteryPriz;
                }
            }
            return null;
        }

        private void btn_edit_people_Click(object sender, EventArgs e)
        {
            EditPeopleForm editPeopleForm = new EditPeopleForm(this);
            editPeopleForm.ShowDialog();
        }

        private void btn_pickup_one_Click(object sender, EventArgs e)
        {
            if (!Lottery())
            {
                MessageBox.Show("더 이상 추첨할 상품이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.btn_pickup_one.Text = "추첨 중입니다...";
                this.btn_pickup_one.Enabled = false;
                this.timer1.Start();
            }
        }

        private bool Lottery()
        {
            Prize? prize = GetNextPrize();
            if (!prize.HasValue)
            {
                return false;
            }

            int randomNumber = Between(0, _peoples.Count - 1);
            People people = _peoples[randomNumber];

            int whileCnt = 0;
            while (IsLotteryed(people))
            {
                whileCnt++;
                randomNumber = Between(0, _peoples.Count - 1);
                people = _peoples[randomNumber];

                if (whileCnt > _peoples.Count)
                {
                    MessageBox.Show("더 이상 추첨할 사람이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            _lotteryList.Add(people);

            Prize prizeNotNull = prize.Value;

            List<People> Tos = new List<People>();
            if (prizeNotNull.To != null)
            {
                Tos.AddRange(prizeNotNull.To);
            }
            Tos.Add(people);

            prizeNotNull.To = Tos;
            prizeNotNull.Amount--;

            SetPrize(prizeNotNull);

            UpdateTree(true);

            return true;
        }

        private void SetPrize(Prize p)
        {
            List<Prize> newPrizes = new List<Prize>();
            foreach (Prize prize in _lotteryPrizes)
            {
                if (prize.Supporter.Equals(p.Supporter) && prize.Name.Equals(p.Name))
                {
                    newPrizes.Add(p);
                }
                else
                {
                    newPrizes.Add(prize);
                }
            }

            _lotteryPrizes.Clear();
            _lotteryPrizes.AddRange(newPrizes);
        }

        private Prize? GetNextPrize()
        {
            if (_lotteryPrizes.Count == 0)
            {
                _lotteryPrizes.AddRange(_prizes);
            }

            foreach (Prize prize in _lotteryPrizes)
            {
                if (prize.Amount > 0)
                {
                    return prize;
                }
            }

            return null;
        }

        private bool IsLotteryed(People people)
        {
            foreach (People people1 in _lotteryList)
            {
                if (this.cbx_multi_phone.Checked && people1.Phone.Replace("-", string.Empty)
                        .Equals(people.Phone.Replace("-", string.Empty)))
                {
                    return true;
                }
            }

            return false;
        }

        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        // https://scottlilly.com/create-better-random-numbers-in-c/
        public static int Between(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int) (minimumValue + randomValueInRange);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "이벤트 추첨 프로그램 v" + ProgramVersion;

            DisableCheck();
            new Thread(new ThreadStart(stats)).Start();

            SetProgramIcon();

            SetFont(this.treeView1);
        }

        private void SetProgramIcon()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var programIconStream =
                assembly.GetManifestResourceStream("EventLotteryProgram.EventLotteryProgramIcon.ico");

            if (programIconStream == null)
            {
                return;
            }

            var icon = new Icon(programIconStream);
            this.Icon = icon;
        }

        public void DisableCheck()
        {
            try
            {
                using (var client = new WebClient())
                {
                    byte[] response =
                        client.DownloadData("http://checker.horyu.me/program/EventLotteryProgram/" +
                                            ProgramVersion); //byte[] 값 수신
                    string responseString = Encoding.UTF8.GetString(response); //수신값 string로 변환

                    if (responseString.Contains("true^"))
                    {
                        string reason = responseString.Replace("true^", "");
                        MessageBox.Show("프로그램 실행이 차단되었습니다.\n\n사유:" + reason, "경고",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Process.GetCurrentProcess().Kill();
                    }
                    else if (!responseString.Contains("false"))
                    {
                        MessageBox.Show("서버에서 보내는 응답을 해석 할 수 없습니다\n\n프로그램 접근이 거부되었습니다.\n" + responseString, "경고",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch
            {
                MessageBox.Show("인증 서버에 접속하는 중 오류가 발생하였습니다.\n\n프로그램 접근이 거부되었습니다.", "경고", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void stats()
        {
            try
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection();
                    string[] os_info = getOSInfo();
                    values["program"] = "EventLotteryProgram";
                    values["version"] = ProgramVersion;
                    values["username"] = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                    values["caption"] = os_info[0];
                    values["csname"] = os_info[1];
                    values["osarchitecture"] = os_info[2];
                    values["md5"] = GetMD5();
                    client.UploadValues("http://cafe24_horyu.horyu.me/Program/stats.php", values);
                }
            }
            catch
            {
            }
        }

        private string[] getOSInfo()
        {
            string[] output = new string[3];
            ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = cls.GetInstances();

            foreach (ManagementObject instance in instances)
            {
                foreach (PropertyData prop in instance.Properties)
                {
                    if (prop.Name.Equals("Caption")) output[0] = prop.Value.ToString();
                    if (prop.Name.Equals("CSName")) output[1] = prop.Value.ToString();
                    if (prop.Name.Equals("OSArchitecture")) output[2] = prop.Value.ToString();
                }
            }
            return output;
        }

        private string GetMD5()
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream stream = new FileStream(Process.GetCurrentProcess().MainModule.FileName, FileMode.Open,
                FileAccess.Read);

            md5.ComputeHash(stream);

            stream.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5.Hash.Length; i++)
                sb.Append(md5.Hash[i].ToString("x2"));

            return sb.ToString().ToUpperInvariant();
        }

        public void SetFont(Control control)
        {
            Font controlFont = control.Font;
            control.Font = new Font(_privateFonts.Families[0], controlFont.Size, controlFont.Style);
        }

        private bool ignoreCBXHideEvent = false;

        private void cbx_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreCBXHideEvent)
            {
                return;
            }

            if (this.cbx_hide.Checked)
            {
                UpdateTree(true);
            }
            else
            {
                ignoreCBXHideEvent = true;
                this.cbx_hide.Checked = true;

                if (
                    MessageBox.Show(
                        "본 체크 박스를 해제할 경우, 가려진 개인 정보들이 표시됩니다." +
                        "\n추첨 방송 중일 경우 절대 사용하지 마시기 바랍니다." +
                        "\n\n정말 개인 정보를 표시하시겠습니까?", "경고",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    ignoreCBXHideEvent = false;
                    return;
                }

                if (
                    MessageBox.Show(
                        "개인 정보 표시를 위해서는 한번 더 \"예\" 를 눌러주시기 바랍니다.", "경고",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    ignoreCBXHideEvent = false;
                    return;
                }

                this.cbx_hide.Checked = false;
                ignoreCBXHideEvent = false;

                UpdateTree(true);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.btn_pickup_one.Text = "추첨";
            this.btn_pickup_one.Enabled = true;
            this.timer1.Stop();
        }
    }
}