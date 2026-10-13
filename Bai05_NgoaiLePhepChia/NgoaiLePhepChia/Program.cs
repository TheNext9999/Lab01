using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoaiLePhepChia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 5: XỬ LÝ NGOẠI LỆ PHÉP CHIA ---");
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("a / b = " + (a / b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu phải là số nguyên.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0.");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính.");
            }
        }
    }
}
