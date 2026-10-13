using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinCaNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 1: THÔNG TIN CÁ NHÂN ---");
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            int namSinh;
            if (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh > DateTime.Now.Year || namSinh < 1900)
            {
                Console.WriteLine("Năm sinh không hợp lệ.");
                return;
            }
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);
        }
    }
}
