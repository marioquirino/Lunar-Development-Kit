using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using FarseerPhysics.DebugViewXNA;
using LunarEngine.Collections;
using ProjectMercury;

namespace LunarEngine
{
    public sealed class GameManager : DrawableGameComponent
    {
        #region Consts

        internal const string FILE_ID = "LUNAR DEVELOPMENT KIT";
        internal const string LEVEL_EXTENSION = ".lvl";
        internal const string NO_SCRIPT = "<No Script Assigned>";
        private const string NO_AUDIO = "<No audio project assigned>";

        #endregion

        #region Fields

        private GraphicsDeviceManager _gfx;

        private System.Reflection.Assembly _scriptsDLL;
        internal System.Reflection.Assembly ScriptsDLL
        {
            get { return _scriptsDLL; }
        }

        private Input _input;
        internal Input Input
        {
            get { return _input; }
        }

        private LunarGame _Game;
        internal LunarGame LunarGame
        {
            get { return _Game; }
        }


        internal Microsoft.Xna.Framework.Content.ContentManager Content
        {
            get { return Game.Content; }
        }


        private string _gameFilePath;
        private bool _endWithEsc;
        private Color _backgroundColor;

        internal string mainFolder;
        internal string spritesFolder;
        internal string actorTypesFolder;
        internal string fontsFolder;
        internal string levelsFolder;
        internal string effectsFolder;


        private bool _isExiting = false;

        #endregion

        #region Init
        
