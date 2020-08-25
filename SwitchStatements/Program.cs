using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Do you have a favorite subject in school?");

            string schoolSubject = Console.ReadLine();

            // asking for user fave subject

            switch (schoolSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("That can add up!");
                    break;
                case "science":
                    Console.WriteLine("That can be a blast!");
                    break;
                case "history":
                    Console.WriteLine("That will be around for awhile!");
                    break;
                case "lunch":
                    Console.WriteLine("YASSSSSSS!");
                    break;

                default:
                    Console.WriteLine("Sounds like a good one!");
                    break;

            }

            Console.WriteLine("Well, That was FUN!!!");

        }
    }
}
