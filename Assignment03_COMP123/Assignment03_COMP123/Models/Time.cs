using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP123.Models
{
    public struct Time
    {
        private int _Hours;
        private int _Minutes;

        public int Hours
        {
            get { return _Hours; }
            private set { _Hours = value; }
        }
        public int Minutes
        {
            get { return _Minutes; }
            private set { _Minutes = value; }
        }

        public Time(int hours, int minutes = 0)
        {
            this._Hours = hours;
            this._Minutes = minutes;
        }

        public override string ToString()
        {
            if (Minutes < 10)
            {
                return $"[{this.Hours}:0{this.Minutes}]";
                // I know this is janky but it is the only way I could
                // think of adding a "0" infront of a single minute number...
            }
            else
                return $"[{this.Hours}:{this.Minutes}]";
        }

        static public bool operator ==(Time lhs, Time rhs)
        {
            // Converting the hours to minutes by multiplying by 60.
            // and adding the leftover minutes.
            int time_lhs = lhs.Hours * 60 + lhs.Minutes;
            int time_rhs = rhs.Hours * 60 + rhs.Minutes;

            // Returns a true or false if the difference is less than 15 minutes.
            return Math.Abs(time_lhs - time_rhs) < 15;
            // Needs Math.Abs = Absolute value otherwise C# rounds up
            // and incorrect true/false output when comparing two Times.
        }

        static public bool operator !=(Time lhs, Time rhs)
        {
            // Converting the hours to minutes by multiplying by 60
            // and adding the leftover minutes.
            int time_lhs = lhs.Hours * 60 + lhs.Minutes;
            int time_rhs = rhs.Hours * 60 + rhs.Minutes;

            // Returns a true or false if the difference is less than 15 minutes.
            // Same thing as above but opposite.
            return Math.Abs(time_lhs - time_rhs) > 15;
            // Needs Math.Abs = Absolute value otherwise C# rounds up
            // and gives incorrect true/false output when comparing two Times.
        }

        public override bool Equals(object obj)
        {
            // Returns false if obj is null or not Time type.
            if (obj is null || !(obj is Time))
            {
                return false;
            }

            // Creating a Time object to return.
            Time time_new = (Time)obj;

            return this.Hours == time_new.Hours && this.Minutes == time_new.Minutes;
        }

        public override int GetHashCode()
        {
            // C# required me to override GetHashCode().
            return Hours.GetHashCode() ^
                Minutes.GetHashCode();
        }
    }
}
