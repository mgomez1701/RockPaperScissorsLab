using System;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {

            Player randomPlayer = new RandomPlayer("Random Balboa");
            //randomPlayer.Name = "Random Balboa";

            Player rockPlayer = new RockPlayer("Rocky Balboa");
            //rockPlayer.Name = "Rockey Balboa";

            UserPlayer userPlayer = new UserPlayer();
            Console.Write("Enter your Name"); // user input
            userPlayer.Name = Console.ReadLine(); ;

            Console.WriteLine("Select your rockPlayer!");
            Console.WriteLine("1). Rocky Balboa");
            Console.WriteLine("2). Random Balboa");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Play(userPlayer, new RockPlayer("Rocky Balboa"));
                    break;
                case "2":
                    Play(userPlayer, new RandomPlayer("Random Balboa"));
                    break;
            }

        }          
        public static void Play(UserPlayer userPlayer, Player choosenPlayer)
        {
            int i = 0;
            //int rockyWins = 0;
            //int randomWins = 0;
            //int ties = 0;

            while (i < 10)// this means we will run it 10 times. 
            {
             
                Console.WriteLine("Pick Rock, Paper, Scissors");
                string rocky = choosenPlayer.GenerateRoshambo();
                string random = userPlayer.GenerateRoshambo();
               
                if (rocky == "Rock" && random == "Rock")
                {
                    Console.WriteLine($"{userPlayer.Name} selected {random}");
                    Console.WriteLine(($"{choosenPlayer.Name} selected {rocky}"));
                    Console.WriteLine("Tie");
                    
                }

                else if (rocky == "Rock" && random == "Paper")
                {
                    Console.WriteLine($"{userPlayer.Name} selected {random}");
                    Console.WriteLine(($"{choosenPlayer.Name} selected {rocky}"));
                    Console.WriteLine($"{choosenPlayer.Name} Wins!");
                    
                }
                else if (rocky == "Rock" && random == "Scissors")
                {
                    Console.WriteLine($"{userPlayer.Name} selected {random}");
                    Console.WriteLine(($"{choosenPlayer.Name} selected {rocky}"));
                    Console.WriteLine($"{choosenPlayer.Name} Wins!");
                    
                }
                else if (rocky == "Rock" && random == "Paper")
                {
                    Console.WriteLine($"{userPlayer.Name} selected {random}");
                    Console.WriteLine(($"{choosenPlayer.Name} selected {rocky}"));
                    Console.WriteLine($"{userPlayer.Name} Wins!");
                             
                }
                i++;  // this is to get out of the while loop

            }

        }
      
    }
}
