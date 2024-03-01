using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo_lab
{
    public class RandomPlayer : Player
    {
        public override string Name { get; set; }

        public override Roshambo RoshamboValue { get; set; }

        public RandomPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();

            int randomOption = random.Next(1,4);
            Roshambo roshambo = (Roshambo)randomOption;
            RoshamboValue = roshambo;
            return RoshamboValue;
        }
    }
}
