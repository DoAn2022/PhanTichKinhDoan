namespace PhanTichKinhDoan.View
{
    partial class DoiMatKhauForm
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
            this.dangNhapBTN = new System.Windows.Forms.Button();
            this.mkCHField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdtCHField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dangNhapBTN
            // 
            this.dangNhapBTN.BackColor = System.Drawing.Color.Teal;
            this.dangNhapBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangNhapBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dangNhapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangNhapBTN.ForeColor = System.Drawing.Color.White;
            this.dangNhapBTN.Location = new System.Drawing.Point(143, 170);
            this.dangNhapBTN.Name = "dangNhapBTN";
            this.dangNhapBTN.Size = new System.Drawing.Size(108, 30);
            this.dangNhapBTN.TabIndex = 8;
            this.dangNhapBTN.Text = "ĐỔI MẬT KHẨU";
            this.dangNhapBTN.UseVisualStyleBackColor = false;
            this.dangNhapBTN.Click += new System.EventHandler(this.dangNhapBTN_Click);
            // 
            // mkCHField
            // 
            this.mkCHField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCHField.Location = new System.Drawing.Point(133, 116);
            this.mkCHField.Name = "mkCHField";
            this.mkCHField.PasswordChar = '*';
            this.mkCHField.Size = new System.Drawing.Size(207, 26);
            this.mkCHField.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // sdtCHField
            // 
            this.sdtCHField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtCHField.Location = new System.Drawing.Point(133, 60);
            this.sdtCHField.Name = "sdtCHField";
            this.sdtCHField.Size = new System.Drawing.Size(207, 26);
            this.sdtCHField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số điện thoại";
            // 
            // DoiMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(385, 232);
            this.Controls.Add(this.dangNhapBTN);
            this.Controls.Add(this.mkCHField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdtCHField);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhauForm";
            this.Text = "DoiMatKhauForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dangNhapBTN;
        private System.Windows.Forms.TextBox mkCHField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sdtCHField;
        private System.Windows.Forms.Label label1;
    }
}