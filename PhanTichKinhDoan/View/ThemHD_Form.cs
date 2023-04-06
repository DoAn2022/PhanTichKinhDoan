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
    internal partial class ThemHD_Form : Form
    {
        hoaDonController hdCTL = new hoaDonController();
        sanPhamController spCTL = new sanPhamController();
        danhMucController dmCTL = new danhMucController();

        HoaDon hoaDon = new HoaDon();
        CuaHang cuaHang = new CuaHang();
        SanPham sp_DuocChon = new SanPham();

        List<String> tenSp_list = new List<String>();
        List<SanPham> sp_list = new List<SanPham>();
        List<DanhMuc> danhMuc_list = new List<DanhMuc>();

        int slkd = 0;
        Random rnd = new Random();

        public ThemHD_Form(CuaHang ch)
        {
            InitializeComponent();
            cuaHang = ch;
            TaoHoaDonMoi(cuaHang);
            LoadDataComboBox();
            
        }
        //Hàm tạo hóa dơn
        public void TaoHoaDonMoi(CuaHang cuaHang)
        {
            hoaDon.IdHd = rnd.Next(10000000);
            hoaDon.IdCh = cuaHang.MaCH;
            hoaDon.NgayTao = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }
        //Hàm tải dữ liệu cho comboBox
        public void LoadDataComboBox()
        {
            sp_list = spCTL.AllSanPham(cuaHang);

            //Thêm phần tử cho tenSp_list
            foreach (SanPham sp in sp_list)
            {
                tenSp_list.Add(sp.TenSp);
            }

            //Load dữ liệu cho comboBox
            sp_ComboBox.DataSource = tenSp_list;
            ThongTinSPDuocChon();
        }
        //Hàm lấy thông tin sản phẩm dựa vào comboBox
        public void ThongTinSPDuocChon()
        {
            int sp_index = sp_ComboBox.SelectedIndex;
            TongSl_Label.Text = "Tổng số lượng: " + sp_list[sp_index].Sl;
            Gia_Label.Text = "Giá: "+ sp_list[sp_index].Gia;
            slkd = (sp_list[sp_index].Sl - sp_list[sp_index].SlDb);
            SlKd_Label.Text = "Số lượng khả dụng: " + slkd;
            sp_DuocChon = sp_list[sp_index];
        }

        //Hàm clear thông tin đơn
        public void ClearDon()
        {
            dm_ListView.Items.Clear();
            tenSp_list.Clear();
            sp_list.Clear();
            danhMuc_list.Clear();

        }
        private void chotDon_BTN_Click(object sender, EventArgs e)
        {
            hdCTL.InsertHD(hoaDon);
            foreach(DanhMuc danhMuc in danhMuc_list)
            {
                dmCTL.InsertDM(danhMuc);
            }

            MessageBox.Show("Đã tạo xong!");

            ClearDon();
            
            TaoHoaDonMoi(cuaHang);
            LoadDataComboBox();
        }


        private void sp_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongTinSPDuocChon();
        }

        private void themSp_BTN_Click(object sender, EventArgs e)
        {
            if (soLuong_NuBox.Value > 0 && soLuong_NuBox.Value<=slkd)
            {
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.IdSp = sp_DuocChon.IdSp;
                danhMuc.IdHd = hoaDon.IdHd;
                danhMuc.SL = int.Parse(soLuong_NuBox.Value.ToString());

                danhMuc_list.Add(danhMuc);
                dm_ListToListView(dm_ListView);
                LoadDataComboBox();
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lý!");
            }
        }
         
        //Hàm truyền danh sach danh muc lên listView
        public void dm_ListToListView(ListView splv)
        {
            splv.Items.Clear();

            foreach (DanhMuc dm in danhMuc_list)
            {
                //lấy tên sản phẩm
                SanPham sp = new SanPham();
                sp.IdSp = dm.IdSp;
                sp = spCTL.ThongTinSanPham(sp);
                ListViewItem lvItem = new ListViewItem(sp.TenSp.ToString());

                lvItem.SubItems.Add(dm.SL.ToString());
                lvItem.SubItems.Add(sp.Gia.ToString());

                splv.Items.Add(lvItem);
            }
        }

        private void refresh_BTN_Click(object sender, EventArgs e)
        {
            ClearDon();
            LoadDataComboBox();
        }
    }
}
