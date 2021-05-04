using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    abstract class Player : Hand
    {
        public abstract int ID();
        public abstract int Score();

        public abstract void Play();
    }
}
