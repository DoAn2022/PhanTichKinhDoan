using MySql.Data.MySqlClient;
using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        //Hàm xóa sản phẩm
        public void DeleteSp(int idSp)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "DELETE FROM `analysis`.`sanpham` WHERE (`idSp` = "+idSp+");";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());

                    cmd.ExecuteNonQuery();
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
        public void UpdateSp(SanPham spCu, SanPham spMoi)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "UPDATE `analysis`.`sanpham` " +
                        "SET `tenSp` = '"+spMoi.TenSp+"', `gia` = "+spMoi.Gia+", `Sl` = "+spMoi.Sl+", `SlDb` = "+spMoi.SlDb+" " +
                        "WHERE (`idSp` = "+spCu.IdSp+");";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());

                    cmd.ExecuteNonQuery();
                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
        }

        //Truyền sản phẩm lên chart
        public void ToChart(Chart chart, CuaHang ch)
        {
            chart.Series["SLDB"].Points.Clear();
            chart.Series["SUM"].Points.Clear();

            List <SanPham> spList = AllSanPham(ch);

            int i = 0;
            foreach (SanPham sp in spList)
            {
                chart.Series["SLDB"].Points.AddXY(sp.TenSp, sp.SlDb);
                chart.Series["SLDB"].Points[i].Label = sp.SlDb.ToString();

                chart.Series["SUM"].Points.AddXY(sp.TenSp, sp.Sl);
                chart.Series["SUM"].Points[i].Label = sp.Sl.ToString();
                i++;
            }
        }

        public void ToPieChart(Chart chart, CuaHang ch)
        {
            chart.Series["SP"].Points.Clear();
            List<SanPham> spList = AllSanPham(ch);

            int tong = 0;

            foreach (SanPham sp in spList)
            {
                tong += sp.SlDb * sp.Gia;
            }
            int i = 0;
            foreach (SanPham sp in spList)
            {
                double dt = sp.SlDb * sp.Gia;
                double per = Math.Round(dt);
                chart.Series["SP"].Points.AddXY(sp.TenSp, per);
                chart.Series["SP"].Points[i].Label = sp.TenSp + " " + Math.Round((dt / tong) * 100) + "%";
                i++;
            }
        }
    }
    
}
