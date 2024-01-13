using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    public class Character
    {
        public Character(string name)
        {
            Name = name;
            Health = 100;
            Status = Status.Alive;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public Status Status { get; set; }


    }

}
