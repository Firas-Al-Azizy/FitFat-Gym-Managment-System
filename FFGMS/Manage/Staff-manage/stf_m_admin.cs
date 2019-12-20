using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFGMS.db_con;
using System.Data.SqlClient;
using System.IO;

namespace FFGMS.Manage.Staff_manage
{
    public partial class stf_m_admin : Form
    {

        SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms ; integrated security=true");
        public stf_m_admin()
        {
            InitializeComponent();
        }

        private void pho_txb_Click(object sender, EventArgs e)
        {

        }

        private void adr_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gr_view_admin_Click(object sender, EventArgs e)
        {

        }

        private void st_add_admin_Click(object sender, EventArgs e)
        {

        }

        private void adr_txb_Click(object sender, EventArgs e)
        {

        }

        private void st_tab_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pass_txb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uname_txb_Click(object sender, EventArgs e)
        {

        }

        private void uname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void gender_box_Click(object sender, EventArgs e)
        {

        }

        private void email_txb_Click(object sender, EventArgs e)
        {

        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dob_lbl_Click(object sender, EventArgs e)
        {

        }

        private void type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void img_picb_Click(object sender, EventArgs e)
        {

        }

        private void img_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sal_txb_Click(object sender, EventArgs e)
        {

        }

        private void sal_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pho_lbl_Click(object sender, EventArgs e)
        {

        }

        private void gender_f_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gender_lbl_Click(object sender, EventArgs e)
        {

        }

        private void gender_m_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void name_txb_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_grbx_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void erase_btn_Click(object sender, EventArgs e)
        {

        }

        private void erase_btn_Click_1(object sender, EventArgs e)
        {

            clearinfo();

        }

        private void table_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_picb.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void name_txb_Click_1(object sender, EventArgs e)
        {

        }
        private void stf_m_admin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("page is loaded");

        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            byte[] picture;
            int inserted;

            picture = conv_picture();
            cls_emp s = new cls_emp();
            s.emp_name = name_txb.Text;
            s.emp_age = age_txb.Text;
            if (radio_male.Checked == true)
            {
                s.emp_gender = radio_male.Text;
            }
            else if (radio_female.Checked == true)
            {
                s.emp_gender = radio_female.Text;
            }
            s.emp_email = email_txb.Text;
            s.emp_phone = pho_txb.Text;
            s.emp_address = adr_txb.Text;
            s.emp_salary = sal_txb.Text;
            s.emp_userName = uname_txb.Text;
            s.emp_pass = pass_txb.Text;
            s.emp_img = picture;
            s.emp_pos = type_cobx.Text;

            inserted = cls_emp.InsertData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully adding a new  employee ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
            


        }

        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandText = "[Pkgemp.insert]";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@Pemp_name", SqlDbType.NVarChar).Value = name_txb.Text;
        //cmd.Parameters.Add("@Pemp_age", SqlDbType.NVarChar).Value = age_txb.Text;
        //if (radio_male.Checked == true)
        //{
        //    cmd.Parameters.Add("@Pemp_gender", SqlDbType.NVarChar).Value = radio_male.Text;
        //}
        //else if (radio_female.Checked == true)
        //{
        //    cmd.Parameters.Add("@Pemp_gender", SqlDbType.NVarChar).Value = radio_female.Text;
        //}
        //cmd.Parameters.Add("@Pemp_email", SqlDbType.NVarChar).Value = email_txb.Text;
        //cmd.Parameters.Add("@Pemp_phone", SqlDbType.NVarChar).Value = pho_txb.Text;
        //cmd.Parameters.Add("@Pemp_address", SqlDbType.NVarChar).Value = adr_txb.Text;
        //cmd.Parameters.Add("@Pemp_salary", SqlDbType.NVarChar).Value = sal_txb.Text;
        //cmd.Parameters.Add("@Pemp_userName", SqlDbType.NVarChar).Value = uname_txb.Text;
        //cmd.Parameters.Add("@Pemp_pass", SqlDbType.NVarChar).Value = pass_txb.Text;
        //cmd.Parameters.Add("@Pemp_img", SqlDbType.Image).Value = picture;
        //cmd.Parameters.Add("@Pemp_pos", SqlDbType.NVarChar).Value = type_cobx.Text;
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
   // }
            byte[] conv_picture()
            {
                try
                {
                    //converting photo to binary data
                    if (img_picb.Image != null)
                    {
                        Image imageToBeResized =
                            Image.FromFile(openFileDialog1.FileName);
                        int imageHeight = imageToBeResized.Height;
                        int imageWidth = imageToBeResized.Width;
                        int maxHeight = 150;
                        int maxWidth = 100;
                        imageHeight = (imageHeight * maxWidth) / imageWidth;
                        imageWidth = maxWidth;
                        if (imageHeight > maxHeight)
                        {
                            imageWidth = (imageWidth * maxHeight) / imageHeight;
                            imageHeight = maxHeight;
                        }
                        Bitmap bitmap = new Bitmap(imageToBeResized, imageWidth, imageHeight);
                        MemoryStream stream = new MemoryStream();
                        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        stream.Position = 0;
                        byte[] image = new byte[stream.Length + 1];
                        stream.Read(image, 0, image.Length);

                        return image;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error code 0001 img\n");
                }
                return null;
            }

        void clearinfo()
        {
            adr_txb.Clear();
            age_txb.Clear();
            email_txb.Clear();
            name_txb.Clear();
            pho_txb.Clear();
            pass_txb.Clear();
            sal_txb.Clear();
            uname_txb.Clear();
            type_cobx.SelectedIndex = -1;
            img_picb.Image = null;
            radio_male.Checked = false;
            radio_female.Checked = false;


        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
    }

