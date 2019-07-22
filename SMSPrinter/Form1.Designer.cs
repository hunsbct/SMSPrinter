namespace SMSPrinter
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.gvMessages = new MetroFramework.Controls.MetroGrid();
            this.cbFileFormat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnPrintFiltered = new MetroFramework.Controls.MetroButton();
            this.cbColorPicker = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentreceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Sender Phone Number:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Enabled = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(326, 38);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(161, 23);
            this.txtContact.TabIndex = 2;
            this.txtContact.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // gvMessages
            // 
            this.gvMessages.AllowUserToAddRows = false;
            this.gvMessages.AllowUserToDeleteRows = false;
            this.gvMessages.AllowUserToResizeRows = false;
            this.gvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sender,
            this.timestamp,
            this.sentreceived,
            this.message});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMessages.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMessages.EnableHeadersVisualStyles = false;
            this.gvMessages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvMessages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvMessages.Location = new System.Drawing.Point(23, 171);
            this.gvMessages.Name = "gvMessages";
            this.gvMessages.ReadOnly = true;
            this.gvMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMessages.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMessages.Size = new System.Drawing.Size(1208, 438);
            this.gvMessages.Style = MetroFramework.MetroColorStyle.Silver;
            this.gvMessages.TabIndex = 4;
            this.gvMessages.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvMessages_DataError);
            // 
            // cbFileFormat
            // 
            this.cbFileFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFileFormat.FormattingEnabled = true;
            this.cbFileFormat.ItemHeight = 23;
            this.cbFileFormat.Items.AddRange(new object[] {
            "Plain Text",
            "CSV"});
            this.cbFileFormat.Location = new System.Drawing.Point(750, 136);
            this.cbFileFormat.Name = "cbFileFormat";
            this.cbFileFormat.Size = new System.Drawing.Size(134, 29);
            this.cbFileFormat.TabIndex = 6;
            this.cbFileFormat.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(175, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Filters";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(493, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Message:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtMessage
            // 
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(560, 38);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(181, 23);
            this.txtMessage.TabIndex = 9;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(326, 89);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 10;
            this.dtFrom.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(243, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Timestamp:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(326, 67);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "From";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(532, 67);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(24, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "To";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(532, 89);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 29);
            this.dtTo.TabIndex = 14;
            this.dtTo.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(236, 13);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(23, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "?";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnPrintFiltered
            // 
            this.btnPrintFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintFiltered.Location = new System.Drawing.Point(890, 142);
            this.btnPrintFiltered.Name = "btnPrintFiltered";
            this.btnPrintFiltered.Size = new System.Drawing.Size(173, 23);
            this.btnPrintFiltered.TabIndex = 16;
            this.btnPrintFiltered.Text = "Print Table Contents";
            this.btnPrintFiltered.UseSelectable = true;
            this.btnPrintFiltered.Click += new System.EventHandler(this.PrintFiltered_Click);
            // 
            // cbColorPicker
            // 
            this.cbColorPicker.FormattingEnabled = true;
            this.cbColorPicker.ItemHeight = 23;
            this.cbColorPicker.Location = new System.Drawing.Point(84, 136);
            this.cbColorPicker.Name = "cbColorPicker";
            this.cbColorPicker.Size = new System.Drawing.Size(146, 29);
            this.cbColorPicker.TabIndex = 17;
            this.cbColorPicker.UseSelectable = true;
            this.cbColorPicker.SelectedIndexChanged += new System.EventHandler(this.cbColorPicker_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 136);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Theme:";
            // 
            // sender
            // 
            this.sender.HeaderText = "Sender";
            this.sender.Name = "sender";
            this.sender.ReadOnly = true;
            this.sender.Width = 66;
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "Timestamp";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 84;
            // 
            // sentreceived
            // 
            this.sentreceived.HeaderText = "Sent/Received";
            this.sentreceived.Name = "sentreceived";
            this.sentreceived.ReadOnly = true;
            this.sentreceived.Width = 102;
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Width = 75;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(750, 114);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(124, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Output File Format:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 632);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cbColorPicker);
            this.Controls.Add(this.btnPrintFiltered);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbFileFormat);
            this.Controls.Add(this.gvMessages);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmMain";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "SMS Printer";
            ((System.ComponentModel.ISupportInitialize)(this.gvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroGrid gvMessages;
        private MetroFramework.Controls.MetroComboBox cbFileFormat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnPrintFiltered;
        private MetroFramework.Controls.MetroComboBox cbColorPicker;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentreceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}

