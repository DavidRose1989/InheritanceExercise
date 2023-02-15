using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal 
    {
        public bool AreSnakes { get; set; }
        public string Name { get; set; }

        public bool IsHidden { get; set; }

        public bool HasScales { get; set; }


        public void Print()             //Anytime there is a void return type the always use console.writeline
        {
            Console.WriteLine("Listen to the story of my long lost friend");
            Console.WriteLine();
            Console.WriteLine($"This snake is a {Name} and it is {IsHidden} that he has no feet. I know that is crazy but that's what makes it {AreSnakes} that he is a snake. Oh I forgot that it's {HasScales} \n " +
                $"they have scales");
        }

    }
}
