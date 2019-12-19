using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace FFGMS.db_con
{
    class cls_db
    {
        static SqlConnection con;

        SqlCommand Scom;

        public static void setConnection()
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-HPA6H4U\SQLEXPRESS;
        database=db_ffgms ; integrated security=true");
            // SqlConnection con = new SqlConnection(@"server=ALI-PC\SQLEXPRESS;
            //database=ali_db ; integrated security=true");
        }

        public static object exe_pro(SqlCommand com, int type)
        {
            setConnection();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                com.Connection = con;
            }
            switch (type)
            {
                case 1:
                    {


                        int r = com.ExecuteNonQuery();
                        con.Close();
                        return r;


                    }
                case 2:
                    {
                        DataTable dt = new DataTable();

                        SqlDataReader sDR = com.ExecuteReader();
                        dt.Load(sDR);

                        con.Close();
                        return dt;

                    }

            }
            return -1;
        }
    }
}
