using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace String_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,4,6,8 };//như 1 mảng nhung không cần biết chiều dài
            list.RemoveAt(4);


            List<Sinhvien> sv = new List<Sinhvien>();//quan ly list Sinhvien1
            Sinhvien sv1 = new Sinhvien();
            sv1.Name = "Nguyen Van A";
            sv1.Age = 10;
            sv1.Birthday = "01/02/1996";
            sv.Add(sv1);

            Sinhvien sv2 = new Sinhvien();
            sv2.Name = "Nguyen Van AD";
            sv2.Age = 15;
            sv2.Birthday = "01/05/1996";
            sv.Add(sv2);

            int count = sv.Count();
            Console.WriteLine($"So luong sv:{count}");
            foreach (var item in sv)
            {
                Console.WriteLine($"{item.Name},{item.Age},{item.Birthday}");
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "ABC");


            //mang 2 chieu
            int[,] arr1 = new int[3, 5];
            int soDong = 3;
            int soCot = 4;
            int[,] mang = new int[soDong, soCot];
            for (int j=0; j<soDong; j++)
            {
                for (int k=0; k<soCot; k++)
                {
                    mang[j, k] = (j + 1) * k;//gan gia tri cho tung phan tu trong mang 2 chieu
                }
            }


            ///mang 1 chieu
            int[] arr = new int[] { 1, 2, 4, 6, 8, 7, 9 };
            for (int i=0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                if (arr[i] == 6)
                {
                    //Console.WriteLine(i);
                }
                
            }


            /*string s = DateTime.Now.ToString("dd/MM/yyyy");

            int num1 = 12;
            string hex = num1.ToString("X4");//ma hexa 4so


            char kytu1 = 'A';
            char kytu2 = 'B';
            //Console.WriteLine(kytu1.CompareTo(kytu2));//= 0,> 1, < la -1
            
            Char.ToUpper(kytu1);//chu thuong thanh chu hoa

            string link = @"C:\Users\phong\source\repos"; //= txt = "C:\\Users\\phong\source\repos"

            string txt = "barcode date time";
            string[] spl = txt.Split(' ');//tach ra thanh cac chuoi bỏ space ngược với .Join là gom lại
            foreach (var item in spl)
            {
                Console.WriteLine(item);
            }
            if(txt.Contains("name"))
            {
                Console.WriteLine("Write to PLC");
            }
            else
            {
                Console.WriteLine("Err");
            }
            //for (int k =0; k<text.Length; k++)
            //{
            //    Console.WriteLine(text[k]);
            //    Thread.Sleep(10);
            //}*/

            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
