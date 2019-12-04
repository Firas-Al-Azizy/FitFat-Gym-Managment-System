using FFGMS.Manage;
using FFGMS.Manage.Group_manage;
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
                form_list_tabs.Visible = false;
                form_list_tabs.Hide();
                this.Controls.Add(logo_panel);
                logo_panel.Dock = DockStyle.Right;
                logo_panel.Visible = true;
                logo_panel.Show();
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
                logo_panel.Visible = false;
                logo_panel.Hide();
                form_list_tabs.Visible = true;
                form_list_tabs.Show();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width <= 50)
            {
                form_list_tabs.Visible = false;
                form_list_tabs.Controls.Clear();
                gr_m_reciption f = new gr_m_reciption()
                {
                    TopLevel = false,
                    TopMost = true,
                    Dock = DockStyle.Fill,
                    WindowState = FormWindowState.Maximized
                };

                form_list_tabs.Controls.Add(f);
                form_list_tabs.Visible = true;
                f.Show();
            }
            else
            {
                form_list_tabs.Visible = false;
            }
        }
    }
}
