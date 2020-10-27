using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What was your favorite subject in high school?");
            var response = Console.ReadLine(); 
            switch (response.ToLower())
            {
                case "english":
                    Console.WriteLine("Hated it, and still don't speak English correctly");
                    break;
                case "health":
                    Console.WriteLine("Gym Rat!!");
                    break;
                case "chemistry":
                    Console.WriteLine("I enjoyed the formulas, reminded me of math.");
                    break;
                case "history":
                    Console.WriteLine("What a bore!");
                    break;
                case "math":
                    Console.WriteLine("Math was my favorite also!!");
                    break;

                default:
                    Console.WriteLine("Never taken that class");
                    break;
            }
        }
    }
}
