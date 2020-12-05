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
    public partial class fAddFoodCategory : Form
    {
        public fAddFoodCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                DANHMUCMON insert = new DANHMUCMON();
                if(textbox1.Text.Trim()=="")
                {
                    MessageBox.Show("Chưa nhập tên danh mục");
                    return;
                }    
                insert.Danh_Muc = textbox1.Text;
                db.DANHMUCMONs.InsertOnSubmit(insert);
                db.SubmitChanges();
                this.Close();
            }    
        }
    }
}
