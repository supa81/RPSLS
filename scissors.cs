using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Scissors
    {
        //MEMBER VARIABLES - HAS A
        int scissors;

        //CONSTRUCTOR - SPAWN
        public Scissors(int scissors)
        {
            this.scissors = 3;
        }

        //MEMBER METHODS - CAN DO
        
        //Scissors cuts Paper
        public void ScissorsCutsPaper()
        {
            if (3 > 2)
            {
                Console.WriteLine("Scissors Cuts Paper!");
            }
        }
        //Scissors decapitates Lizard
        public void ScissorsDecapitatesLizard()
        {
            if (3 > 4)
            {
                Console.WriteLine("Scissors Decapitates Lizard!");
            }
        }
        
    }
}
