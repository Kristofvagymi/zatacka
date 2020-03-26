using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Zatacka_own
{
    public partial class Game : Form
    {

        private PlayerList players;
        private AllDeadPopup popup;
        public static Bitmap b = new Bitmap(1000, 1000);

        public Game()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DoubleBuffered = true;

            players = new PlayerList();

            //Initialise players
            players.Add( new Player(Color.Aquamarine, Keys.Left, Keys.Right, 100, 100, 0));
            players.Add( new Player(Color.Red, Keys.A, Keys.D, 200, 200, 3.14));

            InitializeComponent();

            popup = new AllDeadPopup();

            timer1.Start();
        }

        //Listing all the results
        private void ListResults()
        {
            for(int i = Player.result.Count-1; i>-1; i--)
            {
                popup.scoreBoard.AppendText((Player.result.Count-i).ToString() + "   " +
                    Player.result[i].GetColor().ToString());
                popup.scoreBoard.AppendText(Environment.NewLine);
            }
        }

        private void OnePlayerLeft()
        {
            int aliveCounter = 0;
            Player playerAlive = null;

            for (int i = 0; i < players.Size(); i++)
            {
                Player currentPlayer = players.getPlayer(i);

                if (currentPlayer.Player_death == false)
                {
                    aliveCounter++;
                    playerAlive = currentPlayer;
                }
            }

            if (aliveCounter == 1)
            {
                Player.result.Add(playerAlive);
                this.SuspendLayout();
                timer1.Stop();

                ListResults();
                popup.Show();

                playerAlive.printPath();
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
            OnePlayerLeft();

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
