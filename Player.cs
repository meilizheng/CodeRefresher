using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefresher
{
    internal class Player  //created a class called Player;
    {
        public string Name { get; set; } //created a filed string name, int Number;
        public int Number { get; set; }

        public Player(string name, int number) //created a constructor;
        {
            Name = name;
            Number = number;
        }
    }
}
