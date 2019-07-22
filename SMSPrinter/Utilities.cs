using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Globalization;

namespace SMSPrinter
{
    public static class Utilities
    {
        private static readonly DateTime epoch = new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static DateTime FromEpoch(long seconds)
        {
            return epoch.AddSeconds(seconds);
        }

        public static long ToEpoch(DateTime timestamp)
        {
            return (long)(timestamp - epoch).TotalSeconds;
        }

        public static bool ValidatePhoneNumber(string number)
        {
            Regex rgx = new Regex(@"[0-9]{10}");
            return rgx.IsMatch(number.Remove('-').Remove('(').Remove(')').Remove(' '));
        }

        public static bool WriteToCsvFile(DataTable dt, string filePath)
        {
            bool result = false;
            dt.Columns["sender"].ColumnName = "Sender";
            dt.Columns["text"].ColumnName = "Message";
            dt.Columns.Remove("is_from_me");
            dt.Columns.Remove("SentReceived");
            dt.Columns.Remove("date");
            try
            {
                StringBuilder fileContent = new StringBuilder();

                foreach (var col in dt.Columns)
                    fileContent.Append(col.ToString() + ",");

                fileContent.Replace(",", Environment.NewLine, fileContent.Length - 1, 1);

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (var column in dr.ItemArray)
                        fileContent.Append("\"" + column.ToString() + "\",");

                    fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
                }

                File.WriteAllText(filePath, fileContent.ToString());
                result = true;
            }
            catch(Exception)
            {

            }
            return result;
            
        }

        public static bool WriteToTextFile(DataTable dataTable, string filepath)
        {
            bool result = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        sw.WriteLine(row["sender"].ToString());
                        string line = "[" + row["timestamp"] + "]";
                        if (row["sentreceived"].ToString() == "Sent")
                            line += " -> ";
                        else
                            line += " <- ";
                        sw.WriteLine(line);
                        sw.WriteLine(row["text"]);
                        sw.WriteLine();
                    }
                }
                result = true;
            }
            catch(Exception)
            {

            }
            return result;
            
        }

        // Unicode -> ASCII
        public static string EncodeNonAsciiCharacters(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in value)
            {
                if (c > 127)
                    sb.Append("U+" + ((int)c).ToString("x4"));
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }

        // ASCII -> Unicode
        public static string DecodeEncodedNonAsciiCharacters(string value)
        {
            return Regex.Replace(value, @"u\+(?<Value>[a-zA-Z0-9]{4})", m =>
            {
                return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString().ToUpper();
            });
        }
    }
}

