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
            InitializeComponent();
            timer1.Start();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            p1.paint(10, 10, e);
        }

        int ad = 0;

        private void timer_tick(object sender, EventArgs e)
        {
            //p1.tick();
            ad++;
            p1.PosX++;
            Console.WriteLine(ad);
            Console.WriteLine(p1.PosX);
            Application.DoEvents();
            /*p1.PosX += 1;
            p1.PosY += 1;
            Console.WriteLine(p1.PosX);
            Console.WriteLine(p1.PosY);*/
            Invalidate();
        }
    }
}
