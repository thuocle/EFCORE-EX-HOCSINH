using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Entities
{
    public class Lop
    {
        public int LopID { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public IEnumerable<HocSinh> ListHocSinh { get; set; }   
    }
}
