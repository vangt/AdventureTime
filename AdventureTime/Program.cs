using AdventureTime.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTime
{
    class Program
    {
        static void Main(string[] args)
        {
            StartingTown start = new StartingTown();
            Console.WriteLine("You wake up and your mother tells you to go outside to the park or something.  You've been in bed all day.");
            start.GetOutOfBed();
        }
    }
}