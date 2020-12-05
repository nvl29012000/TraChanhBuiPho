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
    public partial class fEditFoodCategory : Form
    {
        public delegate void senddata(DANHMUCMON a);
        public senddata foodcategory;
        public fEditFoodCategory()
        {
            InitializeComponent();
            foodcategory = new senddata(loaddata);
        }

        private void loaddata(DANHMUCMON a)
        {
            lbID.Text = a.ID.ToString();
            textbox1.Text = a.Danh_Muc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                DANHMUCMON edit = db.DANHMUCMONs.Where(p => p.ID.Equals(lbID.Text)).SingleOrDefault();
                if(textbox1.Text.Trim()=="")
                {
                    MessageBox.Show("Không được để trống tên");
                    return;
                }    
                edit.Danh_Muc = textbox1.Text;
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
