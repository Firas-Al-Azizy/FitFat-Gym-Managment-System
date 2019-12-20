using FFGMS.Manage;
using FFGMS.Manage.Staff_manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FFGMS
{
    public partial class Admin_Dashbord : Form
    {

        SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms ; integrated security=true");

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
                bunifuFlatButton2.Width = 200;
                //bunifuFlatButton3.Width = 225;
                bunifuFlatButton4.Width = 200;
                bunifuFlatButton5.Width = 200;
                bunifuFlatButton6.Width = 200;
                bunifuFlatButton7.Width = 200;
                bunifuFlatButton8.Width = 200;
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
            if (panel1.Width <= 50)
            {
                form_list_tabs.Visible = false;
                form_list_tabs.Controls.Clear();
                stf_m_admin f = new stf_m_admin()
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
            try
            {
                con.Open();
                MessageBox.Show("conncting is true");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 005 :\n" + ex.Message);

            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (panel1.Width <= 50)
            {
                form_list_tabs.Visible = false;
                form_list_tabs.Controls.Clear();
                gr_m_admin f = new gr_m_admin()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
