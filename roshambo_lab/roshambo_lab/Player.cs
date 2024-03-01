using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo_lab
{
    public abstract class Player
    {
        public abstract string Name { get; set; }

        public abstract Roshambo RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
