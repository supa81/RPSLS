﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Paper
    {
        //MEMBER VARIABLES - HAS A
        int paper;


        //CONSTRUCTOR - SPAWN
        public Paper(int paper)
        {
            this.paper = 2;
        }

        //MEMBER METHODS - CAN DO
        
        //Paper covers Rock
        public void PaperCoversRock()
        {
            if (2 > 1)
            {
                Console.WriteLine("Paper Covers Rock!");
            }
        }
        //Paper disproves Spock
        public void PaperDisprovesSprock()
        {
            if (2 > 5)
            {
                Console.WriteLine("Paper Disproves Sprock");
            }
        }
    }
}
