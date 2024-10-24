using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using MonoLibrary;

namespace ActorCrab
{
    internal class CrabWorld : World
    {
        private Random random = new Random();

        public CrabWorld() : base(800, 600) 
        { 
        
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            // Load game art from the "Content" folder.
            string[] names = { "crab", "crab2", "worm", "lobster", "sand2" };
            GameArt.Add(names);
            
            // set background tile
            BackgroundTile = GameArt.Get("sand2");

            // create game
            Crab crab = new Crab();
            this.Add(crab);
            //System.Type type = crab.GetType();
            //System.Type classType = typeof(Crab);

            this.AddWorms();
            AddLobsters(crab);
            
        }
        private void AddWorms()
        {
            for (int i = 0; i < 10; i++)
            {
                float x = random.Next(Width);
                float y = random.Next(Height);
                Worm worm = new Worm();
                worm.Position = new Vector2(x, y);
                Add(worm);
            }

        }
        private void AddLobsters(Crab crab)
        {
            Lobster lobster = new Lobster(crab);
            lobster.Position = new Vector2(100, 100);
            Add(lobster);

            Lobster lobster2 = new Lobster(crab);
            lobster2.Position = new Vector2(100, Height - 100);
            Add(lobster2);

            Lobster lobster3 = new Lobster(crab);
            lobster3.Position = new Vector2(Width - 100, 100);
            Add(lobster3);

            Lobster Lobster4 = new Lobster(crab);
            Lobster4.Position = new Vector2(Width - 100, Height - 100);
            Add(Lobster4);
        }

        protected override void Update(GameTime gameTime)
        {
            // Call Update once per object in the world.
            base.Update(gameTime);

            // Add game logic for the world here.
            // your code ...
        }
    }
}
