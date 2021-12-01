namespace SunshineAirlines1.Forms.OfficeUser
{
    partial class FoodServices
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
            this.txt_idTypeNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_idType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_load = new System.Windows.Forms.Button();
            this.cbx_flight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pan_food = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_paymentState = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.lbl_selectAmount = new System.Windows.Forms.Label();
            this.lbl_selectItem = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Services";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_idTypeNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_idType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 92);
            this.panel1.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(399, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_idTypeNum
            // 
            this.txt_idTypeNum.Location = new System.Drawing.Point(259, 48);
            this.txt_idTypeNum.Name = "txt_idTypeNum";
            this.txt_idTypeNum.Size = new System.Drawing.Size(100, 25);
            this.txt_idTypeNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Type Number:";
            // 
            // cbx_idType
            // 
            this.cbx_idType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_idType.FormattingEnabled = true;
            this.cbx_idType.Items.AddRange(new object[] {
            "PassPort"});
            this.cbx_idType.Location = new System.Drawing.Point(55, 49);
            this.cbx_idType.Name = "cbx_idType";
            this.cbx_idType.Size = new System.Drawing.Size(121, 26);
            this.cbx_idType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Type:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.cbx_flight);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(8, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 92);
            this.panel2.TabIndex = 4;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(464, 33);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // cbx_flight
            // 
            this.cbx_flight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_flight.FormattingEnabled = true;
            this.cbx_flight.Location = new System.Drawing.Point(119, 35);
            this.cbx_flight.Name = "cbx_flight";
            this.cbx_flight.Size = new System.Drawing.Size(326, 26);
            this.cbx_flight.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Flight:";
            // 
            // pan_food
            // 
            this.pan_food.AutoScroll = true;
            this.pan_food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_food.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_food.Location = new System.Drawing.Point(9, 252);
            this.pan_food.Name = "pan_food";
            this.pan_food.Size = new System.Drawing.Size(1179, 421);
            this.pan_food.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected Item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 727);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Selected Amount:";
            // 
            // lbl_paymentState
            // 
            this.lbl_paymentState.AutoSize = true;
            this.lbl_paymentState.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentState.Location = new System.Drawing.Point(13, 765);
            this.lbl_paymentState.Name = "lbl_paymentState";
            this.lbl_paymentState.Size = new System.Drawing.Size(62, 18);
            this.lbl_paymentState.TabIndex = 8;
            this.lbl_paymentState.Text = "Payment:";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.Location = new System.Drawing.Point(88, 765);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(11, 18);
            this.lbl_payment.TabIndex = 11;
            this.lbl_payment.Text = " ";
            // 
            // lbl_selectAmount
            // 
            this.lbl_selectAmount.AutoSize = true;
            this.lbl_selectAmount.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectAmount.Location = new System.Drawing.Point(124, 727);
            this.lbl_selectAmount.Name = "lbl_selectAmount";
            this.lbl_selectAmount.Size = new System.Drawing.Size(11, 18);
            this.lbl_selectAmount.TabIndex = 10;
            this.lbl_selectAmount.Text = " ";
            // 
            // lbl_selectItem
            // 
            this.lbl_selectItem.AutoSize = true;
            this.lbl_selectItem.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectItem.Location = new System.Drawing.Point(110, 686);
            this.lbl_selectItem.Name = "lbl_selectItem";
            this.lbl_selectItem.Size = new System.Drawing.Size(11, 18);
            this.lbl_selectItem.TabIndex = 9;
            this.lbl_selectItem.Text = " ";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("TeX Gyre Adventor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(499, 718);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(169, 37);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // FoodServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.lbl_selectAmount);
            this.Controls.Add(this.lbl_selectItem);
            this.Controls.Add(this.lbl_paymentState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pan_food);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodServices";
            this.Text = "FoodServices";
            this.Load += new System.EventHandler(this.FoodServices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_idTypeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_idType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbx_flight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel pan_food;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_paymentState;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl_selectAmount;
        private System.Windows.Forms.Label lbl_selectItem;
        private System.Windows.Forms.Button btn_confirm;
    }
}