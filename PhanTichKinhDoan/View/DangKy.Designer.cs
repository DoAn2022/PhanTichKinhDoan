namespace PhanTichKinhDoan
{
    partial class DangKyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tenCHFiledDK = new System.Windows.Forms.TextBox();
            this.mkCHFieldDK = new System.Windows.Forms.TextBox();
            this.dangKyBTN2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mkShow = new System.Windows.Forms.Button();
            this.diaChiBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maThueBox = new System.Windows.Forms.Label();
            this.sdtBox = new System.Windows.Forms.Label();
            this.sdtNuBox = new System.Windows.Forms.NumericUpDown();
            this.maThueNuBox = new System.Windows.Forms.NumericUpDown();
            this.chuShBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtNuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maThueNuBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tenCHFiledDK
            // 
            this.tenCHFiledDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenCHFiledDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenCHFiledDK.Location = new System.Drawing.Point(315, 21);
            this.tenCHFiledDK.Name = "tenCHFiledDK";
            this.tenCHFiledDK.Size = new System.Drawing.Size(349, 26);
            this.tenCHFiledDK.TabIndex = 2;
            // 
            // mkCHFieldDK
            // 
            this.mkCHFieldDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mkCHFieldDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCHFieldDK.Location = new System.Drawing.Point(123, 254);
            this.mkCHFieldDK.Name = "mkCHFieldDK";
            this.mkCHFieldDK.PasswordChar = '*';
            this.mkCHFieldDK.Size = new System.Drawing.Size(343, 26);
            this.mkCHFieldDK.TabIndex = 2;
            // 
            // dangKyBTN2
            // 
            this.dangKyBTN2.BackColor = System.Drawing.Color.Teal;
            this.dangKyBTN2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangKyBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dangKyBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangKyBTN2.ForeColor = System.Drawing.Color.White;
            this.dangKyBTN2.Location = new System.Drawing.Point(315, 322);
            this.dangKyBTN2.Name = "dangKyBTN2";
            this.dangKyBTN2.Size = new System.Drawing.Size(80, 30);
            this.dangKyBTN2.TabIndex = 4;
            this.dangKyBTN2.Text = "ĐĂNG KÝ";
            this.dangKyBTN2.UseVisualStyleBackColor = false;
            this.dangKyBTN2.Click += new System.EventHandler(this.dangKyBTN2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // mkShow
            // 
            this.mkShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mkShow.ForeColor = System.Drawing.Color.White;
            this.mkShow.Location = new System.Drawing.Point(472, 253);
            this.mkShow.Name = "mkShow";
            this.mkShow.Size = new System.Drawing.Size(192, 27);
            this.mkShow.TabIndex = 6;
            this.mkShow.Text = "Ẩn/Hiện mật khẩu";
            this.mkShow.UseVisualStyleBackColor = false;
            this.mkShow.Click += new System.EventHandler(this.mkShow_Click);
            // 
            // diaChiBox
            // 
            this.diaChiBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diaChiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiBox.Location = new System.Drawing.Point(315, 98);
            this.diaChiBox.Name = "diaChiBox";
            this.diaChiBox.Size = new System.Drawing.Size(349, 26);
            this.diaChiBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // maThueBox
            // 
            this.maThueBox.AutoSize = true;
            this.maThueBox.ForeColor = System.Drawing.Color.White;
            this.maThueBox.Location = new System.Drawing.Point(370, 188);
            this.maThueBox.Name = "maThueBox";
            this.maThueBox.Size = new System.Drawing.Size(88, 20);
            this.maThueBox.TabIndex = 5;
            this.maThueBox.Text = "Mã số thuế";
            // 
            // sdtBox
            // 
            this.sdtBox.AutoSize = true;
            this.sdtBox.ForeColor = System.Drawing.Color.White;
            this.sdtBox.Location = new System.Drawing.Point(69, 188);
            this.sdtBox.Name = "sdtBox";
            this.sdtBox.Size = new System.Drawing.Size(41, 20);
            this.sdtBox.TabIndex = 5;
            this.sdtBox.Text = "SĐT";
            // 
            // sdtNuBox
            // 
            this.sdtNuBox.Location = new System.Drawing.Point(123, 181);
            this.sdtNuBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sdtNuBox.Name = "sdtNuBox";
            this.sdtNuBox.Size = new System.Drawing.Size(193, 26);
            this.sdtNuBox.TabIndex = 7;
            // 
            // maThueNuBox
            // 
            this.maThueNuBox.Location = new System.Drawing.Point(472, 181);
            this.maThueNuBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maThueNuBox.Name = "maThueNuBox";
            this.maThueNuBox.Size = new System.Drawing.Size(169, 26);
            this.maThueNuBox.TabIndex = 7;
            // 
            // chuShBox
            // 
            this.chuShBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chuShBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuShBox.Location = new System.Drawing.Point(315, 61);
            this.chuShBox.Name = "chuShBox";
            this.chuShBox.Size = new System.Drawing.Size(349, 26);
            this.chuShBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(203, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chủ sở hữu";
            // 
            // DangKyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 412);
            this.Controls.Add(this.maThueNuBox);
            this.Controls.Add(this.sdtNuBox);
            this.Controls.Add(this.mkShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdtBox);
            this.Controls.Add(this.maThueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dangKyBTN2);
            this.Controls.Add(this.mkCHFieldDK);
            this.Controls.Add(this.chuShBox);
            this.Controls.Add(this.diaChiBox);
            this.Controls.Add(this.tenCHFiledDK);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DangKyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký mới";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtNuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maThueNuBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tenCHFiledDK;
        private System.Windows.Forms.TextBox mkCHFieldDK;
        private System.Windows.Forms.Button dangKyBTN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button mkShow;
        private System.Windows.Forms.NumericUpDown sdtNuBox;
        private System.Windows.Forms.Label sdtBox;
        private System.Windows.Forms.Label maThueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diaChiBox;
        private System.Windows.Forms.NumericUpDown maThueNuBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chuShBox;
    }
}