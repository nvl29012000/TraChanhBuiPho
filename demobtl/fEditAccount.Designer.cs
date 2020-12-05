namespace demobtl
{
    partial class fEditAccount
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
            this.chkbox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbusename = new System.Windows.Forms.Label();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkbox1
            // 
            this.chkbox1.AutoSize = true;
            this.chkbox1.Location = new System.Drawing.Point(150, 119);
            this.chkbox1.Name = "chkbox1";
            this.chkbox1.Size = new System.Drawing.Size(156, 17);
            this.chkbox1.TabIndex = 13;
            this.chkbox1.Text = "Tài khoản cho quản trị viên";
            this.chkbox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài khoản";
            // 
            // lbusename
            // 
            this.lbusename.AutoSize = true;
            this.lbusename.Location = new System.Drawing.Point(147, 41);
            this.lbusename.Name = "lbusename";
            this.lbusename.Size = new System.Drawing.Size(0, 13);
            this.lbusename.TabIndex = 15;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(150, 68);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(156, 20);
            this.txbpassword.TabIndex = 16;
            // 
            // editaccount
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 229);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.lbusename);
            this.Controls.Add(this.chkbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editaccount";
            this.Text = "Sửa tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbusename;
        private System.Windows.Forms.TextBox txbpassword;
    }
}