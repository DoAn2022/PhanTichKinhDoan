namespace PhanTichKinhDoan
{
    partial class DangNhapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tenCHField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkCHField = new System.Windows.Forms.TextBox();
            this.dangNhapBTN = new System.Windows.Forms.Button();
            this.dangKyBTN = new System.Windows.Forms.Button();
            this.quenMkLink = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mkShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cửa hàng";
            // 
            // tenCHField
            // 
            this.tenCHField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenCHField.Location = new System.Drawing.Point(148, 60);
            this.tenCHField.Name = "tenCHField";
            this.tenCHField.Size = new System.Drawing.Size(246, 26);
            this.tenCHField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // mkCHField
            // 
            this.mkCHField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCHField.Location = new System.Drawing.Point(148, 110);
            this.mkCHField.Name = "mkCHField";
            this.mkCHField.PasswordChar = '*';
            this.mkCHField.Size = new System.Drawing.Size(246, 26);
            this.mkCHField.TabIndex = 2;
            // 
            // dangNhapBTN
            // 
            this.dangNhapBTN.BackColor = System.Drawing.Color.Teal;
            this.dangNhapBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangNhapBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dangNhapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangNhapBTN.ForeColor = System.Drawing.Color.White;
            this.dangNhapBTN.Location = new System.Drawing.Point(114, 161);
            this.dangNhapBTN.Name = "dangNhapBTN";
            this.dangNhapBTN.Size = new System.Drawing.Size(89, 30);
            this.dangNhapBTN.TabIndex = 3;
            this.dangNhapBTN.Text = "ĐĂNG NHẬP";
            this.dangNhapBTN.UseVisualStyleBackColor = false;
            this.dangNhapBTN.Click += new System.EventHandler(this.dangNhapBTN_Click);
            // 
            // dangKyBTN
            // 
            this.dangKyBTN.BackColor = System.Drawing.Color.Teal;
            this.dangKyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangKyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dangKyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangKyBTN.ForeColor = System.Drawing.Color.White;
            this.dangKyBTN.Location = new System.Drawing.Point(249, 161);
            this.dangKyBTN.Name = "dangKyBTN";
            this.dangKyBTN.Size = new System.Drawing.Size(89, 30);
            this.dangKyBTN.TabIndex = 3;
            this.dangKyBTN.Text = "ĐĂNG KÝ";
            this.dangKyBTN.UseVisualStyleBackColor = false;
            this.dangKyBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // quenMkLink
            // 
            this.quenMkLink.ActiveLinkColor = System.Drawing.Color.Teal;
            this.quenMkLink.AutoSize = true;
            this.quenMkLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenMkLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quenMkLink.Location = new System.Drawing.Point(317, 207);
            this.quenMkLink.Name = "quenMkLink";
            this.quenMkLink.Size = new System.Drawing.Size(128, 16);
            this.quenMkLink.TabIndex = 4;
            this.quenMkLink.TabStop = true;
            this.quenMkLink.Text = "Bạn quên mật khẩu?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mkShow
            // 
            this.mkShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mkShow.Location = new System.Drawing.Point(400, 110);
            this.mkShow.Name = "mkShow";
            this.mkShow.Size = new System.Drawing.Size(37, 26);
            this.mkShow.TabIndex = 5;
            this.mkShow.UseVisualStyleBackColor = false;
            this.mkShow.Click += new System.EventHandler(this.mkShow_Click);
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(449, 227);
            this.Controls.Add(this.mkShow);
            this.Controls.Add(this.quenMkLink);
            this.Controls.Add(this.dangKyBTN);
            this.Controls.Add(this.dangNhapBTN);
            this.Controls.Add(this.mkCHField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenCHField);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập cửa hàng";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenCHField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mkCHField;
        private System.Windows.Forms.Button dangNhapBTN;
        private System.Windows.Forms.Button dangKyBTN;
        private System.Windows.Forms.LinkLabel quenMkLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button mkShow;
    }
}

