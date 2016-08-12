using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class DiceChoice
    {
    string choice;
    int intChoice;
        public DiceChoice()
        {
           
        }

        public Dice diceChoice()
        {
            Console.WriteLine("Select the type of dice (4, 6, 10, 12, 20)");
            choice = Console.ReadLine();
            intChoice = int.Parse(choice);
            return new Dice(intChoice);
        }
    }
}
