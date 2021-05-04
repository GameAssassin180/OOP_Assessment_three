using System;

namespace OOP_Assessment_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Deck deck = new Deck();
                Player human = new Human(deck);
                Player computer = new Computer(deck);
                Console.WriteLine($"Welcome to the card game lincoln. " +
                        $"\nThe rules are very basic you and the computer will be delt 10 cards from a shuffled deck," +
                        $"\nEach round you and the computer will draw 2 cards, the values of these cards will be added," +
                        $"\nWho ever has the highest total wins." +
                        $"\nPress the enter key to begin the game.");
                while (true)// starts a loop that will continue till the user is finished or the deck is empty.
                {
                    int Rounds = 1;
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        while(true)
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid key");
                        continue;
                    }
                }
            }
        }
    }
}