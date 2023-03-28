using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Academy
{
    public static class Questions 
    {
        public static int Question1()
        {
            QuestionMethods.QuestionFormat("What type of Version Control System is git", "Distributed", "Centralized", "Instrsic", "None of the above");
            var answer = QuestionMethods.AnswerA("Distibuted");
            return answer;
        }

        public static int Question1_(int opponent)
        {
            QuestionMethods.QuestionFormat("What type of Version Control System is git", "Distributed", "Centralized", "Instrsic", "None of the above");
            var answer = Opponent.OpponentAnswer(opponent, "Distributed");
            return answer;
        }

        public static void Question2()
        {
            QuestionMethods.QuestionFormat("If we wanted to add ALL modified files to the staging area, what git command should we use?", "git add", "git add <filename>", "git add .", "git log");
            QuestionMethods.AnswerC("git add .");
        }
        public static void Question3()
        {
            QuestionMethods.QuestionFormat("________ is a hosting service for Git repositories?", "it-scm.com", "dotnet.microsft.com", "github.com", "none of the above");
            QuestionMethods.AnswerC("github.com");
        }

        public static void Question4()
        {
            QuestionMethods.QuestionFormat("Who created Git?", "Elon Musk", "Microsoft", "Google", "Linus Torvalds");
            QuestionMethods.AnswerD("Linus Torvalds");
        }
        public static void Question5()
        {
            QuestionMethods.QuestionFormat("This command initializes a new Git repository in the current directory:", "git init", "git commit", "git remote add orgin https://github.com/ ", "git initialize");
            QuestionMethods.AnswerA("git init");
        }

        public static void Question6()
        {
            QuestionMethods.QuestionFormat("A ______ is the Git equivalent of a \"save\"?", "commit", "push", "remote", "add .");
            QuestionMethods.AnswerA("commit");
        }

    }
}
