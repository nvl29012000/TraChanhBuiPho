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
    public partial class fEditFood : Form
    {
        public fEditFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                MON edit = db.MONs.Where(f => f.ID.Equals(lbIdfood.Text)).SingleOrDefault();
                if(txbfoodname.Text.Trim()=="")
                {
                    MessageBox.Show("Tên món không được để trống");
                    return;
                }
                if(!decimal.TryParse(textBox1.Text, out decimal gia))
                {
                    MessageBox.Show("Giá tiền nhập sai");
                    return;
                }
                edit.Ten = txbfoodname.Text;
                edit.Gia = gia;
                edit.Danh_Muc = (from fc in db.DANHMUCMONs where fc.Danh_Muc.Equals(cbx1.SelectedItem) select fc.ID).SingleOrDefault();
                db.SubmitChanges();
            }
            this.Close();
        }

        private void fEditFood_Load(object sender, EventArgs e)
        {
            MON a = this.Tag as MON;
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                lbIdfood.Text = a.ID.ToString();
                txbfoodname.Text = a.Ten;
                textBox1.Text = a.Gia.ToString();
                cbx1.DataSource = from fc in db.DANHMUCMONs select fc.Danh_Muc;
                cbx1.SelectedItem = (from fc in db.DANHMUCMONs where fc.ID.Equals(a.Danh_Muc) select fc.Danh_Muc).SingleOrDefault();
            }
        }
    }
}
