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

        private double Direction { set; get; }
        
        private List<Point> path;  //List storing player 1's path
        public static List<Player> result = new List<Player>(); //Result of one round;

        private Color lineColor;
        private Keys left;
        private Keys right;

        private Boolean turningRight;
        private Boolean turningLeft;

        public Boolean Player_death { set; get; } = false;

        public Player(Color lineColor, Keys left, Keys right,double x,double y,double dir) {
            this.lineColor = lineColor;
            this.left = left;
            this.right = right;

            
            path = new List<Point>(); //Path of the player
            result = new List<Player>(); //Result of one round
            

            PosX = x;
            PosY = y;
            Direction = dir;

            Point start = new Point(Convert.ToInt32(PosX), Convert.ToInt32(PosY));

            path.Add(start);
            path.Add(start);
        }

        //Getting the Color of the current player
        public Color GetColor()
        {
            return lineColor;
        }

        internal void paint( PaintEventArgs e)
        {
            e.Graphics.DrawCurve(new Pen(lineColor, 4), path.ToArray());
        }
        
        //Getting the color of the specific pixel pair
        public Color GetPixelColor(int x, int y)
        {
            return Game.b.GetPixel(x, y);
        }

        public void tick()
        {
            if(Player_death == true)
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

                //Checking valid X, Y coordinates
                if (newPoint.X >= Game.ActiveForm.Width || newPoint.X <= 1
                    || newPoint.Y >= Game.ActiveForm.Height || newPoint.Y <= 1)
                {
                    //Death
                    Player_death = true;
                    result.Add(this);//Adding to the result list
                }
                //Checking background color
                else if (this.GetPixelColor(newPoint.X, newPoint.Y) != Color.FromArgb(255, 240, 240, 240)
                    && this.GetPixelColor(newPoint.X, newPoint.Y) != Color.FromArgb(0, 0, 0, 0))
                {
                    //Death
                    Player_death = true;
                    result.Add(this);//Adding to the result list
                }
                else
                {
                    path.Add(newPoint);
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
