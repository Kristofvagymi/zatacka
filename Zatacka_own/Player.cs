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

        public int PosX{set; get; }
        public int PosY {set; get; }
        public int Speed { set; get; } = 1;

        public int Direction
        {
            set
            {
                if (value > 360)
                    Direction = 360;
                else if (value < 0)
                    Direction = 0;
                else Direction = value;
            }
            get { return Direction; }
        }

        public void paint(int x, int y, PaintEventArgs e)
        {
            PosX = x;
            PosY = y;

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 4);
            g.DrawEllipse(pen, PosX, PosY, 4, 4);
        }

        public void tick()
        {
            PosX += Speed;
            PosY += Speed;
        }
    }
}
