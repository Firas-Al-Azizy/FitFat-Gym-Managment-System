using FFGMS.db_con;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
    
}
