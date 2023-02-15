using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal 
    {
        public bool HaveWings { get; set; }

        public bool CanFly { get; set; }    

        public string Feathers { get; set; }    

        public string claws { get; set; }   
    }
}
