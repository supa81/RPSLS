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
            listOfGestures.Add(rock); 
            listOfGestures.Add(paper);
            listOfGestures.Add(scissors);
            listOfGestures.Add(lizard);
            listOfGestures.Add(spock);
        }

        //MEMBER METHODS - CAN DO 
        
    }
}
