using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        private Player p1;
        private List<Point> p1_points = new List<Point>();
        

        public Game()
        {
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
            e.Graphics.DrawCurve(new Pen(Color.Red, 4), p1_points.ToArray());
        }

        int ad = 0;

        private void timer_tick(object sender, EventArgs e)
        {
            p1.tick();
            Point newPoint = new Point(p1.PosX, p1.PosY);
            p1_points.Add(newPoint);
            Console.WriteLine("posx: "+p1.PosX);
            Console.WriteLine("posy: "+p1.PosY);
            Invalidate();
        }
    }
}
