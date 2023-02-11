using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder256
{
    public  class Program
    {
        static void Main(string[] args)
        {
                SinglePlayer position = new SinglePlayer();
                position.StartPosition();

               DiceRoll getnumber = new DiceRoll();
            getnumber.RollTheDice();
            }
        }
    }
    

