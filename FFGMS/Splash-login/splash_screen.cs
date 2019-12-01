using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace FFGMS
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }
        
        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://github.com/HebaFayad/");
            Process.Start(sInfo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://github.com/Firas-Al-Azizy/");
            Process.Start(sInfo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            if (type_combo.SelectedIndex==0)
            {
                Admin_Dashbord main = new Admin_Dashbord();
                main.Show();
            }
            else if (type_combo.SelectedIndex == 1)
                {
                Reciption_Dashbord main = new Reciption_Dashbord();
                main.Show();
            }
            else if (type_combo.SelectedIndex == 2)
            {
                Trainer_Dashboard main = new Trainer_Dashboard();
                main.Show();
            }
            this.Hide();

        }

        private void progress_time_Tick(object sender, EventArgs e)
        {
            if (load_progress.Value <100)
            {
                load_progress.Value++;
            }
            else
            {
                panel3.Visible = false;
               
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splash_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
