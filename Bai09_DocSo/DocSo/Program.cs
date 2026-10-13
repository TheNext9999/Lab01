using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSo
{
    internal class Program
    {
        private static string DocChuSo(int num)
        {
            switch (num)
            {
                case 0: return "không";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 9: ĐỌC SỐ TỪ 0 ĐẾN 99 ---");
            Console.Write("Nhập số nguyên (0 - 99): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 99)
            {
                Console.WriteLine("Số nhập vào phải từ 0 đến 99.");
                return;
            }

            string result = "";
            if (n < 10)
            {
                result = DocChuSo(n);
                result = char.ToUpper(result[0]) + result.Substring(1);
            }
            else if (n < 20)
            {
                int donVi = n % 10;
                if (donVi == 0) result = "Mười";
                else if (donVi == 5) result = "Mười lăm";
                else result = "Mười " + DocChuSo(donVi);
            }
            else
            {
                int chuc = n / 10;
                int donVi = n % 10;

                string strChuc = DocChuSo(chuc);
                strChuc = char.ToUpper(strChuc[0]) + strChuc.Substring(1);

                if (donVi == 0) result = strChuc + " mươi";
                else if (donVi == 1) result = strChuc + " mươi mốt";
                else if (donVi == 4) result = strChuc + " mươi tư";
                else if (donVi == 5) result = strChuc + " mươi lăm";
                else result = strChuc + " mươi " + DocChuSo(donVi);
            }

            Console.WriteLine("Cách đọc: {0}", result);
        }
    }
}
