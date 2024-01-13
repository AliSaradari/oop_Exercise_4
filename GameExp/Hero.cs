using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    internal class Hero : Character
    {
        public Hero(string name) : base(name)
        {
            Name = name;
            Power = 50;
        }
    }
}
