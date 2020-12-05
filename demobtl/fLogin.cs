using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demobtl
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //xác nhận đóng ứng dụng
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng?", "Thông báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
        }


        //xử lý đăng nhập
        private void bntlogin_Click(object sender, EventArgs e)
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN query = (from ac in db.TAIKHOANs where ac.Username.Equals(txbusername.Text) && ac.Password.Equals(txbpassword.Text) select ac).SingleOrDefault();
                if (query == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                    return;
                }
                else
                    if (query.Admin == false)
                {
                    fGiaoDien f = new fGiaoDien();
                    this.Hide();
                    f.ShowDialog();
                    txbusername.ResetText();
                    txbpassword.ResetText();
                    this.Show();
                }
                else
                {
                    fAdmin fa = new fAdmin();
                    this.Hide();
                    fa.ShowDialog();
                    txbusername.ResetText();
                    txbpassword.ResetText();
                    this.Show();
                }
            }
        }
    }
}
