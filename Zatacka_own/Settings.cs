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
    public partial class Settings : Form
    {
        public Settings()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            Player.Speed = this.speedBar.Value; //Default
            Player.Turn = this.turnspeedBar.Value * 0.1; //Default
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            Player.Speed = this.speedBar.Value;
        }

        private void turnspeedBar_Scroll(object sender, EventArgs e)
        {
            Player.Turn = this.turnspeedBar.Value * 0.1;
        }
    }
}
