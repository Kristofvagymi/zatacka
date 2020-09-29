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
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //Getting rid of title bar
            InitializeComponent();
            this.Text = "Settings";
            Player.Speed = this.speedBar.Value; //Default
            Player.Turn = this.turnspeedBar.Value * 0.1; //Default
        }

        //Takes you back to the Main Menu (Welcome Page)
        private void backToMenu()
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
        }

        //Apply button click action
        private void applyButton_Click(object sender, EventArgs e)
        {
            Player.Speed = this.speedBar.Value;
            Player.Turn = this.turnspeedBar.Value * 0.1;
            Game.GapLength = this.holesBar.Value;
            backToMenu();
        }

        //Back button click action
        private void backButton_Click(object sender, EventArgs e)
        {
            backToMenu();
        }
    }
}
