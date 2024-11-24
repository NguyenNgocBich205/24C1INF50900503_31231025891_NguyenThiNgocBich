using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

internal class Session02
{
    public static void Main()
    {
        //Session02_ex01();
        //Session02_ex02();
        //Session02_ex03();
        //Session02_ex04();
        //Session02_ex05();
        //Session02_ex06();
        //Session02_ex07();
        //Session02_ex08();
        //Session02_ex09();
        //Session02_ex10();
    
    }

    public static void Session02_ex01() //Tinh tong 2 so
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine("Tong hai so la: {0} + {1} = {2}", a, b, c);
        Console.ReadLine();
    }

    public static void Session02_ex02() //Hoan doi 2 so
    {
        Console.Write("Nhap so thu nhat (a): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai (b): ");
        int b = int.Parse(Console.ReadLine());
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("Sau khi hoan doi a = {0}, b = {1}", a, b);
        Console.ReadLine();
    }

    public static void Session02_ex03() //Nhan hai so float
    {
        Console.Write("Nhap so a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai (b): ");
        float b = float.Parse(Console.ReadLine());
        float c = a * b;
        Console.WriteLine($"{a} * {b} = {c}");
    }

    public static void Session02_ex04() //Doi feet sang met
    {
        Console.Write("Nhap so feet: ");
        float f = float.Parse(Console.ReadLine());
        double m = f * 0.3048;
        Console.WriteLine($"{f} feet = {m} m");
    }

    public static void Session02_ex05() //Doi do C sang do F va nguoc lai
    {
        Console.WriteLine("Chuowng trinh chuyen doi nhiet do");
        Console.WriteLine("1. Chuyen tu do C sang do F");
        Console.WriteLine("2. Chuyen tu do F sang do C");
        Console.Write("Chon che do <1/2>: ");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Nhap nhiet do bang do C: ");
                float C1 = float.Parse(Console.ReadLine());
                float F1 = (C1 * 9 / 5) + 32;
                Console.WriteLine($"{C1} do C = {F1} do F");
            break;
            case 2:
                Console.Write("Nhap nhiet do bang do F: ");
                float F2 = float.Parse(Console.ReadLine());
                float C2 = (F2 - 32) * 5/9;
                Console.WriteLine($"{C2} do C = {F2} do F");
            break;
            default:
                Console.WriteLine("Chuc nang da chon khong hop le");
            break;


        }
    }

    public static void Session02_ex06() //Kich thuoc cua kieu du lieu
    {
        Console.WriteLine("Kich thuoc cua int: {0}", sizeof(int));
        Console.WriteLine("Kich thuoc cua float: {0}", sizeof(float));
        Console.WriteLine("Kich thuoc cua double: {0}", sizeof(double));
        Console.WriteLine("Kich thuoc cua bool: {0}", sizeof(bool));
        Console.WriteLine("Kich thuoc cua long: {0}", sizeof(long));
    }

    public static void Session02_ex07() //Chuyen thanh ma ASCII
    {
        Console.Write("Nhap mot ky tu: ");
        char character = char.Parse(Console.ReadLine());
        int num = character;
        Console.WriteLine($"Ma ASCII cua {character} la {num}");
    }

    public static void Session02_ex08() //Tinh dien tich hinh tron
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        float r = float.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"Dien tich hinh tron la {area}");
    }

    public static void Session02_ex09() //Tinh dien tich hinh vuong
    {
        Console.Write("Nhap canh hinh vuong: ");
        float a = float.Parse(Console.ReadLine());
        double area = Math.Pow(a, 2);
        Console.WriteLine($"Dien tich hinh vuong la {area}");
    }

    public static void Session02_ex10() //Chuyen tu ngay sang nam, tuan, ngay
    {
        Console.Write("Nhap so ngay: ");
        int days = int.Parse(Console.ReadLine());
        int y = days / 365;
        int w = days % 365 / 7;
        int d = days - y * 365 - w * 7;
        Console.WriteLine($"{days} ngay = {y} nam {w} tuan {d} ngay");
    }

}



