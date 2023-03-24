using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPS_Academy
{
    public class Opponent
    {
        public string Name { get; set; }

        public static void Description(int opponent)
        {
            switch (opponent)
            {
                case 1:
                    Console.WriteLine("Opponent: Novice Natalie");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Natalie is just starting out in the world of coding. She has a basic understanding of programming concepts and syntax, but is still learning the ropes.");
                    break;

                case 2:
                    Console.WriteLine("Opponent: Beginner Ben");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Ben has been coding for a few months now, and has a solid grasp of the basics. He's comfortable with basic programming\nconstructs like loops and conditionals, and is starting to work on more complex problems.");
                    break;

                case 3:
                    Console.WriteLine("Opponent: Junior Developer Julie");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Julie has been coding for about a year, and has worked on a few small projects. She's familiar with common programming languages\nlike Java and Python, and has a good understanding of object-oriented programming concepts.");
                    break;

                case 4:
                    Console.WriteLine("Opponent: Intermediate Isaac");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Isaac has been coding for a couple of years, and has worked on a variety of projects. He's comfortable with advanced\nprogramming concepts like recursion and dynamic programming, and is starting to dive into more complex data structures.");
                    break;

                case 5:
                    Console.WriteLine("Opponent: Advanced Amelia");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Amelia has been coding for several years, and has worked on both small and large-scale projects. She's familiar with a\nvariety of programming languages and has a strong understanding of algorithms and data structures.");
                    break;

                case 6:
                    Console.WriteLine("Opponent: Senior Developer Sam");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Sam has been coding for over a decade, and has worked on a variety of projects ranging from web development to machine\nlearning. They have a deep understanding of software architecture and are comfortable working with complex\nsystems.");
                    break;

                case 7:
                    Console.WriteLine("Opponent: Expert Ethan");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Ethan has been coding for over 15 years, and is considered an expert in their field. They have a deep understanding of\nprogramming languages, algorithms, and data structures, and have contributed to open source projects and published\nresearch in their field.");
                    break;

                case 8:
                    Console.WriteLine("Opponent: Masterful Morgan");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Morgan has been coding for over 20 years and is a master of their craft. They have an unparalleled understanding of\nsoftware development and have worked on some of the most complex systems in the industry.");
                    break;

                case 9:
                    Console.WriteLine("Opponent: Guru Giselle");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Giselle is a true coding guru. She has been coding for over 25 years, and has contributed to the development of programming\nlanguages and software tools. She's an expert in both theory and practice, and is a sought-after speaker and consultant\nin the industry.");
                    break;

                case 10:
                    Console.WriteLine("Opponent: Visionary Victor");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Victor is a coding visionary. He has been coding for over 30 years, and has been instrumental in the development of cutting-edge\ntechnologies like artificial intelligence and blockchain. He's a recognized thought leader in the industry and is widely\nrespected for his contributions.");
                    break;

                case 11:
                    Console.WriteLine("Opponent: Lengendary Lila");
                    Console.WriteLine("\n\nDescription:");
                    Console.WriteLine("Lila is a coding legend. She has been coding for over 35 years, and has contributed to the development of some of the most\ntransformative technologies of our time. She's a true pioneer in the industry, and her contributions have paved the way\nfor future generations of coders.");
                    break;
            }
        }

        public static int OpponentSelecter(string player1)
        {

            var selectableOpponents = new List<string> {"Novice Natalie", "Beginner Ben", "Junior Developer Julie", "Intermediate Isaac", "Advanced Amelia", "Senior Developer Sam", "Expert Ethan", "Masterful Morgan","Guru Giselle", "Visionary Victor", "Legendary Lila"};


            Console.WriteLine($"Nice to meet you, {player1}, welcome to RPS Academy! You will have the option to play against 11 different opponents\neach with varying levels of skill. Do you think you have what it takes to beat them all?\n\n\nPlease enter the number that corresponds to the opponent you wish to select then press Enter:\n ");
            Console.WriteLine($"1) {selectableOpponents[0]}\n2) {selectableOpponents[1]}\n3) {selectableOpponents[2]}\n4) {selectableOpponents[3]}\n5) {selectableOpponents[4]}\n6) {selectableOpponents[5]}\n7) {selectableOpponents[6]} \n8) {selectableOpponents[7]} \n9) {selectableOpponents[8]} \n10) {selectableOpponents[9]}\n11) {selectableOpponents[10]}");
            Console.WriteLine("\nSelect Opponent:");         
            int opponent = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"You have selected {selectableOpponents[opponent-1]}. if that is correct press Enter confirm, if not enter 'N' to re-select your opponent.");
            for (var i = 0; i < 3; i++)
            {
                string Answer = Console.ReadLine().ToUpper();
                switch (Answer)
                {
                    case "":
                        Console.WriteLine($"Opponent Set to '{selectableOpponents[opponent-1]}'. Good luck!");
                        SelectionMethods.EnterClear();
                        return opponent;

                    case "N":
                        Console.Clear();
                        return OpponentSelecter(player1);

                    default:
                        Console.WriteLine("Invalid input.\nPlease enter the number that corresponds to the opponent you wish to battle then press Enter.");
                        continue;


                    }
                }
                Console.Clear();
                return OpponentSelecter(player1);
            }
    }
}
