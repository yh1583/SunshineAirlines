namespace SunshineAirlines1.Forms.Administrator
{
    partial class TicketStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.dgv_resultList = new System.Windows.Forms.DataGridView();
            this.crt_dataLineMap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_viewBy = new System.Windows.Forms.ComboBox();
            this.che_showAmount = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_dataLineMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(492, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Statistics";
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.CustomFormat = "yyyy-MM";
            this.dtp_startDate.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDate.Location = new System.Drawing.Point(35, 98);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(121, 25);
            this.dtp_startDate.TabIndex = 5;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.CustomFormat = "yyyy-MM";
            this.dtp_endDate.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDate.Location = new System.Drawing.Point(253, 98);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(121, 25);
            this.dtp_endDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "-------------";
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_statistics.Location = new System.Drawing.Point(417, 96);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(75, 23);
            this.btn_statistics.TabIndex = 8;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // dgv_resultList
            // 
            this.dgv_resultList.AllowUserToAddRows = false;
            this.dgv_resultList.AllowUserToDeleteRows = false;
            this.dgv_resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultList.Location = new System.Drawing.Point(35, 172);
            this.dgv_resultList.Name = "dgv_resultList";
            this.dgv_resultList.ReadOnly = true;
            this.dgv_resultList.RowTemplate.Height = 23;
            this.dgv_resultList.Size = new System.Drawing.Size(545, 403);
            this.dgv_resultList.TabIndex = 9;
            // 
            // crt_dataLineMap
            // 
            chartArea1.Name = "ChartArea1";
            this.crt_dataLineMap.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.crt_dataLineMap.Legends.Add(legend1);
            this.crt_dataLineMap.Location = new System.Drawing.Point(586, 172);
            this.crt_dataLineMap.Name = "crt_dataLineMap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "FlightAmount";
            this.crt_dataLineMap.Series.Add(series1);
            this.crt_dataLineMap.Size = new System.Drawing.Size(568, 403);
            this.crt_dataLineMap.TabIndex = 10;
            this.crt_dataLineMap.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.label3.Location = new System.Drawing.Point(660, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "View By:";
            // 
            // cbx_viewBy
            // 
            this.cbx_viewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_viewBy.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.cbx_viewBy.FormattingEnabled = true;
            this.cbx_viewBy.Items.AddRange(new object[] {
            "FlightsAmount",
            "TicketsAmount",
            "TicketsRevenue"});
            this.cbx_viewBy.Location = new System.Drawing.Point(726, 139);
            this.cbx_viewBy.Name = "cbx_viewBy";
            this.cbx_viewBy.Size = new System.Drawing.Size(121, 26);
            this.cbx_viewBy.TabIndex = 12;
            this.cbx_viewBy.SelectedIndexChanged += new System.EventHandler(this.cbx_viewBy_SelectedIndexChanged);
            // 
            // che_showAmount
            // 
            this.che_showAmount.AutoSize = true;
            this.che_showAmount.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.che_showAmount.Location = new System.Drawing.Point(973, 141);
            this.che_showAmount.Name = "che_showAmount";
            this.che_showAmount.Size = new System.Drawing.Size(107, 22);
            this.che_showAmount.TabIndex = 13;
            this.che_showAmount.Text = "Show Amount";
            this.che_showAmount.UseVisualStyleBackColor = true;
            this.che_showAmount.CheckedChanged += new System.EventHandler(this.che_showAmount_CheckedChanged);
            // 
            // TicketStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.che_showAmount);
            this.Controls.Add(this.cbx_viewBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crt_dataLineMap);
            this.Controls.Add(this.dgv_resultList);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketStatistics";
            this.Text = "TicketStatistics";
            this.Load += new System.EventHandler(this.TicketStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_dataLineMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.DataGridView dgv_resultList;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_dataLineMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_viewBy;
        private System.Windows.Forms.CheckBox che_showAmount;
    }
}