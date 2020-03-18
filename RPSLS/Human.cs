using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human(string name, int  score, string gesture)
        {
            this.name = name;
            score = 0;
            gesture = ("Rock,Paper,Scissors,Lizard,Spock");
        }

    }
}
