using EF_EX_HOCSINH.Helper;

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

        public HocSinh()
        {
              /*  Console.WriteLine("Nhap Ho ten: ");
                HoTen = Console.ReadLine();
                Console.WriteLine("Nhap Ngay Sinh: ");
                NgaySinh = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Que Quan: ");
                QueQuan = Console.ReadLine();*/
        }
        public void Sua(HocSinh hs, inputType ip)
        {
            if(ip == inputType.SuaTen)
            {
                Console.WriteLine("Nhap Ho ten: ");
                hs.HoTen = Console.ReadLine();
            }
            else if(ip == inputType.SuaNgSinh)
            {
                Console.WriteLine("Nhap Ngay Sinh: ");
                hs.NgaySinh = DateTime.Parse(Console.ReadLine());
            }
            else if(ip == inputType.SuaQue)
            {
                Console.WriteLine("Nhap Que Quan: ");
                hs.QueQuan = Console.ReadLine();
            }
            else if(ip == inputType.SuaAll)
            {
                Console.WriteLine("Nhap Ho ten: ");
                hs.HoTen = Console.ReadLine();
                Console.WriteLine("Nhap Ngay Sinh: ");
                hs.NgaySinh = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Que Quan: ");
                hs.QueQuan = Console.ReadLine();
            }

        }

    }

}
