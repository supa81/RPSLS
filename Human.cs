using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        //MEMBER VARIABLES 
        //

        //CONSTRUCTOR 

        public Human(string name)
            :base(name)
        {
            Player playerOne = new Human("SuperMan");
            Player playerTwo = new Human("HomeLander");
        }


        // MEMBER METHODS 

    }
}
