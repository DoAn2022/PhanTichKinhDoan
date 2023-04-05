using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichKinhDoan.Model
{
    internal class CuaHang
    {
        private int maCH;
        private string tenCH;
        private string password;
        private byte[] hinhAnh;
        private string maThue;
        private string chuSh;
        private string sdt;
        private string diaChi;

        public int MaCH { get => maCH; set => maCH = value; }
        public string TenCH { get => tenCH; set => tenCH = value; }
        public string Password { get => password; set => password = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MaThue { get => maThue; set => maThue = value; }
        public string ChuSh { get => chuSh; set => chuSh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public CuaHang(int _maCH, string _tenCH, string _password, byte[] _hinhAnh,
            string maThue, string chuSh, string sdt, string diaChi)
        {
            this.MaCH = _maCH;
            this.TenCH = _tenCH;
            this.Password = _password;
            this.HinhAnh = _hinhAnh;
            this.maThue = maThue;
            this.chuSh = chuSh;
            this.sdt = sdt;
            this.diaChi = diaChi;
        }
        public CuaHang() { }


    }
}
