namespace EventLotteryProgram
{
    partial class EditPrizeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrizeSupporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrizeSupporter,
            this.PrizeName,
            this.PrizeAmount});
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(451, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrizeSupporter
            // 
            this.PrizeSupporter.HeaderText = "상품 서포터";
            this.PrizeSupporter.Name = "PrizeSupporter";
            // 
            // PrizeName
            // 
            this.PrizeName.HeaderText = "상품 명";
            this.PrizeName.Name = "PrizeName";
            // 
            // PrizeAmount
            // 
            this.PrizeAmount.HeaderText = "상품 수";
            this.PrizeAmount.Name = "PrizeAmount";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(460, 38);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "항목 수정 시 항목을 더블 클릭하여 가능합니다.\r\n항목 삭제 시에는 항목을 선택 후 Delete 키를 눌러, 삭제하실 수 있습니다.";
            // 
            // EditPrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 534);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPrizeForm";
            this.Resizable = false;
            this.Text = "상품 수정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPriceForm_FormClosing);
            this.Load += new System.EventHandler(this.EditPrizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeSupporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeAmount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}