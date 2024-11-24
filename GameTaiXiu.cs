using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _31231025891_NGUYEN_THI_NGOC_BICH
{
    internal class GameTaiXiu
    {
        static int rollDice()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(6) + 1;
            int dice2 = rnd.Next(6) + 1;
            int dice3 = rnd.Next(6) + 1;
            int sumOfDice = dice1 + dice2 + dice3;
            return sumOfDice;
        }

        static void playOneRound()
        {
            int compDice = rollDice();
            Console.Write("Ban doan Tai hay Xiu <T/X>: ");
            string userGuessing = Console.ReadLine();
            if (userGuessing.ToUpper().Equals("T"))
            {
                if (compDice >= 10)
                    Console.WriteLine("Ban thang");
                else
                    Console.WriteLine("Ban thua");
            }
            else if (userGuessing.ToUpper().Equals("X"))
            {
                if (compDice < 10)
                    Console.WriteLine("Ban thang");
                else
                    Console.WriteLine("Ban thua");
            }
            else
            {
                Console.WriteLine("Vui long chon dung");
            }
        }

        static void gameEngine()
        {
            do
            {
                playOneRound();
                Console.Write("Ban choi nua khong <C/K>: ");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            } while (true);
            Console.WriteLine("Tro choi ket thuc");
        }

        public static void Main()
        {
            gameEngine();
        }
    }
}
