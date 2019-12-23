using FFGMS.db_con;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS.Manage
{
    public partial class gr_m_admin : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");
        public gr_m_admin()
        {
            InitializeComponent();
        }

        private void table_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void gr_m_admin_Load(object sender, EventArgs e)
        {
            DataTable dtt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand("SELECT [emp_name]FROM [db_ffgms_new].[dbo].[employee]", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dtt1);
            trrnr_combx.DataSource = dtt1;
            trrnr_combx.DisplayMember = "emp_name";
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();

            dtt = cls_gr.selectAll();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            cls_trne s = new cls_trne();
            s.tra_name = name_txb.Text;
            s.tra_age = age_txb.Text;
        }
    }
}
