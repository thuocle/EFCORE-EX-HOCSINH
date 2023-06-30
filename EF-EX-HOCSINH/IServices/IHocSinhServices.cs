using EF_EX_HOCSINH.Entities;
using EF_EX_HOCSINH.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.IServices
{
    public interface IHocSinhServices
    {
        errType ThemHSVaoLop(HocSinh hs, int lopID);
    }
}
