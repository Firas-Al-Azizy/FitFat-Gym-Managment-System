using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS.Manage.Machinary_manage
{
    public partial class mach_m_admincs : Form
    {
        public mach_m_admincs()
        {
            InitializeComponent();
        }

        private void mach_m_admincs_Load(object sender, EventArgs e)
        {

        }

        private void table_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sel_img_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.png;*.jpg;*.jpeg;*.bmp;*.wdp;*.dib|png |*.png|jpeg|*.jpg;*.jpeg|bmp|*.bmp|wdp|*.wdp|dib|*.dib";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_picb.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void erase_btn_Click(object sender, EventArgs e)
        {
            clearinfo();
        }
        void clearinfo()
        {
            name_txb.Clear();
        }
    }
}
