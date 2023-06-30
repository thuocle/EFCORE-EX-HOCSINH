using EF_EX_HOCSINH.Entities;

namespace EF_EX_HOCSINH.Helper
{
    public enum inputType
    {
        SuaTen, SuaNgSinh, SuaAll, SuaQue, Them
    }
    public class InputHelper
    {
        public static List<string> lstProvinces = new List<string>()
{
    "An Giang",
    "Bà Rịa - Vũng Tàu",
    "Bắc Giang",
    "Bắc Kạn",
    "Bạc Liêu",
    "Bắc Ninh",
    "Bến Tre",
    "Bình Định",
    "Bình Dương",
    "Bình Phước",
    "Bình Thuận",
    "Cà Mau",
    "Cần Thơ",
    "Cao Bằng",
    "Đà Nẵng",
    "Đắk Lắk",
    "Đắk Nông",
    "Điện Biên",
    "Đồng Nai",
    "Đồng Tháp",
    "Gia Lai",
    "Hà Giang",
    "Hà Nam",
    "Hà Nội",
    "Hà Tĩnh",
    "Hải Dương",
    "Hải Phòng",
    "Hậu Giang",
    "Hòa Bình",
    "Hưng Yên",
    "Khánh Hòa",
    "Kiên Giang",
    "Kon Tum",
    "Lai Châu",
    "Lâm Đồng",
    "Lạng Sơn",
    "Lào Cai",
    "Long An",
    "Nam Định",
    "Nghệ An",
    "Ninh Bình",
    "Ninh Thuận",
    "Phú Thọ",
    "Phú Yên",
    "Quảng Bình",
    "Quảng Nam",
    "Quảng Ngãi",
    "Quảng Ninh",
    "Quảng Trị",
    "Sóc Trăng",
    "Sơn La",
    "Tây Ninh",
    "Thái Bình",
    "Thái Nguyên",
    "Thanh Hóa",
    "Thừa Thiên Huế",
    "Tiền Giang",
    "TP. Hồ Chí Minh",
    "Trà Vinh",
    "Tuyên Quang",
    "Vĩnh Long",
    "Vĩnh Phúc","Yên Bái"
};
        public static bool KiemTraChuoi(string str, int maxLenght = 20)
        {
            return str.Length > maxLenght;
        }
        public static bool KiemTraQueQuan(string str)
        {
           var pos = lstProvinces.FindIndex(x=>x == str);
            if (pos == null)
                return false;
            return true;
        }
        public static errType KiemTraHocSinh(HocSinh hs)
        {
            if (KiemTraChuoi(hs.HoTen))
            {
                return errType.SoKTQuadai;
            }
            if (!KiemTraChuoi(hs.HoTen, 2))
            {
                return errType.SoKTQuaNgan;
            }
            if (!(hs.HoTen.Split(' ').Length >= 2))
            {
                return errType.SoTuNgan;
            }
            if (hs.NgaySinh.Year < 2001 || hs.NgaySinh.Year > 2013)
            {
                return errType.KhongHopleNgSinh;
            }
            if (!KiemTraQueQuan(hs.QueQuan))
            {
                return errType.QueQuanKHL;
            }
            return errType.ThanhCong;
        }
    }
}
