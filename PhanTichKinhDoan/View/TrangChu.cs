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
    internal partial class TrangChu : Form
    {
        //Khai báo thuộc tính
        sanPhamController spCTL = new sanPhamController();
        hoaDonController hdCTL = new hoaDonController();
        danhMucController dmCTL = new danhMucController();
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
            //Hết Tab Thông tin
            /*-------------------------------------------------------------------*/
            //Thêm dữ liệu tab NHẬP XUẤT
            hdCTL.ToListView(hd_ListView,ch);
        //Hết Tab Nhập xuất
        /*-------------------------------------------------------------------*/


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
    }
}
