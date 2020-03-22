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

        private List<Point> p1_points;  //List storing player 1's path

        private Color lineColor;

        public Player(Color lineColor) {

            this.lineColor = lineColor;

            p1_points = new List<Point>();

            PosX = 100;
            PosY = 100;
            Point start = new Point(PosX, PosY);

            p1_points.Add(start);
            p1_points.Add(start);
        }

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

        internal void paint( PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 4);
            g.DrawEllipse(pen, PosX, PosY, 4, 4);*/

            e.Graphics.DrawCurve(new Pen(lineColor, 4), p1_points.ToArray());
        }

        public void tick()
        {
            PosX += Speed;
            PosY += Speed;

            //Adding player's new path point to the list
            Point newPoint = new Point(PosX, PosY);
            p1_points.Add(newPoint);
        }
    }
}
