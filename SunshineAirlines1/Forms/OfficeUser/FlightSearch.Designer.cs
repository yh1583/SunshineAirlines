namespace SunshineAirlines1.Forms.OfficeUser
{
    partial class FlightSearch
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
            this.cbx_flightType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_cabinType = new System.Windows.Forms.ComboBox();
            this.cabinTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session1DataSet = new SunshineAirlines1.Session1DataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ret = new System.Windows.Forms.DateTimePicker();
            this.dtp_dep = new System.Windows.Forms.DateTimePicker();
            this.lbl_ret = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_toCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.session1DataSet1 = new SunshineAirlines1.Session1DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_fromCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_round = new System.Windows.Forms.RadioButton();
            this.rbtn_one = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pan_dep = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pan_ret = new System.Windows.Forms.Panel();
            this.cityTableAdapter = new SunshineAirlines1.Session1DataSetTableAdapters.CityTableAdapter();
            this.cityTableAdapter1 = new SunshineAirlines1.Session1DataSet1TableAdapters.CityTableAdapter();
            this.cabinTypeTableAdapter = new SunshineAirlines1.Session1DataSetTableAdapters.CabinTypeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbx_flightType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbx_cabinType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_ret);
            this.panel1.Controls.Add(this.dtp_dep);
            this.panel1.Controls.Add(this.lbl_ret);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbx_toCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_fromCity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtn_round);
            this.panel1.Controls.Add(this.rbtn_one);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 106);
            this.panel1.TabIndex = 3;
            // 
            // cbx_flightType
            // 
            this.cbx_flightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_flightType.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_flightType.FormattingEnabled = true;
            this.cbx_flightType.Items.AddRange(new object[] {
            "All",
            "Non-Stop",
            "Stop"});
            this.cbx_flightType.Location = new System.Drawing.Point(860, 61);
            this.cbx_flightType.Name = "cbx_flightType";
            this.cbx_flightType.Size = new System.Drawing.Size(151, 26);
            this.cbx_flightType.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(879, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Flight Type:";
            // 
            // cbx_cabinType
            // 
            this.cbx_cabinType.DataSource = this.cabinTypeBindingSource;
            this.cbx_cabinType.DisplayMember = "CabinTypeName";
            this.cbx_cabinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cabinType.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cabinType.FormattingEnabled = true;
            this.cbx_cabinType.Location = new System.Drawing.Point(685, 61);
            this.cbx_cabinType.Name = "cbx_cabinType";
            this.cbx_cabinType.Size = new System.Drawing.Size(157, 26);
            this.cbx_cabinType.TabIndex = 15;
            this.cbx_cabinType.ValueMember = "CabinTypeId";
            // 
            // cabinTypeBindingSource
            // 
            this.cabinTypeBindingSource.DataMember = "CabinType";
            this.cabinTypeBindingSource.DataSource = this.session1DataSet;
            // 
            // session1DataSet
            // 
            this.session1DataSet.DataSetName = "Session1DataSet";
            this.session1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cabin Type:";
            // 
            // dtp_ret
            // 
            this.dtp_ret.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ret.Location = new System.Drawing.Point(529, 59);
            this.dtp_ret.Name = "dtp_ret";
            this.dtp_ret.Size = new System.Drawing.Size(128, 25);
            this.dtp_ret.TabIndex = 13;
            // 
            // dtp_dep
            // 
            this.dtp_dep.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dep.Location = new System.Drawing.Point(369, 59);
            this.dtp_dep.Name = "dtp_dep";
            this.dtp_dep.Size = new System.Drawing.Size(128, 25);
            this.dtp_dep.TabIndex = 12;
            // 
            // lbl_ret
            // 
            this.lbl_ret.AutoSize = true;
            this.lbl_ret.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ret.Location = new System.Drawing.Point(527, 23);
            this.lbl_ret.Name = "lbl_ret";
            this.lbl_ret.Size = new System.Drawing.Size(80, 18);
            this.lbl_ret.TabIndex = 11;
            this.lbl_ret.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departure Date:";
            // 
            // cbx_toCity
            // 
            this.cbx_toCity.DataSource = this.cityBindingSource1;
            this.cbx_toCity.DisplayMember = "CityName";
            this.cbx_toCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_toCity.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_toCity.FormattingEnabled = true;
            this.cbx_toCity.Location = new System.Drawing.Point(261, 60);
            this.cbx_toCity.Name = "cbx_toCity";
            this.cbx_toCity.Size = new System.Drawing.Size(84, 26);
            this.cbx_toCity.TabIndex = 8;
            this.cbx_toCity.ValueMember = "CityCode";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.session1DataSet1;
            // 
            // session1DataSet1
            // 
            this.session1DataSet1.DataSetName = "Session1DataSet1";
            this.session1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "To City:";
            // 
            // cbx_fromCity
            // 
            this.cbx_fromCity.DataSource = this.cityBindingSource;
            this.cbx_fromCity.DisplayMember = "CityName";
            this.cbx_fromCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_fromCity.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fromCity.FormattingEnabled = true;
            this.cbx_fromCity.Location = new System.Drawing.Point(155, 60);
            this.cbx_fromCity.Name = "cbx_fromCity";
            this.cbx_fromCity.Size = new System.Drawing.Size(84, 26);
            this.cbx_fromCity.TabIndex = 6;
            this.cbx_fromCity.ValueMember = "CityCode";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.session1DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "From City:";
            // 
            // rbtn_round
            // 
            this.rbtn_round.AutoSize = true;
            this.rbtn_round.Checked = true;
            this.rbtn_round.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_round.Location = new System.Drawing.Point(33, 61);
            this.rbtn_round.Name = "rbtn_round";
            this.rbtn_round.Size = new System.Drawing.Size(97, 22);
            this.rbtn_round.TabIndex = 4;
            this.rbtn_round.TabStop = true;
            this.rbtn_round.Text = "Round Ways";
            this.rbtn_round.UseVisualStyleBackColor = true;
            this.rbtn_round.CheckedChanged += new System.EventHandler(this.rbtn_round_CheckedChanged);
            // 
            // rbtn_one
            // 
            this.rbtn_one.AutoSize = true;
            this.rbtn_one.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_one.Location = new System.Drawing.Point(33, 21);
            this.rbtn_one.Name = "rbtn_one";
            this.rbtn_one.Size = new System.Drawing.Size(80, 22);
            this.rbtn_one.TabIndex = 3;
            this.rbtn_one.Text = "One Way";
            this.rbtn_one.UseVisualStyleBackColor = true;
            this.rbtn_one.CheckedChanged += new System.EventHandler(this.rbtn_one_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(1017, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pan_dep);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departure Flights";
            // 
            // pan_dep
            // 
            this.pan_dep.AutoScroll = true;
            this.pan_dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_dep.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_dep.Location = new System.Drawing.Point(6, 14);
            this.pan_dep.Name = "pan_dep";
            this.pan_dep.Size = new System.Drawing.Size(1143, 284);
            this.pan_dep.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pan_ret);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(22, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 321);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Flights";
            // 
            // pan_ret
            // 
            this.pan_ret.AutoScroll = true;
            this.pan_ret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_ret.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_ret.Location = new System.Drawing.Point(6, 14);
            this.pan_ret.Name = "pan_ret";
            this.pan_ret.Size = new System.Drawing.Size(1143, 301);
            this.pan_ret.TabIndex = 0;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // cabinTypeTableAdapter
            // 
            this.cabinTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FlightSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightSearch";
            this.Text = "FlightSearch";
            this.Load += new System.EventHandler(this.FlightSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_ret;
        private System.Windows.Forms.DateTimePicker dtp_dep;
        private System.Windows.Forms.Label lbl_ret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_toCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_fromCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_round;
        private System.Windows.Forms.RadioButton rbtn_one;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_flightType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_cabinType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pan_dep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pan_ret;
        private Session1DataSet session1DataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private Session1DataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private Session1DataSet1 session1DataSet1;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private Session1DataSet1TableAdapters.CityTableAdapter cityTableAdapter1;
        private System.Windows.Forms.BindingSource cabinTypeBindingSource;
        private Session1DataSetTableAdapters.CabinTypeTableAdapter cabinTypeTableAdapter;
    }
}