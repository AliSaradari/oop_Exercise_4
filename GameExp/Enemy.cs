using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    internal class Enemy : Character
    {
        public Enemy(string name) : base(name) 
        {
            Name = name;
            Power = 25;
            Speed = 50;
        }
        public int Speed { get; set; }
    }
}
