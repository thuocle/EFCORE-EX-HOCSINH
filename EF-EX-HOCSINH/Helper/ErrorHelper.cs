using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Helper
{
    public enum errType
    {
        ThanhCong, TrungMa, ChuaTonTai, ThatBai, LopMax, SoKTQuadai, SoTuNgan, KhongHopleNgSinh, SoKTQuaNgan, QueQuanKHL
    }
    public class ErrorHelper
    {
        public static void Log(errType errType)
        {
            switch (errType)
            {
                case errType.ThanhCong:
                    Console.WriteLine(Res.ThanhCong);
                    break;
                case errType.TrungMa:
                    Console.WriteLine(Res.TrungMa);
                    break;
                case errType.ChuaTonTai:
                    Console.WriteLine(Res.ChuaTonTai);
                    break;
                case errType.ThatBai:
                    Console.WriteLine(Res.ThatBai);
                    break;
                case errType.LopMax:
                    Console.WriteLine(Res.LopMax);
                    break;
                case errType.SoKTQuaNgan:
                    Console.WriteLine(Res.SoKTQuaNgan);
                    break;
                case errType.SoKTQuadai:
                    Console.WriteLine(Res.SoKTQuadai);
                    break;
                case errType.SoTuNgan:
                    Console.WriteLine(Res.SoTuNgan);
                    break;
                case errType.KhongHopleNgSinh:
                    Console.WriteLine(Res.KhongHopleNgSinh);
                    break;
                case errType.QueQuanKHL:
                    Console.WriteLine(Res.QueQuanKHL);
                    break;
            }
        }
    }
}
