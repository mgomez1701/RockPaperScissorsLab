using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public string Roshambo { get; set; }
        
        public Player ()
        {

        }
        public Player (string name)
        {
            Name = name;
        }
        public abstract string GenerateRoshambo(); // does not need a body since the inheritance class will define

    }
}
