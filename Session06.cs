using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session06
    {
        /// <summary>
        /// 1. Khai báo mảng với n phần tử, n nhập từ bàn phím
        /// 1.1 Enter item values for this array
        /// 1.2 Print the array to screen
        /// 1.3 Write a function that increase each item of the array by adding it with 2.
        /// 1.4 Print to screen again
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            /*NhapMang(a);
            Console.Write("Mang ban dau la: ");
            InMang(a);
            IncrementArrayBy2(a);
            Console.Write("\nMang sau khi tang moi phan tu len 2: ");
            InMang(a);*/

            generateRandomArray(a);
            InMang(a);
            Console.Write("\nNhap so can tim: ");
            int soCanTim = int.Parse(Console.ReadLine());
            //int pos = searchLinear(a, soCanTim);
            int pos = searchBinary(a, soCanTim);
            if (pos == -1)
                Console.WriteLine("So can tim khong xuat hien trong mang");
            else
                Console.WriteLine($"So can tim xuat hien o vi tri {pos}");
        }

        public static void NhapMang(int[] a)
        {
            Console.WriteLine("Nhap gia tri cac phan tu cua mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void InMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write($"{i}, ");
            }
        }

        public static void IncrementArrayBy2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += 2;
            }
        }

        /// <summary>
        /// Tìm một số có trong mảng hay không
        /// </summary>
        /// <param name="a">là mảng số nguyên</param>
        /// <param name="socantim">là số cần tìm trong mảng</param>
        /// <returns>Trả về: -1 nếu không tìm thấy, vị trí xuất hiện nếu tìm thấy
        /// </returns>

        public static void generateRandomArray(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
        }

        public static int searchLinear(int[] a, int soCanTim)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == soCanTim)
                    return i;
            }
            return -1;
        }

        public static int searchBinary(int[] a, int soCanTim)
        {
            Array.Sort(a);
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (soCanTim == a[mid])
                {
                    return mid;
                }
                else if (soCanTim < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
