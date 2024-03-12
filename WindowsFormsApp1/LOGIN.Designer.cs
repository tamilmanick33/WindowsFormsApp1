namespace WindowsFormsApp1
{
    partial class LOGIN
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
            this.LFdataGridView1 = new System.Windows.Forms.DataGridView();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.SignUPLabel = new System.Windows.Forms.LinkLabel();
            this.LFPwdTxtBox = new System.Windows.Forms.TextBox();
            this.LOginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LFUNmeTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LFdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFdataGridView1
            // 
            this.LFdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LFdataGridView1.Location = new System.Drawing.Point(116, 24);
            this.LFdataGridView1.Name = "LFdataGridView1";
            this.LFdataGridView1.Size = new System.Drawing.Size(515, 317);
            this.LFdataGridView1.TabIndex = 0;
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Location = new System.Drawing.Point(301, 147);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(70, 13);
            this.PASSWORD.TabIndex = 2;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // SignUPLabel
            // 
            this.SignUPLabel.AutoSize = true;
            this.SignUPLabel.Location = new System.Drawing.Point(432, 179);
            this.SignUPLabel.Name = "SignUPLabel";
            this.SignUPLabel.Size = new System.Drawing.Size(55, 13);
            this.SignUPLabel.TabIndex = 3;
            this.SignUPLabel.TabStop = true;
            this.SignUPLabel.Text = "SignUP??";
            this.SignUPLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUPLabel_LinkClicked);
            // 
            // LFPwdTxtBox
            // 
            this.LFPwdTxtBox.Location = new System.Drawing.Point(287, 172);
            this.LFPwdTxtBox.Name = "LFPwdTxtBox";
            this.LFPwdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LFPwdTxtBox.TabIndex = 5;
            // 
            // LOginbtn
            // 
            this.LOginbtn.Location = new System.Drawing.Point(296, 221);
            this.LOginbtn.Name = "LOginbtn";
            this.LOginbtn.Size = new System.Drawing.Size(75, 23);
            this.LOginbtn.TabIndex = 6;
            this.LOginbtn.Text = "LOGIN";
            this.LOginbtn.UseVisualStyleBackColor = true;
            this.LOginbtn.Click += new System.EventHandler(this.LOginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER NAME";
            // 
            // LFUNmeTxtBox
            // 
            this.LFUNmeTxtBox.Location = new System.Drawing.Point(287, 112);
            this.LFUNmeTxtBox.Name = "LFUNmeTxtBox";
            this.LFUNmeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LFUNmeTxtBox.TabIndex = 8;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LFUNmeTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOginbtn);
            this.Controls.Add(this.LFPwdTxtBox);
            this.Controls.Add(this.SignUPLabel);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.LFdataGridView1);
            this.Name = "LOGIN";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LFdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LFdataGridView1;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.LinkLabel SignUPLabel;
        private System.Windows.Forms.TextBox LFPwdTxtBox;
        private System.Windows.Forms.Button LOginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LFUNmeTxtBox;
    }
}

