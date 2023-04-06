namespace PhanTichKinhDoan.View
{
    partial class SuaSP
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
            this.tenSP_Box = new System.Windows.Forms.TextBox();
            this.soLuong_NuBox = new System.Windows.Forms.NumericUpDown();
            this.GiaSp_NuBox = new System.Windows.Forms.NumericUpDown();
            this.capNhapBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maThueLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_NuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaSp_NuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenSP_Box
            // 
            this.tenSP_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSP_Box.Location = new System.Drawing.Point(207, 32);
            this.tenSP_Box.Name = "tenSP_Box";
            this.tenSP_Box.Size = new System.Drawing.Size(241, 26);
            this.tenSP_Box.TabIndex = 23;
            // 
            // soLuong_NuBox
            // 
            this.soLuong_NuBox.Location = new System.Drawing.Point(207, 141);
            this.soLuong_NuBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.soLuong_NuBox.Name = "soLuong_NuBox";
            this.soLuong_NuBox.Size = new System.Drawing.Size(241, 20);
            this.soLuong_NuBox.TabIndex = 21;
            // 
            // GiaSp_NuBox
            // 
            this.GiaSp_NuBox.Location = new System.Drawing.Point(207, 91);
            this.GiaSp_NuBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.GiaSp_NuBox.Name = "GiaSp_NuBox";
            this.GiaSp_NuBox.Size = new System.Drawing.Size(241, 20);
            this.GiaSp_NuBox.TabIndex = 22;
            // 
            // capNhapBTN
            // 
            this.capNhapBTN.BackColor = System.Drawing.Color.Teal;
            this.capNhapBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capNhapBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.capNhapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhapBTN.ForeColor = System.Drawing.Color.White;
            this.capNhapBTN.Location = new System.Drawing.Point(233, 198);
            this.capNhapBTN.Name = "capNhapBTN";
            this.capNhapBTN.Size = new System.Drawing.Size(89, 30);
            this.capNhapBTN.TabIndex = 20;
            this.capNhapBTN.Text = "CẬP NHẬP";
            this.capNhapBTN.UseVisualStyleBackColor = false;
            this.capNhapBTN.Click += new System.EventHandler(this.capNhapBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(109, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(103, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá (VNĐ)";
            // 
            // maThueLabel
            // 
            this.maThueLabel.AutoSize = true;
            this.maThueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maThueLabel.Location = new System.Drawing.Point(74, 42);
            this.maThueLabel.Name = "maThueLabel";
            this.maThueLabel.Size = new System.Drawing.Size(105, 16);
            this.maThueLabel.TabIndex = 19;
            this.maThueLabel.Text = "Tên sản phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SuaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 260);
            this.Controls.Add(this.tenSP_Box);
            this.Controls.Add(this.soLuong_NuBox);
            this.Controls.Add(this.GiaSp_NuBox);
            this.Controls.Add(this.capNhapBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maThueLabel);
            this.Name = "SuaSP";
            this.Text = "SuaSP";
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_NuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaSp_NuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenSP_Box;
        private System.Windows.Forms.NumericUpDown soLuong_NuBox;
        private System.Windows.Forms.NumericUpDown GiaSp_NuBox;
        private System.Windows.Forms.Button capNhapBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maThueLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}