        public GameManager( Game game, GraphicsDeviceManager graphics, string gameFilePath )
            : base( game )
        {
            if( !File.Exists( gameFilePath ) )
            {
                System.Windows.Forms.MessageBox.Show( "The game file doesn't exist!\r\nExiting game!", "Invalid Game File", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
                game.Exit( );

                Game.Exiting += new EventHandler( Game_Exiting );

                _isExiting = true;
                return;
            }

            _gfx = graphics;
            _gameFilePath = gameFilePath;
        }

        private void Game_Exiting( object sender, EventArgs e )
        {
            Game.Components.Remove( _input );
            _input.Dispose( );

            _scriptsDLL = null;

            Sound.Dispose( );
            Game.Content.Unload( );
        }

        public override void Initialize( )
        {
            if( !_isExiting )
            {
                _input = new Input( this );
                Game.Components.Add( _input );

                Sound.GameManager = this;
                Physics.World = new FarseerPhysics.Dynamics.World( Vector2.Zero );
                Effects.Renderer = new ProjectMercury.Renderers.SpriteBatchRenderer
                {
                    GraphicsDeviceService = _gfx
                };

                LoadGameFile( );
            }

            base.Initialize( );
        }

        #endregion

        #region Update

        public override void Update( GameTime gameTime )
        {
            base.Update( gameTime );

            if( !_isExiting )
            {
                if( _endWithEsc && _input.IsKeyPress( Keys.Escape ) )
                    Game.Exit( );

                Sound.Update( );
                Physics.Update( (float)gameTime.ElapsedGameTime.TotalSeconds );

                _Game.GameUpdate( gameTime );
            }
        }

        #endregion

        #region Draw

        public override void Draw( GameTime gameTime )
        {
            this.GraphicsDevice.Clear( _backgroundColor );

            _Game.GameDraw( );

            base.Draw( gameTime );
        }

        #endregion

        #region Load Game File
        private void LoadGameFile( )
        {
            using( BinaryReader file = new BinaryReader( File.OpenRead( _gameFilePath ) ) )
            {
                string line;

                mainFolder = Path.GetDirectoryName( _gameFilePath );
                spritesFolder = Path.Combine( mainFolder, "Content\\Sprites" );
                actorTypesFolder = Path.Combine( mainFolder, "Content\\Actors" );
                fontsFolder = Path.Combine( mainFolder, "Content\\Fonts" );
                levelsFolder = Path.Combine( mainFolder, "Levels" );
                effectsFolder = Path.Combine( mainFolder, "Content\\Effects" );

                Game.Content.RootDirectory = Path.Combine( mainFolder, "Content" );

                // ---- Reads the header data

                if( file.ReadString( ) != FILE_ID )
                {
                    System.Windows.Forms.MessageBox.Show( "The file is invalid or is corrupted!\r\nExiting game!", "Invalid Game File", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
                    this.Game.Exit( );
                    _isExiting = true;
                    return;
                }

                int version = file.ReadInt32( );



                // ---- Reads the game settings and immediately make changes

                Game.Window.Title = file.ReadString( );
                _gfx.PreferredBackBufferWidth = file.ReadInt32( );
                _gfx.PreferredBackBufferHeight = file.ReadInt32( );
                _gfx.IsFullScreen = file.ReadBoolean( );
                _gfx.ApplyChanges( );
                _endWithEsc = file.ReadBoolean( );
                _backgroundColor = new Color( file.ReadByte( ), file.ReadByte( ), file.ReadByte( ) );


                if( version >= 2 )
                {
                    // ---- Loads the audio engine, if one specified

                    string audioEngineFile = file.ReadString( );
                    if( audioEngineFile != NO_AUDIO )
                    {
                        string audioFolder = Path.Combine( mainFolder, "Content\\Audio" );
                        audioEngineFile = Path.Combine( audioFolder, audioEngineFile + ".xgs" );
                        if( File.Exists( audioEngineFile ) )
                        {
                            string[] audioFiles = Directory.GetFiles( audioFolder );
                            List<string> waveBankFiles = new List<string>( );
                            List<string> soundBankFiles = new List<string>( );

                            foreach( string audioFile in audioFiles )
                            {
                                if( audioFile.EndsWith( ".xwb" ) )
                                {
                                    waveBankFiles.Add( audioFile );
                                    continue;
                                }

                                if( audioFile.EndsWith( ".xsb" ) )
                                    soundBankFiles.Add( audioFile );
                            }

                            Sound.AudioEngine = new AudioEngine( audioEngineFile );

                            foreach( string waveBank in waveBankFiles )
                                Sound.AddWaveBank( waveBank );

                            foreach( string soundBank in soundBankFiles )
                                Sound.AddSoundBank( soundBank );
                        }
                    }
                }

                //Create a new instance of the LunarGame class
                if( _Game != null )
                    _Game.Dispose( );
                _Game = new LunarGame( this, _gfx );


                //Load the scripts.dll
                string dllPath = Path.Combine( mainFolder, "Content\\scripts.dll" );
                if( File.Exists( dllPath ) )
                    _scriptsDLL = System.Reflection.Assembly.LoadFrom( dllPath );



                // ---- Starts loading the sprites

                //Get the number of sprites
                int spriteCount = file.ReadInt32( );

                //Init the spritePaths array
                string[] spritePaths = new string[spriteCount];

                for( int i = 0; i < spriteCount; i++ )
                {
                    //Get the name of the sprite
                    line = file.ReadString( );

                    string path = Path.Combine( spritesFolder, line + ".xnb" );
                    if( File.Exists( path ) )
                        spritePaths[i] = path;
                    else
                        Console.WriteLine( "Sprite: " + line + ".xnb could not be found!" );
                }

                string[] fontPaths = null;
                //Checks for the version. Fonts are only supported in version 2 and greater
                if( version >= 2 )
                {
                    // ---- Starts getting the fonts data

                    //Get the number of fonts
                    int fontCount = file.ReadInt32( );

                    //Init the fontPaths array
                    fontPaths = new string[fontCount];

                    for( int i = 0; i < fontCount; i++ )
                    {
                        //Get the name of the font
                        line = file.ReadString( );

                        string path = Path.Combine( fontsFolder, line + ".xnb" );
                        if( File.Exists( path ) )
                            fontPaths[i] = path;
                        else
                            Console.WriteLine( "Font: " + line + ".xnb could not be found!" );
                    }
                }




                // ---- Starts loading the actor types

                //Get the number of actor types
                int actorsCount = file.ReadInt32( );
                StringKeyPool<ActorType> actorTypes = new StringKeyPool<ActorType>( );

                for( int i = 0; i < actorsCount; i++ )
                {
                    //Get the name of the actor
                    line = file.ReadString( );

                    string path = Path.Combine( actorTypesFolder, line + ".actor" );
                    if( File.Exists( path ) )
                    {
                        //Opens and reads the file
                        using( BinaryReader file2 = new BinaryReader( File.OpenRead( path ) ) )
                        {
                            //Check the header of the file for validation
                            if( file2.ReadString( ) != FILE_ID )
                            {
                                Console.WriteLine( Path.GetFileName( path ) + " is invalid or corrupted!" );
                                return;
                            }

                            //Get the file version
                            int actorVersion = file2.ReadInt32( );

                            //Create a new ActorType instance
                            ActorType actor = new ActorType( );

                            //Get the actor type name
                            actor.Name = file2.ReadString( );

                            //Get the actor type scale
                            actor.Scale = file2.ReadSingle( );

                            //Get the actor type rotation angle
                            actor.Rotation = file2.ReadSingle( );

                            //Get the actor type's sprite name and set it to the actortype object SpriteName
                            actor.SpriteName = file2.ReadString( );

                            //Get the actor type's script name, search for the respective path and set it to the actortype object's ScriptPath
                            actor.ScriptName = file2.ReadString( );

                            actor.Tags.Add( actor.Name );
                            if( actorVersion >= 3 )
                            {
                                actor.Tags.Clear( );
                                int tagCount = file2.ReadInt32( );
                                for( int j = 0; j < tagCount; j++ )
                                {
                                    actor.Tags.Add( file2.ReadString( ) );
                                }
                            }

                            //Checks for the actor file version. The TextActor-related data is only supported on version 2 and above
                            //Includes the addition from the version 3 of the file
                            if( actorVersion >= 2 )
                            {
                                //Get the flag value that determines if the actor is in fact a TextActor
                                bool b = file2.ReadBoolean( );
                                actor.IsTextActor = b;

                                //Checks if the actor is a TextActor in order to retrieve the rest of the data
                                if( actor.IsTextActor )
                                {
                                    //Get the font's name
                                    actor.FontName = file2.ReadString( );

                                    //Get the text to be displayed
                                    actor.Text = file2.ReadString( );

                                    //Get the text's color
                                    actor.TextColor = new Color( file2.ReadByte( ), file2.ReadByte( ), file2.ReadByte( ) );

                                    if( actorVersion >= 3 )
                                        actor.TextColor.A = file2.ReadByte( );
                                }
                            }


                            //Attempt to add the loaded actortype to the actorTypes dictionary
                            actorTypes.Add( actor.Name, actor );
                        }
                    }
                    else
                        Console.WriteLine( line + ".actor could not be found!" );
                }




                // ---- Starts loading the levels

                //Gets the number of levels to load
                int levelsCount = file.ReadInt32( );

                //Initialize the levelPaths array
                string[] levelPaths = new string[levelsCount];

                for( int i = 0; i < levelsCount; i++ )
                {
                    //Get the name of the level
                    line = file.ReadString( );

                    string path = Path.Combine( levelsFolder, line + LEVEL_EXTENSION );
                    if( File.Exists( path ) )
                        levelPaths[i] = path;
                    else
                        Console.Write( line + LEVEL_EXTENSION + " could not be found!" );
                }


                // ---- Reads the name of the main game script

                bool gameScriptCreated = false;
                line = file.ReadString( );
                if( line != NO_SCRIPT )
                {
                    if( _scriptsDLL != null )
                    {
                        Type type = GetClassType( line );

                        if( type != null )
                        {
                            _Game = Activator.CreateInstance( type ) as LunarGame;

                            if( _Game != null )
                            {
                                _Game.GameManager = this;
                                _Game.GFX = _gfx;
                                _Game.SpriteBatch = new SpriteBatch( _gfx.GraphicsDevice );
                                _Game.Camera = new Camera( _gfx.GraphicsDevice.Viewport );

                                _Game.SpritePaths = spritePaths;
                                _Game.FontPaths = fontPaths;
                                _Game.LevelPaths = levelPaths;
                                _Game.ActorTypes = actorTypes;

                                gameScriptCreated = true;
                            }
                        }
                    }
                }

                //if the _Game wasn't initialized by a script, then create a default LunarGame instance
                if( !gameScriptCreated )
                {
                    _Game = new LunarGame( this, _gfx );
                }


                Effects.LoadEffects( this );


                _Game.Init( );


                file.Close( );
            }
        }
        #endregion

        #region Methods

        internal Type GetClassType( string className )
        {
            Type[] types = _scriptsDLL.GetTypes( );

            foreach( Type type in types )
            {
                if( type.IsClass && type.Name == className )
                    return type;
            }

            return null;
        }

        #endregion
    }
}
