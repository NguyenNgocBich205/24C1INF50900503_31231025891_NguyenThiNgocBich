using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session04
    {
        public static void Main()
        {
            //Session04_sample01();
            //Session04_sample02();
            //Session04_ex01();
            //Session04_ex02();
            //Session04_ex03();
            //Session04_ex04();
            //Session04_ex05();
            //Session04_ex06();
            //Session04_ex07_1();
            //Session04_ex07_2();
            Session04_ex10();

        }

        public static void Session04_sample01() //giai va bien luan pt bac 1: ax+b=0
        {
            Console.Write("Nhap he so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("x tuy y");
                else
                    Console.WriteLine("Vo ly");
            else
                if (b == 0)
                Console.WriteLine("x = 0");
            else
                Console.WriteLine("x = " + (-b / (float)a));
        }

        public static void Session04_sample02() //game doan so
        {
            do
            {
                //1. May nghi ngau nhien 1 so tu 1 den 10
                Random rnd = new Random();
                int compNum = rnd.Next(0, 10) + 1;
                //2. Hoi nguoi dung doan so
                //doan toi khi dung thi dung tro choi
                int count = 0;
                bool isContinue = true;
                //3. Kiem tra ket qua
                do
                {
                    count++;
                    Console.Write("Ban doan so may <1..10>: ");
                    int userNum = int.Parse(Console.ReadLine());
                    if (userNum == compNum)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (userNum > compNum)
                            Console.WriteLine("So ban doan lon hon so may nghi");
                        else
                            Console.WriteLine("So ban doan nho hon so may nghi");
                    }
                } while (isContinue);
                Console.WriteLine("================================");
                Console.Write("Thu lai? <C/K>: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Tro choi ket thuc");
                    return;
                }
            } while (true);
            
        } 

        public static void Session04_ex01() //kiem tra so chan, le
        {
            Console.Write("Nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("So da nhap la so chan");
            else
                Console.WriteLine("So da nhap la so le");
        }

        public static void Session04_ex02() //tim so lon nhat trong 3 so
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b>max)
                max = b;
            if (c>max)
                max = c;
            Console.WriteLine($"So lon nhat trong 3 so la {max}"); 
        }

        public static void Session04_ex03() //xac dinh toa do thuoc phan tu nao tren do thi
        {
            Console.Write("Nhap toa do mot diem:\nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Toa do thuoc phan tu thu nhat");
            else if (x < 0 && y > 0)
                Console.WriteLine("Toa do thuoc phan tu thu hai");
            else if (x < 0 && y < 0)
                Console.WriteLine("Toa do thuoc phan tu thu ba");
            else if (x > 0 && y < 0)
                Console.WriteLine("Toa do thuoc phan tu thu tu");
            else if (x == 0 && y == 0)
                Console.WriteLine("Toa do da cho la goc toa do");
            else
                Console.WriteLine("Toa do da cho nam tren truc toa do");
        }

        public static void Session04_ex04() //kiem tra tam giac la deu, can, hay khong can
        {
            Console.Write("Nhap canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giac da cho la tam giac deu");
            }
            else if (a == b || b == c || a==c)
            {
                Console.WriteLine("Tam giac da cho la tam giac can");
            }
            else
            {
                Console.WriteLine("Tam giac da cho la tam giac khong can");
            }
        }
    
        public static void Session04_ex05() //tinh tong va trung binh cua 10 so
        {
            int sum = 0;
            for (int i = 1; i<=10; i++)
            {
                Console.Write($"Nhap so thu {i}: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10.0;
            Console.WriteLine($"Tong 10 so la: {sum}");
            Console.WriteLine($"Trung binh 10 so la: {average}");
        }

        public static void Session04_ex06() //bang cuu chuong
        {
            Console.Write("Nhap so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;i<=10;i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }

        public static void Session04_ex07_1() //hien thi so theo mau hinh tam giac
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Session04_ex07_2() //hien thi so lien tiep theo mau tam giac
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        public static void Session04_ex08() //tong cua chuoi dieu hoa
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i<=n; i++)
            {
                sum += (double)1/i;
                Console.Write($"1/{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua chuoi dieu hoa la: {sum}");
        }

        public static void Session04_ex09()  //tim so hoan hao
        {
            Console.Write("Nhap khoang so bat dau: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Nhap khoang so ket thuc: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i<=end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;
        } //kiem tra so hoan hao

        public static void Session04_ex10() //kiem tra so nguyen to
        {
            Console.Write("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to");
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) 
                    return false;
            }
            return true;
        }
    }
}



   

