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

namespace FFGMS.Manage.MemberShip_manage
{
    public partial class memb_m_admin : Form
    {
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


    }
}
