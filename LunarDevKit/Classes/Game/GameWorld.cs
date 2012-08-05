using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LunarEngine;

namespace LunarDevKit.Classes
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class GameWorld : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        string filePath;

        public GameWorld( string gameFilePath )
        {
            this.graphics = new GraphicsDeviceManager( this );
            this.Content.RootDirectory = "Content";

            this.filePath = gameFilePath;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize( )
        {
            this.Components.Add( new GameManager( this, this.graphics, filePath ) );

            base.Initialize( );
        }
    }
}
