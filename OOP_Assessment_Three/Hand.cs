﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Hand
    {
        public List<Card> HandList = new List<Card>();
        private Deck deck = new Deck();
        public void BuildHand()
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