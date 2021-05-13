using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Program
    {
        // This method allows access to the custom exception DrawException if triggered it will throw the exception.
        static void DrawCatch(int human, int computer)
        {
            if (human == computer)
                throw new DrawException(); // Creates a new exception object.
        }
        // The below method adds a point to the users score if they win. 
        static int Add(int Score, int Temp)
        {
            return (Score + Temp + 1);
        }
        // If a deck is created this method is run informing the user of this.
        public void CreatedDeck()
        {
            Console.WriteLine("A deck has been shuffled!");
        }
        // The bellow 2 methods are named the same but passed different arguments, this is static polymorphism. 
        // Both pick a random card from the deck and display it to the users, the bigger card wins the hand. 
        // This method handels if the last game is a draw and awards a point to the who ever wins. 
        static void DrawClause(Deck deck, Player human, Player computer)
        {
            // Creates 2 random numbers. 
            Random rnd = new Random();
            int card1 = rnd.Next(0, 32); // 32 as a deck has 52 cards and after 2 players have drawn 10 cards that how many is left.
            int card2 = rnd.Next(0, 31); // The second card is drawn from a deck with 1 less card in it hence 31. 
            Card HCard = (deck.deckList[card1]); // Gives the one random card to variable
            deck.deckList.RemoveAt(card1);// Removes that card from the deck. 
            Card CCard = (deck.deckList[card2]);
            deck.deckList.RemoveAt(card2);
            // Informs the user whats happened. 
            Console.WriteLine($"The last hand came out as a draw due to this 2 random cards will be picked." +
                $"\nThe bigger card value wins the game. ");
            Console.WriteLine("\nPress enter when ready...");
            // Loops until the user pressed enter no other key will be accepted. 
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid key, Please press enter...");
                    continue;
                }
            }
            // Infroms the user what cards have been drawn from the deck.
            Console.WriteLine("Your cards is: the " + HCard.cardName);
            Console.WriteLine("The computer card is: the " + CCard.cardName);
            // Sees if the 2 random cards have the same value. if they do throws an exception and recalls the function. 
            try
            {
                DrawCatch(HCard.cardNumber, CCard.cardNumber);
            }
            catch (DrawException draw)
            {
                Console.WriteLine(draw.Message);
                // Puts the cards back into the deck. 
                deck.deckList.Add(HCard);
                deck.deckList.Add(CCard);
                DrawClause(deck, human, computer);
            }
            // Sellects whose won the draw. 
            if (HCard.cardNumber.CompareTo(CCard.cardNumber) == -1)
            {
                Console.WriteLine("The computer has won.");
                computer.ScoreSet = computer.ScoreSet++;
            }
            else if (HCard.cardNumber.CompareTo(CCard.cardNumber) == 1)
            {
                Console.WriteLine("You have won well done.");
                human.ScoreSet = human.ScoreSet++;
            }
        }
        // This method handels if the game is overall a draw and who ever wins this wins the game over all. 
        static void DrawClause(Deck deck)
        {
            // Same ass above method with changed recursion and text to fit situation. 
            Random rnd = new Random();
            int card1 = rnd.Next(0, 32);
            int card2 = rnd.Next(0, 31);
            Card HCard = (deck.deckList[card1]);
            deck.deckList.RemoveAt(card1);
            Card CCard = (deck.deckList[card2]);
            deck.deckList.RemoveAt(card2);
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
                    Console.WriteLine("Invalid key, Please press enter...");
                    continue;
                }
            }
            Console.WriteLine("Your cards is: the " + HCard.cardName);
            Console.WriteLine("The computer card is: the " + CCard.cardName);
            try 
            {
                DrawCatch(HCard.cardNumber, CCard.cardNumber);
            }
            catch(DrawException draw)
            {
                Console.WriteLine(draw.Message);
                deck.deckList.Add(HCard);
                deck.deckList.Add(CCard);
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

        static void Main()
        {
            // Starts a loop in which the game will run until the user wishes to exit. 
            while (true)
            {
                // Explains the rules to the user. 
                Console.WriteLine($"Welcome to the card game, Lincoln. " +
                        $"\nThe rules are very basic you and the computer will be delt 10 cards from a shuffled deck," +
                        $"\nEach round you and the computer will draw 2 cards, the values of these cards will be added," +
                        $"\nWho ever has the highest total wins." +
                        $"\nPress the enter key to begin the game...");
                // Instantiates three new objects, Deck, Human and Computer.  
                Deck deck = new Deck();
                Player human = new Human(deck);
                Player computer = new Computer(deck);
                // Starts a count to make sure only 5 games are played. 10 cards per hand / 2 cards played each turn = 5 rounds.  
                int Rounds = 0;
                while (Rounds < 5)
                {
                    // Sets the temporay score to 0, this will be used later if a game results in a draw.  
                    int TempScore = 0;
                    // Sets the Winner ID to 1, this will be used to decide who plays first each round. 
                    int WinnerID = 1;
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        while(true)
                        {
                            // If the round count is less the 5 this runs. 
                            if (Rounds < 5)
                            {
                                if (WinnerID == 1)
                                {
                                    // Player goes frist then computer.
                                    Console.WriteLine("");
                                    human.Play();
                                    Console.WriteLine("");
                                    computer.Play();
                                }
                                else if (WinnerID == 2)
                                {
                                    // Computer goes frist then player.
                                    Console.WriteLine("");
                                    computer.Play();
                                    Console.WriteLine("");
                                    human.Play();
                                }
                                // This if statment makes the decision on who won the round. 
                                if (human.Total.Equals(computer.Total))
                                {
                                    // If the totals where the same the point is carried.
                                    TempScore = 1;
                                    Console.WriteLine("\nBoth the score where the same the point has been carried.");
                                }
                                else if(human.Total.CompareTo(computer.Total) == 1)
                                {
                                    // If the players total is greater then the users the user gets a point. 
                                    human.ScoreSet = Add(human.ScoreSet, TempScore);
                                    TempScore = 0;
                                    WinnerID = human.ID;
                                    Console.WriteLine(("\nYou have won this round with " + human.Total + "."));
                                }
                                else if (human.Total.CompareTo(computer.Total) == -1)
                                {
                                    // If the computer total is greater the computer gets a point. 
                                    computer.ScoreSet = Add(computer.ScoreSet, TempScore);
                                    TempScore = 0;
                                    WinnerID = computer.ID;
                                    Console.WriteLine("\nBetter luck next time the computer won this round with " + computer.Total + ".");
                                }
                                // Increases the round count by one. 
                                Rounds++;
                                // Tells the user the current score before allowing them to continue. 
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
                                        Console.WriteLine("Invalid key, Please press enter...");
                                        continue;
                                    }
                                }
                            }
                            // If the round count equals 5 this runs to pick the game winner. 
                            else if (Rounds == 5)
                            {
                                // Tells the user that all cards have been played.
                                Console.WriteLine("All cards have been played.");
                                if (TempScore == 1)
                                {
                                    // This will happen if the last game is a draw.
                                    DrawClause(deck, human, computer);
                                    break;
                                }
                                else if (human.ScoreSet.Equals(computer.ScoreSet))
                                {
                                    // This will happen if the game over all is a draw. 
                                    DrawClause(deck);
                                    break;
                                }
                                else if (human.ScoreSet.CompareTo(computer.ScoreSet) == 1)
                                {
                                    // If the player wins this message is displayed.
                                    Console.WriteLine(human.ScoreSet + "/" + computer.ScoreSet +" Congratulations you have won!!");
                                    break;
                                }
                                else if (human.ScoreSet.CompareTo(computer.ScoreSet) == -1)
                                {
                                    // If the computer wins this message is displayed. 
                                    Console.WriteLine(computer.ScoreSet + "/" + human.ScoreSet + " Sorry the computer beat you.");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid key, Please press enter...");
                        continue;
                    }
                }
                // Asks the user if they would like to play again.
                Console.WriteLine("Would you like to play again Y/N? ");
                while (true)
                {
                    // This will only accept the inputs of Y and N.
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Y)
                    {
                        // If Y key is pressed the game starts again. 
                        Console.Clear();
                        break;
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        // If the N key is pressed the game closes with no problems.
                        Console.WriteLine("Thank you for playing!! \nThe program will end in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        // Tells the user they have entered the wrong key. 
                        Console.WriteLine("Invalid key, Please press Y to continue or N to close the game...");
                        continue;
                    }
                }
            }
        }
    }
}