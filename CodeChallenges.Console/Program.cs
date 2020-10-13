using CodeChallenges.ConsoleUI.Challenges;
using System;

namespace CodeChallenges.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number= ");
            var input = Console.ReadLine();
            var armstrong = new ArmstrongNumber();

            var isArmstrong = armstrong.Calculate(input);

            if(isArmstrong)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}
