using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarEngine
{
    public class LunarGame : IDisposable
    {
        #region Fields

        private GameManager _gameManager;
        internal GameManager GameManager
        {
            get { return _gameManager; }
            set { _gameManager = value; }
        }

        private SpriteBatch _spriteBatch;
        internal SpriteBatch SpriteBatch
        {
            get { return _spriteBatch; }
            set { _spriteBatch = value; }
        }

        private GraphicsDeviceManager _gfx;
        internal GraphicsDeviceManager GFX
        {
            get { return _gfx; }
            set { _gfx = value; }
        }

        private Camera _camera;
        public Camera Camera
        {
            get { return _camera; }
            set { _camera = value; }
        }

        private Level _activeLevel;
        public Level ActiveLevel
        {
            get { return _activeLevel; }
            private set { _activeLevel = value; }
        }

        public Input Input
        {
            get { return _gameManager.Input; }
        }


        internal string[] SpritePaths;
        internal string[] FontPaths;
        internal string[] LevelPaths;
        internal StringKeyPool<ActorType> ActorTypes;

        internal StringKeyPool<Sprite> Sprites = new StringKeyPool<Sprite>( );
        internal StringKeyPool<SpriteFont> Fonts = new StringKeyPool<SpriteFont>( );


        private bool _levelUnloaded = true;

        #endregion

        #region Init

        public LunarGame( ) { }

        internal LunarGame( GameManager gameManager, GraphicsDeviceManager gfx )
        {
            _gameManager = gameManager;
            _spriteBatch = new SpriteBatch( gfx.GraphicsDevice );
            _camera = new Camera( gfx.GraphicsDevice.Viewport );
        }

        #endregion

        #region Methods

        internal void GameUpdate( GameTime gameTime )
        {
            Update( gameTime );

            if( ActiveLevel != null )
            {
                ActiveLevel.LevelUpdate( gameTime );

                Effects.Update( gameTime );
            }
        }

        internal void GameDraw( )
        {
            _spriteBatch.Begin( SpriteBlendMode.AlphaBlend, SpriteSortMode.Deferred, SaveStateMode.None, _camera.View );
            

            if( ActiveLevel != null )
            {
                Draw( _spriteBatch );

                ActiveLevel.LevelDraw( SpriteBatch );
            }

            _spriteBatch.End( );

            Matrix view = Camera.View;
            Effects.Draw( ref view );
        }

        public void Dispose( )
        {
            _gameManager = null;
            _gfx = null;
            _spriteBatch.Dispose( );
            _activeLevel.Dispose( );
        }
        
        #region Load Sprites

        private void LoadSprite( string[] paths )
        {
            if( paths.Length == 0 )
                return;

            // ---- Start the first pass, it will verify if a sprite from the array is already loaded and unload all sprites that are not

            //Create a temp list to hold the names of the sprites to unload.
            List<string> tmpNames = new List<string>( );

            //Iterate through all sprites in the _sprites pool
            foreach( string spriteName in Sprites.Keys )
            {
                //local variable to check if the sprite was already loaded or not
                bool spriteAlreadyLoaded = false;

                //Iterate through each sprite path
                foreach( string path in paths )
                {
                    //Get the name from the path
                    string name = Path.GetFileNameWithoutExtension( path );

                    //Check if the spriteName is equal to the name retrieved from the sprite path
                    if( spriteName == name )
                    {
                        //if so, it means the sprite is already loaded and doesn't need to be disposed
                        //so we set the variable to true
                        spriteAlreadyLoaded = true;

                        //Break the loop since we already found what we were searching for
                        break;
                    }
                }

                //Check if the sprite was already loaded
                if( !spriteAlreadyLoaded )
                    //if so add the sprite name to the tmpNames list.
                    //the sprite will be disposed in the second pass
                    tmpNames.Add( spriteName );
            }


            // ---- Start the second pass, this is where the unneeded sprites will be disposed

            //Iterate through the tmpNames list
            foreach( string name in tmpNames )
            {
                //Unload the texture from memory
                Sprites[name].Texture.Dispose( );

                //Remove the sprite object from the _sprites pool
                Sprites.Remove( name );
            }

            //Clear the list
            tmpNames = null;



            // ---- Start the third pass, now it's ready to load the new sprites

            //Iterate through each sprite path
            foreach( string path in paths )
            {
                //Get the name from the path
                string name = Path.GetFileNameWithoutExtension( path );

                //Checks if the _sprites pool already contains the loaded sprite
                if( !Sprites.ContainsKey( name ) )
                {
                    //if it doesn't go ahead and try to load the sprite

                    //Checks if the xnb file exists
                    if( !File.Exists( path ) )
                    {
                        //if not, write a message to the console
                        Console.WriteLine( "Sprite: " + name + ".xnb could not be found!" );

                        //and continue to the next sprite path
                        continue;
                    }
                    else
                    {
                        //otherwise load the sprite
                        Sprite sprite = new Sprite( GameManager.Game.Content.Load<Texture2D>( "Sprites\\" + name ) );

                        //Set the name
                        sprite.Name = name;

                        //and add the sprite to the _sprites pool
                        Sprites.Add( name, sprite );
                    }
                }
            }
        }

        internal bool LoadSprite( string spriteName )
        {
            if( !Sprites.ContainsKey( spriteName ) )
            {
                if( !File.Exists( Path.Combine( _gameManager.spritesFolder, spriteName + ".xnb" ) ) )
                {
                    Console.WriteLine( "Sprite: " + spriteName + ".xnb could not be found!" );
                    return false;
                }
                else
                {
                    Sprite sprite = new Sprite( _gameManager.Game.Content.Load<Texture2D>( "Sprites\\" + spriteName ) );

                    sprite.Name = spriteName;

                    Sprites.Add( spriteName, sprite );
                }
            }

            return true;
        }

        #endregion

        #region Load Fonts

        private void LoadFont( string[] paths )
        {
            if( paths.Length == 0 )
                return;
            // ---- Start the first pass, it will verify if a font from the array is already loaded and unload all fonts that are not

            //Create a temp list to hold the names of the fonts to unload.
            List<string> tmpNames = new List<string>( );

            //Iterate through all fonts in the Fonts pool
            foreach( string fontName in Fonts.Keys )
            {
                //local variable to check if the font was already loaded or not
                bool fontAlreadyLoaded = false;

                //Iterate through each font path
                foreach( string path in paths )
                {
                    //Get the name from the path
                    string name = Path.GetFileNameWithoutExtension( path );

                    //Check if the fontName is equal to the name retrieved from the font path
                    if( fontName == name )
                    {
                        //if so, it means the font is already loaded and doesn't need to be disposed
                        //so we set the variable to true
                        fontAlreadyLoaded = true;

                        //Break the loop since we already found what we were searching for
                        break;
                    }
                }

                //Check if the font was already loaded
                if( !fontAlreadyLoaded )
                    //if so add the font name to the tmpNames list.
                    //the font will be disposed in the second pass
                    tmpNames.Add( fontName );
            }


            // ---- Start the second pass, this is where the unneeded fonts will be disposed

            //Iterate through the tmpNames list
            foreach( string name in tmpNames )
            {
                //Set the font to null
                Fonts[name] = null;

                //Remove the font object from the Fonts pool
                Fonts.Remove( name );
            }

            //Clear the list
            tmpNames = null;



            // ---- Start the third pass, now it's ready to load the new fonts

            //Iterate through each font path
            foreach( string path in paths )
            {
                //Get the name from the path
                string name = Path.GetFileNameWithoutExtension( path );

                //Checks if the Fonts pool already contains the loaded sprite
                if( !Fonts.ContainsKey( name ) )
                {
                    //if it doesn't, go ahead and try to load the font

                    //Checks if the xnb file exists
                    if( !File.Exists( path ) )
                    {
                        //if not, write a message to the console
                        Console.WriteLine( "Font: " + name + ".xnb could not be found!" );

                        //and continue to the next font
                        continue;
                    }
                    else
                    {
                        //otherwise load the font
                        SpriteFont font = GameManager.Game.Content.Load<SpriteFont>( "Fonts\\" + name );

                        //and add the font to the Fonts pool
                        Fonts.Add( name, font );
                    }
                }
            }
        }

        internal bool LoadFont( string fontName )
        {
            if( !Fonts.ContainsKey( fontName ) )
            {
                if( !File.Exists( Path.Combine( _gameManager.fontsFolder, fontName + ".xnb" ) ) )
                {
                    Console.WriteLine( "Font: " + fontName + ".xnb could not be found!" );
                    return false;
                }
                else
                {
                    SpriteFont font = _gameManager.Game.Content.Load<SpriteFont>( "Fonts\\" + fontName );

                    Fonts.Add( fontName, font );
                }
            }

            return true;
        }

        #endregion

        #endregion

        #region Public Methods

        #region LoadLevel
        public void LoadLevel( string levelName )
        {
            if( !_levelUnloaded )
                UnloadLevel( );

            LevelLoading( );

            string path = Path.Combine( _gameManager.levelsFolder, levelName + GameManager.LEVEL_EXTENSION );

            using( BinaryReader file = new BinaryReader( File.OpenRead( path ) ) )
            {
                //Check the header of the file for validation
                if( file.ReadString( ) != GameManager.FILE_ID )
                {
                    Console.WriteLine( Path.GetFileName( path ) + " is invalid or corrupted!" );
                    return;
                }

                //Get the file version
                int levelVersion = file.ReadInt32( );


                Level lvl = null;

                //Get level script's name and immediately loads the script
                string scriptName = file.ReadString( );
                if( scriptName != GameManager.NO_SCRIPT )
                {
                    Type type = _gameManager.GetClassType( scriptName );

                    if( type != null )
                        lvl = Activator.CreateInstance( type ) as Level;

                }

                if( lvl == null )
                    lvl = new Level( );


                // ---- Start reading the sprite references for this level

                //Get the number of sprite references
                int spriteCount = file.ReadInt32( );

                //Create a local array to hold the sprite paths
                string[] tmpPaths = new string[spriteCount];
                for( int i = 0; i < spriteCount; i++ )
                {
                    //Get the sprite's name
                    string line = file.ReadString( );

                    tmpPaths[i] = Path.Combine( _gameManager.spritesFolder, line + ".xnb" );
                }

                //Pass the array of sprite paths and load the sprites
                LoadSprite( tmpPaths );



                //Checks for the level file version. Font data is only supported in version 2 and above
                if( levelVersion >= 2 )
                {
                    // ---- Start reading the font references for this level

                    //Get the number of font references
                    int fontCount = file.ReadInt32( );

                    //Create a local array to hold the font paths
                    tmpPaths = new string[fontCount];
                    for( int i = 0; i < fontCount; i++ )
                    {
                        //Get the font's name
                        string line = file.ReadString( );

                        tmpPaths[i] = Path.Combine( _gameManager.fontsFolder, line + ".xnb" );
                    }

                    //Pass the array of font paths and load the fonts
                    LoadFont( tmpPaths );
                }



                // ---- Start reading the layers data

                //Get the number of layers
                int layerCount = file.ReadInt32( );
                for( int i = 0; i < layerCount; i++ )
                {
                    // ---- Read the layer data

                    //Get the layer's name
                    string line = file.ReadString( );

                    //Create a new layer instance
                    Layer layer = new Layer( line );

                    //Get the layer Visible value
                    layer.Visible = file.ReadBoolean( );

                    //Get the layer Scale value
                    layer.Scale = file.ReadSingle( );

                    //Get the number of actors on this layer
                    int actorCount = file.ReadInt32( );
                    for( int j = 0; j < actorCount; j++ )
                    {
                        // ---- Read the actor data


                        //Create a new Actor instance
                        Actor actor =  null;

                        //Get the actor's ID
                        int ID = file.ReadInt32( );

                        //Get the sprite name
                        string spriteName = file.ReadString( );

                        //Get the script name
                        scriptName = file.ReadString( );
                        if( scriptName != GameManager.NO_SCRIPT )
                        {
                            Type type = _gameManager.GetClassType( scriptName );

                            if( type != null )
                                actor = Activator.CreateInstance( type ) as Actor;
                        }

                        if( actor == null )
                            actor = new Actor( );

                        actor.ID = ID;

                        //Assign the correct sprite to the actor if a match is found
                        if( Sprites.ContainsKey( spriteName ) )
                            actor.Sprite = Sprites[spriteName];

                        //Get and assign the name of the actor
                        actor.Name = file.ReadString( );

                        //Get and assign the actor's position
                        actor.Position = new Vector2( file.ReadSingle( ), file.ReadSingle( ) );

                        //Get and assign the actor's origin
                        actor.Origin = new Vector2( file.ReadSingle( ), file.ReadSingle( ) );

                        //Get and assign the actor's scale
                        actor.Scale = file.ReadSingle( );

                        //Get and assign the actor's rotation angle
                        actor.Rotation = file.ReadSingle( );

                        //Get and assign the actor's visibility
                        actor.Visible = file.ReadBoolean( );

                        if( levelVersion >= 3 )
                        {
                            int tagCount = file.ReadInt32( );
                            for( int k = 0; k < tagCount; k++ )
                            {
                                actor.AddTag( file.ReadString( ) );
                            }

                            bool isTextActor = file.ReadBoolean( );
                            if( isTextActor )
                            {
                                if( ( actor as TextActor ) == null )
                                {
                                    TextActor txtActor = new TextActor( );
                                    actor.CopyValues( txtActor );
                                    actor = txtActor;
                                }

                                string fontName = file.ReadString( );
                                if( Fonts.ContainsKey( fontName ) )
                                    ( actor as TextActor ).Font = Fonts[fontName];
                                ( actor as TextActor ).Text = file.ReadString( );
                                ( actor as TextActor ).TextColor = new Color( file.ReadByte( ), file.ReadByte( ), file.ReadByte( ), file.ReadByte( ) );
                            }
                        }

                        //Add the actor to the layer
                        layer.AddActor( actor );
                    }

                    //Add the layer instance to the level
                    lvl.NewLayer( layer );
                }

                file.Close( );

                lvl.Game = this;
                ActiveLevel = lvl;
            }

            LevelLoaded( );

            ActiveLevel.Init( );

            foreach( Layer layer in ActiveLevel.Layers.Values )
            {
                foreach( Actor actor in layer.Actors )
                {
                    actor.Init( );
                }
            }
        }
        #endregion

        public void UnloadLevel( )
        {
            LevelUnloading( );

            ActiveLevel.End( );

            ActiveLevel.Dispose( );
            ActiveLevel = null;

            LevelUnloaded( );
        }

        public Texture2D GetSprite( string spriteName )
        {
            if( !Sprites.ContainsKey( spriteName ) )
                LoadSprite( spriteName );

            if( Sprites.ContainsKey( spriteName ) )
                return Sprites[spriteName].Texture;

            return null;
        }

        #endregion

        #region C# Script Events

        public virtual void Init( ) { }

        public virtual void Update( GameTime gameTime ) { }

        public virtual void Draw( SpriteBatch spriteBatch ) { }

        public virtual void LevelLoading( ) { }

        public virtual void LevelLoaded( ) { }

        public virtual void LevelUnloading( ) { }

        public virtual void LevelUnloaded( ) { }

        #endregion
    }
}
