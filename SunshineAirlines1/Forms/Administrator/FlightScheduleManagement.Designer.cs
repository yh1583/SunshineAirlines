namespace SunshineAirlines1.Forms.Administrator
{
    partial class FlightScheduleManagement
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exchange = new System.Windows.Forms.Button();
            this.cbx_to = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_from = new System.Windows.Forms.ComboBox();
            this.rbtn_byCity = new System.Windows.Forms.RadioButton();
            this.rbtn_byAirport = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_resultList = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EconomyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_change = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.session1DataSet = new SunshineAirlines1.Session1DataSet();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportTableAdapter = new SunshineAirlines1.Session1DataSetTableAdapters.AirportTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp_endDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_startDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Exchange);
            this.panel1.Controls.Add(this.cbx_to);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_from);
            this.panel1.Controls.Add(this.rbtn_byCity);
            this.panel1.Controls.Add(this.rbtn_byAirport);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 131);
            this.panel1.TabIndex = 3;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Location = new System.Drawing.Point(734, 60);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(111, 21);
            this.dtp_endDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(702, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "To";
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(585, 60);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(111, 21);
            this.dtp_startDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(582, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departure Date:";
            // 
            // btn_Exchange
            // 
            this.btn_Exchange.BackgroundImage = global::SunshineAirlines1.Properties.Resources.exchange;
            this.btn_Exchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exchange.Location = new System.Drawing.Point(315, 48);
            this.btn_Exchange.Name = "btn_Exchange";
            this.btn_Exchange.Size = new System.Drawing.Size(75, 42);
            this.btn_Exchange.TabIndex = 8;
            this.btn_Exchange.UseVisualStyleBackColor = true;
            this.btn_Exchange.Click += new System.EventHandler(this.btn_Exchange_Click);
            // 
            // cbx_to
            // 
            this.cbx_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_to.FormattingEnabled = true;
            this.cbx_to.Location = new System.Drawing.Point(410, 60);
            this.cbx_to.Name = "cbx_to";
            this.cbx_to.Size = new System.Drawing.Size(121, 20);
            this.cbx_to.TabIndex = 7;
            this.cbx_to.SelectedIndexChanged += new System.EventHandler(this.cbx_to_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(407, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // cbx_from
            // 
            this.cbx_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_from.FormattingEnabled = true;
            this.cbx_from.Location = new System.Drawing.Point(175, 60);
            this.cbx_from.Name = "cbx_from";
            this.cbx_from.Size = new System.Drawing.Size(121, 20);
            this.cbx_from.TabIndex = 5;
            this.cbx_from.SelectedIndexChanged += new System.EventHandler(this.cbx_from_SelectedIndexChanged);
            // 
            // rbtn_byCity
            // 
            this.rbtn_byCity.AutoSize = true;
            this.rbtn_byCity.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.rbtn_byCity.Location = new System.Drawing.Point(25, 75);
            this.rbtn_byCity.Name = "rbtn_byCity";
            this.rbtn_byCity.Size = new System.Drawing.Size(87, 28);
            this.rbtn_byCity.TabIndex = 4;
            this.rbtn_byCity.Text = "By City";
            this.rbtn_byCity.UseVisualStyleBackColor = true;
            this.rbtn_byCity.CheckedChanged += new System.EventHandler(this.rbtn_byCity_CheckedChanged);
            // 
            // rbtn_byAirport
            // 
            this.rbtn_byAirport.AutoSize = true;
            this.rbtn_byAirport.Checked = true;
            this.rbtn_byAirport.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.rbtn_byAirport.Location = new System.Drawing.Point(25, 38);
            this.rbtn_byAirport.Name = "rbtn_byAirport";
            this.rbtn_byAirport.Size = new System.Drawing.Size(111, 28);
            this.rbtn_byAirport.TabIndex = 3;
            this.rbtn_byAirport.TabStop = true;
            this.rbtn_byAirport.Text = "By Airport";
            this.rbtn_byAirport.UseVisualStyleBackColor = true;
            this.rbtn_byAirport.CheckedChanged += new System.EventHandler(this.rbtn_byAirport_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_search.Location = new System.Drawing.Point(865, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(404, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Schedule Management";
            // 
            // dgv_resultList
            // 
            this.dgv_resultList.AllowUserToAddRows = false;
            this.dgv_resultList.AllowUserToDeleteRows = false;
            this.dgv_resultList.AllowUserToResizeColumns = false;
            this.dgv_resultList.AllowUserToResizeRows = false;
            this.dgv_resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.From,
            this.To,
            this.Aircraft,
            this.EconomyPrice,
            this.FlightNumber,
            this.Gate,
            this.Status,
            this.Detail});
            this.dgv_resultList.Location = new System.Drawing.Point(17, 212);
            this.dgv_resultList.Name = "dgv_resultList";
            this.dgv_resultList.ReadOnly = true;
            this.dgv_resultList.RowTemplate.Height = 23;
            this.dgv_resultList.Size = new System.Drawing.Size(1171, 527);
            this.dgv_resultList.TabIndex = 4;
            this.dgv_resultList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultList_CellContentClick);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "To";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Aircraft
            // 
            this.Aircraft.DataPropertyName = "Aircraft";
            this.Aircraft.HeaderText = "Aircraft";
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.ReadOnly = true;
            // 
            // EconomyPrice
            // 
            this.EconomyPrice.DataPropertyName = "Economy Price";
            this.EconomyPrice.HeaderText = "Economy Price";
            this.EconomyPrice.Name = "EconomyPrice";
            this.EconomyPrice.ReadOnly = true;
            // 
            // FlightNumber
            // 
            this.FlightNumber.DataPropertyName = "Flight Number";
            this.FlightNumber.HeaderText = "Flight Number";
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.ReadOnly = true;
            // 
            // Gate
            // 
            this.Gate.DataPropertyName = "Gate";
            this.Gate.HeaderText = "Gate";
            this.Gate.Name = "Gate";
            this.Gate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Text = "Detail";
            this.Detail.ToolTipText = "Detail";
            this.Detail.UseColumnTextForLinkValue = true;
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_change.Location = new System.Drawing.Point(1077, 745);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(111, 43);
            this.btn_change.TabIndex = 13;
            this.btn_change.Text = "Cancel/Confirm";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(484, 184);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(141, 24);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total Schedule:";
            // 
            // session1DataSet
            // 
            this.session1DataSet.DataSetName = "Session1DataSet";
            this.session1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataMember = "Airport";
            this.airportBindingSource.DataSource = this.session1DataSet;
            // 
            // airportTableAdapter
            // 
            this.airportTableAdapter.ClearBeforeFill = true;
            // 
            // FlightScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dgv_resultList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightScheduleManagement";
            this.Text = "FlightScheduleManagement";
            this.Load += new System.EventHandler(this.FlightScheduleManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_byCity;
        private System.Windows.Forms.RadioButton rbtn_byAirport;
        private System.Windows.Forms.ComboBox cbx_from;
        private System.Windows.Forms.Button btn_Exchange;
        private System.Windows.Forms.ComboBox cbx_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DataGridView dgv_resultList;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label lbl_total;
        private Session1DataSet session1DataSet;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private Session1DataSetTableAdapters.AirportTableAdapter airportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn EconomyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewLinkColumn Detail;
    }
}