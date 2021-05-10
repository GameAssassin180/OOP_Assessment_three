using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Program
    {
        static void DrawCatch(int human, int computer)
        {
            if (human == computer)
                throw new DrawException();
        }
        static int Add(int Score, int Temp)
        {
            return (Score + Temp + 1);
        }
        public void CreatedDeck()
        {
            Console.WriteLine("A deck has been shuffled!");
        }
        static void DrawClause(Deck deck, Player human, Player computer)
        {
            Random rnd = new Random();
            int card1 = rnd.Next(0, 32);
            int card2 = rnd.Next(0, 32);
            Card HCard = (deck.deckList[card1]);
            Card CCard = (deck.deckList[card2]);
            Console.WriteLine($"The last hand came out as a draw due to this 2 random cards will be picked." +
                $"\nThe bigger card value wins the game. ");
            Console.WriteLine("\nPress enter when ready...");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid key");
                    continue;
                }
            }
            Console.WriteLine("Your cards is: " + HCard.cardName);
            Console.WriteLine("The computer card is: " + CCard.cardName);
            try
            {
                DrawCatch(HCard.cardNumber, CCard.cardNumber);
            }
            catch (DrawException draw)
            {
                Console.WriteLine(draw.Message);
                DrawClause(deck, human, computer);
            }
            if (HCard.cardNumber.CompareTo(CCard.cardNumber) == -1)
            {
                Console.WriteLine("The computer has won.");
                computer.ScoreSet = computer.ScoreSet + 1;
            }
            else if (HCard.cardNumber.CompareTo(CCard.cardNumber) == 1)
            {
                Console.WriteLine("You have won well done.");
                human.ScoreSet = human.ScoreSet + 1 ;
            }
        }
        static void DrawClause(Deck deck)
        {
            Random rnd = new Random();
            int card1 = rnd.Next(0, 32);
            int card2 = rnd.Next(0, 32);
            Card HCard = (deck.deckList[card1]);
            Card CCard = (deck.deckList[card2]);
            Console.WriteLine($"The game came out as a draw due to this 2 random cards will be picked." +
                $"\nThe bigger card value wins the game. ");
            Console.WriteLine("\nPress enter when ready...");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid key");
                    continue;
                }
            }
            Console.WriteLine("Your cards is: " + HCard.cardName);
            Console.WriteLine("The computer card is: " + CCard.cardName);
            try 
            {
                DrawCatch(HCard.cardNumber, CCard.cardNumber);
            }
            catch(DrawException draw)
            {
                Console.WriteLine(draw.Message);
                DrawClause(deck);
            }
            if (HCard.cardNumber.CompareTo(CCard.cardNumber) == -1)
            {
                Console.WriteLine("The computer has won.");
            }
            else if (HCard.cardNumber.CompareTo(CCard.cardNumber) == 1)
            {
                Console.WriteLine("You have won well done.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Welcome to the card game, Lincoln. " +
                        $"\nThe rules are very basic you and the computer will be delt 10 cards from a shuffled deck," +
                        $"\nEach round you and the computer will draw 2 cards, the values of these cards will be added," +
                        $"\nWho ever has the highest total wins." +
                        $"\nPress the enter key to begin the game...");
                Deck deck = new Deck();
                Player human = new Human(deck);
                Player computer = new Computer(deck);
                int Rounds = 0;
                while (Rounds < 5)
                {
                    int TempScore = 0;
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        while(true)
                        {
                            if (Rounds < 5)
                            {
                                Console.WriteLine("");
                                human.Play();
                                Console.WriteLine("");
                                computer.Play();
                                if (human.Total.Equals(computer.Total))
                                {
                                    TempScore = 1;
                                    Console.WriteLine("\nBoth the score where the same the point has been carried.");
                                }
                                else if(human.Total.CompareTo(computer.Total) == 1)
                                {
                                    human.ScoreSet = Add(human.ScoreSet, TempScore);
                                    TempScore = 0;
                                    Console.WriteLine(("\nYou have won this round with " + human.Total + "."));
                                }
                                else if (human.Total.CompareTo(computer.Total) == -1)
                                {
                                    computer.ScoreSet = Add(computer.ScoreSet, TempScore);
                                    TempScore = 0;
                                    Console.WriteLine("\nBetter luck next time the computer won this round with " + computer.Total + ".");
                                }
                                Rounds++;
                                Console.WriteLine("The current score is (Computer:"+computer.ScoreSet + ", Human:" + human.ScoreSet + ").");
                                Console.WriteLine("\nPress enter again for next round...");
                                while (true)
                                {
                                    var keyPress = Console.ReadKey(true);
                                    if (keyPress.Key == ConsoleKey.Enter)
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid key");
                                        continue;
                                    }
                                }
                            }
                            else if (Rounds == 5)
                            {
                                Console.WriteLine("All hands have been played.");
                                if (TempScore == 1)
                                {
                                    DrawClause(deck, human, computer);
                                    break;
                                }
                                else if (human.ScoreSet.Equals(computer.ScoreSet))
                                {
                                    DrawClause(deck);
                                    break;
                                }
                                else if (human.ScoreSet.CompareTo(computer.ScoreSet) == 1)
                                {
                                    Console.WriteLine(human.ScoreSet + "/" + computer.ScoreSet +" Congratulations you have won!!");
                                    break;
                                }
                                else if (human.ScoreSet.CompareTo(computer.ScoreSet) == -1)
                                {
                                    Console.WriteLine(computer.ScoreSet + "/" + human.ScoreSet + " Sorry the computer beat you.");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid key");
                        continue;
                    }
                }
                Console.WriteLine("Would you like to play again Y/N? ");
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("Thank you for playing!! \nThe program will end in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        System.Environment.Exit(0);
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