using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
     abstract class Player
     {

        public string Name { get; set; }
                    
        public string Roshambo { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GeneratedRoshambo();
     }
   
}
// Create an abstract class named Player that stores a name and a Roshambo value. 
//This class should include an abstract method named generatedRoshambo that allows an inheriting class to generate and return a Roshambo value.


