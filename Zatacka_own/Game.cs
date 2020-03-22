using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {

        private List<Player> playerList = new List<Player>();


        public Game()
        {
            //Initialise players
            playerList.Add( new Player(Color.Aquamarine, Keys.Left, Keys.Right, 100, 100, 0));
            playerList.Add( new Player(Color.Red, Keys.A, Keys.D, 200, 200, 3.14));

            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            foreach (Player player in playerList)
            {
                //Draw player's path
                player.paint(e);
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            foreach (Player player in playerList)
            {
                //Move players
                player.tick();
            }
            //Refresh
            Invalidate();
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            foreach (Player player in playerList)
            {
                player.keyDownEvent(e.KeyCode);
            }
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            foreach (Player player in playerList)
            {
                player.keyUpEvent(e.KeyCode);
            }
        }
    }
}
