using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Ai : Player
    {
        public string gesture;

        public Ai(string name, int score, string gesture)
            :base(gesture)
        {
            this.name = name;
            score = 0;
            this.gestures = gesture;
            Console.WriteLine("Rock,Paper,Scissors,Lizard,Spock");
        }






    }
}
