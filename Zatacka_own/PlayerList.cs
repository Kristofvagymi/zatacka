using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatacka_own
{
    class PlayerList
    {
        private List<Player> playerList = new List<Player>();

        internal void Add(Player player)
        {
            playerList.Add(player);
        }

        internal int Size()
        {
            return playerList.Count;
        }

        internal Player getPlayer(int i)
        {
            return playerList[i];
        }


        internal void paint(PaintEventArgs e)
        {
            foreach (Player player in playerList)
            {
                //Draw player's path
                player.paint(e);
            }
        }

        internal void tick()
        {
            foreach (Player player in playerList)
            {
                //Move players
                player.tick();
            }
        }

        internal void keyPressedEvent(KeyEventArgs e)
        {
            foreach (Player player in playerList)
            {
                player.keyDownEvent(e.KeyCode);
            }
        }

        internal void keyUpEvent(KeyEventArgs e)
        {
            foreach (Player player in playerList)
            {
                player.keyUpEvent(e.KeyCode);
            }
        }
    }
}
