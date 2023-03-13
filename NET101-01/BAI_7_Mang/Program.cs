using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_Mang
{
    internal class Program
    {
        /*
        * Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            //1. khai báo
            //int arrSo[5];
            int[] arrSo;
            //2. khởi tạo
            // arrSo = { 1,2,3} ;
            arrSo = new int[] { 1, 2, 3 };
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //khởi tạo 1 mảng có 1 phần tử là 5
            int[] arrNum = new int[]{5};
            //khởi tạo 1 mảng có kích thước gồm 5 phần tử
            int[] arrTuoi = new int[5];

            //3. gán giá trị cho mảng
            //vị trí mảng chạy từ  0 => n-1
            arrTuoi[0] = 10;
            arrTuoi[1] = 20;
            arrTuoi[2] = 34;
            arrTuoi[3] = 18;
            arrTuoi[4] = 7;

            //4. truy xuất phần tử
            Console.WriteLine($"arrTuoi[3] = {arrTuoi[3]}");

            //5. duyệt mảng
            //cách 1: for i
            //for tab
            Console.WriteLine($"length= {arrTuoi.Length}");
            for (int i = 0; i < arrTuoi.Length; i++)
            {
                Console.WriteLine($"arrTuoi[{i}] = {arrTuoi[i]}");
            }
            //cách 2: foreach
            Console.WriteLine("Cách 2: foreach ");
            //fore tab
            foreach (var tuoi in arrTuoi)
            {
                Console.WriteLine(tuoi);
            }
            ///-------------------------------------------------
            //THAO TÁC VỚI MẢNG
            /*
               * Thao tác với mảng
               *  ***Phương thức của Array
               *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
               *      + GetValue(index): lấy giá trị ở vị trí
               *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
               *      + GetLength(0): Trả ra số lượng phần tử trong mảng
               *      + Reverse(<mảng>): Đảo ngược mảng
               *      + Sort(Array): Sắp xếp mảng theo chiều tăng dần
               */
            string[] arrMonHoc = { "Java", "C#", "MKT", "English" };
            double[] arrDiemTrungBinh = { 8.2, 9.4, 7.3, 6.8 };

            Array.Sort(arrMonHoc);
            Array.Reverse(arrMonHoc);
            Console.WriteLine("Mang mon hoc");
            for (int i = 0; i < arrMonHoc.Length; i++)
            {
                Console.WriteLine(arrMonHoc[i]);
            }

           // Array.Sort(arrDiemTrungBinh);
            Array.Reverse(arrDiemTrungBinh);
            Console.WriteLine("Mang diem trung binh");
            foreach (var item in arrDiemTrungBinh)
            {
                Console.WriteLine(item);
            }


        }
    }
    //BTVN
}
