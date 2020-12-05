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
    public partial class fCreateBill : Form
    {
        public delegate void senddata(BAN a);
        public senddata table;
        public fCreateBill()
        {
            InitializeComponent();
            table = new senddata(loadTalbeName);
        }

        private void loadTalbeName(BAN a)
        {
            lbTable.Text = a.Ten_Ban;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                HOADON insert = new HOADON();
                insert.Ten_Khach = textBox1.Text;
                insert.Ngay = DateTime.Now;
                insert.Chiet_Khau = 0;
                insert.Ban = (from tb in db.BANs where tb.Ten_Ban.Equals(lbTable.Text) select tb.ID).SingleOrDefault();
                db.HOADONs.InsertOnSubmit(insert);
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
