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
    internal class sanPhamController
    {
        DBconnect dBconnect = new DBconnect();
        MySqlDataReader dataReader;
        MySqlCommand cmd;

        //Hàm thêm san phẩm
        public void InsertCH(SanPham sp)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO `analysis`.`sanpham` (`idSp`, `idCh`, `tenSp`, `gia`, `Sl`, `SlDb`)" +
                        " VALUES (" +
                        ""+sp.IdSp+", "+sp.IdCh+", '"+sp.TenSp+"',"+sp.Gia+", "+sp.Sl+", "+sp.SlDb+");";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
        }


        //Hàm lấy thông tin sanPham
        public SanPham ThongTinSanPham(SanPham sp)
        {
            SanPham sanPham = new SanPham();
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`sanpham` where `idSp` = '" + sp.IdSp + "';";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        sanPham.IdSp = int.Parse(dataReader["idSp"].ToString());
                        sanPham.IdCh = int.Parse(dataReader["idCh"].ToString());
                        sanPham.TenSp = dataReader["tenSp"].ToString();
                        sanPham.Gia = int.Parse(dataReader["gia"].ToString());
                        sanPham.Sl = int.Parse(dataReader["Sl"].ToString());
                        sanPham.SlDb = int.Parse(dataReader["SlDb"].ToString());
                    }

                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }

            return sanPham;
        }
        //Hàm lấy thông tin sanPham
        public List<SanPham> AllSanPham(CuaHang ch)
        {
            List<SanPham> sanPhamList = new List<SanPham>();
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`sanpham` where `idCh` = "+ch.MaCH+";";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        SanPham sanPham = new SanPham();
                        sanPham.IdSp = int.Parse(dataReader["idSp"].ToString());
                        sanPham.IdCh = int.Parse(dataReader["idCh"].ToString());
                        sanPham.TenSp = dataReader["tenSp"].ToString();
                        sanPham.Gia = int.Parse(dataReader["gia"].ToString());
                        sanPham.Sl = int.Parse(dataReader["Sl"].ToString());
                        sanPham.SlDb = int.Parse(dataReader["SlDb"].ToString());
                        sanPhamList.Add(sanPham);
                    }

                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
            return sanPhamList;
        }

        //Hàm truyền danh sach sản phẩm lên listView
        public void ToListView(ListView splv, CuaHang ch)
        {
            List<SanPham>  spList = AllSanPham(ch);
            splv.Items.Clear();

            foreach(SanPham sp in spList)
            {
                ListViewItem lvItem = new ListViewItem(sp.IdSp.ToString());
                lvItem.SubItems.Add(sp.TenSp.ToString());
                lvItem.SubItems.Add(sp.Gia.ToString());
                lvItem.SubItems.Add(sp.Sl.ToString());
                lvItem.SubItems.Add(sp.SlDb.ToString());
                lvItem.SubItems.Add((sp.Sl-sp.SlDb).ToString());

                splv.Items.Add(lvItem);
            }
        }

        //Hàm update thông tin sản phẩm khi có hóa đơn mua
        public void UpdateSp()
        {

        }
    }
    
}
