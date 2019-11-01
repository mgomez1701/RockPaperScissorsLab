using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
        }

        public RockPlayer(string name) : base(name)
        {
        }

        public override string GenerateRoshambo()
        {

            return "Rock";
        }
    }
}
