using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Thread = System.Threading.Thread;

namespace HusuabiEventLotteryProgram
{
    public partial class EditPeopleForm : MetroForm
    {
        private readonly MainForm _mainForm;
        private List<People> _removed = new List<People>();
        private bool _ignoreCloseEvent = false;

        public EditPeopleForm(MainForm mainForm)
        {
            this._mainForm = mainForm;
            InitializeComponent();
        }

        private void EditPeopleForm_Load(object sender, EventArgs e)
        {
            _mainForm.SetFont(this.listView1);
            _mainForm.SetFont(this.groupBox1);
            _mainForm.SetFont(this.label1);

            Thread thread = new Thread(new ThreadStart(LoadPeoples));
            thread.Start();
        }

        private void LoadPeoples()
        {
            this.btn_from_file.Enabled = false;
            this.tbx_people_name.Enabled = false;
            this.tbx_people_phone.Enabled = false;
            this.btn_people_add.Enabled = false;

            this.Text = "추첨 대상자 수정 [불러오는 중...]";
            this.progressBar1.Maximum = _mainForm.GetPeople().Count;
            this.progressBar1.Value = 0;

            this.listView1.BeginUpdate();

            this.listView1.Items.Clear();
            foreach (People people in _mainForm.GetPeople())
            {
                this.progressBar1.Value++;

                ListViewItem listViewItem =
                    new ListViewItem(people.Date.HasValue
                        ? people.Date.Value.ToString("yyyy-MM-dd HH:mm:ss")
                        : "자동 인식 실패");
                listViewItem.SubItems.Add(people.Name);
                listViewItem.SubItems.Add(people.Phone);

                this.listView1.Items.Add(listViewItem);
            }

            this.listView1.EndUpdate();

            this.Text = "추첨 대상자 수정";

            this.btn_from_file.Enabled = true;
            this.tbx_people_name.Enabled = true;
            this.tbx_people_phone.Enabled = true;
            this.btn_people_add.Enabled = true;

            this.Refresh();
        }

        private void btn_people_add_Click(object sender, EventArgs e)
        {
            AddPeople();
        }

        private void AddPeople()
        {
            if (string.IsNullOrEmpty(this.tbx_people_name.Text) || string.IsNullOrEmpty(this.tbx_people_phone.Text))
            {
                MessageBox.Show("이름과 전화번호를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem listViewItem = new ListViewItem("없음");
            listViewItem.SubItems.Add(this.tbx_people_name.Text);
            listViewItem.SubItems.Add(this.tbx_people_phone.Text);

            this.listView1.Items.Add(listViewItem);

            this.tbx_people_name.Clear();
            this.tbx_people_phone.Clear();
        }

        private void EditPeopleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ignoreCloseEvent)
            {
                return;
            }

            e.Cancel = true;

            Thread thread = new Thread(new ThreadStart(SavePeoples));
            thread.Start();
        }

        private void SavePeoples()
        {
            _ignoreCloseEvent = true;
            this.btn_from_file.Enabled = false;
            this.tbx_people_name.Enabled = false;
            this.tbx_people_phone.Enabled = false;
            this.btn_people_add.Enabled = false;

            this.Text = "추첨 대상자 수정 [저장 중...]";
            this.progressBar1.Maximum = this.listView1.Items.Count;
            this.progressBar1.Value = 0;

            this.Refresh();

            List<People> peoples = new List<People>();
            foreach (ListViewItem peopleItem in this.listView1.Items)
            {
                this.progressBar1.Value++;

                DateTime? dateTime;
                try
                {
                    dateTime = DateTime.ParseExact(peopleItem.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                }
                catch
                {
                    dateTime = null;
                }

                People people = new People();
                people.Date = dateTime;
                people.Name = peopleItem.SubItems[1].Text;
                people.Phone = peopleItem.SubItems[2].Text;

                peoples.Add(people);
            }

            _mainForm.SetPeople(peoples);

            this.Close();
        }

        private List<People> GetPeopleFromListView()
        {
            List<People> peoples = new List<People>();
            foreach (ListViewItem item in this.listView1.Items)
            {
                People people = new People()
                {
                    Name = item.SubItems[1].Text,
                    Phone = item.SubItems[2].Text
                };

                peoples.Add(people);
            }
            return peoples;
        }

        private bool HasPhone(List<People> peoples, string phone)
        {
            foreach (People people in peoples)
            {
                if (people.Phone == null)
                {
                    continue;
                }

                string first = people.Phone.Replace("-", string.Empty);
                string second = phone.Replace("-", string.Empty);

                if (first.Equals(second))
                {
                    return true;
                }
            }
            return false;
        }

        private DateTime FromUnixTime(long unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 9, 0, 0, DateTimeKind.Local);
            return epoch.AddMilliseconds(unixTime);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                Point pt = listView1.PointToScreen(e.Location);
                this.contextMenuStrip1.Show(pt);
            }
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void tbx_people_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPeople();
                this.tbx_people_name.Focus();
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.metroTextBox2.Enabled = this.metroRadioButton3.Checked;

            if (this.metroRadioButton3.Checked)
            {
                if (string.IsNullOrEmpty(this.metroTextBox2.Text))
                {
                    this.label1.Text = "[인식 가능한 라인 예시]\n경고: 문자를 입력해주세요.";
                }
                else
                {
                    this.label1.Text = "[인식 가능한 라인 예시]\n홍길동" + this.metroTextBox2.Text + "010-1234-5678\n홍길동" +
                                       this.metroTextBox2.Text + "01012345678";
                }
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroRadioButton1.Checked)
            {
                this.label1.Text = "[인식 가능한 라인 예시]\n홍길동 010-1234-5678\n홍길동 01012345678";
                this.metroTextBox2.Text = " ";
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroRadioButton2.Checked)
            {
                this.label1.Text = "[인식 가능한 라인 예시]\n홍길동/010-1234-5678\n홍길동/01012345678";
                this.metroTextBox2.Text = "/";
            }
        }

        private void metroTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(this.metroTextBox2.Text))
            {
                this.label1.Text = "[인식 가능한 라인 예시]\n경고: 문자를 입력해주세요.";
            }
            else
            {
                this.label1.Text = "[인식 가능한 라인 예시]\n홍길동" + this.metroTextBox2.Text + "010-1234-5678\n홍길동" +
                                   this.metroTextBox2.Text + "01012345678";
            }
        }

        private void btn_from_file_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.fileInput.Text))
            {
                MessageBox.Show("파일을 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(this.metroTextBox2.Text))
            {
                MessageBox.Show("문자를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetFromFile();
        }

        private void GetFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(this.fileInput.Text, GetEncoding(this.fileInput.Text));

                foreach (string line in lines)
                {
                    string[] splited = Regex.Split(line, this.metroTextBox2.Text);

                    if (splited.Length < 2)
                    {
                        continue;
                    }

                    string name = splited[0];
                    string phone = getPhone(splited);

                    ListViewItem listViewItem = new ListViewItem("없음");
                    listViewItem.SubItems.Add(name);
                    listViewItem.SubItems.Add(phone);

                    this.listView1.Items.Add(listViewItem);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류가 발생하였습니다.\n" + e.Message, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;
        }

        private string getPhone(string[] splited)
        {
            string result = "";

            for (int i = 1; i < splited.Length; i++)
            {
                result += splited[i];
            }

            return result;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "파일 선택";
            fileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileInput.Text = fileDialog.FileName;
            }
        }
    }
}