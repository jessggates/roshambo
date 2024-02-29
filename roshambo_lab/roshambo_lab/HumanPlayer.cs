using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo_lab
{
    public class HumanPlayer : Player
    {
        public override string Name { get; set; }

        public override string RoshamboValue { get; set; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            return RoshamboValue;
        }
    }
}
