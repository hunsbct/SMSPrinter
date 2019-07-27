using System.Data.SQLite;
using System.Data;

namespace SMSPrinter
{
    public class DBAccess
    {
        private SQLiteConnection Connection;

        public DBAccess()
        {
            Connection = new SQLiteConnection("Data Source=sms.db;FailIfMissing=True;");
        }

        public DBAccess(string dbfilepath)
        {
            Connection = new SQLiteConnection("Data Source=" + dbfilepath + ";FailIfMissing=True;");
        }

        public DataTable GetConversation(string chat_id)
        {
            string query = "select  message.text, message.is_from_me, message.date, message.handle_id " +
                "from message join chat_message_join on message.ROWID = chat_message_join.message_id " +
                "join chat on chat.ROWID = chat_message_join.chat_id where chat.chat_identifier = '" + chat_id + "'";
            return GetTable(query);
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

        public DataTable GetConversations()
        {
            DataTable dt = new DataTable();
            string query = "select chat_identifier, text, max(date) from chat join chat_message_join on chat_id = chat.rowid join message on message_id = message.rowid group by chat_identifier";
            Connection.Open();
            SQLiteDataAdapter sqlAdapter = new SQLiteDataAdapter(query, Connection);
            sqlAdapter.AcceptChangesDuringFill = false;
            sqlAdapter.Fill(dt);
            Connection.Close();
            return dt;
        }

    }
}

