using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        private Player p1;

        public Game()
        {
            //Initialise player 1
            p1 = new Player(Color.Aquamarine, Keys.Left, Keys.Right);

            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            //Draw player 1's path
            p1.paint(e);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            p1.tick();

            //Refresh
            Invalidate();
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            p1.keyDownEvent(e.KeyCode);
            //e.Handled = true;
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            p1.keyUpEvent(e.KeyCode);
            //e.Handled = true;
        }
    }
}
