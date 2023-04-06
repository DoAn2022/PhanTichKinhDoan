namespace PhanTichKinhDoan.View
{
    partial class ThemHD_Form
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
            this.soLuong_NuBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.themSp_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gia_Label = new System.Windows.Forms.Label();
            this.TongSl_Label = new System.Windows.Forms.Label();
            this.SlKd_Label = new System.Windows.Forms.Label();
            this.sp_ComboBox = new System.Windows.Forms.ComboBox();
            this.maThueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dm_ListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chotDon_BTN = new System.Windows.Forms.Button();
            this.refresh_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_NuBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.soLuong_NuBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.themSp_BTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sp_ComboBox);
            this.panel1.Controls.Add(this.maThueLabel);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 205);
            this.panel1.TabIndex = 0;
            // 
            // soLuong_NuBox
            // 
            this.soLuong_NuBox.Location = new System.Drawing.Point(103, 100);
            this.soLuong_NuBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.soLuong_NuBox.Name = "soLuong_NuBox";
            this.soLuong_NuBox.Size = new System.Drawing.Size(186, 20);
            this.soLuong_NuBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng";
            // 
            // themSp_BTN
            // 
            this.themSp_BTN.BackColor = System.Drawing.Color.Teal;
            this.themSp_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themSp_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.themSp_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themSp_BTN.ForeColor = System.Drawing.Color.White;
            this.themSp_BTN.Location = new System.Drawing.Point(116, 157);
            this.themSp_BTN.Name = "themSp_BTN";
            this.themSp_BTN.Size = new System.Drawing.Size(89, 30);
            this.themSp_BTN.TabIndex = 5;
            this.themSp_BTN.Text = "THÊM";
            this.themSp_BTN.UseVisualStyleBackColor = false;
            this.themSp_BTN.Click += new System.EventHandler(this.themSp_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Gia_Label);
            this.panel2.Controls.Add(this.TongSl_Label);
            this.panel2.Controls.Add(this.SlKd_Label);
            this.panel2.Location = new System.Drawing.Point(316, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 183);
            this.panel2.TabIndex = 1;
            // 
            // Gia_Label
            // 
            this.Gia_Label.AutoSize = true;
            this.Gia_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gia_Label.Location = new System.Drawing.Point(14, 85);
            this.Gia_Label.Name = "Gia_Label";
            this.Gia_Label.Size = new System.Drawing.Size(39, 16);
            this.Gia_Label.TabIndex = 2;
            this.Gia_Label.Text = "Giá: ";
            // 
            // TongSl_Label
            // 
            this.TongSl_Label.AutoSize = true;
            this.TongSl_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongSl_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TongSl_Label.Location = new System.Drawing.Point(14, 30);
            this.TongSl_Label.Name = "TongSl_Label";
            this.TongSl_Label.Size = new System.Drawing.Size(114, 16);
            this.TongSl_Label.TabIndex = 2;
            this.TongSl_Label.Text = "Tổng số lượng: ";
            // 
            // SlKd_Label
            // 
            this.SlKd_Label.AutoSize = true;
            this.SlKd_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlKd_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SlKd_Label.Location = new System.Drawing.Point(14, 138);
            this.SlKd_Label.Name = "SlKd_Label";
            this.SlKd_Label.Size = new System.Drawing.Size(139, 16);
            this.SlKd_Label.TabIndex = 2;
            this.SlKd_Label.Text = "Số lượng khả dụng:";
            // 
            // sp_ComboBox
            // 
            this.sp_ComboBox.FormattingEnabled = true;
            this.sp_ComboBox.Location = new System.Drawing.Point(103, 44);
            this.sp_ComboBox.Name = "sp_ComboBox";
            this.sp_ComboBox.Size = new System.Drawing.Size(186, 21);
            this.sp_ComboBox.TabIndex = 0;
            this.sp_ComboBox.SelectedIndexChanged += new System.EventHandler(this.sp_ComboBox_SelectedIndexChanged);
            // 
            // maThueLabel
            // 
            this.maThueLabel.AutoSize = true;
            this.maThueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maThueLabel.Location = new System.Drawing.Point(14, 47);
            this.maThueLabel.Name = "maThueLabel";
            this.maThueLabel.Size = new System.Drawing.Size(76, 16);
            this.maThueLabel.TabIndex = 2;
            this.maThueLabel.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // dm_ListView
            // 
            this.dm_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader11});
            this.dm_ListView.HideSelection = false;
            this.dm_ListView.Location = new System.Drawing.Point(12, 240);
            this.dm_ListView.Name = "dm_ListView";
            this.dm_ListView.Size = new System.Drawing.Size(617, 158);
            this.dm_ListView.TabIndex = 5;
            this.dm_ListView.UseCompatibleStateImageBehavior = false;
            this.dm_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sản phẩm";
            this.columnHeader3.Width = 315;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 138;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giá bán (VNĐ)";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 158;
            // 
            // chotDon_BTN
            // 
            this.chotDon_BTN.BackColor = System.Drawing.Color.Teal;
            this.chotDon_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chotDon_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chotDon_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chotDon_BTN.ForeColor = System.Drawing.Color.White;
            this.chotDon_BTN.Location = new System.Drawing.Point(213, 404);
            this.chotDon_BTN.Name = "chotDon_BTN";
            this.chotDon_BTN.Size = new System.Drawing.Size(89, 30);
            this.chotDon_BTN.TabIndex = 5;
            this.chotDon_BTN.Text = "TẠO ĐƠN";
            this.chotDon_BTN.UseVisualStyleBackColor = false;
            this.chotDon_BTN.Click += new System.EventHandler(this.chotDon_BTN_Click);
            // 
            // refresh_BTN
            // 
            this.refresh_BTN.BackColor = System.Drawing.Color.Teal;
            this.refresh_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_BTN.ForeColor = System.Drawing.Color.White;
            this.refresh_BTN.Location = new System.Drawing.Point(329, 404);
            this.refresh_BTN.Name = "refresh_BTN";
            this.refresh_BTN.Size = new System.Drawing.Size(89, 30);
            this.refresh_BTN.TabIndex = 5;
            this.refresh_BTN.Text = "REFRESH";
            this.refresh_BTN.UseVisualStyleBackColor = false;
            this.refresh_BTN.Click += new System.EventHandler(this.refresh_BTN_Click);
            // 
            // ThemHD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 442);
            this.Controls.Add(this.dm_ListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_BTN);
            this.Controls.Add(this.chotDon_BTN);
            this.Controls.Add(this.panel1);
            this.Name = "ThemHD_Form";
            this.Text = "Thêm hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_NuBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sp_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Gia_Label;
        private System.Windows.Forms.Label SlKd_Label;
        private System.Windows.Forms.Label maThueLabel;
        private System.Windows.Forms.Button themSp_BTN;
        private System.Windows.Forms.NumericUpDown soLuong_NuBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TongSl_Label;
        private System.Windows.Forms.ListView dm_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button chotDon_BTN;
        private System.Windows.Forms.Button refresh_BTN;
    }
}