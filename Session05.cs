using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session05
    {
        public static int maxOfThreeNumbers(int a, int b, int c) //ex01
        {
           return Math.Max(Math.Max(a,b),c);
            /*int max = a;
            if (b>max) { max = b; }
            if (c>max) { max = c; }
            return max;*/
        }

        public static long Factorial(int n) //ex02, tinh giai thua
        {
            if (n == 0||n==1) return 1;
            return n * Factorial(n - 1);
        }
        
        public static bool isPrime(int number) //ex03
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        public static void printPrimeNumberUnderN(int n) //ex04.1
        {
            for (int i = 2;i <= n;i++)
                if (isPrime(i))
                    Console.Write(i + ", ");
        }

        public static void printFirstNPrimeNumber(int n) //ex04.2
        {
            int so = 2;
            int dem = 0; 
            while (dem<n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + ", ");
                    dem++;
                }  
                so++;
            }
            
        }

        public static bool isPerfect(int n) //ex05.1
        {
            int sum = 0;
            for (int i = 1; i <= n/2 ; i++)
            {
                if (n % i == 0)
                    sum += i ;
            }
            return sum == n;
        }

        public static void printPerfectNumberUnderN(int n) //ex05.2
        {
            for (int i = 1;i<=n;i++)
                if (isPerfect(i))
                Console.Write(i +", "); 
        }

        public static bool isPangram(string str) //ex06: kiem tra pangram
                                             //pangram la mot chuoi sd tat ca cac ky tu trong bang chu cai it nhat 1 lan
        {
            str = str.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!str.Contains(c)) return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            //printFirstNPrimeNumber(100);

            /*Console.WriteLine("Nhap so de tinh giai thua: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {Factorial(n)}");*/

            /*Console.Write("Nhap so can kiem tra: ");
            int n = int.Parse(Console.ReadLine());
            if (isPerfect(n)) Console.WriteLine($"{n} la so hoan hao");
            else Console.WriteLine($"{n} khong la so hoan hao");*/

            //printPrimeNumberUnderN(100);

            //printPerfectNumberUnderN(1000);

            Console.Write("Nhap cau can kiem tra: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(isPangram(sentence) ? "Cau la Pangram": "Cau khong phai Pangram");
        }
    }
}
