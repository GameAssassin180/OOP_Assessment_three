using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    class Card
    {
        // Below is an enum list of suits, an enum will keep these values constant and allow easier access then an array. 
        // Info gathered at https://www.w3schools.com/cs/cs_enums.asp.
        public enum cardType
        {
            Diamonds,
            Clubs,
            Hearts,
            Spades
        }
        // Below are some simple value setting methods. 
        public int cardNumber
        {
            get;
            set;
        }
        public cardType suit
        {
            get;
            set;
        }
        // The below method handles the picture cards such as the king by switching the value 13 with the word king. 
        public string pictureCards
        {
            get
            {
                string name = string.Empty; // Initiates a sting variable called name that has now value. 
                switch (cardNumber)
                {
                    case (14): // If the card number equals 1 this case is activated,
                        name = "Ace"; // the name variable is changed to Ace,
                        break; // and the code breaks. 
                               // The above is true for all below.
                    case (11):
                        name = "Jack";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (13):
                        name = "King";
                        break;
                    default: // If none of the above are activated this is run as the default,
                        name = cardNumber.ToString(); // the number is converted to a string so 2 become Two. 
                        break;
                }
                return name; // Returns the name varable. 
            }
        }
        // The below method creates the full name of the card. 
        public string cardName
        {
            get
            {
                return pictureCards + " of " + suit.ToString(); // concatinates the cards number or name and its suit before returning the variable. 
            }
        }
        // Below is the construtor for this class it has 2 arguments 1 relates the the cards number the other relates to the cards suit. 
        public Card(int number, cardType suit)
        {
            cardNumber = number + 1; // passes the arguments value to the cardNumber get set method before it is used. 
            this.suit = suit;
        }
    }
}
