using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Academy
{
    public static class QuestionMethods 
    {
        public static void QuestionFormat(string question, string answer1, string answer2, string answer3, string answer4)
        {
            Console.WriteLine($"\n\n\nQuestion: {question}\n");
            Console.WriteLine($"A) {answer1}");
            Console.WriteLine($"B) {answer2}");
            Console.WriteLine($"C) {answer3}");
            Console.WriteLine($"D) {answer4}\n");
        } 
        public static int AnswerA(string correctAnswer)
        {
            Console.WriteLine("Please enter the letter that corresponds to your answer and then press Enter.");
            for (var i = 0; i < 3; i++)
            {
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "a":
                        Console.WriteLine($"That is Correct! The Answer was: {correctAnswer}.\nYou have earned an additional point!");
                        return 1;
                    case "b":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "c":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "d":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    default:
                        Console.WriteLine("Invalid response. Please enter the letter that corresponds to your answer and then press Enter.");
                        continue;
                }
            }
            Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
            return 0;
        }
        public static int AnswerB(string correctAnswer)
        {
            Console.WriteLine("Please enter the letter that corresponds to your answer and then press Enter.");
            for (var i = 0; i < 100; i++)
            {
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "a":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "b":
                        Console.WriteLine($"That is Correct! The Answer was: {correctAnswer}.\nYou have earned an additional point!");
                        return 1;
                    case "c":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "d":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    default:
                        Console.WriteLine("Invalid response. Please enter the letter that corresponds to your answer and then press Enter.");
                        continue;
                }
            }
            return 0;
        }
        public static int AnswerC(string correctAnswer)
        {
            Console.WriteLine("Please enter the letter that corresponds to your answer and then press Enter.");
            for (var i = 0; i < 100; i++)
            {
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "a":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "b":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "c":
                        Console.WriteLine($"That is Correct! The Answer was: {correctAnswer}.\nYou have earned an additional point!");
                        return 1;
                    case "d":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    default:
                        Console.WriteLine("Invalid response. Please enter the letter that corresponds to your answer and then press Enter.");
                        continue;
                }
            }
            return 0;
        }
        public static int AnswerD(string correctAnswer)
        {
            Console.WriteLine("Please enter the letter that corresponds to your answer and then press Enter.");
            for (var i = 0; i < 3; i++)
            {
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "a":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "b":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "c":
                        Console.WriteLine($"That is Incorrect... The correct answer was: {correctAnswer}.");
                        return 0;
                    case "d":
                        Console.WriteLine($"That is Correct! The Answer was: {correctAnswer}.\nYou have earned an additional point!");
                        return 1;
                    default:
                        Console.WriteLine("Invalid response. Please enter the letter that corresponds to your answer and then press Enter.");
                        continue;
                }
            }
            return 0;
        }
    }
}