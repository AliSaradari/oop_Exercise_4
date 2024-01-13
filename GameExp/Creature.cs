using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    internal class Creature : Character
    {
        public Creature(string name) : base(name) 
        {
            Name = name;
            Power = 20;
        }
    }
}
