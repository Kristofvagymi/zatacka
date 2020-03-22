﻿using System;
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

        private List<Point> p1_points;  //List storing player 1's path

        private Color lineColor;
        private Keys left;
        private Keys right;

        private Boolean turningRight;
        private Boolean turningLeft;

        public Player(Color lineColor, Keys left, Keys right,double x,double y,double dir) {
            this.direction = 0;
            this.lineColor = lineColor;
            this.left = left;
            this.right = right;

            p1_points = new List<Point>();

            PosX = x;
            PosY = y;
            Direction = dir;

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
