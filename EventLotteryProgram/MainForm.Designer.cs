namespace EventLotteryProgram
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_edit_people = new MetroFramework.Controls.MetroButton();
            this.btn_edit_prize = new MetroFramework.Controls.MetroButton();
            this.btn_pickup_one = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_status = new MetroFramework.Controls.MetroLabel();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_protect_phone = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_protect_name = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_protect_email = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // treeView1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.treeView1, true);
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treeView1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.treeView1.Location = new System.Drawing.Point(23, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(555, 473);
            this.treeView1.TabIndex = 3;
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
            // btn_pickup_one
            // 
            this.btn_pickup_one.Location = new System.Drawing.Point(584, 492);
            this.btn_pickup_one.Name = "btn_pickup_one";
            this.btn_pickup_one.Size = new System.Drawing.Size(272, 44);
            this.btn_pickup_one.TabIndex = 4;
            this.btn_pickup_one.Text = "추첨";
            this.btn_pickup_one.Click += new System.EventHandler(this.btn_pickup_one_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_status.Location = new System.Drawing.Point(370, 10);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(302, 50);
            this.label_status.TabIndex = 13;
            this.label_status.Text = "시스템 시간: 0000-00-00 오전 00:00\r\n추첨 대상자 수: 0명";
            // 
            // timer_status
            // 
            this.timer_status.Enabled = true;
            this.timer_status.Interval = 500;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_protect_phone);
            this.groupBox1.Controls.Add(this.cbx_protect_name);
            this.groupBox1.Controls.Add(this.cbx_protect_email);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(584, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 231);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보 보호";
            // 
            // cbx_protect_phone
            // 
            this.cbx_protect_phone.AutoSize = true;
            this.cbx_protect_phone.Checked = true;
            this.cbx_protect_phone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_protect_phone.Location = new System.Drawing.Point(6, 194);
            this.cbx_protect_phone.Name = "cbx_protect_phone";
            this.cbx_protect_phone.Size = new System.Drawing.Size(164, 15);
            this.cbx_protect_phone.TabIndex = 3;
            this.cbx_protect_phone.Text = "전화번호 형식 일부 가리기";
            this.cbx_protect_phone.UseVisualStyleBackColor = true;
            this.cbx_protect_phone.CheckedChanged += new System.EventHandler(this.cbx_protect_phone_CheckedChanged);
            // 
            // cbx_protect_name
            // 
            this.cbx_protect_name.AutoSize = true;
            this.cbx_protect_name.Checked = true;
            this.cbx_protect_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_protect_name.Location = new System.Drawing.Point(6, 152);
            this.cbx_protect_name.Name = "cbx_protect_name";
            this.cbx_protect_name.Size = new System.Drawing.Size(140, 15);
            this.cbx_protect_name.TabIndex = 2;
            this.cbx_protect_name.Text = "이름 형식 일부 가리기";
            this.cbx_protect_name.UseVisualStyleBackColor = true;
            this.cbx_protect_name.CheckedChanged += new System.EventHandler(this.cbx_protect_name_CheckedChanged);
            // 
            // cbx_protect_email
            // 
            this.cbx_protect_email.AutoSize = true;
            this.cbx_protect_email.Checked = true;
            this.cbx_protect_email.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_protect_email.Location = new System.Drawing.Point(6, 173);
            this.cbx_protect_email.Name = "cbx_protect_email";
            this.cbx_protect_email.Size = new System.Drawing.Size(152, 15);
            this.cbx_protect_email.TabIndex = 1;
            this.cbx_protect_email.Text = "이메일 형식 일부 가리기";
            this.cbx_protect_email.UseVisualStyleBackColor = true;
            this.cbx_protect_email.CheckedChanged += new System.EventHandler(this.cbx_protect_email_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(217, 114);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "당첨자의 개인 정보 일부를\r\n가리는 기능입니다.\r\n\r\n추첨 영상을 촬영하거나\r\n실시간 방송 중일 경우\r\n반드시 활성화해주시기 바랍니다.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EventLotteryProgram.Properties.Resources.EventLotteryProgramFooter;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(23, 548);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pickup_one);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_edit_prize);
            this.Controls.Add(this.btn_edit_people);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "이벤트 추첨 프로그램";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel label_status;
        private System.Windows.Forms.Timer timer_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox cbx_protect_email;
        private MetroFramework.Controls.MetroCheckBox cbx_protect_phone;
        private MetroFramework.Controls.MetroCheckBox cbx_protect_name;
    }
}

