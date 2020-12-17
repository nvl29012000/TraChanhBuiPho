using Microsoft.Reporting.WinForms;
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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            HOADON a = this.Tag as HOADON;
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                string Ban = (from b in db.BANs where b.ID.Equals(a.Ban) select b.Ten_Ban).SingleOrDefault();
                double tien = (double)db.Fn_TienChuaCK(a.ID);
                // TODO: This line of code loads data into the 'Trachanhbuipho1DataSet.Fn_Report' table. You can move, or remove it, as needed.
                this.Fn_ReportTableAdapter.Fill(this.Trachanhbuipho1DataSet.Fn_Report, a.ID);
                string HD = String.Format("{0}{1}{2}-{3}", a.Ngay.Day, a.Ngay.Month, a.Ngay.Year,a.ID);
                ReportParameter[] allPar = new ReportParameter[8];
                allPar[0] = new ReportParameter("HD", HD);
                allPar[1] = new ReportParameter("Ban", Ban);
                allPar[2] = new ReportParameter("Ngay", a.Ngay.ToString());
                allPar[3] = new ReportParameter("KH", a.Ten_Khach);
                allPar[4] = new ReportParameter("Tien", tien.ToString());
                allPar[5] = new ReportParameter("CK", (a.Chiet_Khau * 100).ToString());
                allPar[6] = new ReportParameter("TienCK", (tien * (1-a.Chiet_Khau)).ToString());
                allPar[7] = new ReportParameter("TientoString", ChuyenSoSangChuoi(tien * (1 - a.Chiet_Khau)));
                this.reportViewer1.LocalReport.SetParameters(allPar);
                this.reportViewer1.RefreshReport();
            }
        }

        #region hàm chuyển đổi số => chữ
        string[] mNumText = "Không;Một;Hai;Ba;Bốn;Năm;Sáu;Bảy;Tám;Chín".Split(';');
        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so % 10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " Mươi";
                if (donvi == 1)
                {
                    chuoi += " Mốt";
                }
            }
            else if (chuc == 1)
            {//Số hàng chục từ 10-19
                chuoi = " Mười";
                if (donvi == 1)
                {
                    chuoi += " Một";
                }
            }
            else if (daydu && donvi > 0)
            {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                chuoi = " Lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " Lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so / 100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " Trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so / 1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " Triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin 
            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " Nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " Tỷ";
            } while (ty > 0);
            return chuoi + " Đồng";
        }
        #endregion
    }

}

