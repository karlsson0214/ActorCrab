using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoLibrary;

namespace ActorCrab
{
    internal class Worm : Actor
    {

        public Worm()
        {
            Image = GameArt.Get("worm");
            
        }
        public override void Update(GameTime gameTime)
        {
            // do nothing
        }
    }
}
