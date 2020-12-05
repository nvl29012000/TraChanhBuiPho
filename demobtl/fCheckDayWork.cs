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
    public partial class fCheckDayWork : Form
    {
        public fCheckDayWork()
        {
            InitializeComponent();
            loadstaff();
        }
        //tải danh sách nhân viên
        private void loadstaff()
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                dataGridView1.DataSource = from st in db.NHANVIENs select new {
                                                                ID = st.ID,
                                                                Họ_và_tên = st.Ho_Ten,
                                                                SĐT = st.SDT,
                                                                Ngày_sinh = st.Sinh_Nhat,
                                                                Vị_trí = st.Vi_Tri,
                                                                Lương_cơ_ban = st.Luong_Ngay
                                                                    };
            }    
        }
        private void btncheck_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                DateTime day = dtpkcheckdaywork.Value.Date;
                string id = dataGridView1.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string name = dataGridView1.SelectedCells[0].OwningRow.Cells["Họ_và_tên"].Value.ToString();
                CHAMCONG check = (from cc in db.CHAMCONGs where cc.Ngay.Date.Equals(day) && cc.ID_NV.Equals(id) && cc.Trang_Thai == true select cc).SingleOrDefault();
                if(check!=null)
                {
                    MessageBox.Show(String.Format("Nhân viên {0} đã chấm công ngày {1}", name ,day.ToShortDateString()));
                    return;
                }    
                CHAMCONG insert = new CHAMCONG();
                insert.Ngay = dtpkcheckdaywork.Value.Date;
                insert.ID_NV = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                insert.Trang_Thai = true;
                db.CHAMCONGs.InsertOnSubmit(insert);
                db.SubmitChanges();
                MessageBox.Show(String.Format("Nhân viên {0} chấm công thành công ngày {1})", name , day.ToShortDateString()));
            }    
        }
    }
}
