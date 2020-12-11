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
            this.bntexit = new System.Windows.Forms.Button();
            this.bntlogin = new System.Windows.Forms.Button();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::demobtl.Properties.Resources.buiphotable;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txbusername);
            this.panel1.Controls.Add(this.lbpassword);
            this.panel1.Controls.Add(this.lbusername);
            this.panel1.Controls.Add(this.txbpassword);
            this.panel1.Controls.Add(this.bntlogin);
            this.panel1.Controls.Add(this.bntexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 236);
            this.panel1.TabIndex = 0;
            // 
            // bntexit
            // 
            this.bntexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntexit.Location = new System.Drawing.Point(431, 172);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(89, 36);
            this.bntexit.TabIndex = 1;
            this.bntexit.Text = "Thoát";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // bntlogin
            // 
            this.bntlogin.Location = new System.Drawing.Point(174, 172);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(89, 36);
            this.bntlogin.TabIndex = 0;
            this.bntlogin.Text = "Đăng nhập";
            this.bntlogin.UseVisualStyleBackColor = true;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(174, 87);
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
            this.lbpassword.Location = new System.Drawing.Point(3, 87);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(113, 30);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Mật khẩu:";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(3, 18);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(165, 30);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "Tên đăng nhập:";
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(174, 18);
            this.txbusername.Multiline = true;
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(337, 30);
            this.txbusername.TabIndex = 1;
            this.txbusername.Text = "loc123";
            // 
            // fLogin
            // 
            this.AcceptButton = this.bntlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::demobtl.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bntexit;
            this.ClientSize = new System.Drawing.Size(541, 236);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txbpassword;
        private Label lbpassword;
        private Button bntexit;
        private Button bntlogin;
        private TextBox txbusername;
        private Label lbusername;
    }
}

