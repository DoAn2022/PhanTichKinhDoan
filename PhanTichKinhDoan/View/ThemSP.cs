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
    internal partial class ThemSP : Form
    {
        sanPhamController spCTL = new sanPhamController();
        SanPham sp = new SanPham();
        Random rnd = new Random();
        CuaHang ch = new CuaHang();
        public ThemSP(CuaHang cuaHang)
        {
            InitializeComponent();
            ch = cuaHang;
        }

        private void dangNhapBTN_Click(object sender, EventArgs e)
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
                    sp.IdSp = rnd.Next(10000000);
                    sp.IdCh = ch.MaCH;
                    sp.TenSp = tenSP_Box.Text.ToString();
                    sp.Gia = int.Parse(GiaSp_NuBox.Value.ToString());
                    sp.Sl = int.Parse(soLuong_NuBox.Value.ToString());
                    sp.SlDb = 0;

                    spCTL.InsertCH(sp);

                    tenSP_Box.Clear();
                    GiaSp_NuBox.Value = 0;
                    soLuong_NuBox.Value = 0;
                }
            }
            else
            {
                errorProvider1.SetError(tenSP_Box, "Hãy điền tên sản phẩm!");
            }
        }
    }
}
