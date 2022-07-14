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
    class cls_trne
    {
        public int tra_id { get; set; }
        public string tra_name { get; set; }
        public string tra_age { get; set; }
        public string tra_gender { get; set; }
        public string tra_email { get; set; }
        public string tra_phone { get; set; }
        public string tra_height { get; set; }
        public string tra_weight { get; set; }
        public string tra_address { get; set; }
        public string tra_userName { get; set; }
        public byte[] tra_img { get; set; }
        public int mem_id { get; set; }
        public int tg_id { get; set; }
        public int pro_id { get; set; }

        public static int InsertData(cls_trne o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgtra.insert]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Ptra_name", SqlDbType.NVarChar)
                    {
                        Value = o.tra_name
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_age", SqlDbType.NVarChar)
                    {
                        Value = o.tra_age
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_gender", SqlDbType.NVarChar)
                    {
                        Value = o.tra_gender
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_email", SqlDbType.NVarChar)
                    {
                        Value = o.tra_email
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_phone", SqlDbType.NVarChar)
                    {
                        Value = o.tra_phone
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_height", SqlDbType.NVarChar)
                    {
                        Value = o.tra_height
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_weight", SqlDbType.NVarChar)
                    {
                        Value = o.tra_weight
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_address", SqlDbType.NVarChar)
                    {
                        Value = o.tra_address
                    };
                    SqlCmd.Parameters.Add(p);
                
                    p = new SqlParameter("@Ptra_userName", SqlDbType.NVarChar)
                    {
                        Value = o.tra_userName
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_img", SqlDbType.Image)
                    {
                        Value = o.tra_img
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pmem_id", SqlDbType.Int)
                    {
                        Value = o.mem_id
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptg_id", SqlDbType.Int)
                    {
                        Value = o.tg_id
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ppro_id", SqlDbType.Int)
                    {
                        Value = o.pro_id
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
        public static int updateData(cls_trne o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgtra.update]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Ptra_name", SqlDbType.NVarChar)
                    {
                        Value = o.tra_name
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_age", SqlDbType.NVarChar)
                    {
                        Value = o.tra_age
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_gender", SqlDbType.NVarChar)
                    {
                        Value = o.tra_gender
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_email", SqlDbType.NVarChar)
                    {
                        Value = o.tra_email
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_phone", SqlDbType.NVarChar)
                    {
                        Value = o.tra_phone
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_height", SqlDbType.NVarChar)
                    {
                        Value = o.tra_height
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_weight", SqlDbType.NVarChar)
                    {
                        Value = o.tra_weight
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_address", SqlDbType.NVarChar)
                    {
                        Value = o.tra_address
                    };
                    SqlCmd.Parameters.Add(p);

                    p = new SqlParameter("@Ptra_userName", SqlDbType.NVarChar)
                    {
                        Value = o.tra_userName
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_img", SqlDbType.Image)
                    {
                        Value = o.tra_img
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pmem_id", SqlDbType.Int)
                    {
                        Value = o.mem_id
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptg_id", SqlDbType.Int)
                    {
                        Value = o.tg_id
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ppro_id", SqlDbType.Int)
                    {
                        Value = o.pro_id
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Ptra_id", SqlDbType.Int)
                    {
                        Value = o.tra_id
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
                        withBlock.CommandText = "[Pkgtra.SelectAll]";
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

        public static DataTable searchdata(cls_trne o)
        {
            DataTable dt = new DataTable();

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgtra.search]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Ptra_name", SqlDbType.NVarChar)
                    {
                        Value = o.tra_name
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
