using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Entities
{
    public class HocSinh
    {
        public int HocSinhID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public int LopID { get; set; }
        public Lop Lop { get; set; }
    }
}
