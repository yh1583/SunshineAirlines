namespace SunshineAirlines1.Forms.OfficeUser
{
    partial class FoodUnit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_foodImg = new System.Windows.Forms.PictureBox();
            this.che_isSelected = new System.Windows.Forms.CheckBox();
            this.nud_foodNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_foodNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(41, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(41, 12);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "label1";
            // 
            // pic_foodImg
            // 
            this.pic_foodImg.Location = new System.Drawing.Point(70, 22);
            this.pic_foodImg.Name = "pic_foodImg";
            this.pic_foodImg.Size = new System.Drawing.Size(156, 89);
            this.pic_foodImg.TabIndex = 1;
            this.pic_foodImg.TabStop = false;
            // 
            // che_isSelected
            // 
            this.che_isSelected.AutoSize = true;
            this.che_isSelected.Location = new System.Drawing.Point(16, 55);
            this.che_isSelected.Name = "che_isSelected";
            this.che_isSelected.Size = new System.Drawing.Size(15, 14);
            this.che_isSelected.TabIndex = 2;
            this.che_isSelected.UseVisualStyleBackColor = true;
            // 
            // nud_foodNumber
            // 
            this.nud_foodNumber.Location = new System.Drawing.Point(232, 48);
            this.nud_foodNumber.Name = "nud_foodNumber";
            this.nud_foodNumber.Size = new System.Drawing.Size(47, 21);
            this.nud_foodNumber.TabIndex = 3;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(113, 114);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(41, 12);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "label2";
            // 
            // FoodUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.nud_foodNumber);
            this.Controls.Add(this.che_isSelected);
            this.Controls.Add(this.pic_foodImg);
            this.Controls.Add(this.lbl_title);
            this.Name = "FoodUnit";
            this.Size = new System.Drawing.Size(280, 132);
            this.Load += new System.EventHandler(this.FoodUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_foodNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_foodImg;
        private System.Windows.Forms.CheckBox che_isSelected;
        private System.Windows.Forms.NumericUpDown nud_foodNumber;
        private System.Windows.Forms.Label lbl_price;
    }
}
