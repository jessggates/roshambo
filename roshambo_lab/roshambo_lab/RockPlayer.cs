using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo_lab
{
    public class RockPlayer : Player
    {
        public override string Name { get; set; } 

        public override Roshambo RoshamboValue { get; set; }

        public RockPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            RoshamboValue = Roshambo.Rock;
            return RoshamboValue;
        }
    }
}
