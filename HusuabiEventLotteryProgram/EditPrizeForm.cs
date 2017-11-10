using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HusuabiEventLotteryProgram
{
    public partial class EditPrizeForm : MetroForm
    {
        private readonly MainForm _mainForm;

        public EditPrizeForm(MainForm mainForm)
        {
            this._mainForm = mainForm;
            this.StyleManager = this.metroStyleManager;

            InitializeComponent();
        }

        private void EditPriceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Validate())
            {
                e.Cancel = true;
                return;
            }

            List<Prize> prizes = new List<Prize>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                {
                    continue;
                }

                string supporter = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string amount = row.Cells[2].Value.ToString();

                Prize prize = new Prize();
                prize.Supporter = supporter;
                prize.Name = name;
                prize.Amount = int.Parse(amount);

                prizes.Add(prize);
            }

            _mainForm.SetPrize(prizes);
        }

        private bool Validate()
        {
            foreach (DataGridViewRow prize in this.dataGridView1.Rows)
            {
                if (prize.Cells[0].Value == null && prize.Cells[1].Value == null && prize.Cells[2].Value == null)
                {
                    continue;
                }

                object prizeSupporter = prize.Cells[0].Value;
                object prizeName = prize.Cells[1].Value;
                object prizeCount = prize.Cells[2].Value;

                if (string.IsNullOrEmpty(prizeSupporter?.ToString())
                    || string.IsNullOrEmpty(prizeName?.ToString())
                    || string.IsNullOrEmpty(prizeCount?.ToString()))
                {
                    MessageBox.Show("입력되지 않은 값이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(prizeCount.ToString(), out int trash))
                {
                    MessageBox.Show("상품 수에 정수가 아닌 문자가 포함되어 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void EditPrizeForm_Load(object sender, EventArgs e)
        {
            SetProgramIcon();

            _mainForm.SetFont(this.dataGridView1);

            this.dataGridView1.Rows.Clear();
            foreach (Prize prize in _mainForm.GetPrize())
            {
                this.dataGridView1.Rows.Add(prize.Supporter, prize.Name, prize.Amount);
            }
        }

        private void SetProgramIcon()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var programIconStream =
                assembly.GetManifestResourceStream("HusuabiEventLotteryProgram.HusuabiEventLotteryProgramIcon.ico");

            if (programIconStream == null)
            {
                return;
            }

            var icon = new Icon(programIconStream);
            this.Icon = icon;
        }
    }
}