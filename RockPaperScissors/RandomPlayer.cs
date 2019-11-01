using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RandomPlayer : Player
    {
        

        Random random = new Random();

        public RandomPlayer()
        {
        }

        public RandomPlayer(string name) : base(name)
        {
        }

        public override string GenerateRoshambo()
        {
           int number = random.Next(0, 3);
        

            switch(number)
            {
                case 0:
                    return "Rock";
                case 1:
                    return "Paper";
                case 2:
                    return "Scissors";


            }
            return "You should not be here" ;
        }
    }
}
