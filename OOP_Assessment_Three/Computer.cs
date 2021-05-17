using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    // Log file located at OOP_Assessment_Three\OOP_Assessment_Three\bin\Debug\netcoreapp3.1
    class Computer : Player
    {
        //The below will override the ID interger and return a value of 2 when called by a computer object.
        public override int ID
        {
            get { return ID = 2; }
        }
        // This constructor does the same as the Human class constructor but for this class. 
        public Computer(Deck deck)
        {
            BuildHand(deck);
        }
        // This method is an override of the abstract method in the player class, this is dynamic polymorphism, 
        // This is run when ever the computer takes their turn. and is practically identical to the play method in the human class. 
        public override void Play()
        {
            List<Card> CardsPlayed = new List<Card>();
            CardsPlayed.Clear();
            CardsPlayed.Add(HandList[0]);
            CardsPlayed.Add(HandList[1]);
            Total = CardsPlayed[0].cardNumber + CardsPlayed[1].cardNumber;
            Console.WriteLine("The computer has played the " + CardsPlayed[0].cardName + " and the " + CardsPlayed[1].cardName + "\nGiving them a total of " + Total + ".");
            File.AppendAllText("Log.txt", "Card 1 " + CardsPlayed[0].cardName + " Card 2 " + CardsPlayed[1].cardName + "\nTotal " + Total + ".\n");
            HandList.RemoveAt(0);
            HandList.RemoveAt(0);

        }
    }
}
