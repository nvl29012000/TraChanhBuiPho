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
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
            using (TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                cbx1.DataSource = from fc in db.DANHMUCMONs select fc.Danh_Muc;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                MON insert = new MON();
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
                insert.Ten = txbfoodname.Text;
                insert.Gia = gia;
                insert.Danh_Muc = (from fc in db.DANHMUCMONs where fc.Danh_Muc.Equals(cbx1.SelectedItem) select fc.ID).SingleOrDefault(); 
                db.MONs.InsertOnSubmit(insert);
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
