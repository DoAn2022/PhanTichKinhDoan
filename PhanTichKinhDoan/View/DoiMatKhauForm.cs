using PhanTichKinhDoan.Controller;
using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichKinhDoan.View
{
    public partial class DoiMatKhauForm : Form
    {
        cuaHangController chCTL = new cuaHangController();
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }

        public void DoiMatKhau()
        {
            String sdt = sdtCHField.Text;
            String mkMoi = mkCHField.Text;
            if(String.IsNullOrEmpty(sdt)||String.IsNullOrEmpty(mkMoi))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
            }
            else
            {
                chCTL.RePass(sdt, mkMoi);
                MessageBox.Show("Cập nhập thành công!");
            }
        }
        private void dangNhapBTN_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }
    }
}
