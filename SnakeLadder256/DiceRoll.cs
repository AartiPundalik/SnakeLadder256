using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder256
{
    public class DiceRoll
    {
        public void RollTheDice()
        {
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Dice Number : " + DiceRoll);
            Console.ReadLine();

        }
    }
}