using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BÀI 3: XẾP LOẠI KẾT QUẢ HỌC TẬP ---");
            double diem;
            Console.Write("Nhập điểm (0 - 10): ");
            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm phải thuộc [0, 10].");
                return;
            }

            if (diem >= 9.0) Console.WriteLine("Xếp loại: Xuất sắc");
            else if (diem >= 8.0) Console.WriteLine("Xếp loại: Giỏi");
            else if (diem >= 6.5) Console.WriteLine("Xếp loại: Khá");
            else if (diem >= 5.0) Console.WriteLine("Xếp loại: Trung bình");
            else Console.WriteLine("Xếp loại: Yếu");
        }
    }
}
