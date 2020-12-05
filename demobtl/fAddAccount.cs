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
    public partial class fAddAccount : Form
    {
        public fAddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN insert = new TAIKHOAN();
                var query = db.TAIKHOANs.Where(ac => ac.Username.Equals(txbusename.Text)).SingleOrDefault();
                if (txbusename.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống tài khoản");
                    return;
                }
                if (query != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }  
                if(txbpassword.Text.Trim()=="")
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                }    
                insert.Username = txbusename.Text;
                insert.Password = txbpassword.Text;
                insert.Admin = chkbox1.Checked;
                db.TAIKHOANs.InsertOnSubmit(insert);
                db.SubmitChanges();
                this.Close();
            }    
        }
    }
}
