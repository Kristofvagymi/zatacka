using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatacka_own
{
    class Player
    {
        private double PosX {set; get; }
        private double PosY {set; get; }
        private int Speed { set; get; } = 3;

        private double direction;

        private double Direction
        {
            set
            {
                this.direction = value;
            }
            get { return this.direction; }
        }

        private List<Point> points;  //List storing player's path

        private Color lineColor;
        private Keys left;
        private Keys right;

        private Boolean turningRight;
        private Boolean turningLeft;

        private Boolean player_death = false;

        public Player(Color lineColor, Keys left, Keys right,double x,double y,double dir) {
            this.direction = 0;
            this.lineColor = lineColor;
            this.left = left;
            this.right = right;

            points = new List<Point>();

            PosX = x;
            PosY = y;
            Direction = dir;

            Point start = new Point(Convert.ToInt32(PosX), Convert.ToInt32(PosY));

            points.Add(start);
            points.Add(start);
        }

        internal void paint( PaintEventArgs e)
        {
            e.Graphics.DrawCurve(new Pen(lineColor, 4), points.ToArray());
            //e.Graphics.DrawEllipse(new Pen(lineColor, 2), Convert.ToInt32(PosX) - 2, Convert.ToInt32(PosY) - 2, 4, 4);
        }

        public Color GetPixelColor(int x, int y)
        {   
            
            Color pixelColor = Game.b.GetPixel(x, y);

            return pixelColor;
        }

        public void tick()
        {
            if(player_death == true)
            {
                return;
            }
            else
            {
                if (turningLeft)
                    Direction -= 0.1;

                if (turningRight)
                    Direction += 0.1;

                PosX += Math.Cos(Direction) * Speed;

                PosY += Math.Sin(Direction) * Speed;

                //Adding player's new path point to the list
                Point newPoint = new Point(Convert.ToInt32(PosX), Convert.ToInt32(PosY));

                //Checking background color
                if (this.GetPixelColor(newPoint.X, newPoint.Y) != Color.FromArgb(255, 240, 240, 240)
                    && this.GetPixelColor(newPoint.X, newPoint.Y) != Color.FromArgb(0, 0, 0, 0))
                {
                    //Death
                    Console.WriteLine(this + " " + GetPixelColor(newPoint.X, newPoint.Y));
                    Console.WriteLine(newPoint);
                    player_death = true;
                }
                else
                {
                    points.Add(newPoint);
                }
            }
        }


        public void keyDownEvent(Keys key) {
            if (left.Equals(key)) 
                turningLeft = true;

            if (right.Equals(key))
                turningRight = true;
        }

        public void keyUpEvent(Keys key){
            if (left.Equals(key))
                turningLeft = false;

            if (right.Equals(key))
                turningRight = false;
        }

    }
}
