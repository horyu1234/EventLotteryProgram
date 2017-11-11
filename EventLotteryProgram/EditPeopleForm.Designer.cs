namespace EventLotteryProgram
{
    partial class EditPeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPeopleForm));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.peopleDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peopleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peoplePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_from_file = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.fileInput = new MetroFramework.Controls.MetroTextBox();
            this.tbx_people_name = new MetroFramework.Controls.MetroTextBox();
            this.tbx_people_phone = new MetroFramework.Controls.MetroTextBox();
            this.btn_people_add = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.peopleDate,
            this.peopleName,
            this.peoplePhone});
            this.listView1.Location = new System.Drawing.Point(23, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // peopleDate
            // 
            this.peopleDate.Text = "신청일";
            this.peopleDate.Width = 171;
            // 
            // peopleName
            // 
            this.peopleName.Text = "이름";
            this.peopleName.Width = 92;
            // 
            // peoplePhone
            // 
            this.peoplePhone.Text = "전화 번호";
            this.peoplePhone.Width = 159;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(394, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "리스트에서 이름을 우클릭 시 해당 항목을 삭제할 수 있습니다.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(472, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 26);
            this.progressBar1.TabIndex = 9;
            // 
            // btn_from_file
            // 
            this.btn_from_file.Location = new System.Drawing.Point(6, 279);
            this.btn_from_file.Name = "btn_from_file";
            this.btn_from_file.Size = new System.Drawing.Size(374, 58);
            this.btn_from_file.TabIndex = 4;
            this.btn_from_file.Text = "파일로 부터 불러오기";
            this.btn_from_file.Click += new System.EventHandler(this.btn_from_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "[인식 가능한 라인 예시]\r\n홍길동 010-1234-5678\r\n홍길동 01012345678";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTextBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.fileInput);
            this.groupBox1.Controls.Add(this.btn_from_file);
            this.groupBox1.Location = new System.Drawing.Point(472, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일로 부터 불러오기";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBox2);
            this.groupBox2.Controls.Add(this.metroRadioButton3);
            this.groupBox2.Controls.Add(this.metroRadioButton2);
            this.groupBox2.Controls.Add(this.metroRadioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 114);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이름, 전화번호 구분자";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Enabled = false;
            this.metroTextBox2.Location = new System.Drawing.Point(261, 16);
            this.metroTextBox2.MaxLength = 5;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PromptText = "문자";
            this.metroTextBox2.Size = new System.Drawing.Size(104, 23);
            this.metroTextBox2.TabIndex = 17;
            this.metroTextBox2.Text = " ";
            this.metroTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroTextBox2_KeyUp);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(208, 20);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(47, 15);
            this.metroRadioButton3.TabIndex = 16;
            this.metroRadioButton3.Text = "기타";
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(115, 20);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(28, 15);
            this.metroRadioButton2.TabIndex = 15;
            this.metroRadioButton2.Text = "/";
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(6, 20);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(47, 15);
            this.metroRadioButton1.TabIndex = 14;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "공백";
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(330, 20);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(50, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "...";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(6, 20);
            this.fileInput.Name = "fileInput";
            this.fileInput.PromptText = "파일을 선택해주세요 -->";
            this.fileInput.ReadOnly = true;
            this.fileInput.Size = new System.Drawing.Size(318, 23);
            this.fileInput.TabIndex = 12;
            // 
            // tbx_people_name
            // 
            this.tbx_people_name.Location = new System.Drawing.Point(472, 443);
            this.tbx_people_name.Name = "tbx_people_name";
            this.tbx_people_name.PromptText = "이름";
            this.tbx_people_name.Size = new System.Drawing.Size(118, 23);
            this.tbx_people_name.TabIndex = 1;
            // 
            // tbx_people_phone
            // 
            this.tbx_people_phone.Location = new System.Drawing.Point(596, 443);
            this.tbx_people_phone.Name = "tbx_people_phone";
            this.tbx_people_phone.PromptText = "전화번호";
            this.tbx_people_phone.Size = new System.Drawing.Size(181, 23);
            this.tbx_people_phone.TabIndex = 2;
            this.tbx_people_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_people_phone_KeyDown);
            // 
            // btn_people_add
            // 
            this.btn_people_add.Location = new System.Drawing.Point(783, 443);
            this.btn_people_add.Name = "btn_people_add";
            this.btn_people_add.Size = new System.Drawing.Size(75, 23);
            this.btn_people_add.TabIndex = 3;
            this.btn_people_add.Text = "추가";
            this.btn_people_add.Click += new System.EventHandler(this.btn_people_add_Click);
            // 
            // EditPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_people_add);
            this.Controls.Add(this.tbx_people_phone);
            this.Controls.Add(this.tbx_people_name);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPeopleForm";
            this.Text = "추첨 대상자 수정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPeopleForm_FormClosing);
            this.Load += new System.EventHandler(this.EditPeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader peopleName;
        private System.Windows.Forms.ColumnHeader peoplePhone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader peopleDate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton btn_from_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox fileInput;
        private MetroFramework.Controls.MetroTextBox tbx_people_name;
        private MetroFramework.Controls.MetroTextBox tbx_people_phone;
        private MetroFramework.Controls.MetroButton btn_people_add;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
    }
}