using EF_EX_HOCSINH.Entities;
using EF_EX_HOCSINH.IServices;
using EF_EX_HOCSINH.Services;
using EF_EX_HOCSINH.Helper;
using System.Threading.Channels;

IHocSinhServices hocSinhServices = new HocSinhServices();
void MENU()
{
    Console.Clear();
        Console.WriteLine("===MENU===\n" +
        "1.Them mot hoc sinh\n" +
        "2.Sua thong tin hoc sinh\n" +
        "3.Xoa hoc sinh\n" +
        "4.Chuyen lop cho hoc sinh\n" +
        "5.Thoat");
    char c = Console.ReadKey().KeyChar;
    Console.WriteLine();
    DoAction(c);
}
void DoAction(char c)
{
    switch (c)
    {
        case '1':
            Console.WriteLine("Them hoc sinh vao lop nao?");
            int lopID = int.Parse(Console.ReadLine());
            hocSinhServices.ThemHSVaoLop(new HocSinh(), lopID);
            break;
        case '2':
            Console.WriteLine("Nhap id hoc sinh can sua:");
            int hsID = int.Parse(Console.ReadLine());
            hocSinhServices.SuaHS(hsID);
            break;
        case '3':
            Console.WriteLine("Nhap id hoc sinh can xoa:");
            hsID = int.Parse(Console.ReadLine());
            hocSinhServices.XoaHS(hsID);
            break;
        case '4':
            Console.WriteLine("Nhap id hoc sinh muon chuyen:");
            hsID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lop muon chuyen toi:");
            lopID = int.Parse(Console.ReadLine());
            hocSinhServices.ChuyenLopChoHS(hsID,lopID);
            break;
        case '5':
            return;
    }
    Console.ReadKey();
    MENU();
}
void Main() 
{
    MENU();
    
    /* HocSinh newhs = new HocSinh()
     {
         HoTen = "Nguyen A",
         NgaySinh = new DateTime(2000, 12,12),
         QueQuan = "Ha Noi"
     };
     hocSinhServices.ThemHSVaoLop(newhs, 1);*/
}
Main();