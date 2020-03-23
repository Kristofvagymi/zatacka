﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {

        private PlayerList players;
        public static Bitmap b = new Bitmap(1000, 1000);

        public Game()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DoubleBuffered = true;

            players = new PlayerList();

            //Initialise players
            players.Add( new Player(Color.Aquamarine, Keys.Left, Keys.Right, 100, 100, 0,false));
            players.Add( new Player(Color.Red, Keys.A, Keys.D, 200, 200, 3.14,false));

            InitializeComponent();
            timer1.Start();
        }


        private void AllDead()
        {
            int deathCounter = 0;
            for (int i = 0; i < players.Size(); i++)
            {
                Player p = players.getPlayer(i);
                if (p.player_death == true)
                {
                    deathCounter++;
                }
            }

            if (deathCounter == players.Size())
            {
                this.SuspendLayout();
                timer1.Stop();
                AllDeadPopup popup = new AllDeadPopup();
                popup.Show();
            }
        }

        private void paint(object sender, PaintEventArgs e)
        {
            players.paint(e);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            //Tick
            players.tick();

            //Redraw the bitmap
            b = new Bitmap(this.Width, this.Height);
            DrawToBitmap(b,new Rectangle(0,0,this.Width,this.Height));

            //Alldead
            AllDead();

            //Refresh
            Invalidate();
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            players.keyPressedEvent(e);
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            players.keyUpEvent(e);
        }
    }
}
