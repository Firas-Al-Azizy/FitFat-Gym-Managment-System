using FFGMS.profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS.Dashboards
{
    public partial class Trainee_Dashboard : Form
    {
        public Trainee_Dashboard()
        {
            InitializeComponent();
        }
        private void exit_btn_Click_1(object sender, EventArgs e)
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
                bunifuFlatButton8.Width = 200;
                bunifuFlatButton8.IconZoom = 75;

            }
        }
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (panel1.Width <= 50)
            {
                form_list_tabs.Visible = false;
                form_list_tabs.Controls.Clear();
                trainee_profile f = new trainee_profile()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
