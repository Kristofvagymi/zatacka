using System;
using System.Windows.Forms;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        Player p1;

        public Game()
        {
            p1 = new Player();
            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {

            p1.paint(100, 100, e);

        }

        private void timer_tick(object sender, EventArgs e)
        {
            p1.tick();
            Console.WriteLine(p1.PosX);
            Console.WriteLine(p1.PosY);
            Invalidate();
        }
    }
}
