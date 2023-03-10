using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_NHAP_XUAT
{
    internal class Program
    {
        /*
         * BÀI 3: Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASCII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.InputEncoding= Encoding.Unicode;
            //nhập & xuất thông tin sinh viên từ bàn phím
            //msv: string
            //hoTen: string
            //namSinh: int
            //diem: double
            //isBoy: bool
            // Console.ReadLine(); đọc 1 dòng dữ liệu từ bàn phím
            // => trả về kiểu string

            //cw  tab tab
            
            //PHẦN 1: NHẬP
            Console.WriteLine("Nhập mã sinh viên: ");
            string msv = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            //ép kiểu từ String về Số int

            //diem: double
            Console.WriteLine("Nhập điểm: ");
            double diem = Convert.ToDouble(Console.ReadLine());
            //isBoy: bool => true /false
            Console.WriteLine("Là nam-true hay nữ- false: ");
            bool isBoy= Convert.ToBoolean(Console.ReadLine());

            //PHẦN 2: XUẤT
            Console.WriteLine($"msv= {msv}");
            Console.WriteLine($"hoTen= {hoTen}");
            Console.WriteLine($"tuoi= {2023-namSinh}");
            Console.WriteLine($"diem= {diem}");
            Console.WriteLine($"isBoy= {isBoy}");
        }
        /*
         * BTVN:
         * Nhập và xuất thông tin món quà 8/3 bạn tặng cho NY
         * ten: string
         * giaTien: double
         * soLuong: int
         * isNew: bool //true- mới, false- cũ
         * noiMua: string
         */
    }
}
