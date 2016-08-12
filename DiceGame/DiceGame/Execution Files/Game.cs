using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        Turn turn;
        Player playerOne;
        Player playerTwo;
        Dice dice;
        int round;
        int numberOfRounds;
        string choice;
        int intChoice;

        public Game()
        {
            this.playerOne = new Player("name:");
            this.playerTwo = new Player("name:");
            this.dice = new Dice(intChoice);
            this.numberOfRounds = 3;
            this.round = 0;
        }

        public void RunGame()
        {
                Console.WriteLine("Welcome to my Dice Game");  
                while (this.round < this.numberOfRounds) //Gaming loop
            {
                Dice dice = new DiceChoice().diceChoice();
                Console.WriteLine("Welcome to Turn {0}", this.round);
                Turn playerOneTurn = new Turn(this.playerOne); 
                playerOneTurn.TakeTurn();
                dice.RollDice(); 
                Console.WriteLine("It is your turn ");
                Turn playerTwoTurn = new Turn(this.playerTwo);
                playerTwoTurn.TakeTurn();
                this.round++;

            }
        }

    }
}
