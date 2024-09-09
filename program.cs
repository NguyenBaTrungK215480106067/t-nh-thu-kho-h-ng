namespace ConsoleApp5
     //Nguyễn Bá Trung
     //bài toán về tính tiền nước đá

  using System;

namespace TinhTienNuocDa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo số lượng túi nước đá và giá mỗi túi
            int soLuongTui = 75;
            int giaMoiTui = 10000;

            // Tính tổng số tiền
            int tongSoTien = soLuongTui * giaMoiTui;

            // In kết quả ra màn hình
            Console.WriteLine("Tổng số tiền mà cửa hàng thu được từ việc bán nước đá là: " + tongSoTien + " VND");

            // Đợi người dùng nhấn phím để đóng chương trình
            Console.ReadKey();
        }
    }
}
