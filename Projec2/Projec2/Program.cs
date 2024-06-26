using System;
using System.Threading.Channels;

namespace Projec2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WritelineColorAndText(ConsoleColor.DarkBlue, "Hello to the Student's Grading System console app.");
            Console.WriteLine();

            bool StudentsGradingSystemApp = false;

            while (!StudentsGradingSystemApp)
            {
                Console.WriteLine();
                WritelineColorAndText(ConsoleColor.Cyan,
                    "1 - Add student's grades to the program memory and show statistics\n" +
                    "2 - Add student's grades to the .txt file and show statistics\n" +
                    "X - Close app\n");

                WritelineColorAndText(ConsoleColor.Yellow, "What you want to do? \nPress key 1, 2 or X: ");
                var UserAnswer = Console.ReadLine().ToUpper();

                switch (UserAnswer)
                {
                    case "X":
                        StudentsGradingSystemApp = true;
                        break;

                    default:
                        WritelineColorAndText(ConsoleColor.White, "Invalid operation.\n");
                        continue;
                }
            }
        }

        private static void WritelineColorAndText(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static string GetValueFromUserInput(string value)
        {
            WritelineColorAndText(ConsoleColor.Yellow, value);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}