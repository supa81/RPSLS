using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player 
    {
        //MEMBER VARIABLES - HAS A
        public string name;
        public List<Gestures> listOfGestures;
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Lizard lizard = new Lizard();
        Spock spock = new Spock();





        //CONSTRUCTOR - SPAWN
        public Player(string name)
        {
            this.name = name;
            listOfGestures = new List<Gestures>();
            listOfGestures.Add(rock); //[0]
            listOfGestures.Add(paper); //[1]
            listOfGestures.Add(scissors); //[2]
            listOfGestures.Add(lizard); //[3]
            listOfGestures.Add(spock); //[4]
        }

        //MEMBER METHODS - CAN DO 
        
    }
}
