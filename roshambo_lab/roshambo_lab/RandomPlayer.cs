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

        public override string RoshamboValue { get; set; }

        public RandomPlayer(string name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            string[] options = { "rock", "paper", "scissors" };
            Random random = new Random();

            string randomOption = options[random.Next(options.Length)];

            return randomOption;
        }
    }
}
