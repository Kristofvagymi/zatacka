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
        public double PosX {set; get; }
        public double PosY {set; get; }
        public int Speed { set; get; } = 2;

        public double direction;

        public double Direction
        {
            set
            {
                if (value > 360)
                    this.direction -= 360;
                else if (value < 0)
                    this.direction += 360;
                else this.direction = value;
            }
            get { return this.direction; }
        }

        private List<Point> p1_points;  //List storing player 1's path

        private Color lineColor;
        private Keys left;
        private Keys right;

        private Boolean turningRight;
        private Boolean turningLeft;

        public Player(Color lineColor, Keys left, Keys right) {
            this.direction = 0;
            this.lineColor = lineColor;
            this.left = left;
            this.right = right;

            p1_points = new List<Point>();

            PosX = 100;
            PosY = 100;
            Point start = new Point(Convert.ToInt32(PosX), Convert.ToInt32(PosY));

            p1_points.Add(start);
            p1_points.Add(start);
        }

        internal void paint( PaintEventArgs e)
        {
            e.Graphics.DrawCurve(new Pen(lineColor, 4), p1_points.ToArray());
        }

        public void tick()
        {
            if (turningLeft)
                Direction -= 0.1;

            if (turningRight)
                Direction += 0.1;

            PosX += Math.Cos(Direction) * Speed;

            PosY += Math.Sin(Direction) * Speed;

            //Adding player's new path point to the list
            Point newPoint = new Point(Convert.ToInt32(PosX), Convert.ToInt32(PosY));
            p1_points.Add(newPoint);
        }

        public void keyPressHappened(Keys key) {
            if (left.Equals(key)){
                if (turningLeft)
                    turningLeft = false;
                else
                    turningLeft = true;
            }
            else if (right.Equals(key)) {
                if (turningRight)
                    turningRight = false;
                else
                    turningRight = true;
            }
        }

    }
}
