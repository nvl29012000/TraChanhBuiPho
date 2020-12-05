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
    public partial class fEditStaff : Form
    {
        public delegate void senddata(NHANVIEN a);
        public senddata staff;
        public fEditStaff()
        {
            InitializeComponent();
            staff = new senddata(loadstaff);
        }


        private void loadstaff(NHANVIEN a)
        {
            lbID.Text = a.ID.ToString();
            txbname.Text = a.Ho_Ten;
            txbphone.Text = a.SDT;
            dtpkstaff.Value = a.Sinh_Nhat;
            cbxstaff.Text = a.Vi_Tri;
            txbsalary.Text = a.Luong_Ngay.ToString();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                NHANVIEN edit = db.NHANVIENs.Where(staff => staff.ID.Equals(lbID.Text)).SingleOrDefault();
                if (txbname.Text.Trim() == "")
                {
                    MessageBox.Show("Tên không được để trống");
                    return;
                }
                if (txbphone.Text.Trim() == "")
                {
                    MessageBox.Show("SĐT không được để trống");
                    return;
                }
                Match match = Regex.Match(txbphone.Text, @"((\(\d{3}\) ?)|(\d{3}))?\d{3}\d{4}");
                if (!match.Success)
                {
                    MessageBox.Show("Định dạng SĐT sai");
                    return;
                }
                if (!decimal.TryParse(txbsalary.Text, out decimal lcb))
                {
                    MessageBox.Show("Nhập sai lương");
                    return;
                }
                if (cbxstaff.SelectedItem == null)
                {
                    MessageBox.Show("Chưa chọn vị trí");
                    return;
                }
                edit.Ho_Ten = txbname.Text;
                edit.SDT = txbphone.Text;
                edit.Sinh_Nhat = dtpkstaff.Value;
                edit.Vi_Tri = cbxstaff.SelectedItem.ToString();
                edit.Luong_Ngay = lcb;
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
