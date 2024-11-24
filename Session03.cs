using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session03
    {
        public static void Main()
        {
            //Session03_ex01();
            //Session03_ex02();
            //Session03_ex03();
            //Session03_ex04();
            //Session03_ex05();
            //Session03_ex06();
            Session03_ex07();

        }

        public static void Session03_ex01() //doi tu do C sang do F va do K
        {
            Console.Write("Nhap do C: ");
            int celcius = int.Parse(Console.ReadLine());
            int kelvin = celcius + 273;
            int fahrenheit = celcius * 18 / 10 + 32;
            Console.WriteLine($"{celcius} do C bang {kelvin} do K va bang {fahrenheit} do F");
            Console.ReadKey();
        }

        public static void Session03_ex02() //tinh dien tich mat cau va the tich khoi cau 
        {
            Console.Write("Nhap ban kinh khoi cau: ");
            int r = int.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich mat cau la {surface:F2} va the tich khoi cau la {volume:F2}");
            Console.ReadKey();
        }

        public static void Session03_ex03() //thuc hien cac phep tinh voi 2 so nguoi dung nhap 
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
            Console.ReadKey();
        }

        public static void Session03_ex04() //chuong trinh cho nguoi dung lua chon chuc nang tinh 
        {
            Console.Write("Nhap so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("1. Thuc hien phep cong");
            Console.WriteLine("2. Thuc hien phep tru");
            Console.WriteLine("3. Thuc hien phep nhan");
            Console.WriteLine("4. Thuc hien phep chia");
            Console.WriteLine("5. Thuc hien phep chia lay du");
            Console.Write("Chon chuc nang <1..5>: ");
            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    else
                        Console.WriteLine("Khong the thuc hien phep chia cho 0");
                    break;
                case 5:
                    if (b != 0)
                        Console.WriteLine($"{a} % {b} = {a % b}");
                    else
                        Console.WriteLine("Khong the thuc hien phep chia lay du cho 0");
                    break;
                default:
                    Console.WriteLine("Chuc nang da chon khong hop le");
                    return;
            }


        }

        public static void Session03_ex05() //hien thi gia tri ham x = y^2 + 2y + 1 voi y nguyen tu -5 den 5
        {
            Console.WriteLine("Gia tri cua ham y^2 + 2y + 1 voi y nguyen tu -5 den 5: ");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }

        public static void Session03_ex06() //nhap khoang cach va thoi gian, hien thi van toc theo km/h va miles/h
        {
            Console.Write("Nhap khoang cach (km): ");
            float distance = float.Parse(Console.ReadLine());
            Console.Write("Nhap so gio: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Nhap so phut: ");
            int mins = int.Parse(Console.ReadLine());
            Console.Write("Nhap so giay: ");
            int secs = int.Parse(Console.ReadLine());
            float timeInHours = hours + (float)mins / 60 + (float)secs / 3600;
            float speedKmH = distance / timeInHours;
            double speedMilesH = speedKmH * 0.6214;
            Console.WriteLine($"Van toc la {speedKmH:F2} km/h");
            Console.WriteLine($"Van toc la {speedMilesH:F2} miles/h");
        }

        public static void Session03_ex07() //kiem tra ky tu la nguyen am, chu so hay ky tu khac
        {
            Console.Write("Nhap mot ky tu: ");
            char userChar = char.Parse(Console.ReadLine());
            if ("ueoaiUEOAI".IndexOf(userChar) >= 0) //index of dung de tim vi tri cua ky tu trong chuoi, bat dau tu 0..n, neu ky tu khong xuat hien tra ve -1
                Console.WriteLine("Ky tu da nhap la mot nguyen am");
            else if (char.IsDigit(userChar))
                Console.WriteLine("Ky tu da nhap la mot chu so");
            else
                Console.WriteLine("Ky tu da nhap la mot ky tu khac");
        }
    }
}
