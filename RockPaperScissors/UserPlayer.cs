using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class UserPlayer : Player
    {
        public override string GenerateRoshambo()
        {
            return Console.ReadLine();
        }
    }
}
