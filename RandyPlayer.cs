using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class RandyPlayer : Player
    {
        public Random R {get; set;}

        public RandyPlayer(string Name,Random R) : base(Name)
        {
            this.R = R;           
        }
                
        public override string GeneratedRoshambo()
        {
            
            
            List<string> RPSvalue = new List<string>() {RPS.Rock,RPS.Paper,RPS.Scissors };
            int selection = R.Next(0, 3);
            return RPSvalue[selection];
        }
    }
}
//Create and name two player classes. One player should always select rock. 
//The other player should randomly select rock, paper, or scissors(a 1 in 3 chance of selecting each)