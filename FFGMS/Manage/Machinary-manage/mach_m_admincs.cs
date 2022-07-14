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

namespace FFGMS.Manage.Machinary_manage
{
    public partial class mach_m_admincs : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-46DG448\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");
        public mach_m_admincs()
        {
            InitializeComponent();
        }

        private void mach_m_admincs_Load(object sender, EventArgs e)
        {

        }

        private void table_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sel_img_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.png;*.jpg;*.jpeg;*.bmp;*.wdp;*.dib|png |*.png|jpeg|*.jpg;*.jpeg|bmp|*.bmp|wdp|*.wdp|dib|*.dib";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_picb.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void erase_btn_Click(object sender, EventArgs e)
        {
            clearinfo();
        }
        void clearinfo()
        {
            name_txb.Clear();
            img_picb.Image = null;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            byte[] picture;
            int inserted;

            picture = conv_picture();
            cls_mac s = new cls_mac();
            s.mac_name = name_txb.Text;
            s.mac_img = picture;
            inserted = cls_mac.InsertData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully adding a new  machain ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            
            dtt = cls_mac.selectAll();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            mach_tab_admin.SelectedIndex = 0;
            name_txb.Text = this.data_view.CurrentRow.Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            try
            {
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
                cmd.CommandText = "[Pkgmac.selectImage]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Pmac_name", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[1].Value.ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtt);
                return dtt;
            }
            catch (Exception)
            {
                return dtt;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            byte[] picture;
            int inserted;

            picture = conv_picture();
            cls_mac s = new cls_mac();
            s.mac_name = name_txb.Text;
            s.mac_id = Convert.ToInt16(this.data_view.CurrentRow.Cells[0].Value.ToString());
            s.mac_img = picture;
            inserted = cls_mac.updateData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully updating a machain ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
        }

        private void search_picbx_Click(object sender, EventArgs e)
        {

            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgmac.search]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pmac_name", SqlDbType.NVarChar).Value = search_txb.Text;
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgmac.delete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pmac_id", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[0].Value.ToString();

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

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            machine_report main = new machine_report();
            main.ShowDialog();
        }
    }
    }
    

