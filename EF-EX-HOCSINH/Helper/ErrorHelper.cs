using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Helper
{
    public enum errType
    {
        ThanhCong, TrungMa, ChuaTonTai, ThatBai, LopMax
    }
    public class ErrorHelper
    {
       public static void Log(errType et)
        {
           switch (et)
            {
                case errType.ThanhCong:
                    break;
                case errType.TrungMa:
                    break;
                case errType.ChuaTonTai:
                    break;
                case errType.ThatBai:
                    break;
            }
        }
    }
}
