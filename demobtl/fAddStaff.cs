using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demobtl
{
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                NHANVIEN insert = new NHANVIEN();
                if(txbname.Text.Trim()=="")
                {
                    MessageBox.Show("Tên không được để trống");
                    return;
                }    
                if(txbphone.Text.Trim()=="")
                {
                    MessageBox.Show("SĐT không được để trống");
                    return;
                }
                Match match = Regex.Match(txbphone.Text, @"((\(\d{3}\) ?)|(\d{3}))?\d{3}\d{4}");
                if(!match.Success)
                {
                    MessageBox.Show("Định dạng SĐT sai");
                    return;
                }
                if(!decimal.TryParse(txbsalary.Text, out decimal lcb))
                {
                    MessageBox.Show("Nhập sai lương");
                    return;
                }
                if(cbxstaff.SelectedItem==null)
                {
                    MessageBox.Show("Chưa chọn vị trí");
                    return;
                }    
                insert.Ho_Ten = txbname.Text;
                insert.SDT = txbphone.Text;
                insert.Sinh_Nhat = dtpkstaff.Value;
                insert.Vi_Tri = cbxstaff.SelectedItem.ToString();
                insert.Luong_Ngay = lcb;
                db.NHANVIENs.InsertOnSubmit(insert);
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
