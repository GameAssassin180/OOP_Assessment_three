using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Deck
    {
        // Below is a list of cards from the card class
        public List<Card> deckList = new List<Card>();
        // The below method will fill this list with 52 differnt cards.
        public void DeckFiller()
        {
            // the loop will run 52 times.
            for (int i = 0; i < 52; i++)
            {
                Card.cardType card = (Card.cardType)(Math.Floor((decimal)i / 13)); // this line of code here takes the loop number and divides it by 13, the maths function keeps this number a decimal,
                // this number is then used to index the enum list in the cards class for the cards suit. 
                int val = i % 13 + 1; // sets the number of time 13 can fit into the loop number to a variable. 
                deckList.Add(new Card(val, card));
            }
        }
        // The below method checks if the deck is empty if it is it closes the program. 
        public void IsEmpty()
        {
            Console.WriteLine("The deck is empty, the program will close in 5 seconds.");
            System.Threading.Thread.Sleep(5000);
            System.Environment.Exit(0);
        }
        // This method shuffles the deck.
        public void Shuffle()
        {
            for(int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int Location1 = rnd.Next(0, 52); // Generates a number between 0 and 51.
                int Location2 = rnd.Next(0, 52);
                if(Location1 == Location2)// Enusres that a card isn't swapped with itself.
                {
                    i--;
                    continue;
                }
                else
                {
                    // These four lines of code swap the 2 cards in the deck list. 
                    Card temp = deckList[Location1];
                    deckList[Location1] = deckList[Location2];
                    deckList[Location2] = temp;
                    continue;
                }
            }
        }
        // This method displays one crad to the user then removes it from the list of cards. 
        public void Deal()
        {
            Console.WriteLine(deckList[0].cardName);
            deckList.RemoveAt(0);
        }
        // This is the constructor for this class, whenever a new deck is created this is what will happen. 
        public Deck()
        {
            DeckFiller();
            Shuffle();
            Program P = new Program(); // Creates a new instance of the program class. 
            P.CreatedDeck(); // Runs the created deck method from the program class. 
        }
    }
}