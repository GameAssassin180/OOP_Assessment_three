using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    // Log file located at OOP_Assessment_Three\OOP_Assessment_Three\bin\Debug\netcoreapp3.1
    class Hand
    {
        //This instatiates a list full of Card objects.
        public List<Card> HandList = new List<Card>();
        //The below method fills the above list with 10 cards and removes them from the deck.
        //A deck object has to be created first and passed to the method.
        protected void BuildHand(Deck deck)
        {
            HandList.Clear();
            File.AppendAllText("Log.txt", "\n");
            for (int i = 0; i < 10; i++)
            {
                Card Draw = deck.deckList[0];
                HandList.Add(Draw);
                File.AppendAllText("Log.txt",Draw.cardName + "\n");
                deck.deckList.RemoveAt(0);
            }
        }
    }
}
