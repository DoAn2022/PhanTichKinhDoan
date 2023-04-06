using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichKinhDoan.Controller
{
    internal class PhanTich
    {
        sanPhamController spCTL = new sanPhamController();
        List<SanPham> sp_List = new List<SanPham>();


        public PhanTich(CuaHang ch) {
            sp_List = spCTL.AllSanPham(ch);
        }

        public int TongDT()
        {
            int tong = 0;
            
            foreach(SanPham sp in sp_List)
            {
                tong += sp.SlDb * sp.Gia;
            }
            return tong;
        }

        //Cong thuc max
        /*SLDB : sp.SlDb
        Du: (sp.Sl-sp.SlDb)
        DT: (sp.SlDb*sp.Gia)*/

        /*public SanPham Max(int i)
        {
            int max = 0;
            SanPham sp_Max = new SanPham();
            foreach (SanPham sp in sp_List)
            {
                if (i > max)
                {
                    max = i;
                    sp_Max = sp;
                }
            }
            return sp_Max;
        }
        public SanPham Min(int i)
        {
            SanPham sp_Min = Max(i);
            int min = sp_Min.SlDb;
            foreach (SanPham sp in sp_List)
            {
                if (i < min)
                {
                    min = i;
                    sp_Min = sp;
                }

            }
            return sp_Min;
        }*/

        public SanPham Max_SLBD()
        {
            int max = 0;
            SanPham sp_Max = new SanPham();
            foreach(SanPham sp in sp_List)
            {
                if (sp.SlDb > max) {
                    max = sp.SlDb;
                    sp_Max = sp;
                }
            }
            return sp_Max;
        }
        public SanPham Min_SLBD()
        {
            SanPham sp_Min = Max_SLBD();
            int min = sp_Min.SlDb;
            foreach (SanPham sp in sp_List)
            {
                if (sp.SlDb < min)
                {
                    min = sp.SlDb;
                    sp_Min = sp;
                }
                    
            }
            return sp_Min;
        }
        public SanPham Max_Du()
        {
            int max = 0;
            SanPham sp_Max = new SanPham();
            foreach (SanPham sp in sp_List)
            {
                if ((sp.Sl-sp.SlDb) > max)
                {
                    max = (sp.Sl - sp.SlDb);
                    sp_Max = sp;
                }
            }
            return sp_Max;
        }
        public SanPham Min_Du()
        {
            SanPham sp_Min = Max_Du();
            int min = sp_Min.Sl-sp_Min.SlDb;
            foreach (SanPham sp in sp_List)
            {
                if ((sp.Sl - sp.SlDb) < min)
                {
                    min = (sp.Sl - sp.SlDb);
                    sp_Min= sp;
                }
            }
            return sp_Min;
        }


        public SanPham Max_DT()
        {
            int max = 0;
            SanPham sp_Max = new SanPham();
            foreach (SanPham sp in sp_List)
            {
                if ((sp.SlDb*sp.Gia) > max)
                {
                    max = (sp.SlDb * sp.Gia);
                    sp_Max = sp;
                }
            }
            return sp_Max;
        }
        public SanPham Min_DT()
        {
            SanPham sp_Min = Max_DT();
            int min = (sp_Min.SlDb * sp_Min.Gia);
            foreach (SanPham sp in sp_List)
            {
                if ((sp.SlDb * sp.Gia) < min)
                {
                    min = (sp.SlDb * sp.Gia);
                    sp_Min = sp;
                }

            }
            return sp_Min;
        }
    }
}
