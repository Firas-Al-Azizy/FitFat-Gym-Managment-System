using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FFGMS.Manage.Staff_manage;

namespace FFGMS.db_con
{
    class cls_emp
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_age { get; set; }
        public string emp_gender { get; set; }
        public string emp_email { get; set; }
        public string emp_phone { get; set; }
        public string emp_address { get; set; }
        public string emp_salary { get; set; }
        public string emp_userName { get; set; }
        public string emp_pass { get; set; }
        public byte[] emp_img { get; set; }
        public string emp_pos { get; set; }
        //public  DataTable dt { get; set; }



        public static int InsertData(cls_emp o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgemp.insert]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pemp_name", SqlDbType.NVarChar)
                    {
                        Value = o.emp_name
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_age", SqlDbType.NVarChar)
                    {
                        Value = o.emp_age
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_gender", SqlDbType.NVarChar)
                    {
                        Value = o.emp_gender
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_email", SqlDbType.NVarChar)
                    {
                        Value = o.emp_email
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_phone", SqlDbType.NVarChar)
                    {
                        Value = o.emp_phone
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_address", SqlDbType.NVarChar)
                    {
                        Value = o.emp_address
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_salary", SqlDbType.NVarChar)
                    {
                        Value = o.emp_salary
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_userName", SqlDbType.NVarChar)
                    {
                        Value = o.emp_userName
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_pass", SqlDbType.NVarChar)
                    {
                        Value = o.emp_pass
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_img", SqlDbType.Image)
                    {
                        Value = o.emp_img
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_pos", SqlDbType.NVarChar)
                    {
                        Value = o.emp_pos
                    };
                    SqlCmd.Parameters.Add(p);

                    EffectedRows = (int)cls_db.exe_pro(SqlCmd, 1);
                }
            }

            catch (Exception)
            {
                return EffectedRows;


            }
            return EffectedRows;

        }
        public static int updateData(cls_emp o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgemp.update]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pemp_name", SqlDbType.NVarChar)
                    {
                        Value = o.emp_name
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_age", SqlDbType.NVarChar)
                    {
                        Value = o.emp_age
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_gender", SqlDbType.NVarChar)
                    {
                        Value = o.emp_gender
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_email", SqlDbType.NVarChar)
                    {
                        Value = o.emp_email
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_phone", SqlDbType.NVarChar)
                    {
                        Value = o.emp_phone
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_address", SqlDbType.NVarChar)
                    {
                        Value = o.emp_address
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_salary", SqlDbType.NVarChar)
                    {
                        Value = o.emp_salary
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_userName", SqlDbType.NVarChar)
                    {
                        Value = o.emp_userName
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_pass", SqlDbType.NVarChar)
                    {
                        Value = o.emp_pass
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_img", SqlDbType.Image)
                    {
                        Value = o.emp_img
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_pos", SqlDbType.NVarChar)
                    {
                        Value = o.emp_pos
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pemp_id", SqlDbType.Int)
                    {
                        Value = o.emp_id
                    };
                    SqlCmd.Parameters.Add(p);

                    EffectedRows = (int)cls_db.exe_pro(SqlCmd, 1);
                }
            }

            catch (Exception)
            {
                return EffectedRows;


            }
            return EffectedRows;

        }

        public static DataTable selectAll()
        {
            DataTable dt = new DataTable();

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgemp.SelectAll]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }

                    dt = (DataTable)cls_db.exe_pro(SqlCmd, 2);
                }
            }

            catch (Exception)
            {
                dt = new DataTable();


            }
            return dt;

        }

        public static DataTable searchdata(cls_emp o)
        {
            DataTable dt = new DataTable();

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgemp.selectbyName]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pemp_name", SqlDbType.NVarChar)
                    {
                        Value = o.emp_name
                    };


                    dt = (DataTable)cls_db.exe_pro(SqlCmd, 2);
                }
            }

            catch (Exception)
            {
                dt = new DataTable();


            }
            return dt;

        }
    }
    
}
