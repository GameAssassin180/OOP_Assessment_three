using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Three
{
    abstract class Player : Hand, IEquatable<Player>, IComparable<Player>
    {
        public virtual int ID() => 0;
        protected int Score;

        public int Total;
        public abstract void Play();
        public int ScoreSet
        {
            get { return Score; }
            set { Score = value; }
        }
        public bool Equals(Player total)
        {
            return this.Total == total.Total;
        }

        public int CompareTo(Player total)
        {
            if (this.Total < total.Total) return -1;
            if (this.Total > total.Total) return 1;
            return 0;
        }
    }
}
