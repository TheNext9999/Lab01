using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 10: VẼ HÌNH BẰNG KÝ TỰ (*) ---");
            int chon;
            do
            {
                Console.WriteLine("\nMenu Bài 10:");
                Console.WriteLine("1. Vẽ tam giác vuông đặc");
                Console.WriteLine("2. Vẽ tam giác vuông rỗng");
                Console.WriteLine("3. Vẽ hình vuông rỗng");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Lựa chọn: ");
                if (!int.TryParse(Console.ReadLine(), out chon)) chon = -1;

                if (chon >= 1 && chon <= 3)
                {
                    Console.Write("Nhập kích thước h (h > 1): ");
                    if (!int.TryParse(Console.ReadLine(), out int h) || h <= 1)
                    {
                        Console.WriteLine("Kích thước h phải lớn hơn 1.");
                        continue;
                    }

                    switch (chon)
                    {
                        case 1:
                            Console.WriteLine("\nTam giác vuông đặc:");
                            for (int i = 1; i <= h; i++)
                            {
                                for (int j = 1; j <= i; j++) Console.Write("* ");
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nTam giác vuông rỗng:");
                            for (int i = 1; i <= h; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    if (j == 1 || j == i || i == h) Console.Write("* ");
                                    else Console.Write("  ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine("\nHình vuông rỗng:");
                            for (int i = 1; i <= h; i++)
                            {
                                for (int j = 1; j <= h; j++)
                                {
                                    if (i == 1 || i == h || j == 1 || j == h) Console.Write("* ");
                                    else Console.Write("  ");
                                }
                                Console.WriteLine();
                            }
                            break;
                    }
                }
            } while (chon != 0);
        }
    }
}
