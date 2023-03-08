using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_NHAP_XUAT_EP_KIEU
{
    internal class Program
    {
        /*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        static void Main(string[] args)
        {
            //1. Ép kiểu giữa các số
            //ép kiểu ngầm định
            int a = 10;
            double b = a;
            Console.WriteLine($"b= {b}");
            //ép kiểu tường minh
            double c = 8.5;
            int d = (int) c;
            Console.WriteLine($"d= {d}");

            //2. Ép kiểu từ string về số
            string num1 = "2";
            string num2 = "6";
            Console.WriteLine(num1 + num2);

            //nếu num1 là null => lỗi ArgumentNullException
            int n1 = int.Parse(num1);
            //nếu num2 là null => nhận giá trị mặc định =0
            int n2 = Convert.ToInt32(num2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n1+n2);
        }
    }
}
