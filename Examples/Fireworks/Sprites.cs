using BubbleLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireworks
{
    internal static class Sprites
    {
        public static Sprite? Cannon { get; private set; }

        public static void Load()
        {
            Cannon = new Sprite("Fireworks/Cannon.png");
        }



    }
}
