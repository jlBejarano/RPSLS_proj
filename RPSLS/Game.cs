using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {   
        public string winner;
        public int round;
        public string gestures;
        public string input;

        Player playerOne;
        Player playerTwo;
        
        List<string> AddGestures = new List<string>();

        public Game()
        {
            AddGestures.Add("Rock");
            AddGestures.Add("Scissors");
            AddGestures.Add("Paper");
            AddGestures.Add("Lizard");
            AddGestures.Add("Spock");

        }



        

        

        public void ChooseGameMode()
            {
                Console.WriteLine("Choose a game mode either, 1 for vs Ai, 2 for vs human");
                string userInput = Console.ReadLine();
                
                if (userInput == "1")
                {
                    string user;
                    Console.WriteLine("Choose player");
                    user = Console.ReadLine();
                    PlayerOne = new Human(user);
                    PlayerTwo = new Ai(user);
                }
                else
                {
                string user;
                user = Console.ReadLine();
                    PlayerOne = new Human(user);
                    PlayerTwo = new Human(user);
                }

                public void DisplayRules()
                {
                    Console.WriteLine("Human player will choose gesture, computer will choose random");
                    Console.WriteLine("This rules of the game are : " +
                    "rock crushes scissors, " +
                    "scissors cuts paper," +
                    " paper covers rock, " +
                    "rock crushes lizard, " +
                    "lizard poisons spock," +
                    "spock smashes scissors, " +
                    "scissors decapitate lizard," +
                     " lizard eats paper, " +
                     "paper disproves spock, " +
                     "spock vaporizes rock");
                }

            public void ChooseGesture()
            {
                if (PlayerOne.chooseGesture == "Rock" && PlayerTwo.chooseGesture == "Scissors") ;
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + PlayerOne.score);
                Console.ReadLine();
            }
            else if (PlayerOne.chooseGesture == "Paper" && PlayerTwo.chooseGesture == "Rock") ;
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + PlayerOne.score);
                Console.ReadLine();
            
            }
            else if (PlayerOne.chooseGesture == "Scissors" && PlayerTwo.chooseGesture == "Paper") ;
            {    Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + PlayerOne.score);
                Console.ReadLine();
            }
            else if (PlayerOne.chooseGesture == "Lizard" && PlayerTwo.chooseGesture == "Paper") ;
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + PlayerOne.score);
                Console.ReadLine();
            }

            
                



















































































        }

    }
}
