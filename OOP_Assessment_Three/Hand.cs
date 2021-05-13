using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Hand
    {
        //This instatiates a list full of Card objects.
        public List<Card> HandList = new List<Card>();
        //The below method fills the above list with 10 cards and removes them from the deck.
        //A deck object has to be created first and passed to the method.
        protected void BuildHand(Deck deck)
        {
            HandList.Clear();
            for (int i = 0; i < 10; i++)
            {
                Card Draw = deck.deckList[0];
                HandList.Add(Draw);
                deck.deckList.RemoveAt(0);
            }
        }
    }
}
