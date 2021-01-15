using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Rock
    {
        //MEMBER VARIABLES - HAS A
        int rock;

        //CONSTRUCTOR - SPAWN
        public Rock(int rock)
        {
            this.rock = 1;
        }


        //MEMBER METHODS - CAN DO 

        //Rock crushes Lizard

        public void RockCrushesLizard()
        {
            if (1 < 4)
            {
                Console.WriteLine("Rock Crushes Lizard!!");
            }

        }
        //Rock crushes Scissors

        public void RockCrushesScissors()
        {
            if (1 < 3)
            {
                Console.WriteLine("Rock Crushes Sicissors!!");
            }
            //how to use inhertance with my classes and jestures
            //if (rock < lizard)
        }
    }
}
