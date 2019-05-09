using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class RockyPlayer : Player
        
    {
        public RockyPlayer(string Name) : base(Name) { }
        public override string GeneratedRoshambo()
        {
            return RPS.Rock;
        }
    }
}
//Create and name two player classes. One player should always select rock. 
//The other player should randomly select rock, paper, or scissors(a 1 in 3 chance of selecting each)

