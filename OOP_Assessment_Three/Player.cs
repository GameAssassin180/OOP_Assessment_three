using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    //This is an Abstract class, it inherits from the Hand class as well as 2 built in interfaces. 
    abstract class Player : Hand, IEquatable<Player>, IComparable<Player>
    {
        // Private readonly means that this integer can only be read by this class. 
        private readonly int Id = 0;
        // By making this getting setting method virtual the child classes can override this to change the id number.
        public virtual int ID
        {
            get { return Id; }
            set {}
        }
        // This integer is protected, meaning that only this class and children of this class can access this variable.  
        protected int Score;
        // This getting and setting method can chnage the score of the above variable. 
        public int ScoreSet
        {
            get { return Score; }
            set { Score = value; }
        }
        // This integer is used as the total for each round. 
        public int Total;
        // This abstract method acts as a template, all child classes mush have this method. 
        public abstract void Play();

        // The bellow methods are from the inherited interfaces IEquatable<T> and IComparable<T>.
        // This one returns a boolean depending on weather 2 values are equal. 
        public bool Equals(Player total)
        {
            return this.Total == total.Total;
        }
        // This method returns an interger depending on weather 2 values are larger or smaller.
        public int CompareTo(Player total)
        {
            if (this.Total < total.Total) return -1;
            if (this.Total > total.Total) return 1;
            return 0;
        }
    }
}
