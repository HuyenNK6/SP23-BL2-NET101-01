using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_TOAN_TU
{
    internal class Program
    {
        /*
         * 4 Loại toán tử trong lập trình
         *  1. Toán tử số học:
         *  (+ - * / % ++ --)
         *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
         *      -: Phép trừ của 2 số
         *      *: Phép nhân của 2 số
         *      %: Phép chia lấy dư của 2 số
         *      ++: Tăng lên 1 đơn vị
         *      --: Giảm 1 đơn vị
         *  2. Toán tử so sánh:
         *  (> < >= <= == !=)
         *      >: Lớn hơn
         *      <: nhỏ hơn
         *      >=: lớn hơn hoặc bằng
         *      <=: nhỏ hơn hoặc bằng
         *      ==: so sánh bằng
         *      !=: so sánh khác
         *  3. Toán tử Logic:
         * (&& || !)
         *      &&: Yêu cầu các mệnh đề phải luôn đúng
         *      ||: Yêu cầu 1 trong các mệnh đề dúng là được
         *      !: Lấy giá trị phủ định của mệnh đề.
         *  4. Toán tử gán:
         * (= += -= *= /= %=)
         *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự
         */

        /*
         * Toán tử ba ngôi
         *  <biểu thức> ? <kết quả đúng> : <kết quả sai>
         */
        static void Main(string[] args)
        {
            //Nhập xuất thông tin của máy tính
            //ma: string
            //hang: string
            //gia: double
            //inch: float
            //win: int
            //isNew: bool => true/ false
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //NHẬP =>    cw tab tab
            Console.WriteLine("-----NHẬP THÔNG TIN------");
            //ma: string
            Console.Write("Nhập mã: ");
            string ma = Console.ReadLine();
            //hang: string
            Console.Write("Nhập hãng: ");
            string hang = Console.ReadLine();
            //gia: double
            Console.Write("Nhập giá tiền: ");
            double gia = Convert.ToDouble(Console.ReadLine());
            //inch: float
            Console.Write("Nhập inch: ");
            float inch = (float)Convert.ToDouble(Console.ReadLine());
            //win: int
            Console.Write("Nhập win: ");
            int win = Convert.ToInt32(Console.ReadLine());
            //isNew: bool => true/ false
            Console.Write("Máy mới hay cũ (true/false)? ");
            bool isNew = Convert.ToBoolean(Console.ReadLine());
            //XUẤT
            Console.WriteLine("------XUẤT THÔNG TIN----------");
            Console.WriteLine($"ma = {ma}");
            Console.WriteLine($"hang = {hang}");
            Console.WriteLine($"gia = {gia}");
            Console.WriteLine($"inch = {inch}");
            Console.WriteLine($"win = {win}");
            Console.WriteLine($"isNew = {isNew}");
            Console.WriteLine($"isNew = {(isNew == true ? "Máy mới" : "Máy cũ")}");

            /////////
            //(isNew) => true

            if (!isNew)
            {
                Console.WriteLine("Máy mới");
            }
            else
            {
                Console.WriteLine("Máy cũ");
            }


            ///Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASCII
            Console.WriteLine("Có muốn tiếp tục không? ");
            int tiepTuc = Console.Read();
            Console.WriteLine(tiepTuc);

        }
    }
}
