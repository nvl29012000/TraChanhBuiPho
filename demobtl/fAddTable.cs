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
    public partial class fAddTable : Form
    {
        public fAddTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TrachanhbuiphoDataContext db = new TrachanhbuiphoDataContext())
            {
                BAN insert = new BAN();
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Tên bàn không được để trống");
                    return;
                }
                insert.Ten_Ban = textBox1.Text;
                db.BANs.InsertOnSubmit(insert);
                db.SubmitChanges();
            }
            this.Close();
        }
    }
}
