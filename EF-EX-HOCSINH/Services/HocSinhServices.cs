using EF_EX_HOCSINH.Entities;
using EF_EX_HOCSINH.Helper;
using EF_EX_HOCSINH.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Services
{
    public class HocSinhServices : IHocSinhServices
    {
        private readonly AppDbContext dbContext;

        public HocSinhServices()
        {
            this.dbContext = new AppDbContext();
        }
        private void UpDateSiSo(int lopID)
        {
            var lopNow = dbContext.Lop.FirstOrDefault(x => x.LopID == lopID);
            if(lopNow != null)
            {
                lopNow.SiSo = dbContext.HocSinh.Count(x => x.LopID == lopNow.LopID) ;
                dbContext.Update(lopNow);
                dbContext.SaveChanges();
            }
        }

        public void ThemHSVaoLop(HocSinh hs, int lopID)
        {
            if(InputHelper.KiemTraHocSinh(hs) != errType.ThanhCong) 
            {
                ErrorHelper.Log(errType.ThatBai);
                return;
            }
            if(dbContext.HocSinh.Any(x=>x.HocSinhID == hs.HocSinhID))//kiem tra da ton tai hoc sinh chua
            {
                ErrorHelper.Log(errType.TrungMa);
                return; 
            }
                if (dbContext.Lop.Any(x => x.LopID == lopID))// kiem tra da co lop de them vao chua
                {
                    var lopNow = dbContext.Lop.FirstOrDefault(x => x.LopID == lopID);
                    if (lopNow.SiSo + 1 > 20)
                    {
                        ErrorHelper.Log(errType.LopMax);
                        return;
                    }
                    else
                    {
                        hs.LopID = lopID;
                        dbContext.HocSinh.Add(hs);
                        dbContext.SaveChanges();
                        UpDateSiSo(lopID);
                        ErrorHelper.Log(errType.ThanhCong);
                    }
                }
                else
                    ErrorHelper.Log(errType.ChuaTonTai);
                    ErrorHelper.Log(errType.ThatBai);
                    return;
        }

        public void SuaHS(int hsID)
        {
            var hsNow = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhID == hsID);
            if (hsNow != null)
            {
                
                /*hsNow.HoTen = hsNow.HoTen;
                hsNow.NgaySinh = hsNow.NgaySinh;
                hsNow.QueQuan = hsNow.QueQuan;*/
                Console.WriteLine("Ban muon sua gi: 1.Ho ten 2.Ngay sinh 3.Que quan 4.Sua tat ca");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (c)
                {
                    case '1':
                        hsNow.Sua(hsNow, inputType.SuaTen); 
                        break;
                    case '2':
                        hsNow.Sua(hsNow, inputType.SuaNgSinh);
                        break;
                    case '3':
                        hsNow.Sua(hsNow, inputType.SuaQue);
                        break;
                    case '4':
                        hsNow.Sua(hsNow, inputType.SuaAll);
                        break;
                }
                if (InputHelper.KiemTraHocSinh(hsNow) != errType.ThanhCong)
                {
                    ErrorHelper.Log(errType.ThatBai);
                    return;
                }
                dbContext.Update(hsNow);
                dbContext.SaveChanges();
                ErrorHelper.Log(errType.ThanhCong);
            }
            else 
            {
                ErrorHelper.Log(errType.ChuaTonTai);
                ErrorHelper.Log(errType.ThatBai);
            }
                
        }

        public void XoaHS(int hsID)
        {
            var hsNow = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhID == hsID);
            if (hsNow != null)
            {
                dbContext.Remove(hsNow);
                dbContext.SaveChanges();
                UpDateSiSo(hsNow.LopID);
                ErrorHelper.Log(errType.ThanhCong);
            }
            else
                ErrorHelper.Log(errType.ChuaTonTai);
                ErrorHelper.Log(errType.ThatBai);
        }

        public void ChuyenLopChoHS(int hsID, int lopNewID)
        {
            
            if (!dbContext.Lop.Any(x=>x.LopID == lopNewID))
            {
                Console.WriteLine($"Lop moi {Res.ChuaTonTai}");
                return;
            }
            var hs = dbContext.HocSinh.FirstOrDefault(x=>x.HocSinhID==hsID);
            if (hs != null) 
            {
                int lopOldID = hs.LopID;
                hs.LopID = lopNewID;
                dbContext.Update(hs);
                dbContext.SaveChanges();
                UpDateSiSo(lopOldID);
                UpDateSiSo(lopNewID);
                Console.WriteLine( Res.ThanhCong);
            }
            else
            {
                Console.WriteLine($"Hoc sinh {Res.ChuaTonTai}");
            }
        }
    }
}
