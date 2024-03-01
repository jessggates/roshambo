﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo_lab
{
    public class HumanPlayer : Player
    {
        public override string Name { get; set; }

        public override Roshambo RoshamboValue { get; set; }

        public string UserChoice { get; set; }
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            switch(UserChoice)
            {
                case "r":
                    RoshamboValue = Roshambo.Rock;
                    break;
                case "p":
                    RoshamboValue = Roshambo.Paper;
                    break;
                case "s":
                    RoshamboValue = Roshambo.Scissors; 
                    break;
                default:
                    Console.WriteLine("That is an invalid option. Please choose r, p, or s.");
                    break;
            }
            
            return RoshamboValue;
        }
    }
}
