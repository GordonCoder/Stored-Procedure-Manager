using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Data;
using System.Web;

namespace Stored_Procedure_Manager
{


    public class AMDBConnection
    {
        private SqlConnection AMDB_con;
        public SqlCommand AMDB_cmd;
        private SqlDataAdapter AMDB_da;
        private DataTable AMDB_dt;
        private SqlDataReader AMDB_dr;

        //NOTES - https://www.youtube.com/watch?v=WG3Hwk7Yp48
        public void SqldbConnect()
        {
            AMDB_con = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
                );
            AMDB_con.Open();
        }

        public void SqlQuery(string queryText)
        {
            AMDB_cmd = new SqlCommand(queryText, AMDB_con);
        }

        public DataTable QueryEx()
        {
            AMDB_da = new SqlDataAdapter(AMDB_cmd);
            AMDB_dt = new DataTable();
            AMDB_da.Fill(AMDB_dt);
            return AMDB_dt;
        }

        //public SqlDataReader SQLdr()
        //{
        //    SqlDataReader sqldr;
        //    sqldr = sqlcmdhc.ExecuteReader();
        //}
        public void NonQuery()
        {
            AMDB_cmd.ExecuteNonQuery();
        }


        // NOTES - https://www.c-sharpcorner.com/UploadFile/f26fb0/connection-class-in-C-Sharp/

        //string ConnectionString = 
        //    " server = '" + Properties.Settings.Default.ServerNameString + "' \\ '"  + Properties.Settings.Default.InstanceString + "'; database= AutomationManager ;uid= '" + Properties.Settings.Default.UserNameString + "'; pwd= '" + Cipher.Decrypt(Properties.Settings.Default.PasswordString) + "'";
        //SqlConnection cnAMDB;

        //public void OpenConection()
        //{
        //    cnAMDB = new SqlConnection(ConnectionString);
        //    cnAMDB.Open();
        //}

        //public void CloseConnection()
        //{
        //    cnAMDB.Close();
        //}

        //public void ExecuteQueries(string Query_)
        //{
        //    SqlCommand cmd = new SqlCommand(Query_, cnAMDB);
        //    cmd.ExecuteNonQuery();
        //}

        //public SqlDataReader DataReader(string Query_)
        //{
        //    SqlCommand cmd = new SqlCommand(Query_, cnAMDB);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    return dr;
        //}

        //public object ShowDataInGridView(string Query_)
        //{
        //    SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
        //    DataSet ds = new DataSet();
        //    dr.Fill(ds);
        //    object dataum = ds.Tables[0];
        //    return dataum;
        //}

    }
}
