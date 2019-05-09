using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class UserPlayer : Player

    {
        public UserPlayer(string Name) : base(Name) { }

                      
        public override string GeneratedRoshambo()
        {
            string playerinput;
            while (true)

            {
                Console.WriteLine("Choose from the following: \nrock\npaper\nscissors");
                 playerinput = Console.ReadLine();
                Console.Clear();

            if (playerinput.ToLower() == "rock") { break; }
            else if (playerinput.ToLower() == "paper") { break; }
            else if (playerinput.ToLower() == "scissors") { break; }
            else
            {
                Console.WriteLine("Sorry, I do not recognize that input. Try again!");

            }
            continue;
        }

            return playerinput;                         

         
        }
           
    }
}

//Create a third player class that inherits the Player class and implements the generateRoshambo method.This method can return any value you choose.
