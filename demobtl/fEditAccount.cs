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
    public partial class fEditAccount : Form
    {
        public delegate void senddata(TAIKHOAN a);
        public senddata account;
        public fEditAccount()
        {
            InitializeComponent();
            account = new senddata(loadAccount);
        }
        private void loadAccount(TAIKHOAN a)
        {
            lbusename.Text = a.Username;
            txbpassword.Text = a.Password;
            chkbox1.Checked = a.Admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN edit = db.TAIKHOANs.Where(ac => ac.Username.Equals(lbusename.Text)).SingleOrDefault();
                if(txbpassword.Text.Trim()=="")
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                }
                edit.Password = txbpassword.Text;
                edit.Admin = chkbox1.Checked;
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
