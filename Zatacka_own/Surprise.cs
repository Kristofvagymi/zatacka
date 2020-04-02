using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatacka_own
{
    class Surprise
    {
        private String name;
        private float posX;
        private float posY;
        private readonly Action action; //method
        public Surprise(String n, float x, float y, Action a)
        {
            this.name = n;
            this.posX = x;
            this.posY = y;
            this.action = a;
        }
    }
}
