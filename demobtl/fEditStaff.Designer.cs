namespace demobtl
{
    partial class fEditStaff
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
            this.btnedit = new System.Windows.Forms.Button();
            this.txbsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxstaff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkstaff = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(154, 372);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 21;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txbsalary
            // 
            this.txbsalary.Location = new System.Drawing.Point(137, 287);
            this.txbsalary.Name = "txbsalary";
            this.txbsalary.Size = new System.Drawing.Size(199, 20);
            this.txbsalary.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lương cơ bản";
            // 
            // cbxstaff
            // 
            this.cbxstaff.FormattingEnabled = true;
            this.cbxstaff.Items.AddRange(new object[] {
            "Thu Ngân",
            "Pha Chế",
            "Phục Vụ",
            "Bảo Vệ"});
            this.cbxstaff.Location = new System.Drawing.Point(136, 240);
            this.cbxstaff.Name = "cbxstaff";
            this.cbxstaff.Size = new System.Drawing.Size(200, 21);
            this.cbxstaff.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vị trí";
            // 
            // dtpkstaff
            // 
            this.dtpkstaff.CustomFormat = "dd/MM/yyyy";
            this.dtpkstaff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkstaff.Location = new System.Drawing.Point(136, 197);
            this.dtpkstaff.Name = "dtpkstaff";
            this.dtpkstaff.Size = new System.Drawing.Size(200, 20);
            this.dtpkstaff.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày sinh";
            // 
            // txbphone
            // 
            this.txbphone.Location = new System.Drawing.Point(136, 155);
            this.txbphone.Name = "txbphone";
            this.txbphone.Size = new System.Drawing.Size(200, 20);
            this.txbphone.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SĐT";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(136, 110);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(200, 20);
            this.txbname.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(133, 62);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(39, 13);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "Họ tên";
            // 
            // fEditStaff
            // 
            this.AcceptButton = this.btnedit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 437);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txbsalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxstaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpkstaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.label1);
            this.Name = "fEditStaff";
            this.Text = "Sửa nhân viên";
            this.Load += new System.EventHandler(this.fEditStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txbsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxstaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkstaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbID;
    }
}