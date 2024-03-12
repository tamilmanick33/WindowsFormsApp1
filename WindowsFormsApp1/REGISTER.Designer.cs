namespace WindowsFormsApp1
{
    partial class REGISTER
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RFcmprLbl = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.RFUNmeTxtBox = new System.Windows.Forms.TextBox();
            this.RFPwdTxtBox = new System.Windows.Forms.TextBox();
            this.RFReEntrTxtBox = new System.Windows.Forms.TextBox();
            this.RFUpdateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RFCIDtxtBox = new System.Windows.Forms.TextBox();
            this.RFdeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RE ENTER PASSWORD";
            // 
            // RFcmprLbl
            // 
            this.RFcmprLbl.AutoSize = true;
            this.RFcmprLbl.Location = new System.Drawing.Point(494, 226);
            this.RFcmprLbl.Name = "RFcmprLbl";
            this.RFcmprLbl.Size = new System.Drawing.Size(35, 13);
            this.RFcmprLbl.TabIndex = 4;
            this.RFcmprLbl.Text = "label4";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(356, 259);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(75, 23);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "REGISTER";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // RFUNmeTxtBox
            // 
            this.RFUNmeTxtBox.Location = new System.Drawing.Point(344, 88);
            this.RFUNmeTxtBox.Name = "RFUNmeTxtBox";
            this.RFUNmeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RFUNmeTxtBox.TabIndex = 6;
            // 
            // RFPwdTxtBox
            // 
            this.RFPwdTxtBox.Location = new System.Drawing.Point(344, 151);
            this.RFPwdTxtBox.Name = "RFPwdTxtBox";
            this.RFPwdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RFPwdTxtBox.TabIndex = 7;
            // 
            // RFReEntrTxtBox
            // 
            this.RFReEntrTxtBox.Location = new System.Drawing.Point(344, 219);
            this.RFReEntrTxtBox.Name = "RFReEntrTxtBox";
            this.RFReEntrTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RFReEntrTxtBox.TabIndex = 8;
            this.RFReEntrTxtBox.TextChanged += new System.EventHandler(this.RFReEntrTxtBox_TextChanged);
            // 
            // RFUpdateBtn
            // 
            this.RFUpdateBtn.Location = new System.Drawing.Point(275, 259);
            this.RFUpdateBtn.Name = "RFUpdateBtn";
            this.RFUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.RFUpdateBtn.TabIndex = 10;
            this.RFUpdateBtn.Text = "UPDATE";
            this.RFUpdateBtn.UseVisualStyleBackColor = true;
            this.RFUpdateBtn.Click += new System.EventHandler(this.RFUpdateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CID";
            // 
            // RFCIDtxtBox
            // 
            this.RFCIDtxtBox.Location = new System.Drawing.Point(217, 219);
            this.RFCIDtxtBox.Name = "RFCIDtxtBox";
            this.RFCIDtxtBox.Size = new System.Drawing.Size(100, 20);
            this.RFCIDtxtBox.TabIndex = 12;
            // 
            // RFdeleteBtn
            // 
            this.RFdeleteBtn.Location = new System.Drawing.Point(462, 259);
            this.RFdeleteBtn.Name = "RFdeleteBtn";
            this.RFdeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.RFdeleteBtn.TabIndex = 13;
            this.RFdeleteBtn.Text = "DELETE";
            this.RFdeleteBtn.UseVisualStyleBackColor = true;
            this.RFdeleteBtn.Click += new System.EventHandler(this.RFdeleteBtn_Click);
            // 
            // REGISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RFdeleteBtn);
            this.Controls.Add(this.RFCIDtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RFUpdateBtn);
            this.Controls.Add(this.RFReEntrTxtBox);
            this.Controls.Add(this.RFPwdTxtBox);
            this.Controls.Add(this.RFUNmeTxtBox);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.RFcmprLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "REGISTER";
            this.Text = "REGISTER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RFcmprLbl;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.TextBox RFUNmeTxtBox;
        private System.Windows.Forms.TextBox RFPwdTxtBox;
        private System.Windows.Forms.TextBox RFReEntrTxtBox;
        private System.Windows.Forms.Button RFUpdateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RFCIDtxtBox;
        private System.Windows.Forms.Button RFdeleteBtn;
    }
}