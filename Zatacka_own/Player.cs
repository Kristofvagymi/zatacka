using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatacka_own
{
    class Player
    {
        private int posX = 100;
        private int posY = 100;

        private int direction = 0;

        public int PosX{ set; get; }
        public int PosY{ set; get; }
        public int Direction
        {
            set
            {
                if (value > 360)
                    direction = 360;
                else if (value < 0)
                    direction = 0;
                else direction = value;
            }
            get { return direction; }
        }

        internal void paint(int x, int y, PaintEventArgs e)
        {
            posX = x;
            posY = y;

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 4);
            g.DrawEllipse(pen, posX, posY, 4, 4);
        }

        internal void tick()
        {
            posX++;
            posY++;
        }
    }
}
