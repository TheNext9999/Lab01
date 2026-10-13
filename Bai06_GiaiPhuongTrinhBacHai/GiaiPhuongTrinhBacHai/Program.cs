using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 6: GIẢI PHƯƠNG TRÌNH BẠC HAI (ax^2 + bx + c = 0) ---");
            Console.Write("Nhập a = ");
            if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Giá trị a không hợp lệ."); return; }
            Console.Write("Nhập b = ");
            if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Giá trị b không hợp lệ."); return; }
            Console.Write("Nhập c = ");
            if (!double.TryParse(Console.ReadLine(), out double c)) { Console.WriteLine("Giá trị c không hợp lệ."); return; }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("Phương trình có vô số nghiệm.");
                    else Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình bậc nhất có nghiệm x = {0:F2}", x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép x = {0:F2}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0:F2}", x1);
                    Console.WriteLine("x2 = {0:F2}", x2);
                }
            }
        }
    }
}
