using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FFGMS.db_con
{
    class cls_mem
    {
        public string mem_duration { get; set; }
        public string mem_cost { get; set; }

        public static int InsertData(cls_mem o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgmem.insert]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pmem_duration ", SqlDbType.NVarChar)
                    {
                        Value = o.mem_duration
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pmem_cost", SqlDbType.NVarChar)
                    {
                        Value = o.mem_cost
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
        public static int updateData(cls_mem o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgmem.update]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pmem_duration ", SqlDbType.NVarChar)
                    {
                        Value = o.mem_duration
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pmem_cost", SqlDbType.NVarChar)
                    {
                        Value = o.mem_cost
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


            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgmem.SelectAll]";
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
    }
}
