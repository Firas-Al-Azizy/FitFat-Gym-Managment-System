using FFGMS.db_con;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS.Manage.Trainees_manage
{
    public partial class trne_m_admin : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");
        public trne_m_admin()
        {
            InitializeComponent();
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
                MessageBox.Show("Error code 0001 img\n" + e);
            }
            return null;
        }

        int selecting(string cmd)
        {
            int id = 0;
            DataTable dtt = new DataTable();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);

            adapter.Fill(dtt);
            con.Close();
            if (dtt.Rows.Count > 0)
            {
                id = (int)dtt.Rows[0][0];
                return id;
            }
            else
            {
                MessageBox.Show("cannot find what you need");
            }
            return id = -1;
        }
        void clearinfo()
        {
            adr_txb.Clear();
            age_txb.Clear();
            email_txb.Clear();
            name_txb.Clear();
            pho_txb.Clear();
            uname_txb.Clear();
            hig_txb.Clear();
            wid_txb.Clear();
            mem_combx.SelectedIndex = -1;
            gr_combx.SelectedIndex = -1;
            pro_combx.SelectedIndex = -1;
            img_picb.Image = null;
            radio_male.Checked = false;
            radio_female.Checked = false;


        }
        private void trne_m_admin_Load(object sender, EventArgs e)
        {
            DataTable dtt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand("SELECT [mem_duration]FROM [db_ffgms_new].[dbo].[membership]", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dtt1);
            mem_combx.DataSource = dtt1;
            mem_combx.DisplayMember = "mem_duration";
            //
            DataTable dtt2 = new DataTable();
            SqlCommand cmd2 = new SqlCommand("SELECT [tg_id]FROM [db_ffgms_new].[dbo].[train_group]", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dtt2);
            gr_combx.DataSource = dtt2;
            gr_combx.DisplayMember = "tg_id";

            //
            DataTable dtt3 = new DataTable();
            SqlCommand cmd3 = new SqlCommand("SELECT [pro_id]FROM [db_ffgms_new].[dbo].[program]", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dtt3);
            pro_combx.DataSource = dtt3;
            pro_combx.DisplayMember = "pro_id";

        }

        private void sel_img_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.png;*.jpg;*.jpeg;*.bmp;*.wdp;*.dib|png |*.png|jpeg|*.jpg;*.jpeg|bmp|*.bmp|wdp|*.wdp|dib|*.dib";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_picb.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {

            byte[] picture;
            int inserted;

            picture = conv_picture();
            cls_trne s = new cls_trne();
            s.tra_name = name_txb.Text;
            s.tra_age = age_txb.Text;
            if (radio_male.Checked == true)
            {
                s.tra_gender = radio_male.Text;
            }
            else if (radio_female.Checked == true)
            {
                s.tra_gender = radio_female.Text;
            }
            s.tra_email = email_txb.Text;
            s.tra_phone = pho_txb.Text;
            s.tra_height = hig_txb.Text;
            s.tra_weight = wid_txb.Text;
            s.tra_address = adr_txb.Text;
            s.tra_userName = uname_txb.Text;
            s.tra_img = picture;
            s.mem_id = selecting("select[mem_id] from[db_ffgms_new].[dbo].[membership] where [mem_duration] = '" + mem_combx.Text + "' ");
            s.tg_id = int.Parse(gr_combx.Text);
            s.pro_id = int.Parse(pro_combx.Text);

            inserted = cls_trne.InsertData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully adding a new  trainee ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "[Pkgtra.insert]";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Ptra_name", SqlDbType.NVarChar).Value = name_txb.Text;
            //cmd.Parameters.Add("@Ptra_age", SqlDbType.NVarChar).Value = age_txb.Text;
            //if (radio_male.Checked == true)
            //{
            //    cmd.Parameters.Add("@Ptra_gender", SqlDbType.NVarChar).Value = radio_male.Text;
            //}
            //else if (radio_female.Checked == true)
            //{
            //    cmd.Parameters.Add("@Ptra_gender", SqlDbType.NVarChar).Value = radio_female.Text;
            //}
            //cmd.Parameters.Add("@Ptra_email", SqlDbType.NVarChar).Value = email_txb.Text;
            //cmd.Parameters.Add("@Ptra_phone", SqlDbType.NVarChar).Value = pho_txb.Text;
            //cmd.Parameters.Add("@Ptra_height", SqlDbType.NVarChar).Value = hig_txb.Text;
            //cmd.Parameters.Add("@Ptra_weight", SqlDbType.NVarChar).Value = wid_txb.Text;

            //cmd.Parameters.Add("@Ptra_address", SqlDbType.NVarChar).Value = adr_txb.Text;
            //cmd.Parameters.Add("@Ptra_userName", SqlDbType.NVarChar).Value = uname_txb.Text;
            //cmd.Parameters.Add("@Ptra_img", SqlDbType.Image).Value = picture;
            //cmd.Parameters.Add("@Pmem_id", SqlDbType.Int).Value = selecting("select[mem_id] from[db_ffgms_new].[dbo].[membership] where [mem_duration] = '" + mem_combx.Text + "' ");
            //cmd.Parameters.Add("@Ptg_id", SqlDbType.Int).Value = int.Parse(gr_combx.Text);
            //cmd.Parameters.Add("@Ppro_id", SqlDbType.Int).Value = int.Parse(pro_combx.Text);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

        }

        private void erase_btn_Click_1(object sender, EventArgs e)
        {
            clearinfo();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //data_view.Columns[1].HeaderCell.Value= "id";
            DataTable dtt = new DataTable();
            //con.Open();
            //SqlCommand myCmd = new SqlCommand("[Pkgemp.SelectAll]", con);
            //myCmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter da = new SqlDataAdapter(myCmd);
            //da.Fill(dt);
            dtt = cls_trne.selectAll();
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
                gunaButton1.Enabled = true;
            }

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            trane_tab_admin.SelectedIndex = 0;
            name_txb.Text = this.data_view.CurrentRow.Cells[1].Value.ToString();
            age_txb.Text = this.data_view.CurrentRow.Cells[2].Value.ToString();
            if (this.data_view.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                radio_male.Checked = true;
            }
            else if (this.data_view.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                radio_female.Checked = true;
            }
            email_txb.Text = this.data_view.CurrentRow.Cells[4].Value.ToString();
            pho_txb.Text = this.data_view.CurrentRow.Cells[5].Value.ToString();
            hig_txb.Text = this.data_view.CurrentRow.Cells[6].Value.ToString();
            wid_txb.Text = this.data_view.CurrentRow.Cells[7].Value.ToString();
            adr_txb.Text = this.data_view.CurrentRow.Cells[8].Value.ToString();
            uname_txb.Text = this.data_view.CurrentRow.Cells[9].Value.ToString();
            // img_picb.Image = this.data_view.CurrentRow.Cells[10].Value.ToString();
            mem_combx.Text = this.data_view.CurrentRow.Cells[11].Value.ToString();
            gr_combx.Text = this.data_view.CurrentRow.Cells[12].Value.ToString();
            pro_combx.Text = this.data_view.CurrentRow.Cells[13].Value.ToString();

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
                    img_picb.Image = null;
                }
            }
            catch (Exception)
            {
                img_picb.Image = null;
               // MessageBox.Show("image in db is in a wrong format " + "\n Error code 00039", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panel6.Visible = false;
            update_btn.Enabled = true;
        }
        public DataTable GetstdImg(string name_txb)
        {
            DataTable dtt = new DataTable();
            try
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "[Pkgtra.selectImage]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ptra_name", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[1].Value.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtt);
                return dtt;
            }
            catch (Exception)
            {
                return dtt;
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgtra.delete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ptra_id", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[0].Value.ToString();

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

        private void search_picbx_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgtra.search]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ptra_name", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_age", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_gender", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_email", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_phone", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_address", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_userName", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_height", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Ptra_weight", SqlDbType.NVarChar).Value = search_txb.Text;
            


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
        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            byte[] picture;
            int inserted;
            picture = conv_picture();

            cls_trne s = new cls_trne();
            s.tra_id = Convert.ToInt16(this.data_view.CurrentRow.Cells[0].Value.ToString());

            s.tra_name = name_txb.Text;
            s.tra_age = age_txb.Text;
            if (radio_male.Checked == true)
            {
                s.tra_gender = radio_male.Text;
            }
            else if (radio_female.Checked == true)
            {
                s.tra_gender = radio_female.Text;
            }
            s.tra_email = email_txb.Text;
            s.tra_phone = pho_txb.Text;
            s.tra_height = hig_txb.Text;
            s.tra_weight = wid_txb.Text;
            s.tra_address = adr_txb.Text;
            s.tra_userName = uname_txb.Text;
            s.tra_img = picture;
            s.mem_id = selecting("select[mem_id] from[db_ffgms_new].[dbo].[membership] where [mem_duration] = '" + mem_combx.Text + "' ");
            s.tg_id = int.Parse(gr_combx.Text);
            s.pro_id = int.Parse(pro_combx.Text);


            inserted = cls_trne.updateData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully updating  trainee ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");

        }
    }
}
