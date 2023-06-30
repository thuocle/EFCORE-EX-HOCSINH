using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Helper
{
    public class InputHelper
    {
        public static bool KiemTraChuoi(string str, int maxLenght = 20)
        {
            return str.Length > maxLenght;
        }
        public static bool KiemTraHocSinh() { return true; }
    }
}
