using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{

    //Dice class should have a roll dice method that player can access 

    class Dice
    {
        //variables 
        int numOfSides;
        int diceRoll4;
        int diceRoll6;
        int diceRoll10;
        int diceRoll12;
        int diceRoll20;
        Random rand;

        public Dice(int NumOfSides) //constructor
        {
            numOfSides = NumOfSides;
            rand = new Random();
        }
        public int RollDice()
        {

            if (numOfSides == 4)
            {
                diceRoll4 = rand.Next(1, 7);
                return diceRoll4;
            }
            else if (numOfSides == 6)
            {
                diceRoll6 = rand.Next(1, 7);
                return diceRoll6;
            }
            else if (numOfSides == 10)
            {
                diceRoll10 = rand.Next(1, 11);
                return diceRoll10;
            }
            else if (numOfSides == 12)
            {
                diceRoll12 = rand.Next(1, 13);
                return diceRoll12;
            }
            else if (numOfSides == 20)
                {
                 diceRoll20 = rand.Next (1, 21);
                 return diceRoll20;
                }
            else
            {
                return 0;
            }
            }  
        }
    
}
