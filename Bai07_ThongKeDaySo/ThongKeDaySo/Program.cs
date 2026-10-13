using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongKeDaySo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 7: THỐNG KÊ DÃY SỐ ---");
            Console.Write("Nhập số lượng phần tử n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng phần tử n phải là số nguyên dương.");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Giá trị sai. Nhập lại phần tử thứ {0}: ", i + 1);
                }
            }

            int tong = 0;
            int max = arr[0];
            int min = arr[0];
            int soChan = 0;

            foreach (int val in arr)
            {
                tong += val;
                if (val > max) max = val;
                if (val < min) min = val;
                if (val % 2 == 0) soChan++;
            }

            double trungBinh = (double)tong / n;

            Console.WriteLine("\n--- KẾT QUẢ THỐNG KÊ ---");
            Console.WriteLine("Tổng: {0}", tong);
            Console.WriteLine("Trung bình cộng: {0:F2}", trungBinh);
            Console.WriteLine("Số lớn nhất (Max): {0}", max);
            Console.WriteLine("Số nhỏ nhất (Min): {0}", min);
            Console.WriteLine("Số lượng số chẵn: {0}", soChan);
        }
    }
}
