using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {

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
            //}

            string userInput;
            string inputCPU;
            int randomGesture;

            Console.WriteLine("Here are the rules to the game\nRock crushes Scissors, Scissors cuts Paper,\nPaper covers Rock, Rock crushes Lizard,\nLizard poisons Spock, Spock smashes Scissors,\nScissors decapitates Lizard, Lizard eats Paper,\nPaper disproves Spock, Spock vaporizes Rock");
            Console.WriteLine("Select your game mode! \n Press 1 for PVE Press 2 for PVP");
            userInput = Console.ReadLine();
            if (userInput.EndsWith("1")) 
            {
                Console.WriteLine("PVE!!");
            }
            else if (userInput.EndsWith("2"))
            {
                Console.WriteLine("PVP!!");
            }

            else
            {
                
            }
            Console.WriteLine("Choose your gesture ROCK, PAPER, SCISSORS, LIZARD, SPOCK!:  ");
            userInput = Console.ReadLine();
            Random rnd = new Random();
            randomGesture = rnd.Next(1,5);


            switch (randomGesture)
            {
                case 1:
                    
                    inputCPU = "rock";
                    Console.WriteLine("CPU choose ROCK");
                    userInput = Console.ReadLine();
                    break;

                case 2:
                    inputCPU = "Paper";
                    Console.WriteLine("CPU choose Paper");
                    userInput = Console.ReadLine();
                    break;

                case 3:
                    inputCPU = "Siccors";
                    Console.WriteLine("CPU choose Scissors");
                    userInput = Console.ReadLine();
                    break;
                case 4:
                    inputCPU = "Lizard";
                    Console.WriteLine("CPU choose Lizard");
                    userInput = Console.ReadLine();
                    break;
                case 5:
                    inputCPU = "Spock";
                    Console.WriteLine("CPU choose Spock");
                    userInput = Console.ReadLine();
                    break;

            }











            Console.ReadLine();



























            Console.ReadLine();
        }
    }
}
