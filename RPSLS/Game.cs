using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public string winner;
        public int round;
        public Player playerOne;
        public Player playerTwo;
        int playerOneScore;
        int playerTwoScore;
        int playerOneScoreMin = 0;
        int playerOneScoreMax = 3;

        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Choose a game mode, 1 = Human, 2 = Ai");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            
            if (userInput == "1" || userInput == "Human")
            {
                string user;
                Console.WriteLine("Choose player");
                user = Console.ReadLine();
                playerOne = new Human("user 1");
                playerTwo = new Human("user 2");
            }
            else if (userInput == "Ai" || userInput == "2")
            {
                string user;
                user = Console.ReadLine();
                playerOne = new Human("user 1");
                playerTwo = new Ai(user);
            }
            else
            {
                ChooseGameMode();
            }
        }
        public void ChooseGesture()
        {

            int playerScore = 0;
 
            if (playerOne.chooseGesture == "Rock" && (playerTwo.chooseGesture == "Scissors"))
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + playerOne.score);
                Console.ReadLine();
            }
            else if (playerOne.chooseGesture == "Paper" && (playerTwo.chooseGesture == "Rock"))
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + playerOne.score);
                Console.ReadLine();
            }
            else if (playerOne.chooseGesture == "Scissors" && (playerTwo.chooseGesture == "Paper"))
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + playerOne.score);
                Console.ReadLine();
            }
            else if (playerOne.chooseGesture == "Lizard" && (playerTwo.chooseGesture == "Paper"))
            {
                Console.WriteLine("PlayerOne wins the round");
                Console.WriteLine("PlayerOne score is" + playerOne.score);
                Console.ReadLine();
            }
            else
            {
                ChooseGesture(); Console.WriteLine("Players Draw!");
                playerScore += 3;
                Console.WriteLine(playerScore);
            }
            

        } 
        
        public void RunMatch()
        {
            ChooseGameMode();
            ChooseGesture();

            Console.WriteLine("Make selection, select opponent");
            Console.ReadLine();

        }
        
    }
}
