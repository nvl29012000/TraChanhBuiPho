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
    public partial class fChangePassAccount : Form
    {
        public fChangePassAccount()
        {
            InitializeComponent();
        }

        private void fChangePassAccount_Load(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN edit = this.Tag as TAIKHOAN;
                lbusername.Text = edit.Username;
            }    
        }

        private void btneditaccount_Click(object sender, EventArgs e)
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN edit = db.TAIKHOANs.Where(ac => ac.Username == lbusername.Text).SingleOrDefault();
                if (db.TAIKHOANs.Where(ac => ac.Password.Equals(txboldpass.Text) && ac.Username.Equals(lbusername.Text)).SingleOrDefault() == null)
                {
                    MessageBox.Show("Mật khẩu cũ sai!");
                    return;
                }
                if (txbnewpass.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                }
                if (txbnewpass.Text.ToUpper() != txbrepass.Text.ToUpper())
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                    return;
                }
                edit.Password = txbnewpass.Text;
                db.SubmitChanges();
                MessageBox.Show("Lưu thông tin thành công!");
                this.Close();
            }
        }
    }
}
