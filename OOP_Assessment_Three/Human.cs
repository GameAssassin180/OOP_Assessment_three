using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Human : Player
    {
        public override int ID() => 1;
        public override int Score() => 0;

        public Human()
        {
            GetHand();
        }
    }
}
