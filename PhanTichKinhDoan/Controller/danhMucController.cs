using MySql.Data.MySqlClient;
using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppConnectDB;

namespace PhanTichKinhDoan.Controller
{
    internal class danhMucController
    {
        DBconnect dBconnect = new DBconnect();
        MySqlDataReader dataReader;
        MySqlCommand cmd;
        sanPhamController spCTL = new sanPhamController();

        //Hàm thêm danh muc
        public void InsertDM(DanhMuc dm)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO `analysis`.`danhmuc` (`idHd`, `idSp`, `Sl`) " +
                        "VALUES ("+dm.IdHd+", "+dm.IdSp+", "+dm.SL+");";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());

                    cmd.ExecuteNonQuery();

                    //Update số lượng đã bán của sản phẩm

                    SanPham spCu = new SanPham();
                    spCu.IdSp = dm.IdSp;
                    SanPham spMoi = spCTL.ThongTinSanPham(spCu);
                    spMoi.SlDb += dm.SL;
                    spCTL.UpdateSp(spCu,spMoi);

                    MessageBox.Show("Thêm thành công!");
                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
        }
        //Hàm lấy thông tin Danh muc
        public List<DanhMuc> AllDanhMuc(HoaDon hd)
        {
            List<DanhMuc> danhMucList = new List<DanhMuc>();
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`danhmuc` where `idHd` = " + hd.IdHd + ";";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DanhMuc danhMuc = new DanhMuc();
                        danhMuc.IdHd = int.Parse(dataReader["idHd"].ToString());
                        danhMuc.IdSp = int.Parse(dataReader["idSp"].ToString());
                        danhMuc.SL = int.Parse(dataReader["Sl"].ToString());

                        danhMucList.Add(danhMuc);
                    }

                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
            return danhMucList;
        }
        //Hàm truyền danh sach hoadon lên listView
        public void ToListView(ListView splv, HoaDon hd)
        {
            List<DanhMuc> dmList = AllDanhMuc(hd);
            splv.Items.Clear();

            foreach (DanhMuc dm in dmList)
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
    }
}
