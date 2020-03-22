using System;
using System.Windows.Forms;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        private Player p1;

        public Game()
        {
            p1 = new Player();
            p1.PosX = 100;
            p1.PosY = 100;
            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            p1.paint(e);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            p1.tick();
            Console.WriteLine("posx: "+p1.PosX);
            Console.WriteLine("posy: "+p1.PosY);
            Invalidate();
        }
    }
}
