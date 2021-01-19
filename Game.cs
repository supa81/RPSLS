using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int playerOneScore = 0;
        int playerTwoScore = 0;

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
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        playerOne = new Human("SuperMan");
                        playerTwo = new AI("CPU");
                        Console.WriteLine("Player vs CPU!!\n\n");
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

            while (playerOneScore < 3 || playerTwoScore < 3)
            {
                int playerOneSelection = SelectGesture();
                Gestures playerone = playerOne.listOfGestures[playerOneSelection];


                int playerTwoSelection = SelectGesture();
                Gestures playertwo = playerTwo.listOfGestures[playerTwoSelection];
                int SelectGesture()
                {
                    Console.WriteLine("Choose your gesture 0 ROCK, 1 PAPER, 2 SCISSORS, 3 LIZARD, 4 SPOCK!");
                    int playerSelection = Convert.ToInt32(Console.ReadLine());
                    return playerSelection;
                }
                if (playerone.nameOfGesture == "Rock")
                {
                    if (playertwo.nameOfGesture == "Rock")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (playertwo.nameOfGesture == "Paper")
                    {
                        Console.WriteLine("Player Two Wins! Paper covers Rock ");
                        playerTwoScore++;

                    }
                    else if (playertwo.nameOfGesture == "Scissors")
                    {
                        Console.WriteLine("Rock Smashes Scissors");
                    }
                    else if (playertwo.nameOfGesture == "Lizard")
                    {
                        Console.WriteLine("Player One Wins! Rock crushes Lizard ");
                        playerOneScore++;
                    }
                    else if (playertwo.nameOfGesture == "Spock")
                    {
                        Console.WriteLine("Player Two Wins! Spock vaporizes Rock");
                        playerTwoScore++;
                    }

                }
                if (playerone.nameOfGesture == "Paper")
                {
                    if (playertwo.nameOfGesture == "Paper")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (playertwo.nameOfGesture == "Rock")
                    {
                        Console.WriteLine("Player One Wins! Paper covers Rock ");
                        playerOneScore++;
                    }
                    else if (playertwo.nameOfGesture == "Scissors")
                    {
                        Console.WriteLine("Player Two Wins! Scissors cuts Paper ");
                        playerTwoScore++;
                    }
                    else if (playertwo.nameOfGesture == "Lizard")
                    {
                        Console.WriteLine("Player Two Wins! Lizard eats paper ");
                        playerTwoScore++;
                    }
                    else if (playertwo.nameOfGesture == "Spock")
                    {
                        Console.WriteLine("Player One Wins Paper disproves Spock ");
                        playerOneScore++;
                    }
                }

                if (playerone.nameOfGesture == "Scissors")
                {
                    if (playertwo.nameOfGesture == "Scissors")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (playertwo.nameOfGesture == "Rock")
                    {
                        Console.WriteLine("Player Two Wins! Rock smashes scissors");
                        playerTwoScore++;
                    }
                    else if (playertwo.nameOfGesture == "Paper")
                    {
                        Console.WriteLine("Player One Wins Scissors cuts paper");
                        playerOneScore++;

                    }
                    else if (playertwo.nameOfGesture == "Lizard")
                    {
                        Console.WriteLine(" PlayerOne Wins! Scissors decapitates Lizard"); playerOneScore++;
                    }
                    else if (playertwo.nameOfGesture == "Spock")
                    {
                        Console.WriteLine("Player Two Win! Spock smashes Scissors");
                        playerTwoScore++;
                    }

                    if (playerone.nameOfGesture == "Lizard")
                    {
                        if (playertwo.nameOfGesture == "Lizard")
                        {
                            Console.WriteLine("DRAW");
                        }

                        else if (playertwo.nameOfGesture == "Rock")
                        {
                            Console.WriteLine("Player Two Wins! Rock crushes Lizard");
                            playerTwoScore++;
                        }
                        else if (playertwo.nameOfGesture == "Paper")
                        {
                            Console.WriteLine("Player One Wins! Lizard eats Paper");
                            playerOneScore++;
                        }
                        else if (playertwo.nameOfGesture == "Scissors")
                        {
                            Console.WriteLine("Player Two Wins! Scissors decapitates Liazrd");
                            playerTwoScore++;

                        }
                        else if (playertwo.nameOfGesture == "Spock")
                        {
                            Console.WriteLine("Player One Wins! Lizard posions Spock ");
                            playerOneScore++;

                        }
                    }

                    if (playerone.nameOfGesture == "Spock")
                    {
                        if (playertwo.nameOfGesture == "Spock")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playertwo.nameOfGesture == "Rock")
                        {
                            Console.WriteLine("Player One Wins! Spock vapories Rock");
                            playerOneScore++;
                        }
                        else if (playertwo.nameOfGesture == "Paper")
                        {
                            Console.WriteLine("Player Two Wins! Paper disproves Spock");
                            playerTwoScore++;
                        }
                        else if (playertwo.nameOfGesture == "Scissors")
                        {
                            Console.WriteLine("Player One Wins! Spock smashes Scissors");
                            playerOneScore++;
                        }
                        else if (playertwo.nameOfGesture == "Lizard")
                        {
                            Console.WriteLine("Player Two Wins! Lizard poisons Spock");
                            playerTwoScore++;
                        }


                        if (playertwo.nameOfGesture == "Rock")
                        {
                            if (playerone.nameOfGesture == "Rock")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerone.nameOfGesture == "Paper")
                            {
                                Console.WriteLine("Player Two Wins! Paper covers Rock ");
                                playerTwoScore++;

                            }
                            else if (playerone.nameOfGesture == "Scissors")
                            {
                                Console.WriteLine("Rock Smashes Scissors");
                            }
                            else if (playerone.nameOfGesture == "Lizard")
                            {
                                Console.WriteLine("Player One Wins! Rock crushes Lizard ");
                                playerOneScore++;
                            }
                            else if (playerone.nameOfGesture == "Spock")
                            {
                                Console.WriteLine("Player Two Wins! Spock vaporizes Rock");
                                playerTwoScore++;
                            }

                        }
                        if (playertwo.nameOfGesture == "Paper")
                        {
                            if (playerone.nameOfGesture == "Paper")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerone.nameOfGesture == "Rock")
                            {
                                Console.WriteLine("Player One Wins! Paper covers Rock ");
                                playerOneScore++;
                            }
                            else if (playerone.nameOfGesture == "Scissors")
                            {
                                Console.WriteLine("Player Two Wins! Scissors cuts Paper ");
                                playerTwoScore++;
                            }
                            else if (playerone.nameOfGesture == "Lizard")
                            {
                                Console.WriteLine("Player Two Wins! Lizard eats paper ");
                                playerTwoScore++;
                            }
                            else if (playerone.nameOfGesture == "Spock")
                            {
                                Console.WriteLine("Player One Wins Paper disproves Spock ");
                                playerOneScore++;
                            }
                        }

                        if (playertwo.nameOfGesture == "Scissors")
                        {
                            if (playerone.nameOfGesture == "Scissors")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (playerone.nameOfGesture == "Rock")
                            {
                                Console.WriteLine("Player Two Wins! Rock smashes scissors");
                                playerTwoScore++;
                            }
                            else if (playerone.nameOfGesture == "Paper")
                            {
                                Console.WriteLine("Player One Wins Scissors cuts paper");
                                playerOneScore++;

                            }
                            else if (playerone.nameOfGesture == "Lizard")
                            {
                                Console.WriteLine(" PlayerOne Wins! Scissors decapitates Lizard"); playerOneScore++;
                            }
                            else if (playerone.nameOfGesture == "Spock")
                            {
                                Console.WriteLine("Player Two Win! Spock smashes Scissors");
                                playerTwoScore++;
                            }

                            if (playertwo.nameOfGesture == "Lizard")
                            {
                                if (playerone.nameOfGesture == "Lizard")
                                {
                                    Console.WriteLine("DRAW");
                                }

                                else if (playerone.nameOfGesture == "Rock")
                                {
                                    Console.WriteLine("Player Two Wins! Rock crushes Lizard");
                                    playerTwoScore++;
                                }
                                else if (playerone.nameOfGesture == "Paper")
                                {
                                    Console.WriteLine("Player One Wins! Lizard eats Paper");
                                    playerOneScore++;
                                }
                                else if (playerone.nameOfGesture == "Scissors")
                                {
                                    Console.WriteLine("Player Two Wins! Scissors decapitates Liazrd");
                                    playerTwoScore++;

                                }
                                else if (playerone.nameOfGesture == "Spock")
                                {
                                    Console.WriteLine("Player One Wins! Lizard posions Spock ");
                                    playerOneScore++;

                                }
                            }

                            if (playertwo.nameOfGesture == "Spock")
                            {
                                if (playerone.nameOfGesture == "Spock")
                                {
                                    Console.WriteLine("DRAW");
                                }
                                else if (playerone.nameOfGesture == "Rock")
                                {
                                    Console.WriteLine("Player One Wins! Spock vapories Rock");
                                    playerOneScore++;
                                }
                                else if (playerone.nameOfGesture == "Paper")
                                {
                                    Console.WriteLine("Player Two Wins! Paper disproves Spock");
                                    playerTwoScore++;
                                }
                                else if (playerone.nameOfGesture == "Scissors")
                                {
                                    Console.WriteLine("Player One Wins! Spock smashes Scissors");
                                    playerOneScore++;
                                }
                                else if (playerone.nameOfGesture == "Lizard")
                                {
                                    Console.WriteLine("Player Two Wins! Lizard poisons Spock");
                                    playerTwoScore++;

                                }
                                //IF I BRING WHATS UNDERNEATH TO THE TOP OF THE IF STATEMENTS THE GAME BECOME PLAYER VS PLAYER VS CPU
                                //ALSO THE CODE BELOW WORKS FOR THE CPU RANDOMLY PICKING A GESTURE AGINST YOU.
                                // NEED TO FIGURE OUT HOW NOT TO GET TWO INPUTS IN CPU AI GAME
                                string userInput;
                                string inputCPU;
                                int randomGesture;
                                Random rnd = new Random();
                                randomGesture = rnd.Next(0,4);
                                switch (randomGesture)
                                {
                                    case 0:

                                        inputCPU = "rock";
                                        Console.WriteLine("CPU choose ROCK");
                                        userInput = Console.ReadLine();
                                        break;

                                    case 1:
                                        inputCPU = "Paper";
                                        Console.WriteLine("CPU choose Paper");
                                        userInput = Console.ReadLine();
                                        break;

                                    case 2:
                                        inputCPU = "Siccors";
                                        Console.WriteLine("CPU choose Scissors");
                                        userInput = Console.ReadLine();
                                        break;
                                    case 3:

                                        inputCPU = "Lizard";
                                        Console.WriteLine("CPU choose Lizard");
                                        userInput = Console.ReadLine();
                                        break;
                                    case 4:
                                        inputCPU = "Spock";
                                        Console.WriteLine("CPU choose Spock");
                                        userInput = Console.ReadLine();
                                        break;


                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


        
     
















 

