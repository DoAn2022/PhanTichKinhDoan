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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 37);
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
            this.tenCHFiledDK.Location = new System.Drawing.Point(123, 193);
            this.tenCHFiledDK.Name = "tenCHFiledDK";
            this.tenCHFiledDK.Size = new System.Drawing.Size(210, 26);
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
            this.mkCHFieldDK.Size = new System.Drawing.Size(210, 26);
            this.mkCHFieldDK.TabIndex = 2;
            // 
            // dangKyBTN2
            // 
            this.dangKyBTN2.BackColor = System.Drawing.Color.Teal;
            this.dangKyBTN2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangKyBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dangKyBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangKyBTN2.ForeColor = System.Drawing.Color.White;
            this.dangKyBTN2.Location = new System.Drawing.Point(151, 330);
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
            this.label1.Location = new System.Drawing.Point(11, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 260);
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
            this.mkShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mkShow.Location = new System.Drawing.Point(340, 253);
            this.mkShow.Name = "mkShow";
            this.mkShow.Size = new System.Drawing.Size(30, 27);
            this.mkShow.TabIndex = 6;
            this.mkShow.UseVisualStyleBackColor = false;
            this.mkShow.Click += new System.EventHandler(this.mkShow_Click);
            // 
            // DangKyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(381, 386);
            this.Controls.Add(this.mkShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dangKyBTN2);
            this.Controls.Add(this.mkCHFieldDK);
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
    }
}