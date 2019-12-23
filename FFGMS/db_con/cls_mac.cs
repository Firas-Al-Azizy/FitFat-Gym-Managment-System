using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFGMS.db_con
{
    class cls_mac
    {
        public string mac_name { get; set; }
        public byte[] mac_img { get; set; }
        public static int InsertData(cls_mac o)
        {
            var EffectedRows = 0;

            SqlParameter p;
            try
            {
                using (SqlCommand SqlCmd = new SqlCommand())
                {
                    {
                        var withBlock = SqlCmd;
                        withBlock.CommandText = "[Pkgmac.insert]";
                        withBlock.CommandType = CommandType.StoredProcedure;
                    }
                    p = new SqlParameter("@Pmac_name", SqlDbType.NVarChar)
                    {
                        Value = o.mac_name
                    };
                    SqlCmd.Parameters.Add(p);
                    p = new SqlParameter("@Pmac_img", SqlDbType.Image)
                    {
                        Value = o.mac_img
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
    }
}
