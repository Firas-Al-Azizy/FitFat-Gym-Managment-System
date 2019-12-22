using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFGMS.Manage.Program_manage
{
    public partial class pro_m_admin : Form
    {
        private int count = 0;
        public pro_m_admin()
        {
            InitializeComponent();
        }

        private void dur_txb_Click(object sender, EventArgs e)
        {

        }

        private void table_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (-1 < count && count < 4)
            {
                count = count + 1;
                count_lbl.Text = count.ToString();
            }
            else
            {
                count = 0;
                count_lbl.Text = count.ToString();
            }
            if (wrkouts_pnl1.Visible == true && count==1)
            {
                workouts_pnl2.Visible = true;
                
            }
            else if (workouts_pnl2.Visible == true && count == 2)
            {
                workout_pnl3.Visible = true;

            }
            else if (workout_pnl3.Visible == true && count == 3)
            {
                workout_pnl4.Visible = true;
            }

        }

        private void prev_btn_Click(object sender, EventArgs e)

        {
            if (-1<count &&count < 4) {
                count = count - 1;
                count_lbl.Text = count.ToString();
            }
            else
            {
                count = 3;
                count_lbl.Text = count.ToString();
            }
            
            if (workout_pnl4.Visible == true && count == 2)
            {
                workout_pnl4.Visible = false;
               
               
            }
            else if (workout_pnl3.Visible == true && count == 1)
            {
                workout_pnl3.Visible = false;
            }
            else if (workouts_pnl2.Visible == true && count == 0)
            {
                workouts_pnl2.Visible = false;
            }

        }
    }
}
