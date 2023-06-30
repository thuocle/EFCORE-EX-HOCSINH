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
        public void UpDateSiSo(int lopID)
        {
            var lopNow = dbContext.Lop.FirstOrDefault(x => x.LopID == lopID);
            if(lopNow != null)
            {
                lopNow.SiSo = dbContext.HocSinh.Count(x => x.LopID == lopNow.LopID) ;
                dbContext.Update(lopNow);
                dbContext.SaveChanges();
            }
        }

        public errType ThemHSVaoLop(HocSinh hs, int lopID)
        {
            if(dbContext.HocSinh.Any(x=>x.HocSinhID == hs.HocSinhID))//kiem tra da ton tai hoc sinh chua
            {
                return errType.TrungMa;
            }
            else
            {
                if (dbContext.Lop.Any(x => x.LopID == lopID))// kiem tra da co lop de them vao chua
                {
                    var lopNow = dbContext.Lop.FirstOrDefault(x=>x.LopID == lopID);
                    if(lopNow.SiSo +1 > 20)
                    {
                        return errType.LopMax;
                    }
                    else
                    {
                        hs.LopID = lopID;
                        dbContext.HocSinh.Add(hs);
                        dbContext.SaveChanges();
                        UpDateSiSo(lopID);
                        return errType.ThanhCong;
                    }
                } else
                    return errType.ChuaTonTai;
            }
        }
    }
}
