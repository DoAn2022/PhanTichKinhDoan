using PhanTichKinhDoan.Controller;
using PhanTichKinhDoan.Model;
using PhanTichKinhDoan.Tools;
using PhanTichKinhDoan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichKinhDoan
{
    public partial class DangNhapForm : Form
    {
        Check check = new Check();
        cuaHangController chCTL = new cuaHangController();
        CuaHang ch = new CuaHang();

        public DangNhapForm()
        {
            InitializeComponent();
            tenCHField.Text = "BigC";
            mkCHField.Text = "123456789";
        }

        //Ham check dang nhap
        public void checkDangNhap()
        {
            errorProvider1.SetError(tenCHField, null);
            errorProvider1.SetError(mkCHField, null);

            if (!string.IsNullOrEmpty(tenCHField.Text) && !string.IsNullOrEmpty(mkCHField.Text))
            {
                ch.TenCH = tenCHField.Text;
                ch.Password = mkCHField.Text;
                if (chCTL.TenCHTonTai(ch.TenCH))
                {
                    if (chCTL.CheckPass(ch.TenCH, ch.Password))
                    {
                        ch = chCTL.ThongTinCuaHang(ch);
                        TrangChu tc = new TrangChu(ch);
                        this.Hide();
                        tc.ShowDialog();
                        //End
                    }
                    else
                    {
                        errorProvider1.SetError(mkCHField, "Mật khẩu không chính xác!");
                        MessageBox.Show("Mật khẩu không chính xác!");
                    }
                }
                else
                {
                    errorProvider1.SetError(tenCHField, "Tên chưa đăng ký!");
                    MessageBox.Show("Tên cửa hàng này chưa được đăng ký!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKyForm dk1 = new DangKyForm();
            dk1.ShowDialog();
        }

        private void dangNhapBTN_Click(object sender, EventArgs e)
        {
            checkDangNhap();
        }

        int h = 0;
        private void mkShow_Click(object sender, EventArgs e)
        {
            if(h%2 == 0)
            {
                mkCHField.PasswordChar = '\0';
            }
            else
            {
                mkCHField.PasswordChar = '*';
            }
            h++;
        }
    }
}
