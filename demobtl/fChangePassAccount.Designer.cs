namespace demobtl
{
    partial class fChangePassAccount
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
            this.btneditaccount = new System.Windows.Forms.Button();
            this.txbrepass = new System.Windows.Forms.TextBox();
            this.txbnewpass = new System.Windows.Forms.TextBox();
            this.txboldpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btneditaccount
            // 
            this.btneditaccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btneditaccount.Location = new System.Drawing.Point(194, 289);
            this.btneditaccount.Name = "btneditaccount";
            this.btneditaccount.Size = new System.Drawing.Size(110, 23);
            this.btneditaccount.TabIndex = 20;
            this.btneditaccount.Text = "Lưu thông tin";
            this.btneditaccount.UseVisualStyleBackColor = true;
            this.btneditaccount.Click += new System.EventHandler(this.btneditaccount_Click);
            // 
            // txbrepass
            // 
            this.txbrepass.Location = new System.Drawing.Point(194, 216);
            this.txbrepass.Name = "txbrepass";
            this.txbrepass.Size = new System.Drawing.Size(176, 20);
            this.txbrepass.TabIndex = 19;
            this.txbrepass.UseSystemPasswordChar = true;
            // 
            // txbnewpass
            // 
            this.txbnewpass.Location = new System.Drawing.Point(194, 165);
            this.txbnewpass.Name = "txbnewpass";
            this.txbnewpass.Size = new System.Drawing.Size(176, 20);
            this.txbnewpass.TabIndex = 18;
            this.txbnewpass.UseSystemPasswordChar = true;
            // 
            // txboldpass
            // 
            this.txboldpass.Location = new System.Drawing.Point(194, 120);
            this.txboldpass.Name = "txboldpass";
            this.txboldpass.Size = new System.Drawing.Size(176, 20);
            this.txboldpass.TabIndex = 17;
            this.txboldpass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(83, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Xác nhận mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(83, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(83, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbusername.Location = new System.Drawing.Point(191, 76);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(0, 13);
            this.lbusername.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(83, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(169, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // fChangePassAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 338);
            this.Controls.Add(this.btneditaccount);
            this.Controls.Add(this.txbrepass);
            this.Controls.Add(this.txbnewpass);
            this.Controls.Add(this.txboldpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "fChangePassAccount";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fChangePassAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneditaccount;
        private System.Windows.Forms.TextBox txbrepass;
        private System.Windows.Forms.TextBox txbnewpass;
        private System.Windows.Forms.TextBox txboldpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}