using Org.BouncyCastle.Asn1.X500;
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
   internal partial class SuaSP : Form
    {
        sanPhamController spCTL = new sanPhamController();
        SanPham sanPham = new SanPham();
        public SuaSP(SanPham sp)
        {
            InitializeComponent();
            sp = spCTL.ThongTinSanPham(sp);
            sanPham = sp;
            tenSP_Box.Text = sp.TenSp;
            GiaSp_NuBox.Value = sp.Gia;
            soLuong_NuBox.Value = sp.Sl;
        }

        private void capNhapBTN_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tenSP_Box, null);
            errorProvider1.SetError(GiaSp_NuBox, null);
            if (!String.IsNullOrEmpty(tenSP_Box.Text))
            {
                if (GiaSp_NuBox.Value <= 0)
                {
                    errorProvider1.SetError(GiaSp_NuBox, "Thêm số lượng!");
                }
                else
                {
                    SanPham spMoi = sanPham;
                    spMoi.TenSp = tenSP_Box.Text;
                    spMoi.Gia = int.Parse(GiaSp_NuBox.Value.ToString());
                    spMoi.Sl = int.Parse(soLuong_NuBox.Value.ToString());

                    spCTL.UpdateSp(sanPham, spMoi);
                    MessageBox.Show("Sửa thành công!");
                }
            }
            else
            {
                errorProvider1.SetError(tenSP_Box, "Hãy điền tên sản phẩm!");
            }
        }
    }
}
