﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demobtl
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            loadAccount();
        }
        #region method
        //tải giá trị datetimepiker
        private void loaddatimepiker()
        {
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59);
            dateTimePicker4.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker3.Value = dateTimePicker4.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59);
        }
        //tải danh sách danh mục món
        private void loadFoodcategory()
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                dtgfoodcategory.DataSource = from fc in db.DANHMUCMONs select new { ID=fc.ID, Tên_danh_mục= fc.Danh_Muc };
                cbfoodcategory.DataSource = from fc in db.DANHMUCMONs select fc.Danh_Muc;
            }
        }
        //tải danh sách tài khoản
        private void loadAccount()
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
                dtgaccount.DataSource = from ac in db.TAIKHOANs select new { Username = ac.Username, Admin = ac.Admin, Active = ac.Active };
        }
        //tải danh sách bàn
        private void loadtable()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                dtgtable.DataSource = from tb in db.BANs select new { ID = tb.ID, Tên_bàn = tb.Ten_Ban };
            }    
        }
        //tải danh sach thức ăn dựa theo danh mục
        private void loadfood()
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
                dtgfood.DataSource = from f in db.MONs
                                     from fc in db.DANHMUCMONs
                                     where f.Danh_Muc == fc.ID
                                     select new
                                     {
                                         ID = f.ID,
                                         Tên = f.Ten,
                                         Giá = f.Gia,
                                         Category = fc.Danh_Muc
                                     } into foood
                                     where foood.Category.CompareTo(cbfoodcategory.SelectedItem) == 0
                                     select new
                                     {
                                         ID = foood.ID,
                                         Tên_món = foood.Tên,
                                         Giá = foood.Giá
                                     };
        }

        //tải danh sách nhân viên
        private void loadstaff()
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                dtgstaff.DataSource = from st in db.NHANVIENs select new {ID = st.ID, Họ_tên = st.Ho_Ten, SDT = st.SDT, Ngày_sinh = st.Sinh_Nhat, Vị_trí = st.Vi_Tri, Lương_cơ_bản = st.Luong_Ngay };
            }    
        }
        //thống kê hóa đơn
        private void thongke()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {

                dtgallbill.DataSource = db.Fn_ThongKe(dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }
        //thống kê lương nhân viên
        private void thongkeluong()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                dtgsalary.DataSource = db.Fn_ThongKeLuong(dateTimePicker4.Value, dateTimePicker3.Value);
            }    
        }
        //tải thông tin tài khoản cần đổi mật khẩu
        private void loadeditacount()
        {
            TAIKHOAN edit = this.Tag as TAIKHOAN;
            lbusername.Text = edit.Username;
        }
        #endregion

        #region events

        #region danh mục món
        //xóa danh mục món
        private void btndeletefoodcategory_Click(object sender, EventArgs e)
        {
            string id = dtgfoodcategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                DANHMUCMON fcdelete = db.DANHMUCMONs.Where(fc => fc.ID.Equals(id)).SingleOrDefault();
                db.DANHMUCMONs.DeleteOnSubmit(fcdelete);
                db.SubmitChanges();
                loadFoodcategory();
            }
        }
        //sửa danh mục món
        private void btneditfoodcategory_Click(object sender, EventArgs e)
        {
            string id = dtgfoodcategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                DANHMUCMON edit = db.DANHMUCMONs.Where(fc => fc.ID.Equals(id)).SingleOrDefault();
                fEditFoodCategory f = new fEditFoodCategory();
                f.Tag = edit;
                f.ShowDialog();
            }
            loadFoodcategory();
        }
        //thêm danh mục món
        private void btnaddfoodcategory_Click(object sender, EventArgs e)
        {
            fAddFoodCategory f = new fAddFoodCategory();
            f.ShowDialog();
            loadFoodcategory();
        }
        #endregion
        #region tải khoản
        //thêm tải khoản
        private void btnadd_Click(object sender, EventArgs e)
        {
            fAddAccount f = new fAddAccount();
            f.ShowDialog();
            loadAccount();
        }
        //kích hoạt | vô hiệu hóa tài khoản
        private void btnedit_Click(object sender, EventArgs e)
        {
            string username = dtgaccount.SelectedCells[0].OwningRow.Cells["Username"].Value.ToString();
            if(String.Compare(username.Replace(" ",""), "Admin")==0)
            {
                MessageBox.Show("Vui lòng không vô hiệu hóa tài khoản Admin để tránh hệ thống bị lỗi! Bạn có thể đổi mật khẩu tài khoản Admin!");
                return;
            }
                using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN edit = db.TAIKHOANs.Where(ac => ac.Username.Equals(username)).SingleOrDefault();
                if(edit.Active == true)
                {
                    if (MessageBox.Show(String.Format("Xác nhận vô hiêu hóa tài khoản {0}", edit.Username),
                    "Thông báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    edit.Active = false;
                }
                else
                {
                    if (MessageBox.Show(String.Format("Xác nhận kích hoạt tài khoản {0}", edit.Username),
                    "Thông báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    edit.Active = true;
                }    
                db.SubmitChanges();
                loadAccount();
            }    
        }
        //Thay đổi mật khảu tài khoản
        private void btneditaccount_Click(object sender, EventArgs e)
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                TAIKHOAN edit = db.TAIKHOANs.Where(a => a.Username.Equals(lbusername.Text)).SingleOrDefault();
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
                txboldpass.ResetText();
                txbnewpass.ResetText();
                txbrepass.ResetText();
                loadAccount();
            }
        }
            #endregion
        #region món
            //thêm món
            private void btnaddfood_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
            loadfood();
        }
        //sửa món
        private void btneditfood_Click(object sender, EventArgs e)
        {
            string id = dtgfood.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                MON edit = db.MONs.Where(food => food.ID.Equals(id)).SingleOrDefault();
                fEditFood f = new fEditFood();
                f.Tag = edit;
                f.ShowDialog();
            }
            loadfood();
        }
        //xóa món
        private void btndeletefood_Click(object sender, EventArgs e)
        {
            string id = dtgfood.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                MON fdelete = db.MONs.Where(food => food.ID.Equals(id)).SingleOrDefault();
                db.MONs.DeleteOnSubmit(fdelete);
                db.SubmitChanges();
                loadfood();
            }
        }
        #endregion  
        #region event_table
        //thêm bàn
        private void btnaddtable_Click(object sender, EventArgs e)
        {
            fAddTable f = new fAddTable();
            f.ShowDialog();
            loadtable();
        }
        //xóa bàn
        private void btndeletetable_Click(object sender, EventArgs e)
        {
            string id = dtgtable.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN delete = db.BANs.Where(tb => tb.ID.Equals(id)).SingleOrDefault();
                db.BANs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                loadtable();
            }    
        }
        #endregion
        #region staff
        //thêm nhân viên
        private void btnaddstaff_Click(object sender, EventArgs e)
        {
            fAddStaff fst = new fAddStaff();
            fst.ShowDialog();
            loadstaff();
        }
        //sửa nhân viên
        private void btneditstaff_Click(object sender, EventArgs e)
        {
            string id = dtgstaff.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                NHANVIEN edit = db.NHANVIENs.Where(staff => staff.ID.Equals(id)).SingleOrDefault();
                fEditStaff f = new fEditStaff();
                f.Tag = edit;
                f.ShowDialog();
            }
            loadstaff();
        }
        //xóa nhân viên
        private void btndeletestaff_Click(object sender, EventArgs e)
        {
            string id = dtgstaff.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                NHANVIEN delete = db.NHANVIENs.Where(staff => staff.ID.Equals(id)).SingleOrDefault();
                db.NHANVIENs.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadstaff();
        }
        #endregion
        #region loaddata
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFoodcategory();
            loadtable();
            loadstaff();
            thongke();
            thongkeluong();
            loaddatimepiker();
            loadeditacount();
        }

        private void cbfoodcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadfood();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            thongke();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            thongke();
        }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            thongkeluong();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            thongkeluong();
        }
        #endregion

        #endregion

    }
}
