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
            tenCH_TC.Text = ch.TenCH.ToString();
            if(ch.HinhAnh!=null)
            {
                ImageConverter imgConverter = new ImageConverter();
                hinhCh.Image = (Image)imgConverter.ConvertFrom(ch.HinhAnh);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String chuoi = chaoMungText.Text;
            chuoi = chuoi.Substring(1,chuoi.Length - 1) + chuoi.Substring(0,1);
            chaoMungText.Text = chuoi;
        }
    }
}
