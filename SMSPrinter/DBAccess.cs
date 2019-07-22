using System.Data.SQLite;
using System.Data;

namespace SMSPrinter
{
    public class DBAccess
    {
        private SQLiteConnection Connection;
        public DBAccess(string dbfilepath)
        {
            // TODO P1 remove
            // TODO P2 add help manual (at end)
            dbfilepath = "sms.db";
            Connection = new SQLiteConnection("Data Source=" + dbfilepath + ";FailIfMissing=True;");
        }

        public DataTable GetTable(string query)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            SQLiteDataAdapter sqlAdapter = new SQLiteDataAdapter(query, Connection);
            sqlAdapter.AcceptChangesDuringFill = false;
            sqlAdapter.Fill(dt);
            Connection.Close();
            return dt;
        }

    }
}

