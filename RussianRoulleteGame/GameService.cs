using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulleteGame
{
    public class GameService : GameInterface
    {
        public int GameLoad { get; set; }
        public int GameSpin { get; set; }

        public int GameShootLoop(int sk)//This function is for setting shoot the gun that how many chance it will take
        {
            if (sk == 6)
            {
                sk = 1;
            }
            else
            {
                sk++;
            }
            return sk;
        }
    }
}
