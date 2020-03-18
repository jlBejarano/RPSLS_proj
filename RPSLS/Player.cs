using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public int score;

        List<Human> Player1;
        List<Ai> Player2;

        public virtual void ChooseaGesture()
        {
            List<string> listofGestures = new List<string>();
            listofGestures.Add("Choose a gesture!");
            listofGestures.Add("Rock");
            listofGestures.Add("Paper");
            listofGestures.Add("Scissors");
            listofGestures.Add("Lizard");
            listofGestures.Add("Spock");

            foreach (string Gesture in listofGestures)
            {
                Console.WriteLine(Gesture);
                Console.ReadLine();
            }
        }

        




        
        
           

        
       

           
        

        
        






    }
}

        

        
    


