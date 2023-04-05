using MySql.Data.MySqlClient;
using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppConnectDB;

namespace PhanTichKinhDoan.Controller
{
    internal class cuaHangController
    {
        DBconnect dBconnect = new DBconnect();
        CuaHang ch = new CuaHang();
        MySqlDataReader dataReader;
        MySqlCommand cmd;


        //Hàm lấy thông tin cửa hàng
        public CuaHang ThongTinCuaHang(CuaHang ch)
        {
            CuaHang cuaHang = new CuaHang();
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`store` where `tenCH` = '"+ch.TenCH+"';";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    dataReader = cmd.ExecuteReader();

                    while(dataReader.Read())
                    {
                        cuaHang.MaCH = int.Parse(dataReader["maCH"].ToString());
                        cuaHang.TenCH = dataReader["tenCH"].ToString();
                        cuaHang.Password = dataReader["password"].ToString();
                        cuaHang.HinhAnh = (byte[])dataReader["image"];
                        cuaHang.ChuSh = dataReader["chuSH"].ToString();
                        cuaHang.DiaChi = dataReader["diaChi"].ToString();
                        cuaHang.Sdt = dataReader["sdt"].ToString();
                        cuaHang.MaThue = dataReader["maThue"].ToString();
                    }

                    dBconnect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ", ex.Message);
                }
            }

            return cuaHang;
        }
        //Hàm thêm cửa hàng
        public void InsertCH(CuaHang ch)
        {
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO `analysis`.`store` (`tenCH`,`password`,`image`,`maThue`, `chuSH`,`sdt`,`diaChi`) " +
                        "VALUES ('" + ch.TenCH + "','"+ch.Password+"',@Image," +
                        "'" + ch.MaThue + "','" + ch.ChuSh + "','" + ch.Sdt + "','" + ch.DiaChi + "');";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    cmd.Parameters.Add("@Image",
                    MySqlDbType.LongBlob, ch.HinhAnh.Length).Value = ch.HinhAnh;

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

        //Hàm tìm kiếm tên cửa hàng
        public Boolean TenCHTonTai(String ten)
        {
            int i = 0;
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`store` where `tenCH` = '"+ten+"';";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    i = int.Parse(cmd.ExecuteScalar()+"");
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show("Lỗi: " + ex.Message);*/
                }
            }
            dBconnect.CloseConnection();
            return i>0;
        }
        //Hàm tìm kiếm tên cửa hàng
        public Boolean CheckPass(String ten, String pass)
        {
            int i = 0;
            if (dBconnect.OpenConnection())
            {
                try
                {
                    string query = "select * from `analysis`.`store` where `tenCH` = '" + ten + "' and `password` = '" + pass + "';";

                    cmd = new MySqlCommand(query, dBconnect.GetConnection());
                    i = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show("Lỗi: " + ex.Message);*/
                }
            }
            dBconnect.CloseConnection();
            return i > 0;
        }

    }
}
