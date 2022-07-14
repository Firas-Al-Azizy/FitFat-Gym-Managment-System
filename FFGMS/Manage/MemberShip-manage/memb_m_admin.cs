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

namespace FFGMS.Manage.MemberShip_manage
{
    public partial class memb_m_admin : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-46DG448\SQLEXPRESS;
        database=db_ffgms_new ; integrated security=true");
        public memb_m_admin()
        {
            InitializeComponent();
        }

        private void memb_m_admin_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int inserted;

            cls_mem s = new cls_mem();
            s.mem_duration = dur_txb.Text;
            s.mem_cost = cost_txb.Text;
            inserted = cls_mem.InsertData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully adding a new  membership ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
        }
        void clearinfo()
        {
            dur_txb.Clear();
            cost_txb.Clear();
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();

            dtt = cls_mem.selectAll();
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
            memb_tab_admin.SelectedIndex = 0;
            dur_txb.Text = this.data_view.CurrentRow.Cells[1].Value.ToString();
            cost_txb.Text = this.data_view.CurrentRow.Cells[2].Value.ToString();
            DataTable dt = new DataTable();
           
            panel5.Visible = false;
            update_btn.Enabled = true;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int inserted;

            cls_mem s = new cls_mem();
            s.mem_duration = dur_txb.Text;
            s.mem_cost = cost_txb.Text;
            s.mem_id= Convert.ToInt16(this.data_view.CurrentRow.Cells[0].Value.ToString());
            inserted = cls_mem.updateData(s);
            if (inserted > 0)
            {
                clearinfo();
                MessageBox.Show("Has successfully updating a membership ^_^");
            }
            else
                MessageBox.Show("Has NOT  completed the process");
        }

        private void search_picbx_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "[Pkgmem.search]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pmem_duration", SqlDbType.NVarChar).Value = search_txb.Text;
            cmd.Parameters.Add("@Pmem_cost", SqlDbType.NVarChar).Value = search_txb.Text;
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
            cmd.CommandText = "[Pkgmem.delete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pmem_id", SqlDbType.NVarChar).Value = this.data_view.CurrentRow.Cells[0].Value.ToString();

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
            membership_report main = new membership_report();
            main.ShowDialog();
        }
    }
}
