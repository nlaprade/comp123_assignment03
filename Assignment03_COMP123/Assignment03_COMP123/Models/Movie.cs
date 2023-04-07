using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP123.Models
{
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; }

        public Movie(string name, int year, int length)
        {
            this.Title = name;
            this.Year = year;
            this.Length = length;

            this.Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            this.Cast.Add(actor);
            // Adding actor arguement to Cast List.
        }

        public void SetGenre(Genre genre)
        {
            this.Genre = genre;
        }

        public override string ToString()
        {
            return $" ~ {this.Title} \n" +
                   $" ~ Year: {this.Year} \n" +
                   $" ~ Duration: {this.Length} minute(s) \n" +
                   $" ~ Genre: {this.Genre} \n" +
                   $" ~ Cast: {string.Join(", ", this.Cast)}";
                    // Need string.Join to add all Cast entries. 
        }
    }
}
