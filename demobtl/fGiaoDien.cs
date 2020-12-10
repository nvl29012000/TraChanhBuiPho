using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demobtl
{
    public partial class fGiaoDien : Form
    {
        public fGiaoDien()
        {
            InitializeComponent();
            loadTable();
            loadfoodcategory();
            loadfood();
        }
        #region method
        //tải danh sách bàn lên màn hình
        private void loadTable()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                List<BAN> listtable = (from tb in db.BANs select tb).ToList<BAN>();
                foreach(BAN item in listtable)
                {
                    Button btn = new Button() { Width = 105, Height = 105 };
                    btn.Text = item.Ten_Ban;
                    btn.Tag = item;
                    btn.Click += Btn_Click;
                    if(item.Trang_Thai==false)
                    {
                        btn.BackColor = Color.Blue;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }    
                    fpnltable.Controls.Add(btn);
                }    
            }    
        }
        //tải danh sách các danh mục món lên combobox
        private void loadfoodcategory()
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                cbcategory.DataSource = from fc in db.DANHMUCMONs select fc.Danh_Muc;
            }    
        }
        //tải danh sách các món theo danh mục sản phẩm được chọn trên combobox
        private void loadfood()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                cbfood.DataSource = from f in db.MONs where f.Danh_Muc.Equals((from fc in db.DANHMUCMONs where fc.Danh_Muc.Equals
                                                                               (cbcategory.SelectedItem) select fc.ID).SingleOrDefault()) select f.Ten;
            }    
        }
        //tải danh sách chi tiết hóa đơn theo bàn
        private void loadListBill(List<CHITIETHOADON> list)
        {
            using(TrachanhbuiphoDataContext db =  new TrachanhbuiphoDataContext())
            {
                lsvbill.Items.Clear();
                decimal sumprice = 0;
                foreach (CHITIETHOADON item in list)
                {
                    string foodname = (from m in db.MONs where m.ID.Equals(item.Mon) select m.Ten).SingleOrDefault();
                    decimal gia = (from m in db.MONs where m.ID.Equals(item.Mon) select m.Gia).SingleOrDefault();
                    ListViewItem a = new ListViewItem(foodname);
                    a.SubItems.Add(item.So_Luong.ToString());
                    a.SubItems.Add(gia.ToString());
                    a.SubItems.Add((item.So_Luong * gia).ToString());
                    sumprice += (decimal)(item.So_Luong*gia);
                    lsvbill.Items.Add(a);
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                decimal discount = nmrdiscount.Value / 100;
                txbsum.Text = (sumprice * (1-discount)).ToString("c",culture);
            }     
        }
        private void showBill(int id)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                int billid = (from hd in db.HOADONs where hd.Ban.Equals(id) && hd.Trang_Thai == false select hd.ID).SingleOrDefault();    
                List<CHITIETHOADON> listbillinfor = (from cthd in db.CHITIETHOADONs where cthd.Hoa_Don.Equals(billid) select cthd).ToList<CHITIETHOADON>();
                loadListBill(listbillinfor);
            }    
        }
    #endregion
        #region events
        //chọn bàn để xem thông tin hóa đơn của bàn hoặc tạo hóa đơn
        private void Btn_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN a = (sender as Button).Tag as BAN;
                lsvbill.Tag = (sender as Button).Tag;
                fpnltable.Tag = (sender as Button);
                int tableID = a.ID;
                bool status = a.Trang_Thai;
                if (status == false)
                {
                    fCreateBill f = new fCreateBill();
                    f.table(a);
                    f.ShowDialog();
                    int idbill = (from hd in db.HOADONs where hd.Ban.Equals(tableID) && hd.Trang_Thai == false select hd.ID).SingleOrDefault();
                    if (idbill != 0)
                    {
                        a.Trang_Thai = !a.Trang_Thai;
                        db.SubmitChanges();
                        (sender as Button).BackColor = Color.Green;
                        showBill(tableID);
                    }
                    else
                        return;
                }
                else
                    showBill(tableID);
            }    
        }
        //đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //mở form chấm công
        private void mnstripchamcong_Click(object sender, EventArgs e)
        {
            fCheckDayWork f = new fCheckDayWork();
            f.ShowDialog();
        }
        //tải danh sách món vào combobox dựa theo giá trị danh mục món trên combobox
        private void cbcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadfood();
        }
        //thêm món
        private void btnaddfood_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN choose = lsvbill.Tag as BAN;
                if(choose==null)
                {
                    MessageBox.Show("Vui lòng chọn bàn");
                    return;
                }    
                HOADON select = (from hd in db.HOADONs where hd.Ban.Equals(choose.ID) && hd.Trang_Thai == false select hd).SingleOrDefault();
                if(select == null)
                {
                    MessageBox.Show("Bàn được chọn hiện trống! Hãy tạo hóa đơn cho bàn trước khi thêm món");
                    return;
                }    
                CHITIETHOADON insert = new CHITIETHOADON();
                insert.Hoa_Don = select.ID; 
                insert.Mon = (from food in db.MONs where food.Ten.Equals(cbfood.SelectedItem.ToString()) select food.ID).SingleOrDefault();   
                insert.So_Luong = Convert.ToInt32(nmrcount.Value);
                CHITIETHOADON check = db.CHITIETHOADONs.Where(cthd => cthd.Mon.Equals(insert.Mon)
                                        && cthd.Hoa_Don.Equals(select.ID)).SingleOrDefault();
                if(check !=null)
                {
                    if ((check.So_Luong + insert.So_Luong) < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ");
                        return;
                    }
                    else
                    {
                        check.So_Luong += insert.So_Luong;
                        if(check.So_Luong==0)
                        {
                            db.CHITIETHOADONs.DeleteOnSubmit(check);
                        }    
                    }    
                }   
                else
                    if(insert.So_Luong<=0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ");
                        return;
                    }    
                else
                    db.CHITIETHOADONs.InsertOnSubmit(insert);
                db.SubmitChanges();
                nmrcount.Value = 1;
                showBill(choose.ID);
            }    
        }
        //thanh toán
        private void btnout_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN choose = lsvbill.Tag as BAN;
                if(choose==null || choose.Trang_Thai==false)
                {
                    MessageBox.Show("Vui lòng chọn bàn cần thanh toán");
                    return;
                }    
                HOADON select = (from hd in db.HOADONs where hd.Ban.Equals(choose.ID) && hd.Trang_Thai==false select hd).SingleOrDefault();
                if(select == null)
                {
                    Button focus1 = fpnltable.Tag as Button;
                    focus1.BackColor = Color.Blue;
                    return;
                }
                if (MessageBox.Show(String.Format("Xác nhận thanh toán bàn {0} cho khách hàng {1} với số tiền {2}", choose.Ten_Ban.ToUpper(), select.Ten_Khach.ToUpper(), txbsum.Text),
                    "Thông báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                    return;
                select.Chiet_Khau = Convert.ToDouble(nmrdiscount.Value / 100);
                select.Trang_Thai = true;
                choose.Trang_Thai = false;
                db.SubmitChanges();
                fReport frp = new fReport();
                frp.Tag = select;
                frp.ShowDialog();
                Button focus = fpnltable.Tag as Button;
                focus.BackColor = Color.Blue;
                showBill(choose.ID);
            }    
        }
        //chuyển tất cả hóa đơn thành thanh toán khi đóng form
        private void fgiaodien_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                List<HOADON> listhd = (from hd in db.HOADONs select hd).ToList<HOADON>();
                foreach(HOADON item in listhd)
                {
                    item.Trang_Thai = true;
                    db.SubmitChanges();
                }    
            }    
        }
        //show lại bill khi sửa chiết khấu
        private void nmrdiscount_ValueChanged(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN choose = lsvbill.Tag as BAN;
                HOADON select = (from hd in db.HOADONs where hd.Ban.Equals(choose.ID) && hd.Trang_Thai == false select hd).SingleOrDefault();
                showBill(choose.ID);
            }    
        }
        #endregion

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassAccount fc = new fChangePassAccount();
            fc.Tag = this.Tag;
            fc.ShowDialog();
        }
    }
}
