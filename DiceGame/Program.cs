using System;

namespace DiceGame
{
    class Program
    {
        static Random rdm = new Random();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your name");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("Hello, " + PlayerName);
            Console.WriteLine("Your opponent's name is Jork");
            do { 
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadLine();
                Console.Clear();
                int PlayerDice = rdm.Next(1, 7);
                int OppDice = rdm.Next(1, 7);
                Console.WriteLine("You rolled a " + PlayerDice);
                Console.WriteLine();
                Console.WriteLine("Jork rolled a " + OppDice);
                Console.WriteLine();

                if (PlayerDice > OppDice)
                {
                    Console.WriteLine("You win!");
                }
                else if (PlayerDice < OppDice)
                {
                    Console.WriteLine("Jork wins!");
                }
                else
                {
                    Console.WriteLine("You tied!");
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to play again?");
                Answer:
                string Again = Console.ReadLine();
                if (Again == "no") {
                    break;
                }
                else if(Again == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Please say yes or no");
                    goto Answer;
                }
            } while(true);
        }
    }
}
