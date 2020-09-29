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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //Remove title bar
            InitializeComponent();
            this.Text = "Zatacka";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Show();
            this.Hide();
        }
    }
}
