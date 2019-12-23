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

//using FFGMS.Reports.Staff;

namespace FFGMS.Manage.Staff_manage
{
    public partial class stf_m_admin : Form
    {

        SqlConnection con = new SqlConnection(@"server=DESKTOP-46DG448\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");

        public stf_m_admin()
        {
            InitializeComponent();
        }

        private void erase_btn_Click_1(object sender, EventArgs e)
        {

            clearinfo();

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.png;*.jpg;*.jpeg;*.bmp;*.wdp;*.dib|png |*.png|jpeg|*.jpg;*.jpeg|bmp|*.bmp|wdp|*.wdp|dib|*.dib";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_picb.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void stf_m_admin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("page is loaded");
            gunaButton4.Enabled = false;

        }
        byte[] conv_picture()
        {
            try
            {
                //converting photo to binary data
                if (img_picb.Image != null)
                {
                    Image imageToBeResized = Image.FromFile(openFileDialog1.FileName);
                    //Image imageToBeResized = img_picb.Image;

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
            catch (Exception e)
            {
                MessageBox.Show("Error code 0001 img\n"+e);
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                //data_view.Columns[1].HeaderCell.Value= "id";
                DataTable dtt = new DataTable();
                //con.Open();
                //SqlCommand myCmd = new SqlCommand("[Pkgemp.SelectAll]", con);
                //myCmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter(myCmd);
                //da.Fill(dt);
                dtt = cls_emp.selectAll();
                data_view.DataSource = dtt;
                if (data_view.RowCount > 0)
                {
                    gunaButton1.Enabled = true;
                    gunaButton4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("data that you are looking for does not exist");
                    gunaButton4.Enabled = false;
                }
            }
            else
            {
                //data_view.Columns[1].HeaderCell.Value= "id";
                DataTable dtt = new DataTable();
                //con.Open();
                //SqlCommand myCmd = new SqlCommand("[Pkgemp.SelectAll]", con);
                //myCmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter(myCmd);
                //da.Fill(dt);
                dtt = cls_emp.selectAll();
                data_view.DataSource = dtt;
                if (data_view.RowCount > 0)
                {
                    gunaButton1.Enabled = true;
                    gunaButton4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("data that you are looking for does not exist");
                    gunaButton4.Enabled = false;
                }
            }

        }

        private void search_picbx_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgemp.search]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pemp_name", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_age", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_gender", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_email", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_phone", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_address", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_salary", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_userName", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pemp_pos", SqlDbType.NVarChar).Value = search_txb.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtt);
            data_view.DataSource = dtt;
            if (data_view.RowCount > 0)
            {
                gunaButton1.Enabled = true;
                gunaButton4.Enabled = true;
            }
            else
            {
                MessageBox.Show("data that you are looking for does not exist");
                gunaButton1.Enabled = false;
                gunaButton4.Enabled = false;
            }




            //cls_emp s = new cls_emp();
            //s.emp_name = search_txb.Text;
            //dtt = cls_emp.searchdata(s);
            //data_view.DataSource = dtt;
            //if (data_view.RowCount > 0)
            //{
            //    gunaButton1.Enabled = true;
            //    gunaButton4.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("data that you are looking for does not exist");
            //    gunaButton1.Enabled = false;
            //    gunaButton4.Enabled = false;
            //}
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            st_tab_admin.SelectedIndex = 0;
            name_txb.Text = this.data_view.CurrentRow.Cells[1].Value.ToString();
            age_txb.Text = this.data_view.CurrentRow.Cells[3].Value.ToString();
            if (this.data_view.CurrentRow.Cells[2].Value.ToString() == "Male")
            {
                radio_male.Checked = true;
            }
            else if (this.data_view.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                radio_female.Checked = true;
            }
            email_txb.Text = this.data_view.CurrentRow.Cells[4].Value.ToString();
            pho_txb.Text = this.data_view.CurrentRow.Cells[5].Value.ToString();
            adr_txb.Text = this.data_view.CurrentRow.Cells[6].Value.ToString();
            sal_txb.Text = this.data_view.CurrentRow.Cells[7].Value.ToString();
            uname_txb.Text = this.data_view.CurrentRow.Cells[8].Value.ToString();
            pass_txb.Text = this.data_view.CurrentRow.Cells[9].Value.ToString();
           // img_picb.Image = this.data_view.CurrentRow.Cells[9].Value.ToString();
            type_cobx.Text = this.data_view.CurrentRow.Cells[11].Value.ToString();
            DataTable dt = new DataTable();
            try
            { // this methode to take employee img from db to ds then to dt
                dt = GetstdImg(name_txb.Text);
                if (dt.Rows.Count > 0)
                {
                    byte[] img = (byte[])dt.Rows[0][0];

                    MemoryStream ms = new MemoryStream(img);
                    img_picb.Image = Image.FromStream(ms);
                }
                else
                {
                    img_picb.Image = null;             }
            }
            catch (Exception ex)
            {
                img_picb.Image = null;
                //MessageBox.Show("image in db is in a wrong format " + "\n Error code 00039", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panel5.Visible = false;
            update_btn.Enabled = true;

        }

        public DataTable GetstdImg(string name_txb)
        {
            DataTable dtt = new DataTable();
            try {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgemp.selectImage]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pemp_name", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[1].Value.ToString();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtt);
            return dtt;
            }
            catch(Exception)
            {
                return dtt;
            }
            //data_view.DataSource = dtt;

            //string command = "select[emp_img] from[db_ffgms].[dbo].[employee] where [emp_name] = '" + name_txb + "'";

            //DataTable dt = new DataTable();
            //con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //adapter.Fill(dt);
            //con.Close();
            //return dt;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            byte[] picture;
            int inserted;

            picture = conv_picture();
           
            cls_emp s = new cls_emp();
            s.emp_id = Convert.ToInt16(this.data_view.CurrentRow.Cells[0].Value.ToString());
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

            inserted = cls_emp.updateData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully updating  employee ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
        }

        private void add_btn_Click_3(object sender, EventArgs e)
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgemp.delete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pemp_id", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[0].Value.ToString();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtt);
            //data_view.DataSource = dtt;
            if (data_view.RowCount > 0)
            {
                gunaButton1.Enabled = true;
                gunaButton4.Enabled = true;

            }
            else
            {
                MessageBox.Show("data that you are looking for does not exist");
                gunaButton1.Enabled = false;
                gunaButton4.Enabled = false;
            }
        }

        private void search_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            staff_report main = new staff_report();
            main.ShowDialog();
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
    }
}

