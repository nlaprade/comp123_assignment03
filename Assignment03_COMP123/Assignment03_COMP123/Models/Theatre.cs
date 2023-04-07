using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP123.Models
{
    public class Theatre
    {
        private List<Show> _Shows;

        public List<Show> Shows
        {
            get { return this._Shows; }
            set { this._Shows = value; }
        }
        public string Name { get; }

        public Theatre(string name)
        {
            this.Name = name;

            this.Shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            // This adds shows to the Theatre object.
            this.Shows.Add(show);
        }

        public void PrintShows()
        {
            // Simple foreach loop to output each show stored in the List<Show>
            foreach (var i in Shows)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintShows(Genre genre)
        {
            // Simple foreach loop to output each show with a Genre arugement.
            foreach (var i in Shows)
            {
                if (i.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintShows(Day day)
        {
            // Simple foreach loop to output each show with a Day arugement.
            foreach (var i in Shows)
            {
                if (i.Day == day)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintShows(Time time)
        {
            // Simple foreach loop to output each show with a Time arugement.
            foreach (var i in Shows)
            {
                if (i.Time == time)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintShows(string actor)
        {
            // Simple foreach loop to output each show with an Actor arugement.
            foreach (var i in Shows)
            {
                if (i.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            // Simple foreach loop to output each show with a Day and Time arugement.
            foreach (var i in Shows)
            {
                if (i.Time == time && i.Day == day)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
