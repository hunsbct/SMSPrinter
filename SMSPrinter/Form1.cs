using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
// TODO use chat-message join table to build a better UI
namespace SMSPrinter
{
    public partial class FrmMain : MetroForm
    {
        private DataTable messages = null;
        private readonly string[] metroColors = { "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow" };


        public FrmMain()
        {
            InitializeComponent();
            WireColumns();
            cbFileFormat.SelectedIndex = 0;
            dtTo.ValueChanged -= dt_ValueChanged;
            dtTo.Value = DateTime.Now.AddDays(1);
            dtTo.ValueChanged += dt_ValueChanged;
            cbColorPicker.DataSource = metroColors;
            cbColorPicker.SelectedIndex = 3;
            BtnView_Click(null, null);
            gvMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        
        private string FormatNumber(string number)
        {
            return number.Substring(0, 2) + " (" + number.Substring(2, 3) + ") " + number.Substring(5, 3) + "-" + number.Substring(8);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            // TODO add formatting options
            // TODO add emoji support
            txtContact.Enabled = true;
            txtContact.Text = "";

            gvMessages.DataSource = GetTable();
            txtContact_TextChanged(null, null);
            txtMessage_TextChanged(null, null);
        }

        private DataTable GetTable()
        {
            DBAccess dba = new DBAccess("");
            long fromTime = Utilities.ToEpoch(dtFrom.Value), toTime = Utilities.ToEpoch(dtTo.Value);
            DataTable dt = dba.GetTable("select handle.id, " +
                "message.date, message.text, message.is_from_me from message, " +
                "handle where message.handle_id = handle.rowid and message.date between " + fromTime + " and " + toTime);
            dt.Columns.Add("Timestamp");
            dt.Columns.Add("SentReceived");
            foreach (DataRow row in dt.Rows)
            {
                row["Timestamp"] = Utilities.FromEpoch(long.Parse(row["date"].ToString()));
                string[] dateValues = row["Timestamp"].ToString().Split(' ')[0].Split('/');
                row["id"] = FormatNumber(row["id"].ToString());
                if (int.Parse(row["is_from_me"].ToString()) == 1)
                    row["SentReceived"] = "Sent";
                else
                    row["SentReceived"] = "Received";
                // Convert Unicode to ASCII
                row["text"] = Utilities.EncodeNonAsciiCharacters(row["text"].ToString());
            }

            return dt;
        }

        private void gvMessages_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There was an error while the data was being read for display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MetroGrid mg = (MetroGrid)sender;
            // Only fire event once
            mg.DataError -= gvMessages_DataError;
            mg.DataError += gvMessages_DataErrorFired;
        }

        private void gvMessages_DataErrorFired(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Leave this blank
        }

        private void Print(DataTable dt, int filetype)
        {
            bool result = true;
            string filepath = SaveFile(filetype);
            // TODO add other filetypes like PDF
            switch (filetype)
            {
                case 0:
                    result = Utilities.WriteToTextFile(dt, filepath);
                    break;
                case 1:
                    result = Utilities.WriteToCsvFile(dt, filepath);
                    break;
                default:
                    result = false;
                    break;
            }
            if (result)
            {
                DialogResult dr = MessageBox.Show("Write finished. Open file?", "Success", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    Process.Start(filepath);
            }
            else
                MessageBox.Show("Unable to write file.", "Error", MessageBoxButtons.OK);
        }


        private string SaveFile(int filetype)
        {
            string filter;
            switch (filetype)
            {
                case 0:
                    filter = "Text|*.txt";
                    break;
                case 1:
                    filter = "Comma Separated Values|*.csv";
                    break;
                default:
                    filter = "All Files|*.*";
                    break;
            }

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save Print File",
                Filter = filter,
                FilterIndex = 0,
                RestoreDirectory = true,
                FileName = "messages"
            })
            {
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                    return sfd.FileName;
                else
                    return "";
            }
        }

        private void WireColumns()
        {
            gvMessages.AutoGenerateColumns = false;
            gvMessages.Columns["sender"].DataPropertyName = "id";
            gvMessages.Columns["timestamp"].DataPropertyName = "TimeStamp";
            gvMessages.Columns["TimeStamp"].ValueType = typeof(DateTime);
            gvMessages.Columns["message"].DataPropertyName = "text";
            gvMessages.Columns["sentreceived"].DataPropertyName = "SentReceived";
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            (gvMessages.DataSource as DataTable).DefaultView.RowFilter = string.Format("id LIKE '%{0}%'", txtContact.Text);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            (gvMessages.DataSource as DataTable).DefaultView.RowFilter = string.Format("text LIKE '%{0}%'", txtMessage.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changing the values in any of the fields will filter the data table's contents accordingly. Text fields are case insensitive. You can also sort the contents of the table by clicking on a column header. When the contents reflect the desired output, select an output file format and click print.\n Currently, the software will only read a file called \"sms.db\" in the same directory as the executable. A file selector could be added if desired.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            string senderName = dtp.Name;
            if (dtFrom.Value > dtTo.Value)
            {
                if (senderName == "dtFrom")
                    dtTo.Value = dtFrom.Value;
                else
                    dtFrom.Value = dtTo.Value;
            }
            else
            {
                gvMessages.DataSource = GetTable();
                txtContact_TextChanged(null, null);
                txtMessage_TextChanged(null, null);
            }
        }

        private void PrintFiltered_Click(object sender, EventArgs e)
        {
            if (cbFileFormat.SelectedIndex > 0 && gvMessages.DataSource != null)
            {
                DataTable filteredTable = new DataTable();
                foreach (DataGridViewColumn column in gvMessages.Columns)
                    filteredTable.Columns.Add(column.Name);
                foreach (DataGridViewRow row in gvMessages.Rows)
                {
                    DataRow dataRow = filteredTable.NewRow();
                    for (int i = 0; i < filteredTable.Columns.Count; i++)
                        dataRow[i] = row.Cells[i].Value;
                    filteredTable.Rows.Add(dataRow);
                }

                messages = filteredTable;
                if (messages != null)
                    Print(messages, cbFileFormat.SelectedIndex - 1);
                else
                    MessageBox.Show("No messages in filtered view. Try different criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbFileFormat.SelectedIndex == 0)
                MessageBox.Show("Please use the dropdown box to select an output format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbColorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbColorPicker.SelectedIndex)
            {
                case 0:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Black;
                    break;
                case 1:
                    gvMessages.Style = MetroFramework.MetroColorStyle.White;
                    break;
                case 2:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Silver;
                    break;
                case 3:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case 4:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case 5:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Lime;
                    break;
                case 6:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Teal;
                    break;
                case 7:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 8:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Brown;
                    break;
                case 9:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 10:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 11:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 12:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 13:
                    gvMessages.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                default:
                    break;
            }

            Style = gvMessages.Style;
            dtFrom.Style = gvMessages.Style;
            dtTo.Style = gvMessages.Style;
            txtContact.Style = gvMessages.Style;
            txtMessage.Style = gvMessages.Style;
            btnPrintFiltered.Style = gvMessages.Style;
            cbColorPicker.Style = gvMessages.Style;
            cbFileFormat.Style = gvMessages.Style;
            this.Refresh();
        }
    }
}
