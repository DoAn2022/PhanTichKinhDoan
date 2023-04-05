using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichKinhDoan.Model
{
    internal class DanhMuc
    {
        private int idHd;
        private int idSp;
        private int Sl;

        public int IdHd { get => idHd; set => idHd = value; }
        public int IdSp { get =>idSp; set => idSp = value; }
        public int SL { get => Sl; set => Sl = value; }

        public DanhMuc()
        {
        }

        public DanhMuc(int idHd, int idSp, int sl)
        {
            this.idHd = idHd;
            this.idSp = idSp;
            Sl = sl;
        }
    }
}
