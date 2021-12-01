namespace SunshineAirlines1.Forms.Administrator
{
    partial class UserManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_resultList = new System.Windows.Forms.DataGridView();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.cbx_pageNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_totalRecords = new System.Windows.Forms.Label();
            this.lbl_totalPages = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_adduser);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.cbx_role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 138);
            this.panel1.TabIndex = 0;
            // 
            // btn_adduser
            // 
            this.btn_adduser.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_adduser.Location = new System.Drawing.Point(621, 43);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(127, 47);
            this.btn_adduser.TabIndex = 9;
            this.btn_adduser.Text = "Add a new user";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_search.Location = new System.Drawing.Point(464, 43);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(114, 47);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(260, 69);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 21);
            this.txt_name.TabIndex = 7;
            // 
            // cbx_role
            // 
            this.cbx_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Location = new System.Drawing.Point(25, 70);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(159, 20);
            this.cbx_role.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(256, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(482, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Management";
            // 
            // dgv_resultList
            // 
            this.dgv_resultList.AllowUserToAddRows = false;
            this.dgv_resultList.AllowUserToDeleteRows = false;
            this.dgv_resultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultList.Location = new System.Drawing.Point(12, 210);
            this.dgv_resultList.Name = "dgv_resultList";
            this.dgv_resultList.ReadOnly = true;
            this.dgv_resultList.RowTemplate.Height = 23;
            this.dgv_resultList.Size = new System.Drawing.Size(1176, 521);
            this.dgv_resultList.TabIndex = 5;
            // 
            // btn_end
            // 
            this.btn_end.BackgroundImage = global::SunshineAirlines1.Properties.Resources.last;
            this.btn_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_end.Location = new System.Drawing.Point(278, 737);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(40, 40);
            this.btn_end.TabIndex = 9;
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = global::SunshineAirlines1.Properties.Resources.next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_next.Location = new System.Drawing.Point(222, 737);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(40, 40);
            this.btn_next.TabIndex = 8;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackgroundImage = global::SunshineAirlines1.Properties.Resources.previous;
            this.btn_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_last.Location = new System.Drawing.Point(68, 737);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(40, 40);
            this.btn_last.TabIndex = 7;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackgroundImage = global::SunshineAirlines1.Properties.Resources.first;
            this.btn_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_first.Location = new System.Drawing.Point(12, 737);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(40, 40);
            this.btn_first.TabIndex = 6;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // cbx_pageNum
            // 
            this.cbx_pageNum.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.cbx_pageNum.FormattingEnabled = true;
            this.cbx_pageNum.Location = new System.Drawing.Point(116, 748);
            this.cbx_pageNum.Name = "cbx_pageNum";
            this.cbx_pageNum.Size = new System.Drawing.Size(84, 26);
            this.cbx_pageNum.TabIndex = 10;
            this.cbx_pageNum.TextChanged += new System.EventHandler(this.cbx_pageNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(617, 747);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Records:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(382, 747);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Pages:";
            // 
            // lbl_totalRecords
            // 
            this.lbl_totalRecords.AutoSize = true;
            this.lbl_totalRecords.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_totalRecords.Location = new System.Drawing.Point(788, 748);
            this.lbl_totalRecords.Name = "lbl_totalRecords";
            this.lbl_totalRecords.Size = new System.Drawing.Size(0, 30);
            this.lbl_totalRecords.TabIndex = 13;
            // 
            // lbl_totalPages
            // 
            this.lbl_totalPages.AutoSize = true;
            this.lbl_totalPages.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_totalPages.Location = new System.Drawing.Point(529, 748);
            this.lbl_totalPages.Name = "lbl_totalPages";
            this.lbl_totalPages.Size = new System.Drawing.Size(0, 30);
            this.lbl_totalPages.TabIndex = 12;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F);
            this.btn_edit.Location = new System.Drawing.Point(1051, 737);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(137, 51);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_totalRecords);
            this.Controls.Add(this.lbl_totalPages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_pageNum);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.dgv_resultList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cbx_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_resultList;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.ComboBox cbx_pageNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_totalRecords;
        private System.Windows.Forms.Label lbl_totalPages;
        private System.Windows.Forms.Button btn_edit;
    }
}