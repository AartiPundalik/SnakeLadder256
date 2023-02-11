using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder256
{
    public class CheckOption
    {
        public void Checkforoption()
        {
            Random random1 = new Random();
            int DiceRoll = random1.Next(1, 4);
            Console.WriteLine("Number of option " + DiceRoll);
            Console.Write("\n");

            int Player_position = 0;
            int No_Play = 0;

            if (DiceRoll == 1)
            {
                Player_position = Player_position + DiceRoll;
                Console.WriteLine("Player position moves ahead by the number on dice : " + Player_position);
                Console.ReadLine();
            }
            else if (DiceRoll == 2)
            {
                Player_position = Player_position - DiceRoll;
                Console.WriteLine("Player position moves behind by the number on dice : " + Player_position);
                Console.ReadLine();
            }
            else
            {
                Player_position = Player_position + No_Play;
                Console.WriteLine("Player position remain same : " + Player_position);
                Console.ReadLine();
            }

           
        }
    }
}
