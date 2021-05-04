using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Human : Player
    {
        public override int ID() => 1;
        public override int Score() => 0;

        public Human(Deck deck)
        {
            BuildHand(deck);
        }

        public override void Play()
        {
            List<Card> CardsPlayed = new List<Card>();
            CardsPlayed.Add(HandList[0]);
            CardsPlayed.Add(HandList[1]);
            int Total = CardsPlayed[0].cardNumber + CardsPlayed[1].cardNumber;
            Console.WriteLine("The player has played " + CardsPlayed[0].cardName + " and " + CardsPlayed[1].cardName + "\nGiving them a total of " + Total);
            HandList.RemoveAt(0);
            HandList.RemoveAt(0);
            CardsPlayed.RemoveAt(0);
            CardsPlayed.RemoveAt(0);
        }
    }
}
