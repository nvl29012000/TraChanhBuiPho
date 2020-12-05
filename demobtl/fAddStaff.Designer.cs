namespace demobtl
{
    partial class fAddStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkstaff = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxstaff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbsalary = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(163, 46);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(200, 20);
            this.txbname.TabIndex = 1;
            // 
            // txbphone
            // 
            this.txbphone.Location = new System.Drawing.Point(163, 91);
            this.txbphone.Name = "txbphone";
            this.txbphone.Size = new System.Drawing.Size(200, 20);
            this.txbphone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // dtpkstaff
            // 
            this.dtpkstaff.CustomFormat = "dd/MM/yyyy";
            this.dtpkstaff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkstaff.Location = new System.Drawing.Point(163, 133);
            this.dtpkstaff.Name = "dtpkstaff";
            this.dtpkstaff.Size = new System.Drawing.Size(200, 20);
            this.dtpkstaff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vị trí";
            // 
            // cbxstaff
            // 
            this.cbxstaff.FormattingEnabled = true;
            this.cbxstaff.Items.AddRange(new object[] {
            "Thu Ngân",
            "Pha Chế",
            "Phục Vụ",
            "Bảo Vệ"});
            this.cbxstaff.Location = new System.Drawing.Point(163, 176);
            this.cbxstaff.Name = "cbxstaff";
            this.cbxstaff.Size = new System.Drawing.Size(200, 21);
            this.cbxstaff.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lương cơ bản";
            // 
            // txbsalary
            // 
            this.txbsalary.Location = new System.Drawing.Point(164, 223);
            this.txbsalary.Name = "txbsalary";
            this.txbsalary.Size = new System.Drawing.Size(199, 20);
            this.txbsalary.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(181, 308);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // addstaff
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 367);
            this.Controls.Add(this.btnadd);
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
            this.Name = "addstaff";
            this.Text = "Thêm nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkstaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxstaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbsalary;
        private System.Windows.Forms.Button btnadd;
    }
}