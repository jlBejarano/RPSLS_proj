using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        

        public Human(string name)
        {
            this.name = name;
        }

        public Human(string name, int  score, string gesture)
        {
            this.name = name;
            Console.WriteLine("Rock,Paper,Scissors,Lizard,Spock!");
        }

        public override void GestureChoice()
        {
            string[] ChoosegesturesArray = { "Rock", "Paper", "Scissors", "Lizard", "Spock!" };
            List<string> playerChoice = new List<string>();
            playerChoice.Add("Rock");
            playerChoice.Add("Paper");
            playerChoice.Add("Scissors");
            playerChoice.Add("Lizard");
            playerChoice.Add("Spock");
            Console.WriteLine(name + "picked" + "");
            Console.ReadLine();
        }

    }
}
