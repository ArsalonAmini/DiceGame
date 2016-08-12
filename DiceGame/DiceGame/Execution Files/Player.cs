using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        //declare variables
        string name;
        int score;
     
        public Player(string name) 
        {
            this.name = name;
            this.score = 0;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
        }

        }
    //    public int getScore()
    //    {
    //        //involves storing dice rolls in a list
    //        //involves adding dice rolls

    //        //Console.ReadLine();
    //        //PlayerTotal[0] += DiceThrow[0];
    //        //PlayerTotal[1] += DiceThrow[1];

    //        //Console.ReadLine();
    //        //Console.Write(Player[0] + " currently has " + PlayerTotal[0]);
    //        //Console.ReadLine();
    //        //Console.Write(Player[1] + " currently has " + PlayerTotal[1]);
    //        //Console.ReadLine();
    //        return this.score;
    //    }

    //    //public void addToScore()
    //    //    {
    //    //    this.score = 
    //    }
    //}
}
