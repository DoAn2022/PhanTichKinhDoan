using PhanTichKinhDoan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichKinhDoan.View
{
    internal partial class TrangChu : Form
    {
        public TrangChu(CuaHang ch)
        {
            InitializeComponent();
            bonus(ch);
        }
        public void bonus(CuaHang ch)
        {
            if(ch.HinhAnh!=null)
            {
                ImageConverter imgConverter = new ImageConverter();
                hinhCh.Image = (Image)imgConverter.ConvertFrom(ch.HinhAnh);
            }
        }
        

    }
}
