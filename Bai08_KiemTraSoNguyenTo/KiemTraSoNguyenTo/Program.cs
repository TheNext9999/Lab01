using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSoNguyenTo
{
    internal class Program
    {
        private static bool IsPrime(int k)
        {
            if (k < 2) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 8: IN DANH SÁCH SỐ NGUYÊN TỐ ---");
            Console.Write("Nhập n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Vui lòng nhập n >= 2.");
                return;
            }

            Console.WriteLine("Các số nguyên tố <= {0} là:", n);
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
