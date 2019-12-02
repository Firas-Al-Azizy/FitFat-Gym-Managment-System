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
    public partial class Reciption_Dashbord : Form
    {
        public Reciption_Dashbord()
        {
            InitializeComponent();
        }

       
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


            if (panel1.Width <= 50)
            {
                panel1.Visible = false;
                panel1.Width = 168;
                menu_trans.ShowSync(panel1);
                label3.Visible = false;
                title_trans.ShowSync(label3);
                pictureBox1.Location = new Point(142, 3);
                bunifuFlatButton1.IconZoom = 60;
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
                bunifuFlatButton1.Width = 200;
                bunifuFlatButton7.Width = 200;
                bunifuFlatButton8.Width = 200;
                bunifuFlatButton1.IconZoom = 75;
                bunifuFlatButton8.IconZoom = 75;


            } 
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            splash_screen main = new splash_screen();
            main.Show();
            this.Close();
           

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reciption_Dashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
