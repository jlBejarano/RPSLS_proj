using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Ai : Player
    {
        public Ai(string name)
        {
            this.name = name;
            Console.WriteLine("Rock,Paper,Scissors,Lizard,Spock!");
        }

        public override void GestureChoice()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");

            var random = new Random();
            {
                var list = new List<string> { "RPSLS" };
                Console.WriteLine(name + "picked" + list);
                Console.ReadLine();
            }
        }








    }
}
