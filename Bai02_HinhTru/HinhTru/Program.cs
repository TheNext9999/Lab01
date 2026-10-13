using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 2: TÍNH TOÁN HÌNH TRỤ ---");
            double r, h;
            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Bán kính phải lớn hơn 0.");
                return;
            }
            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Chiều cao phải lớn hơn 0.");
                return;
            }

            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;
            Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);
        }
    }
}
