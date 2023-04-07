using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP123.Models
{
    // The [Flags] is neccessary otherwise the enum Genre numbers will
    // add into eachother and give a number output.
    [Flags]
    public enum Genre
    {
        Unrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64,
        Fantasy = 128,
        Animation = 256,
        Adventure = 512
    }
}
