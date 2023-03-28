using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Academy
{
    public class SelectionMethods
    {
        public static int NumPlayersPicker()
        {
            Console.WriteLine("Welcome to RPS Academy, the game that makes learning fun and engaging! In this game, you'll play rock-paper-scissors against\ndifferent opponents while learning new coding concepts along the way. Whether you're an experienced coder or a a recent beginner,\nRPS Academy has something for everyone. With each round, you'll not only improve your rock-paper-scissors skills but also expand\nyour knowledge in various subject areas. So put your game face on and get ready to learn, compete, and have fun!\n\n");
            Console.WriteLine("Are you planning to play by yourself or with another player?");
            Console.WriteLine("A) By myself.");
            Console.WriteLine("B) With another player.");
            Console.WriteLine("\nPlease enter the letter that corresponds to your answer and then press Enter.");
            for (var i = 0; i < 3; i++)
            {
                string Answer = Console.ReadLine().ToUpper();
                switch (Answer)
                {
                    case "A":
                        Console.WriteLine("1 Player Selected!");
                        return 1;

                    case "B":
                        Console.WriteLine("2 Players Selected!");
                        return 2;

                    default:
                        Console.WriteLine("Invalid input.\nPlease enter the letter that corresponds to your answer and then press Enter.");
                        continue;


                }
            }
            Console.Clear();
            return NumPlayersPicker();
        }
        public static void EnterClear()
        {
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Instructions()
        {
            Console.WriteLine("\n\nLets play!\n\nremember...\nR = Rock\nP = Paper\nS = Scissors\n\nSelect your attack then press Enter!");
        }
    }
}
