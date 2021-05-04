using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Computer : Player
    {
        public override int ID() => 2;
        public override int Score() => 0;

        public Computer()
        {
            GetHand();
        }
    }
}
