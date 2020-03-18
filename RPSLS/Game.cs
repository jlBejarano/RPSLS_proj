using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerone;
        Player playertwo;

        public void RulesOfGame()
        {
            List<string> listofRules = new List<string>();
            listofRules.Add("Rules Of The Game");
            listofRules.Add("Rock crushes scissors");
            listofRules.Add("Scissors cuts paper");
            listofRules.Add("Paper covers rock");
            listofRules.Add("Rock crushes lizard");
            listofRules.Add("Lizard poisons Spock");
            listofRules.Add("Spock smashes scissors");
            listofRules.Add("Scissors decapitate lizard");
            listofRules.Add("Lizard eats paper");
            listofRules.Add("Paper disproves Spock");
            listofRules.Add("Spock vaporizes rock");

        }

        public void ChooseGameMode()
        {
           
        }

        


    }
}
