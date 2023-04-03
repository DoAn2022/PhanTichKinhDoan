using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichKinhDoan.Tools
{
    internal class Check
    {
        public Check() { }
        /*public Boolean Null(TextBox t) { return t.Text.Equals(""); }*/
        
        public Boolean Lenght(TextBox t, int l) { return t.Text.Length >= l; }
    }
}
