using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    // Log file located at OOP_Assessment_Three\OOP_Assessment_Three\bin\Debug\netcoreapp3.1
    class Human : Player
    {
        //The below will override the ID interger and return a value of 1 when called by a human object.
        public override int ID
        {
            get { return ID = 1; }
        }
        // This is a constructor for the Human class when a new human object is created and passed a deck, it will build a hand for that object.
        // If we where to create a deck in this constructor 2 seperate deck would be created for each player this ensures that 1 deck is used for a game. 
        public Human(Deck deck)
        {
            BuildHand(deck); // Calls this method from the Hand class.
        }
        // This method is an override of the abstract method in the player class, this is dynamic polymorphism, 
        // This is run when ever the player takes their turn. 
        public override void Play()
        {
            List<Card> CardsPlayed = new List<Card>();
            CardsPlayed.Clear(); // Empties the players hand. 
            CardsPlayed.Add(HandList[0]);// Adds the first card from the players hand to the played space.
            CardsPlayed.Add(HandList[1]);// Adds the second card from the players hand to the played space.
            Total = CardsPlayed[0].cardNumber + CardsPlayed[1].cardNumber; // Sets the total that is created in the Player class. 
            Console.WriteLine("You have played the " + CardsPlayed[0].cardName + " and the " + CardsPlayed[1].cardName + "\nGiving you a total of " + Total + ".");
            File.AppendAllText("Log.txt", "Card 1 " + CardsPlayed[0].cardName + " Card 2 " + CardsPlayed[1].cardName + "\nTotal " + Total + ".\n");
            HandList.RemoveAt(0); // Removes the played card from the users hand.
            HandList.RemoveAt(0); // Removes the played card from the users hand.
        }
    }
}
