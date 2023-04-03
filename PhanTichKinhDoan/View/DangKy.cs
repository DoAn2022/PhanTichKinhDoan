using PhanTichKinhDoan.Controller;
using PhanTichKinhDoan.Model;
using PhanTichKinhDoan.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppConnectDB;

namespace PhanTichKinhDoan
{
    public partial class DangKyForm : Form
    {
        Check check = new Check();
        cuaHangController chCTL = new cuaHangController();
        CuaHang ch = new CuaHang();
        

        public DangKyForm()
        {
            InitializeComponent();
            bonus();
        }
        //Ham thiết kế bổ sung
        public void bonus()
        {
        }

        //Hàm xự kiện
        //Thêm mới 1 cửa hàng
        public void ThemCH()
        {
            errorProvider2.SetError(tenCHFiledDK, null);
            errorProvider2.SetError(mkCHFieldDK, null);

            if (!string.IsNullOrEmpty(tenCHFiledDK.Text) && !string.IsNullOrEmpty(mkCHFieldDK.Text))
            {
                if (!chCTL.TenCHTonTai(tenCHFiledDK.Text))
                {
                    if (check.Lenght(mkCHFieldDK,8))
                    {
                        ch.TenCH = tenCHFiledDK.Text;
                        ch.Password = mkCHFieldDK.Text;
                        MemoryStream ms  = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        ch.HinhAnh = ms.ToArray();

                        chCTL.InsertCH(ch);
                    }
                    else
                    {
                        errorProvider2.SetError(mkCHFieldDK, "Mật khẩu không hợp lệ!");
                        MessageBox.Show("Mật khẩu phải lớn hơn 8 ký tự!");
                    }
                }
                else
                {
                    errorProvider2.SetError(tenCHFiledDK, "Tên đã tồn tại!");
                    MessageBox.Show("Tên cửa hàng này đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dangKyBTN2_Click(object sender, EventArgs e)
        {
            ThemCH();
        }
        int h = 0;
        private void mkShow_Click(object sender, EventArgs e)
        {
            if (h % 2 == 0)
            {
                mkCHFieldDK.PasswordChar = '\0';
            }
            else
            {
                mkCHFieldDK.PasswordChar = '*';
            }
            h++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf =    new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png; *gif)|*.jpg; *png; *gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
