using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        private Player p1;
        private List<Point> p1_points = new List<Point>(); //List storing player 1's path
        

        public Game()
        {
            //Initialise player 1
            p1 = new Player();
            p1.PosX = 100;
            p1.PosY = 100;
            Point start = new Point(p1.PosX, p1.PosY);
            p1_points.Add(start);
            p1_points.Add(start);


            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            //Draw player 1's path
            e.Graphics.DrawCurve(new Pen(Color.Red, 4), p1_points.ToArray());
        }

        int ad = 0;

        private void timer_tick(object sender, EventArgs e)
        {
            p1.tick();

            //Adding player 1's new path point to the list
            Point newPoint = new Point(p1.PosX, p1.PosY);
            p1_points.Add(newPoint);

            /*Console.WriteLine("posx: "+p1.PosX);
            Console.WriteLine("posy: "+p1.PosY);*/

            //Refresh
            Invalidate();
        }
    }
}
