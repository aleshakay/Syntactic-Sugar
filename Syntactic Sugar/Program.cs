using System;
using System.Collections.Generic;

namespace Syntactic_Sugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome All You Bugs");
            var rabbitPrey = new List<string>()
            {
                "foxes",
                "cats"
            };

            var rabbitPreditors = new List<string>()
            {
                "foxes",
                "cats"
            };

            var bugs = new Bugs("Alesha", "mammels", rabbitPrey, rabbitPreditors);
            Console.WriteLine(bugs.Eat("cake"));
        }
    }
}
