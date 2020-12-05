using System.Windows.Forms;

namespace demobtl
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntexit = new System.Windows.Forms.Button();
            this.bntlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 221);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bntexit);
            this.panel4.Controls.Add(this.bntlogin);
            this.panel4.Location = new System.Drawing.Point(8, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 72);
            this.panel4.TabIndex = 3;
            // 
            // bntexit
            // 
            this.bntexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntexit.Location = new System.Drawing.Point(394, 18);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(89, 36);
            this.bntexit.TabIndex = 1;
            this.bntexit.Text = "Thoát";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // bntlogin
            // 
            this.bntlogin.Location = new System.Drawing.Point(270, 18);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(89, 36);
            this.bntlogin.TabIndex = 0;
            this.bntlogin.Text = "Đăng nhập";
            this.bntlogin.UseVisualStyleBackColor = true;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbpassword);
            this.panel3.Controls.Add(this.lbpassword);
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 63);
            this.panel3.TabIndex = 2;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(174, 17);
            this.txbpassword.Multiline = true;
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.PasswordChar = '*';
            this.txbpassword.Size = new System.Drawing.Size(337, 29);
            this.txbpassword.TabIndex = 1;
            this.txbpassword.Text = "123456";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(3, 16);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(113, 30);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbusername);
            this.panel2.Controls.Add(this.lbusername);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 63);
            this.panel2.TabIndex = 0;
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(174, 25);
            this.txbusername.Multiline = true;
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(337, 30);
            this.txbusername.TabIndex = 1;
            this.txbusername.Text = "loc123";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(3, 16);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(165, 30);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            this.AcceptButton = this.bntlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntexit;
            this.ClientSize = new System.Drawing.Size(541, 236);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbpassword;
        private Label lbpassword;
        private Panel panel2;
        private TextBox txbusername;
        private Label lbusername;
        private Panel panel4;
        private Button bntexit;
        private Button bntlogin;
    }
}

