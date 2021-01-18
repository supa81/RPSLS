using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        string userInput;




        public void RulesDisplay()
        {
            Console.WriteLine("Here are the rules to the game\nRock crushes Scissors, Scissors cuts Paper,\nPaper covers Rock, Rock crushes Lizard,\nLizard poisons Spock, Spock smashes Scissors,\nScissors decapitates Lizard, Lizard eats Paper,\nPaper disproves Spock, Spock vaporizes Rock");

        }
        public void SelectGameMode()
        {


            bool choice = false;
            while (choice == false)
            {
                Console.WriteLine("Select your game mode! \n\n Press 1 for Player vs AI Press 2 for Player vs Player ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        playerOne = new Human("SuperMan");
                        playerTwo = new AI("CPU");
                        Console.WriteLine("PVE!!\n\n");
                        choice = true;
                        break;

                    case "2":
                        playerOne = new Human("SuperMan");
                        playerTwo = new Human("HomeLander");
                        Console.WriteLine();
                        choice = true;
                        break;

                    default:
                        Console.WriteLine("This does not exist entry invalid");
                        choice = false;
                        break;

                }
            }

        }

        public void RunGame()
        {
            RulesDisplay();
            SelectGameMode();
            RunGame();
            int playerOneSelection = SelectGesture();
            int playerTwoSelection = SelectGesture();
            Gestures playerone = playerOne.listOfGestures[playerOneSelection];
            Gestures playertwo = playerTwo.listOfGestures[playerTwoSelection];
            int playerOneScore = 3;
            int playerTwoScore = 3;
            while (playerOneScore <= 3 || playerTwoScore <= 3)
            {


                if (playerone.nameOfGesture == "rock" && playertwo.nameOfGesture == "rock")
                {
                    Console.WriteLine("DRAW");
                }
                if (playerone.nameOfGesture == "rock" && playertwo.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player Two Wins! Paper covers Rock "); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "rock" && playertwo.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player One Wins! Rock crushes Scissors "); playerOneScore++;
                }
                if (playerone.nameOfGesture == "rock" && playertwo.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player One Wins! Rock crushes Lizard "); playerOneScore++;
                }
                if (playerone.nameOfGesture == "rock" && playertwo.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player Two Wins! Spock vaporizes Rock"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Paper" && playertwo.nameOfGesture == "Paper")
                {
                    Console.WriteLine("DRAW");
                }
                if (playerone.nameOfGesture == "Paper" && playertwo.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player One Wins! Paper covers Rock "); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Paper" && playertwo.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player Two Wins! Scissors cuts Paper "); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Paper" && playertwo.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player Two Wins! Lizard eats paper "); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Paper" && playertwo.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player One Wins Paper disproves Spock "); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Scissors" && playertwo.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("DRAW");
                }
                if (playerone.nameOfGesture == "Scissors" && playertwo.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player Two Wins! Rock smashes scissors"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Scissors" && playertwo.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player One Wins Scissors cuts paper"); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Scissors" && playertwo.nameOfGesture == "Lizard")
                {
                    Console.WriteLine(" PlayerOne Wins! Scissors decapitates Lizard"); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Scissors" && playertwo.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player Two Win! Spock smashes Scissors"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Lizard" && playertwo.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("DRAW");
                }
                if (playerone.nameOfGesture == "Lizard" && playertwo.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player Two Wins! Rock crushes Lizard"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Lizard" && playertwo.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player One Wins! Lizard eats Paper"); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Lizard" && playertwo.nameOfGesture == "scissors")
                {
                    Console.WriteLine("Player Two Wins! Scissors decapitates Liazrd"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Lizard" && playertwo.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player One Wins! Lizard posions Spock "); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Spock" && playertwo.nameOfGesture == "Spock")
                {
                    Console.WriteLine("DRAW");
                }
                if (playerone.nameOfGesture == "Spock" && playertwo.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player One Wins! Spock vapories Rock"); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Spock" && playertwo.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player Two Wins! Paper disproves Spock"); playerTwoScore++;
                }
                if (playerone.nameOfGesture == "Spock" && playertwo.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player One Wins! Spock smashes Scissors"); playerOneScore++;
                }
                if (playerone.nameOfGesture == "Spock" && playertwo.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player Two Wins! Lizard poisons Spock"); playerTwoScore++;
                }

                if (playertwo.nameOfGesture == "rock" && playerone.nameOfGesture == "rock")
                {
                    Console.WriteLine("DRAW");
                }
                if (playertwo.nameOfGesture == "rock" && playerone.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player Two Wins! Paper covers Rock "); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "rock" && playerone.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player One Wins! Rock crushes Scissors "); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "rock" && playerone.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player One Wins! Rock crushes Lizard "); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "rock" && playerone.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player Two Wins! Spock vaporizes Rock"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Paper" && playerone.nameOfGesture == "Paper")
                {
                    Console.WriteLine("DRAW");
                }
                if (playertwo.nameOfGesture == "Paper" && playerone.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player One Wins! Paper covers Rock "); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Paper" && playerone.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player Two Wins! Scissors cuts Paper  "); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Paper" && playerone.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player Two Wins! Lizard eats paper "); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Paper" && playerone.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player One Wins Paper disproves Spock "); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Scissors" && playerone.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("DRAW");
                }
                if (playertwo.nameOfGesture == "Scissors" && playerone.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player Two Wins! Rock smashes scissors"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Scissors" && playerone.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player One Wins Scissors cuts paper"); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Scissors" && playerone.nameOfGesture == "Lizard")
                {
                    Console.WriteLine(" PlayerOne Wins! Scissors decapitates Lizard"); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Scissors" && playerone.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player Two Win! Spock smashes Scissors"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Lizard" && playerone.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("DRAW");
                }
                if (playertwo.nameOfGesture == "Lizard" && playerone.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player Two Wins! Rock crushes Lizard"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Lizard" && playerone.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player One Wins! Lizard eats Paper"); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Lizard" && playerone.nameOfGesture == "scissors")
                {
                    Console.WriteLine("Player Two Wins! Scissors decapitates Liazrd"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Lizard" && playerone.nameOfGesture == "Spock")
                {
                    Console.WriteLine("Player One Wins! Lizard posions Spock "); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Spock" && playerone.nameOfGesture == "Spock")
                {
                    Console.WriteLine("DRAW");
                }
                if (playertwo.nameOfGesture == "Spock" && playerone.nameOfGesture == "Rock")
                {
                    Console.WriteLine("Player One Wins! Spock vapories Rock"); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Spock" && playerone.nameOfGesture == "Paper")
                {
                    Console.WriteLine("Player Two Wins! Paper disproves Spock"); playerTwoScore++;
                }
                if (playertwo.nameOfGesture == "Spock" && playerone.nameOfGesture == "Scissors")
                {
                    Console.WriteLine("Player One Wins! Spock smashes Scissors"); playerOneScore++;
                }
                if (playertwo.nameOfGesture == "Spock" && playerone.nameOfGesture == "Lizard")
                {
                    Console.WriteLine("Player Two Wins! Lizard poisons Spock"); playerTwoScore++;
                }


            }

            int SelectGesture()
            {
                Console.WriteLine("Choose your gesture 0 ROCK, 1 PAPER, 2 SCISSORS, 3 LIZARD, 4 SPOCK!");
                int playerSelection = Convert.ToInt32(Console.ReadLine());
                return playerSelection;

            }

            
        } 
    } 
}

        
        // DISPLAY THE RULES - CWL
        // SINGLE PLAYER OR MULTI? -   if they want single player press 1 mulitplayer 2
        // WHO GOES FIRST? CHOOSE GESTURE
        // NEXT PERSON CHOOSE GESTURE
        // AI NEEDS RANDOM GESTURE
        //MAKE COMPARSION BETWEEN TWO GESTURES
        // WINNING GESTURE WINS ROUND
        // REPEAT TILL BEST OF 3 for loop ??
        // DISPLAY WINNER !!


        //string playerOneGesture = "";
        //string playerTwoGesture = "";
        //Player playerOne = new Human("Bob");
        //Player playerTwo = new Human("Bill");
        //Console.WriteLine(playerOne.listOfGestures[0].nameOfGesture);
        //if (playerOneGesture == "Rock") 
        //{
        //    if (playerTwoGesture == "Paper")
        //    {
        //        Console.WriteLine("PlayerOne Wins!!!!");
        //    }
    

//string userInput;
//        string userInput2;
//        string inputCPU;
//        int randomGesture;
//        Player playerOne;
//        Player playerTwo;
//        Random rnd = new Random();
//        randomGesture = rnd.Next(1, 5);

//            Console.WriteLine("Here are the rules to the game\nRock crushes Scissors, Scissors cuts Paper,\nPaper covers Rock, Rock crushes Lizard,\nLizard poisons Spock, Spock smashes Scissors,\nScissors decapitates Lizard, Lizard eats Paper,\nPaper disproves Spock, Spock vaporizes Rock");
//            Console.WriteLine("Select your game mode! \n\n Press 1 for PVE Press 2 for PVP");
//            userInput = Console.ReadLine();
//            if (userInput.EndsWith("1"))
//            {
//                Console.WriteLine("PVE!!\n\n");
//            }
//            else if (userInput.EndsWith("2"))
//            {
//                Console.WriteLine("PVP!!\n\n");
//            }

//            else
//{

//}

//Console.WriteLine("Choose your gesture 1 ROCK, 2 PAPER, 3 SCISSORS, 4 LIZARD, 5 SPOCK!\n\n");
//userInput = Console.ReadLine();

////switch (randomGesture)
////{
////    case 1:

////        inputCPU = "rock";
////        Console.WriteLine("CPU choose ROCK");
////        userInput = Console.ReadLine();
////        break;

////    case 2:
////        inputCPU = "Paper";
////        Console.WriteLine("CPU choose Paper");
////        userInput = Console.ReadLine();
////        break;

////    case 3:
////        inputCPU = "Siccors";
////        Console.WriteLine("CPU choose Scissors");
////        userInput = Console.ReadLine();
////        break;
////    case 4:

////        inputCPU = "Lizard";
////        Console.WriteLine("CPU choose Lizard");
////        userInput = Console.ReadLine();
////        break;
////    case 5:
////        inputCPU = "Spock";
////        Console.WriteLine("CPU choose Spock");
////        userInput = Console.ReadLine();
////        break;

//switch (randomGesture)
//{
//    case 1:
//        userInput = Console.ReadLine();
//        Console.WriteLine("Player Two choose your gesture");
//        userInput2 = Console.ReadLine();
//        Console.WriteLine();

//        break;
//}

//Console.ReadLine();






////MEMBER VARIABLES - HAS A


////CONSTRUCTOR - SPAWN
//public Game()
//        {

//        }

//        //MEMBER METHODS - CAN DO 












 

