using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class RoshamboApp 
    {
        Random rando = new Random();
        string name = "default";

        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Schissors!");
            Console.WriteLine("Hello player, what is your name?");
            name = Console.ReadLine();
            Console.Clear();
        }
        
        public void Run()
        {

            //User player should go here eventually
            UserPlayer user = new UserPlayer("");
            RockyPlayer rocky = new RockyPlayer("Rocky");
            Player Player = new RockyPlayer("error");
            RandyPlayer randy = new RandyPlayer("Randy", rando);
                     
            
            bool run = true;
           while (run)
           {
                try
                {
                    Console.WriteLine("Would you like to play against Rocky or Randy?");
                    string answer = Console.ReadLine();
                    Console.Clear();



                    if (answer.ToLower() == "rocky") { Player = new RockyPlayer("Rocky"); break; }
                    else if (answer.ToLower() == "randy") { Player = new RandyPlayer("Randy", rando); break; }
                    else { Console.WriteLine("Sorry, I did not understand that input. Please try again!."); }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.GetType());
                }

           }

            string userRPS= user.GeneratedRoshambo().ToLower(); 
            string opponentRPS = Player.GeneratedRoshambo().ToLower();

            Console.WriteLine($"{name} you just threw: {userRPS}. ");
            Console.WriteLine($"Player {Player.Name} threw : {opponentRPS}. ");
            Console.WriteLine("");

            if (userRPS == opponentRPS) {
                Console.WriteLine("Draw!");
            }
            else if (userRPS == RPS.Rock) {
                if (opponentRPS == RPS.Paper) {
                    Console.WriteLine("Opponent Wins!");
                } else if (opponentRPS == RPS.Scissors)
                { Console.WriteLine("You Win!");
                }
            }
            else if (userRPS == RPS.Scissors)
            { if (opponentRPS == RPS.Paper)
                { Console.WriteLine("You Win!");
                } else if (opponentRPS == RPS.Rock)
                { Console.WriteLine("Opponent wins!");
                }
            }
            else if (userRPS == RPS.Paper)
            {
                if (opponentRPS == RPS.Rock)
                {
                    Console.WriteLine("You Win!");
                }
                else if (opponentRPS == RPS.Scissors)
                {
                    Console.WriteLine("Opponent wins!");
                }
            }

        }
    }
}
//Create a class called RoshamboApp that allows the user to play as either of your first two player classes.
//Use a Validator class to validate the user's entries.