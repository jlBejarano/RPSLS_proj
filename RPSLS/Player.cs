using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player 
    {
        public string name;
        public int score;
        public string ChooseGesture;
        public List<string> gesture;

        public Player()
        {
            List<string> chooseGesture = new List<string>();
            Console.WriteLine("Choose a gesture");
            gesture.Add("Rock");
            gesture.Add("Paper");
            gesture.Add("Scissors");
            gesture.Add("Lizard");
            gesture.Add("Spock");
        }

        public abstract void GestureChoice();
    }
}

        

        
    


