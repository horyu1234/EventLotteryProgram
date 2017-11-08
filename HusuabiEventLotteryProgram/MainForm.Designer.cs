namespace HusuabiEventLotteryProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.btn_edit_people = new MetroFramework.Controls.MetroButton();
            this.btn_edit_prize = new MetroFramework.Controls.MetroButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_pickup_one = new MetroFramework.Controls.MetroButton();
            this.cbx_multi_phone = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_hide = new MetroFramework.Controls.MetroCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // btn_edit_people
            // 
            this.btn_edit_people.Location = new System.Drawing.Point(584, 63);
            this.btn_edit_people.Name = "btn_edit_people";
            this.btn_edit_people.Size = new System.Drawing.Size(133, 44);
            this.btn_edit_people.TabIndex = 1;
            this.btn_edit_people.Text = "추첨 대상자 수정";
            this.btn_edit_people.Click += new System.EventHandler(this.btn_edit_people_Click);
            // 
            // btn_edit_prize
            // 
            this.btn_edit_prize.Location = new System.Drawing.Point(723, 63);
            this.btn_edit_prize.Name = "btn_edit_prize";
            this.btn_edit_prize.Size = new System.Drawing.Size(133, 44);
            this.btn_edit_prize.TabIndex = 2;
            this.btn_edit_prize.Text = "상품 수정";
            this.btn_edit_prize.Click += new System.EventHandler(this.btn_edit_prize_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(23, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(555, 473);
            this.treeView1.TabIndex = 3;
            // 
            // btn_pickup_one
            // 
            this.btn_pickup_one.Location = new System.Drawing.Point(584, 492);
            this.btn_pickup_one.Name = "btn_pickup_one";
            this.btn_pickup_one.Size = new System.Drawing.Size(272, 44);
            this.btn_pickup_one.TabIndex = 4;
            this.btn_pickup_one.Text = "추첨";
            this.btn_pickup_one.Click += new System.EventHandler(this.btn_pickup_one_Click);
            // 
            // cbx_multi_phone
            // 
            this.cbx_multi_phone.AutoSize = true;
            this.cbx_multi_phone.Checked = true;
            this.cbx_multi_phone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_multi_phone.Location = new System.Drawing.Point(584, 471);
            this.cbx_multi_phone.Name = "cbx_multi_phone";
            this.cbx_multi_phone.Size = new System.Drawing.Size(160, 15);
            this.cbx_multi_phone.TabIndex = 7;
            this.cbx_multi_phone.Text = "중복 추첨 제외 - 전화번호";
            // 
            // cbx_hide
            // 
            this.cbx_hide.AutoSize = true;
            this.cbx_hide.Checked = true;
            this.cbx_hide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_hide.Location = new System.Drawing.Point(584, 450);
            this.cbx_hide.Name = "cbx_hide";
            this.cbx_hide.Size = new System.Drawing.Size(280, 15);
            this.cbx_hide.TabIndex = 8;
            this.cbx_hide.Text = "개인정보 일부 가림 (찰영 중 반드시 활성화 필요)";
            this.cbx_hide.CheckedChanged += new System.EventHandler(this.cbx_hide_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(23, 544);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(683, 105);
            this.label2.TabIndex = 11;
            this.label2.Text = "본 프로그램은 유튜버 \"허수아비\" 님을 위해 개발되었으며, 다른 곳에서는 사용이 불가합니다.\r\n\r\n개발자: 류현오(horyu1234)\r\n프로필 사" +
    "이트: https://activity.horyu.me\r\n\r\nCopyright horyu1234 All rights reserved\r\n* 본 프로" +
    "그램에는 네이버에서 제공한 나눔글꼴이 적용되어 있습니다.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_hide);
            this.Controls.Add(this.cbx_multi_phone);
            this.Controls.Add(this.btn_pickup_one);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_edit_prize);
            this.Controls.Add(this.btn_edit_people);
            this.Name = "MainForm";
            this.Text = "허수아비 이벤트 추첨 프로그램 v1.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroButton btn_edit_people;
        private MetroFramework.Controls.MetroButton btn_edit_prize;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroButton btn_pickup_one;
        private MetroFramework.Controls.MetroCheckBox cbx_multi_phone;
        private MetroFramework.Controls.MetroCheckBox cbx_hide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

