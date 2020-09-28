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

        public static int tickCounter = 0;
        public static int gapCounter = 0;
        public static int GapLength { set; get; } = 0; //Has to be even

        public static Bitmap b;


        public Game()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            b = new Bitmap(this.Width, this.Height);
            DoubleBuffered = true;

            players = new PlayerList();

            //Initialise players
            players.Add( new Player(Color.Aquamarine, Keys.Left, Keys.Right, 100, 100, 0));
            players.Add( new Player(Color.Red, Keys.A, Keys.D, 200, 200, Math.PI));

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
            }
        }

        private void paint(object sender, PaintEventArgs e)
        {
            players.paint(e);
            //Dispose();
        }

        //Reset tick and gap counter
        private void gapReset()
        {
            tickCounter = 0;
            gapCounter = 0;
        }

        //Advance counters
        private void advanceCounters()
        {
            if(GapLength > 1)
            {
                if (tickCounter >= 30)
                {
                    if (gapCounter == GapLength)
                    {
                        gapReset(); //Reset
                    }
                    else
                    {
                        gapCounter++;
                    }
                }
                else
                {
                    tickCounter++;
                }
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            //Tick
            players.tick();

            //Advance counters
            advanceCounters();

            //Redraw the bitmap
            b.Dispose();
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

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
