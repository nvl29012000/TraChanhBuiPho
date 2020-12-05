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
                ReportParameter[] allPar = new ReportParameter[7];
                allPar[0] = new ReportParameter("HD", a.ID.ToString());
                allPar[1] = new ReportParameter("Ban", Ban);
                allPar[2] = new ReportParameter("Ngay", a.Ngay.ToString());
                allPar[3] = new ReportParameter("KH", a.Ten_Khach);
                allPar[4] = new ReportParameter("Tien", tien.ToString());
                allPar[5] = new ReportParameter("CK", (a.Chiet_Khau * 100).ToString());
                allPar[6] = new ReportParameter("TienCK", (tien * (1-a.Chiet_Khau)).ToString());
                this.reportViewer1.LocalReport.SetParameters(allPar);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
