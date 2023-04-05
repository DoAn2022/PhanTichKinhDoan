using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichKinhDoan.Model
{
    internal class SanPham
    {
        private int idSp;
        private int idCh;
        private String tenSp;
        private int gia;
        private int sl;
        private int slDb;

        public int IdSp { get => idSp; set => idSp = value; }
        public int IdCh { get => idCh; set => idCh = value; }
        public String TenSp { get => tenSp; set => tenSp = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Sl { get=>sl; set => sl = value; }
        public int SlDb { get => slDb;set => slDb = value; }


        public SanPham(int idSp, int idCh, string tenSp, int gia, int sl, int slDb)
        {
            this.idSp = idSp;
            this.idCh = idCh;
            this.tenSp = tenSp;
            this.gia = gia;
            this.sl = sl;
            this.slDb = slDb;
        }

        public SanPham() { }
    }
}
