using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS
{
    public partial class Admin_Dashbord : Form
    {
        public Admin_Dashbord()
        {
            InitializeComponent();
        }
     

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            splash_screen main = new splash_screen();
            main.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            if (panel1.Width == 40)
            {
                panel1.Visible = false;
                panel1.Width =225 ;
                menu_trans.ShowSync(panel1);
                label3.Visible = false;
                title_trans.ShowSync(label3);
                pictureBox1.Location = new Point(189, 3);
                label3.Visible = false;
                bunifuFlatButton1.IconZoom = 60;
                bunifuFlatButton2.IconZoom = 70;
                //bunifuFlatButton3.IconZoom = 70;
                bunifuFlatButton4.IconZoom = 70;
                bunifuFlatButton5.IconZoom = 70;
                bunifuFlatButton6.IconZoom = 70;
                bunifuFlatButton7.IconZoom = 70;
                bunifuFlatButton8.IconZoom = 70;

            }
            else
            {
                label3.Visible = false;
                panel1.Visible = false;
                panel1.Width = 40;
                menu_trans.ShowSync(panel1);
                pictureBox1.Location = new Point(9, 3);
                bunifuFlatButton1.Width = 225;
                bunifuFlatButton2.Width = 225;
                //bunifuFlatButton3.Width = 225;
                bunifuFlatButton4.Width = 225;
                bunifuFlatButton5.Width = 225;
                bunifuFlatButton6.Width = 225;
                bunifuFlatButton7.Width = 225;
                bunifuFlatButton8.Width = 225;
                bunifuFlatButton1.IconZoom = 75;
                bunifuFlatButton2.IconZoom = 75;
                //bunifuFlatButton3.IconZoom = 75;
                bunifuFlatButton4.IconZoom = 75;
                bunifuFlatButton5.IconZoom = 75;
                bunifuFlatButton6.IconZoom = 75;
                bunifuFlatButton7.IconZoom = 75;
                bunifuFlatButton8.IconZoom = 75;


            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Dashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
