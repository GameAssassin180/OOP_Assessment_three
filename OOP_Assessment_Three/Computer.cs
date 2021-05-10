using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Computer : Player
    {
        public override int ID() => 2;
        public Computer(Deck deck)
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
            Console.WriteLine("The computer has played the " + CardsPlayed[0].cardName + " and the " + CardsPlayed[1].cardName + "\nGiving them a total of " + Total + ".");
            HandList.RemoveAt(0);
            HandList.RemoveAt(0);

        }
    }
}
