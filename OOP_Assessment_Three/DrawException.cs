using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class DrawException : Exception
    {
        // Constructs a new exception with the corresponding message. 
        public DrawException() : base("Looks like the 2 card values where the same lets try again")
        {

        }
    }
}
