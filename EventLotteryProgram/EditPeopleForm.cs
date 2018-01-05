using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using Thread = System.Threading.Thread;

namespace EventLotteryProgram
{
    public partial class EditPeopleForm : MetroForm
    {
        private readonly MainForm _mainForm;
        private bool _ignoreCloseEvent = false;
        private bool _savedPeoples = false;

        public EditPeopleForm(MainForm mainForm)
        {
            this._mainForm = mainForm;
            InitializeComponent();
        }

        private void EditPeopleForm_Load(object sender, EventArgs e)
        {
            SetProgramIcon();

            _mainForm.SetFont(this.listView1);
            _mainForm.SetFont(this.groupBox2);
            _mainForm.SetFont(this.groupBox1);
            _mainForm.SetFont(this.metroLabel2);
            _mainForm.SetFont(this.metroLabel1);
            _mainForm.SetFont(this.tbx_from_directly);
            _mainForm.SetFont(this.tbx_from_file);
            _mainForm.SetFont(this.btn_from_directly);
            _mainForm.SetFont(this.btn_from_file);

            _ignoreCloseEvent = false;
            _savedPeoples = false;

            Thread thread = new Thread(new ThreadStart(LoadPeoples));
            thread.Start();
        }

        private void SetProgramIcon()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var programIconStream =
                assembly.GetManifestResourceStream("EventLotteryProgram.Resources.EventLotteryProgramIcon.ico");

            if (programIconStream == null)
            {
                return;
            }

            var icon = new Icon(programIconStream);
            this.Icon = icon;
        }

        private void LoadPeoples()
        {
            _ignoreCloseEvent = true;
            this.btn_from_directly.Enabled = false;
            this.btn_from_file.Enabled = false;

            this.Text = "추첨 대상자 수정 [불러오는 중...]";
            this.progressBar1.Maximum = _mainForm.GetPeople().Count;
            this.progressBar1.Value = 0;

            this.listView1.BeginUpdate();

            this.listView1.Items.Clear();
            foreach (People people in _mainForm.GetPeople())
            {
                this.progressBar1.Value++;

                ListViewItem listViewItem = new ListViewItem(people.Info);

                this.listView1.Items.Add(listViewItem);
            }

            this.listView1.EndUpdate();

            this.Text = "추첨 대상자 수정";

            this.btn_from_directly.Enabled = true;
            this.btn_from_file.Enabled = true;

            _ignoreCloseEvent = false;

            this.Refresh();
        }

        private void AddPeople()
        {
            _ignoreCloseEvent = true;
            this.btn_from_directly.Enabled = false;
            this.btn_from_directly.Text = "불러오는 중";

            this.progressBar1.Maximum = this.tbx_from_directly.Lines.Length;
            this.progressBar1.Value = 0;

            this.listView1.BeginUpdate();
            foreach (string line in this.tbx_from_directly.Lines)
            {
                this.progressBar1.Value++;

                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                ListViewItem listViewItem = new ListViewItem(line);
                this.listView1.Items.Add(listViewItem);
            }

            this.listView1.EndUpdate();
            this.tbx_from_directly.Clear();
            this.btn_from_directly.Text = "직접 입력해서 불러오기";
            this.btn_from_directly.Enabled = true;
            _ignoreCloseEvent = false;
        }

        private void EditPeopleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ignoreCloseEvent)
            {
                e.Cancel = true;
                return;
            }

            if (!_savedPeoples)
            {
                e.Cancel = true;

                Thread thread = new Thread(new ThreadStart(SavePeoples));
                thread.Start();
            }
        }

        private void SavePeoples()
        {
            _ignoreCloseEvent = true;
            this.btn_from_directly.Enabled = false;
            this.btn_from_file.Enabled = false;

            this.Text = "추첨 대상자 수정 [저장 중...]";
            this.progressBar1.Maximum = this.listView1.Items.Count;
            this.progressBar1.Value = 0;

            this.Refresh();

            List<People> peoples = new List<People>();
            foreach (ListViewItem peopleItem in this.listView1.Items)
            {
                this.progressBar1.Value++;

                People people = new People();
                people.Info = peopleItem.Text;

                peoples.Add(people);
            }

            _mainForm.SetPeople(peoples);

            _savedPeoples = true;
            _ignoreCloseEvent = false;

            this.Close();
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

        private void btn_from_file_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbx_from_file.Text))
            {
                MessageBox.Show("파일을 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread thread = new Thread(new ThreadStart(GetFromFile));
            thread.Start();
        }

        private void GetFromFile()
        {
            _ignoreCloseEvent = true;
            this.btn_from_file.Enabled = false;
            this.btn_from_file.Text = "불러오는 중";

            try
            {
                string[] lines = File.ReadAllLines(this.tbx_from_file.Text, GetEncoding(this.tbx_from_file.Text));

                this.progressBar1.Maximum = lines.Length;
                this.progressBar1.Value = 0;
                this.listView1.BeginUpdate();
                foreach (string line in lines)
                {
                    this.progressBar1.Value++;

                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    ListViewItem listViewItem = new ListViewItem(line);

                    this.listView1.Items.Add(listViewItem);
                }

                this.listView1.EndUpdate();
            }
            catch (Exception e)
            {
                MessageBox.Show("오류가 발생하였습니다.\n" + e.Message, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.btn_from_file.Text = "파일로 부터 불러오기";
            this.btn_from_file.Enabled = true;
            _ignoreCloseEvent = false;
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
            return Encoding.UTF8;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("불러오는 파일의 인코딩은\nUTF-8 (BOM 있음) 을 권장합니다.\n\n이외의 인코딩의 경우 한글이 깨질 수 있습니다.", "인코딩 안내", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "파일 선택";
            fileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_from_file.Text = fileDialog.FileName;
            }
        }

        private void btn_from_directly_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbx_from_directly.Text))
            {
                MessageBox.Show("추첨 대상자를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread thread = new Thread(new ThreadStart(AddPeople));
            thread.Start();
        }
    }
}