using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session07
    {
        public static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols];
            TaoMangNgauNhien(a, rows, cols);
            XuatMang(a);
            /*Console.Write("Nhap dong can xuat: "); int rowToPrint = int.Parse(Console.ReadLine()) - 1;
            Xuat1Dong(a, rowToPrint);
            Console.Write("\nNhap cot can xuat: "); int colToPrint = int.Parse(Console.ReadLine()) - 1;
            Xuat1Cot(a, colToPrint);*/
            Console.WriteLine();
            /*int[,] MTChuyenVi = maTranChuyenVi(a, rows, cols);
            XuatMang(MTChuyenVi);*/
            Console.Write("Nhap so can tim: ");
            int soCanTim = int.Parse(Console.ReadLine());
            TimKiemPhantu(a, soCanTim);


        }

        static void NhapMang(int[,] a, int rows, int cols)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                    //int x = int.Parse(Console.ReadLine());
                    //a[i, j] = x;
                }
            }
        }

        static void TaoMangNgauNhien(int[,] a, int rows, int cols)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }

        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Xuat1Dong(int[,] a, int rowToPrint)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[rowToPrint, j] + "\t");
            }
        }

        static void Xuat1Cot(int[,] a, int colToPrint)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine(a[i, colToPrint] + "\n");
            }
        }

        static int findMax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }
            return max;
        }

        static void findMinInRow(int[,] a)
        {
            int min = a[0, 0];
            Console.Write("Nhap dong can tim Min: ");
            int dong = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (dong - 1 == i)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat cua dong {dong} la: {min}");
        }

        static void findMinInCol(int[,] a)
        {
            int min = a[0, 0];
            Console.Write("Nhap cot can tim Min: ");
            int cot = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (cot - 1 == j)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat cua cot {cot} la: {min}");
        }

        static int[,] maTranChuyenVi(int[,] a, int rows, int cols)
        {
            int[,] MTChuyenVi = new int[cols, rows];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                { MTChuyenVi[j, i] = a[i, j]; }
            }
            return MTChuyenVi;

        }

        static void TimKiemPhantu(int[,] a, int soCanTim)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == soCanTim)
                    {
                        Console.WriteLine($"{soCanTim} xuat hien tai dong {i} cot {j}\n");
                    }
                }
            }

        }

        


    }
}
