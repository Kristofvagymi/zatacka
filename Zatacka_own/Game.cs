using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatacka_own
{
    public partial class Game : Form
    {
        public Game()
        {
            Player p1 = new Player();
            InitializeComponent();
            timer1.Start();
        }

        int x = 10;
        int y = 10;

        private void paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red,10);
            g.DrawEllipse(pen, x, y, 100, 100);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            Console.WriteLine("fasz");
            x++;
            y++;
            Invalidate();
        }
    }
}
