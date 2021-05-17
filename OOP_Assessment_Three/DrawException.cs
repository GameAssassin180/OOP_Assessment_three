using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    // Log file located at OOP_Assessment_Three\OOP_Assessment_Three\bin\Debug\netcoreapp3.1
    class DrawException : Exception
    {
        // Constructs a new exception with the corresponding message. 
        public DrawException() : base("Looks like the 2 card values where the same lets try again")
        {
            File.AppendAllText("Log.txt", "Looks like the 2 card values where the same lets try again\n");
        }
    }
}
