using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP123.Models
{
    public class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"{this.Movie} \n" +
                   $" ~ Ticket Price: {this.Price:c2} \n" +
                   $" ~ Date: {this.Day} \n" +
                   $" ~ Time: {this.Time} \n" +
                   $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            // The "~~~" is to separate each output for easier viewing.
        }
    }
}
