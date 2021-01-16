using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Human("Bob");
            Console.WriteLine(playerOne.listOfGestures[0].nameOfGesture);
            Console.ReadLine();
        }
    }
}
