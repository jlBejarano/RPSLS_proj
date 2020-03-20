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
            :base(gesture)
        {
            this.name = name;
            score = 0;
            this.gestures = gesture;
            Console.WriteLine("Rock,Paper,Scissors,Lizard,Spock");
        }

        public void ChooseGestures()
        {
            string[] ChoosegesturesArray = {"Rock", "Paper", "Scissors", "Lizard","Spock");
           
        }

    }
}
