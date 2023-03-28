using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Academy
{
    public class Battle
    {
        public static void ScoreBoard(int winPoint, string player1, int scoreOfPlayer1, string opponentName, int scoreOfOpponent)
        {
            Console.WriteLine($"Scoreboard - First to {winPoint} points:");
            Console.WriteLine($"{player1}: {scoreOfPlayer1}");
            Console.WriteLine($"{opponentName}: {scoreOfOpponent}");
        }
        public static string Player1Attack()
        {
            var myAttack = Console.ReadLine().ToUpper();
            switch (myAttack)
            {
                case "R":
                    Console.WriteLine("You have selected... ROCK");
                    return "R";
                case "P":
                    Console.WriteLine("You have selected... PAPER");
                    return "P";
                case "S":
                    Console.WriteLine("You have selected... SCISSORS");
                    return "S";
                default:
                    return Player1Attack();
            }
        }
        public static string OpponentAttack()
        {
            var options = new int[3] { 1, 2, 3 };
            Random rand = new Random();
            int opponentAttack = options[rand.Next(options.Length)];
            switch (opponentAttack)
            {
                case 1:
                    Console.WriteLine("Your opponent has selected... ROCK!");
                    return "R";
                case 2:
                    Console.WriteLine("Your opponent has selected... PAPER!");
                    return "P";
                case 3:
                    Console.WriteLine("Your opponent has selected... SCISSORS!");
                    return "S";
                default:
                    return OpponentAttack();
            }
        }
        public static int Dual(string opponentAttack, string player1Attack)
        {
            switch (player1Attack)
            {
                case "R":
                    switch (opponentAttack)
                    {
                        case "R":
                            Console.WriteLine("It's a... DRAW!");
                            return 0;

                        case "P":
                            Console.WriteLine("Paper beats Rock... You LOST!");
                            return 2;

                        case "S":
                            Console.WriteLine("Rock beats Scissors... You WON!\n\nYou now have the opportunity to answer a question for the chance to get an additional point.\nBe careful an incorrect answer will allow your opponent to answer the question for a point on their own! ");
                            return 1;

                        default:
                            return 0;
                    }
                case "P":
                    switch (opponentAttack)
                    {
                        case "R":
                            Console.WriteLine("Paper beats Rock... You WON!\n\nYou now have the opportunity to answer a question for the chance to get an additional point.\nBe careful an incorrect answer will allow your opponent to answer the question for a point on their own!");
                            return 1;

                        case "P":
                            Console.WriteLine("It's a... DRAW!");
                            return 0;

                        case "S":
                            Console.WriteLine("Scissors beat Paper... You LOST!");
                            return 2;

                        default:
                            return 0;
                    }

                case "S":
                    switch (opponentAttack)
                    {
                        case "R":
                            Console.WriteLine("Rock beats Scissors... You LOST!");
                            return 2;

                        case "P":
                            Console.WriteLine("Scissors beat Paper... You WON!\n\nYou now have the opportunity to answer a question for the chance to get an additional point.\nBe careful an incorrect answer will allow your opponent to answer the question for a point on their own!");
                            return 1;

                        case "S":
                            Console.WriteLine("It's a... DRAW!");
                            return 0;

                        default:
                            return 0;
                    }
                default: return 0;

            }
        }
    }
}
