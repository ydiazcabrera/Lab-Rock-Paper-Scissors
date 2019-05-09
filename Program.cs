using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {          

            //UserPlayer player = new UserPlayer("");

            RoshamboApp ra = new RoshamboApp();
            ra.Welcome();


            while (true)
            {
                RockyPlayer r = new RockyPlayer("Rocky");
                Random rando = new Random();
                RandyPlayer Randy = new RandyPlayer("Randy", rando);

                ra.Run();
                Console.WriteLine("Play again? (y/n)");
                string input = Console.ReadLine();
                Console.Clear();
                if( input.ToLower() == "y")
                {
                    
                }
                else { break; }

                
            }
            Console.WriteLine("Thanks for playing!");
            
            
           // Console.WriteLine($"{r.Name} throws{r.GeneratedRoshambo()}");

           

            //for (int i =0; i< 1; i++)
           // {
                //Console.WriteLine($"{Randy.Name} throws {Randy.GeneratedRoshambo()}");
           // }

          
        }
    }
}
//What will the application do? 
// The application prompts the player to enter a name and select an opponent
// The application propmts the [layer to select rock, paper, or sceissors. Then, the application displays the player's choice, the opponent's choice and result of the match.
// The application conitnues until the user doesn't want to play anymore.
// If the user makes an invalid selection, the application should display an appropiate error message and prompt the user again until the user makes a valid selection.
//Hit: Paper beats rock, rock beats scissors, scissors beats paper.
//Extended Challenges: Keep track of wins and losses, and display them at the end of each session.
