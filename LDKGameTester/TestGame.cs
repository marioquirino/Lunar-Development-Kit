using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace LDKGameTester
{
    public class TestGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        string gameFilePath;

        public TestGame( string gameFilePath )
        {
            graphics = new GraphicsDeviceManager( this );
            Content.RootDirectory = "Content";

            this.gameFilePath = gameFilePath;
        }

        protected override void Initialize( )
        {
            Components.Add( new LunarEngine.GameManager( this, graphics, gameFilePath ) );

            base.Initialize( );
        }
    }
}
