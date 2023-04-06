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
using System.Windows.Forms.DataVisualization.Charting;

namespace PhanTichKinhDoan.View
{
    internal partial class TrangChu : Form
    {
        //Khai báo thuộc tính
        Random rnd = new Random();
        sanPhamController spCTL = new sanPhamController();
        hoaDonController hdCTL = new hoaDonController();
        danhMucController dmCTL = new danhMucController();
        PhanTich pt;
        CuaHang cuaHang = new CuaHang();

        //Khởi tạo
        public TrangChu(CuaHang ch)
        {
            InitializeComponent();
            bonus(ch);
        }
        public void bonus(CuaHang ch)
        {
            cuaHang = ch;
        //Thêm dữ liệu tab THÔNG TIN
            tenCH_TC.Text = ch.TenCH.ToString();
            maThueLabel.Text = "Mã số thuế: " + ch.MaThue.ToString();
            chuShLabel.Text = "Chủ sở hữu: " + ch.ChuSh.ToString();
            sdtLabel.Text = "SĐT: " + ch.Sdt.ToString();
            diaChiLabel.Text = "Địa chỉ: " + ch.DiaChi.ToString();
            if(ch.HinhAnh!=null)
            {
                ImageConverter imgConverter = new ImageConverter();
                hinhCh.Image = (Image)imgConverter.ConvertFrom(ch.HinhAnh);
            }

            //Truyền dữ liệu vào ListView
            spCTL.ToListView(homeSp_ListView,ch);
            /*-------------------------------------------------------------------*/

            //Thêm dữ liệu tab NHẬP XUẤT
            hdCTL.ToListView(hd_ListView,ch);
            /*-------------------------------------------------------------------*/

            //Thêm dữ liệu tab Biểu đồ
            spCTL.ToChart(SlDb_Chart, ch);
            spCTL.ToPieChart(CoCau_pieChart, ch);

            /*-------------------------------------------------------------------*/
            //Thêm dữ liệu tab phân tich
            pt = new PhanTich(cuaHang);
            PhanTichTC();
        }

        //Ham phan tich
        public void PhanTichTC()
        {
            SanPham sp = pt.Max_SLBD();
            BCN_Label.Text = "  Bán chạy nhất: '" + sp.TenSp + "' đã bán '" + sp.SlDb + "' sản phẩm.";
            sp = pt.Min_SLBD();
            BIN_Label.Text = "  Bán ít nhất: '"+ sp.TenSp+"' chỉ bán được '"+ sp.SlDb + "' sản phẩm.";
            sp = pt.Max_Du();
            CNN_Label.Text = "Còn nhiều nhất:  '" + sp.TenSp + "' còn dư '" + (sp.Sl-sp.SlDb) + "' sản phẩm.";
            sp = pt.Min_Du();
            CIN_Label.Text = "Còn ít nhất:  '" + sp.TenSp + "' còn dư '" + (sp.Sl - sp.SlDb) + "' sản phẩm.";
            sp = pt.Max_DT();
            DTCN_Label.Text = "Sản phẩm cho doanh thu cao nhất:  '" + sp.TenSp + "' thu được " + (sp.SlDb * sp.Gia) + " VNĐ.";
            sp = pt.Min_DT();
            DTTN_Label.Text = "Sản phẩm cho doanh thu thấp nhất:  '" + sp.TenSp + "' thu được " + (sp.SlDb * sp.Gia) + " VNĐ.";
            TDT_Label.Text = "Tổng doanh thu:  " + pt.TongDT() + " VNĐ.";
        }

        //Hàm chạy dòng chữ 
        private void timer1_Tick(object sender, EventArgs e)
        {
            String chuoi = chaoMungText.Text;
            chuoi = chuoi.Substring(1,chuoi.Length - 1) + chuoi.Substring(0,1);
            chaoMungText.Text = chuoi;
        }

        
        private void hd_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            HoaDon hd = new HoaDon();
            try
            {
                hd.IdHd = int.Parse(hd_ListView.SelectedItems[0].Text);
                dmCTL.ToListView(dm_ListView, hd);
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void themSp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemSP themSp_Form = new ThemSP(cuaHang);
            themSp_Form.ShowDialog();
        }

        private void xoaSP_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<int> mangId = new List<int>();
            mangId = homeSp_ListView.CheckedIndices.Cast<int>().Select(i=>i).ToList();
            

            foreach(int idSp in mangId)
            {
                spCTL.DeleteSp(int.Parse(homeSp_ListView.Items[idSp].Text));
            }
            spCTL.ToListView(homeSp_ListView, cuaHang);
            MessageBox.Show("Đã xóa xong!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            spCTL.ToListView(homeSp_ListView, cuaHang);
        }

        private void suaSp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SanPham sp = new SanPham();
            if (homeSp_ListView.CheckedItems.Count != 1)
                MessageBox.Show("Chỉ sửa được 1 sản phẩm!");
            else
            {
                sp.IdSp = int.Parse(homeSp_ListView.CheckedItems[0].Text);
                SuaSP suaForm = new SuaSP(sp);
                suaForm.ShowDialog();
            }

        }

        private void themHD_BTN_Click(object sender, EventArgs e)
        {
          
            ThemHD_Form themHD_Form = new ThemHD_Form(cuaHang);
            themHD_Form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hdCTL.ToListView(hd_ListView, cuaHang);
        }

        private void SlDb_Chart_Click(object sender, EventArgs e)
        {
            spCTL.ToChart(SlDb_Chart, cuaHang);
            spCTL.ToPieChart(CoCau_pieChart, cuaHang);
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            pt = new PhanTich(cuaHang);
            PhanTichTC();
        }
    }
}
