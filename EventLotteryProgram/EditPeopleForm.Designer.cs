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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.tbx_from_directly = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.peopleInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_from_file = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbx_from_file = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_from_directly = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            // tbx_from_directly
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.tbx_from_directly, true);
            this.tbx_from_directly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbx_from_directly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_from_directly.Location = new System.Drawing.Point(7, 58);
            this.tbx_from_directly.Name = "tbx_from_directly";
            this.tbx_from_directly.Size = new System.Drawing.Size(373, 137);
            this.tbx_from_directly.TabIndex = 18;
            this.tbx_from_directly.Text = "";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.peopleInfo});
            this.listView1.Location = new System.Drawing.Point(23, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // peopleInfo
            // 
            this.peopleInfo.Text = "추첨 대상자";
            this.peopleInfo.Width = 415;
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
            this.btn_from_file.Location = new System.Drawing.Point(6, 87);
            this.btn_from_file.Name = "btn_from_file";
            this.btn_from_file.Size = new System.Drawing.Size(374, 33);
            this.btn_from_file.TabIndex = 4;
            this.btn_from_file.Text = "파일로 부터 불러오기";
            this.btn_from_file.Click += new System.EventHandler(this.btn_from_file_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTextBox3);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.tbx_from_file);
            this.groupBox1.Controls.Add(this.btn_from_file);
            this.groupBox1.Location = new System.Drawing.Point(472, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일로 부터 불러오기";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(317, 38);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "파일로 부터 추첨 목록을 불러올 수 있습니다.\r\n추첨 대상 구분은 줄 바꿈으로 해주시기 바랍니다.";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox3.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(330, 58);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(50, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "...";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbx_from_file
            // 
            this.tbx_from_file.Location = new System.Drawing.Point(6, 58);
            this.tbx_from_file.Name = "tbx_from_file";
            this.tbx_from_file.PromptText = "우측 버튼을 눌러 파일을 선택해주세요";
            this.tbx_from_file.ReadOnly = true;
            this.tbx_from_file.Size = new System.Drawing.Size(318, 23);
            this.tbx_from_file.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_from_directly);
            this.groupBox2.Controls.Add(this.btn_from_directly);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(472, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 240);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "직접 입력해서 불러오기";
            // 
            // btn_from_directly
            // 
            this.btn_from_directly.Location = new System.Drawing.Point(7, 201);
            this.btn_from_directly.Name = "btn_from_directly";
            this.btn_from_directly.Size = new System.Drawing.Size(374, 33);
            this.btn_from_directly.TabIndex = 17;
            this.btn_from_directly.Text = "직접 입력해서 불러오기";
            this.btn_from_directly.Click += new System.EventHandler(this.btn_from_directly_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(7, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(317, 38);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "직접 입력해서 추첨 목록을 추가할 수 있습니다.\r\n추첨 대상 구분은 줄 바꿈으로 해주시기 바랍니다.";
            // 
            // EditPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPeopleForm";
            this.Resizable = false;
            this.Text = "추첨 대상자 수정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPeopleForm_FormClosing);
            this.Load += new System.EventHandler(this.EditPeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader peopleInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton btn_from_file;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tbx_from_file;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_from_directly;
        private System.Windows.Forms.RichTextBox tbx_from_directly;
    }
}