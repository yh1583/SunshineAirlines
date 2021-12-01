namespace SunshineAirlines1.Forms.OfficeUser
{
    partial class FlightStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_dep = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_resultList = new System.Windows.Forms.DataGridView();
            this.lbl_sumPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nowPage = new System.Windows.Forms.TextBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Status";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.dtp_dep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 131);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_search.Location = new System.Drawing.Point(185, 63);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 27);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_dep
            // 
            this.dtp_dep.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.dtp_dep.Location = new System.Drawing.Point(41, 64);
            this.dtp_dep.Name = "dtp_dep";
            this.dtp_dep.Size = new System.Drawing.Size(138, 25);
            this.dtp_dep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departure Date:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_resultList);
            this.panel2.Controls.Add(this.lbl_sumPage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_nowPage);
            this.panel2.Controls.Add(this.btn_end);
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_last);
            this.panel2.Controls.Add(this.btn_first);
            this.panel2.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.panel2.Location = new System.Drawing.Point(12, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 583);
            this.panel2.TabIndex = 4;
            // 
            // dgv_resultList
            // 
            this.dgv_resultList.AllowUserToAddRows = false;
            this.dgv_resultList.AllowUserToDeleteRows = false;
            this.dgv_resultList.AllowUserToResizeColumns = false;
            this.dgv_resultList.AllowUserToResizeRows = false;
            this.dgv_resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultList.Location = new System.Drawing.Point(20, 59);
            this.dgv_resultList.Name = "dgv_resultList";
            this.dgv_resultList.ReadOnly = true;
            this.dgv_resultList.RowTemplate.Height = 23;
            this.dgv_resultList.Size = new System.Drawing.Size(1134, 501);
            this.dgv_resultList.TabIndex = 6;
            // 
            // lbl_sumPage
            // 
            this.lbl_sumPage.AutoSize = true;
            this.lbl_sumPage.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumPage.Location = new System.Drawing.Point(215, 25);
            this.lbl_sumPage.Name = "lbl_sumPage";
            this.lbl_sumPage.Size = new System.Drawing.Size(0, 24);
            this.lbl_sumPage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(182, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Of";
            // 
            // txt_nowPage
            // 
            this.txt_nowPage.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.txt_nowPage.Location = new System.Drawing.Point(128, 24);
            this.txt_nowPage.Name = "txt_nowPage";
            this.txt_nowPage.Size = new System.Drawing.Size(51, 25);
            this.txt_nowPage.TabIndex = 4;
            this.txt_nowPage.TextChanged += new System.EventHandler(this.txt_nowPage_TextChanged);
            // 
            // btn_end
            // 
            this.btn_end.BackgroundImage = global::SunshineAirlines1.Properties.Resources.last;
            this.btn_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_end.Location = new System.Drawing.Point(292, 13);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(40, 40);
            this.btn_end.TabIndex = 3;
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = global::SunshineAirlines1.Properties.Resources.next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_next.Location = new System.Drawing.Point(236, 13);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(40, 40);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackgroundImage = global::SunshineAirlines1.Properties.Resources.previous;
            this.btn_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_last.Location = new System.Drawing.Point(82, 13);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(40, 40);
            this.btn_last.TabIndex = 1;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackgroundImage = global::SunshineAirlines1.Properties.Resources.first;
            this.btn_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_first.Location = new System.Drawing.Point(26, 13);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(40, 40);
            this.btn_first.TabIndex = 0;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // FlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightStatus";
            this.Text = "FlightStatus";
            this.Load += new System.EventHandler(this.FlightStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_dep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.TextBox txt_nowPage;
        private System.Windows.Forms.Label lbl_sumPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_resultList;
    }
}