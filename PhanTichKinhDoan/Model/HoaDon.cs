using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichKinhDoan.Model
{
    internal class HoaDon
    {
        private int idHd;
        private int idCh;
        private String ngayTao;


        public int IdHd { get=>idHd; set => idHd = value; }
        public int IdCh { get => idCh;set => idCh = value; }
        public String NgayTao { get => ngayTao;set => ngayTao = value; }
        public HoaDon()
        {
        }

        public HoaDon(int idHd, int idCh, string ngayTao)
        {
            this.idHd = idHd;
            this.idCh = idCh;
            this.ngayTao = ngayTao;
        }
    }
}
