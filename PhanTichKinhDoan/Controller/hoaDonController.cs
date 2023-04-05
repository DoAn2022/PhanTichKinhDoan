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

    internal class hoaDonController
    {
        DBconnect dBconnect = new DBconnect();
        MySqlDataReader dataReader;
        MySqlCommand cmd;

        //Hàm thêm hoa đơn
        public void InsertHD(HoaDon hd)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO `analysis`.`hoadon` (`idHd`, `idCh`, `ngayTao`) " +
                        "VALUES ("+hd.IdHd+", "+hd.IdCh+", '"+hd.NgayTao+"');";

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
        //Hàm lấy thông tin tất cả hóa đơn
        public List<HoaDon> AllHoaDon(CuaHang ch)
        {
            List<HoaDon> hoaDonList = new List<HoaDon>();
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`hoadon` where `idCh` = " + ch.MaCH + ";";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        HoaDon hoadon = new HoaDon();
                        hoadon.IdHd = int.Parse(dataReader["idHd"].ToString());
                        hoadon.IdCh = int.Parse(dataReader["idCh"].ToString());
                        hoadon.NgayTao = dataReader["ngayTao"].ToString();

                        hoaDonList.Add(hoadon);
                    }

                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }
            return hoaDonList;
        }
        //Hàm truyền danh sach hoadon lên listView
        public void ToListView(ListView splv, CuaHang ch)
        {
            List<HoaDon> hdList = AllHoaDon(ch);
            splv.Items.Clear();

            foreach (HoaDon hd in hdList)
            {
                ListViewItem lvItem = new ListViewItem(hd.IdHd.ToString());
                lvItem.SubItems.Add(hd.NgayTao.ToString());

                splv.Items.Add(lvItem);
            }
        }
    }
}
