using QuizBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MILLIONAIRE QUIZ");
            Game game = new Game();
            var question = game.GetQuestion();
            DisplayQuestion(question);
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes. Your answer is correct. Congratulations.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, it is not a proper answer");
                Console.WriteLine("GAME OVER");
            }

            Console.ReadLine();
        }

        static void DisplayQuestion(Question question)
        {
            Console.WriteLine();
            Console.WriteLine($"Question for {question.Category}");
            Console.WriteLine(question.Text);
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($"{answer.Id}. {answer.Text}");
            }

            Console.WriteLine();
            Console.Write("Please enter the number of answer: 1, 2, 3 or 4 =>  ");
        }
    }
}

