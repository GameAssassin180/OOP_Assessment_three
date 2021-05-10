using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Human : Player
    {
        public override int ID() => 1;

        public Human(Deck deck)
        {
            BuildHand(deck);
        }
        public override void Play()
        {
            List<Card> CardsPlayed = new List<Card>();
            CardsPlayed.Clear();
            CardsPlayed.Add(HandList[0]);
            CardsPlayed.Add(HandList[1]);
            Total = CardsPlayed[0].cardNumber + CardsPlayed[1].cardNumber;
            Console.WriteLine("You have played the " + CardsPlayed[0].cardName + " and the " + CardsPlayed[1].cardName + "\nGiving you a total of " + Total + ".");
            HandList.RemoveAt(0);
            HandList.RemoveAt(0);
        }
    }
}
