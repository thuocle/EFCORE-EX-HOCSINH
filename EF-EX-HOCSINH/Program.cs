using EF_EX_HOCSINH.Entities;
using EF_EX_HOCSINH.IServices;
using EF_EX_HOCSINH.Services;
using EF_EX_HOCSINH.Helper;
void Main() 
{
    IHocSinhServices hocSinhServices = new HocSinhServices();
    HocSinh newhs = new HocSinh()
    {
        HoTen = "Nguyen A",
        NgaySinh = new DateTime(2000, 12,12),
        QueQuan = "Ha Noi"
    };
    hocSinhServices.ThemHSVaoLop(newhs, 1);
}
Main();