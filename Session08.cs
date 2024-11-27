using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class Session08
    {
        static void Main()
        {
            string s = "Converting null literal or possible null value to non-nullable type.";
            Console.WriteLine(s);
            //Console.WriteLine(length(s));
            //seperateCharacter(s);
            string s1 = "hello, nice to meet you";
            string s2 = "hallo";
            //Console.WriteLine(compare2Strings(s1,s2));
            string s3 = "mcjhe7838e/*dmjw";
            /*countCharacters(s3,out int chu, out int so, out int kyTuKhac);
            Console.WriteLine($"So ky tu so trong chuoi {so}");
            Console.WriteLine($"So ky tu chu trong chuoi {chu}");
            Console.WriteLine($"So ky tu khac trong chuoi {kyTuKhac}");*/

            //countVowelsAndConsonants(s,out int vowels, out int consonants);
            //Console.WriteLine($"So nguyen am trong chuoi {vowels}, so phu am {consonants}");
            string sub1 = "ull";
            //Console.WriteLine(findSubString(s,sub));
            findSubStringPos(s, sub1);

            /*Console.WriteLine("Nhap mot ky tu:");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            kiemTraKyTu(c);*/

            //Console.WriteLine("So lan xuat hien cua chuoi con la "+ soLanXuatHienChuoiCon(s,sub));

            string sub2 = "world";
            string search = ", ";
            insertSubString(s1, sub2,search);
            

        }

        static int length(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count++;
            }
            return count;
        }

        static void seperateCharacter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        static void printSeperatedStringInReverse(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        static int countWords(string s)
        {
            int count = 0;
            s = s.Trim();
            while (s.IndexOf(" ") != -1)
                s = s.Replace("  ", " ");
            foreach (char c in s)
                if (c == ' ')
                    count++;
            return count+1;
        }

        static int compare2Strings(string s1, string s2)
        {
            int min_len = s1.Length > s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < min_len; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return 0;
        }

        static void countCharacters(string s, out int chu, out int so, out int kyTuKhac)
        {
            chu = 0; 
            so = 0;
            kyTuKhac = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c)) so++;
                else if (char.IsLetter(c)) chu++;
                else kyTuKhac++;
            }
        }

        static void countVowelsAndConsonants(string s, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;
            s= s.ToLower();
            foreach (char c in s)
            {
                if ("ueoai".Contains(c)) vowels++;
                else consonants++;
            }
        }

        static int findSubString(string s,string sub)
        {
           if (s.IndexOf(sub)==-1) return 0;
           else return 1;
        }

        static void findSubStringPos(string s, string sub)
        {
            if (s.IndexOf(sub) == -1)
            {
                Console.WriteLine("chuoi con khong xuat hien trong chuoi");
            }
            else
            {
                int pos = s.IndexOf(sub);
                Console.WriteLine($"Chuoi con xuat hien lan dau tai vi tri {pos}");
            }
        }

        static void kiemTraKyTu(char c)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    Console.WriteLine("Ky tu la chu cai in hoa.");
                }
                else
                {
                    Console.WriteLine("Ky tu la chu cai in thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ky tu khong phai la chu cai.");
            }
        }

        static int soLanXuatHienChuoiCon(string s, string sub)
        {
            int count = 0;
            int index = s.IndexOf(sub);
            while (index !=-1)
            {
                count++;
                index = s.IndexOf(sub, index+sub.Length);
            }
            return count;
        }

        static void insertSubString(string s, string sub, string search) //chen mot chuoi vao vi tri xuat hien dau tien cua mot chuoi khac
        {
            int viTri = s.IndexOf(search);
            if (viTri != -1)
            {
                s = s.Insert(viTri, sub);
                Console.WriteLine($"Chuoi sau khi chen: {s}");
            }
            else
            {
                Console.WriteLine("Chuoi can tim khong ton tai trong chuoi chinh");
            }

        }


    }
}
