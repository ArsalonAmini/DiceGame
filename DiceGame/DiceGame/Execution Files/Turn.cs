using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{

    class Turn //Turn class should take in player class, player class should take in dice class (and have a roll dice method)
    {
        Player player;

        public Turn(Player player)
        {
            this.player = player;
        }
        public void TakeTurn()
        {
            Console.WriteLine("It's your turn");
            //player.addToScore();
            //Console.WriteLine("Your turn is over{0}, you rolled a {1}", player.getName(), player.getScore());
            Console.ReadKey();
        }

    }
}
