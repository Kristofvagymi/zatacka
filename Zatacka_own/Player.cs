using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatacka_own
{
    class Player
    {
        private int posX = 100;
        private int posY = 100;
        private int direction = 0;

        public int PosX{set;get;}
        public int PosY { set; get; }
        public int Direction
        {
            set {
                if (value > 360)
                    direction = 360;
                else if (value < 0)
                    direction = 0;
                else direction = value;
            }get { return direction; } }
    }
}
