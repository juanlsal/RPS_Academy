using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Academy
{
    public class Player
    {
        public string Name { get; set; }

        public static string NameGetter()
        {
            Console.WriteLine("Hello there! Before we begin, please tell me your name so I know who I'm playing against.\n\n");
            Console.WriteLine("Your name:"); 
            var Name = Console.ReadLine();
            Console.WriteLine($"You typed '{Name}' if that is correct press Enter to confirm, if not enter 'N' to re-enter your name.");
            for (var i = 0; i < 3; i++)
            {
                string Answer = Console.ReadLine().ToUpper();
                switch (Answer)
                {
                    case "":
                        Console.WriteLine($"Name Set to '{Name}'!");
                        SelectionMethods.EnterClear();
                        return Name;

                    case "N":
                        Console.Clear();
                        return NameGetter();

                    default:
                        Console.WriteLine("Invalid input.\nPlease enter the letter that corresponds to your answer and then press Enter.");
                        continue;


                }
            }


            Console.Clear();
            return NameGetter();
        }
    }
}
