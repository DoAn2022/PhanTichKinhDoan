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

        public int MaCH { get => maCH; set => maCH = value; }
        public string TenCH { get => tenCH; set => tenCH = value; }
        public string Password { get => password; set => password = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public CuaHang(int _maCH, string _tenCH, string _password, byte[] _hinhAnh)
        {
            this.MaCH = _maCH;
            this.TenCH = _tenCH;
            this.Password = _password;
            this.HinhAnh = _hinhAnh;
        }
        public CuaHang() { }


    }
}
