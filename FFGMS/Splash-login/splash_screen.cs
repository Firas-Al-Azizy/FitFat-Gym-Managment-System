using FFGMS.Dashboards;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace FFGMS
{
    public partial class splash_screen : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");
        //   con = new SqlConnection(@"Server=DESKTOP-HPA6H4U\SQLEXPRESS;
        //User Id=ali_admin;Password=ali123;Database=stud_db;");
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
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgemp.logIn]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pemp_userName", SqlDbType.NVarChar).Value = bunifuMetroTextbox1.Text;
            cmd.Parameters.Add("@Pemp_pass", SqlDbType.NVarChar).Value = bunifuMetroTextbox2.Text;
            cmd.Parameters.Add("@Pemp_pos", SqlDbType.NVarChar).Value = type_combo.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtt);

            if (bunifuMetroTextbox1.Text.Trim() == "")
            {
                errorProvider1.SetError(bunifuMetroTextbox1, "Please Enter your User Name");
            }
            if (bunifuMetroTextbox2.Text.Trim() == "")
            {
                errorProvider1.SetError(bunifuMetroTextbox2, "Please Enter your Password");
            }
            if (type_combo.SelectedIndex == -1)
            {
                errorProvider1.SetError(type_combo, "Please Select a type");
            }
            if (dtt.Rows.Count > 0)
            {
                

                if (type_combo.SelectedIndex == 0)
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
                else if (type_combo.SelectedIndex == 3)
                {
                    Trainee_Dashboard main = new Trainee_Dashboard();
                    main.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user Name or Password /n choose a correct type of users");
            }

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
            type_combo.SelectedIndex = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
