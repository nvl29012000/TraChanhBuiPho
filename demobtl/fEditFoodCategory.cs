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
        public fEditFoodCategory()
        {
            InitializeComponent();
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

        private void fEditFoodCategory_Load(object sender, EventArgs e)
        {
            DANHMUCMON edit = this.Tag as DANHMUCMON;
            lbID.Text = edit.ID.ToString();
            textbox1.Text = edit.Danh_Muc;
        }
    }
}
