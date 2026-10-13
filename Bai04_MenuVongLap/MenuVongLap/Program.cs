using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVongLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 4: TÍNH TỔNG & BẢNG CỬU CHƯƠNG ---");
            int chon;
            do
            {
                Console.WriteLine("\nMenu Bài 4:");
                Console.WriteLine("1. Tính tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương 7");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Lựa chọn: ");
                int.TryParse(Console.ReadLine(), out chon);

                switch (chon)
                {
                    case 1:
                        Console.Write("n = ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            int tong = 0;
                            for (int i = 1; i <= n; i++) tong += i;
                            Console.WriteLine("Tổng 1..{0} = {1}", n, tong);
                        }
                        else
                        {
                            Console.WriteLine("n phải là số nguyên dương.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Bảng cửu chương 7:");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("7 x {0,2} = {1,2}", i, 7 * i);
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
