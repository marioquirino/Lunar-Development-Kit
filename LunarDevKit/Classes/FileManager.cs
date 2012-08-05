using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Bitmap=System.Drawing.Bitmap;

namespace LunarDevKit.Classes
{
    using Collections;
    using Controls;

    public static class FileManager
    {
        #region Public Consts
        
        public const string NO_SCRIPT = "<No Script Assigned>";
        public const string NO_SPRITE = "<No Sprite Assigned>";

        #endregion

        #region World File Methods

        private const int WORLD_VERSION = 2;
        private const string NO_AUDIO = "<No audio project assigned>";

        /// <summary>
        /// Creates a World file given a World object.
        /// </summary>
        public static void CreateWorldFile( World world )
        {
            using( BinaryWriter file = new BinaryWriter( File.Create( world.FilePath ) ) )
            {
                // ---- Writes the file header

                file.Write( Consts.Editor.FILE_HEADER_ID );

                //Writes the version to check for compatibility
                file.Write( WORLD_VERSION );

                // ---- Writes the game settings data

                file.Write( world.GameSettings.Title );
                file.Write( world.GameSettings.Width );
                file.Write( world.GameSettings.Height );
                file.Write( world.GameSettings.Fullscreen );
                file.Write( world.GameSettings.EndWithEsc );
                file.Write( world.GameSettings.BackgroundColor.R );
                file.Write( world.GameSettings.BackgroundColor.G );
                file.Write( world.GameSettings.BackgroundColor.B );


                //Write the name of the assigned Audio Project
                if( string.IsNullOrEmpty( world.AudioProjectName ) )
                    file.Write( NO_AUDIO );
                else
                    file.Write( world.AudioProjectName );


                //Write the number of sprites
                file.Write( Global.AssetsBrowser.SpriteItems.Count );
                foreach( SpriteAssetItem spriteItem in Global.AssetsBrowser.SpriteItems.Values )
                {
                    //Write the sprite's name with the extension
                    file.Write( Path.GetFileName( spriteItem.FilePath ) );
                }


                //Write the number of scripts
                file.Write( Global.AssetsBrowser.ScriptItems.Count );
                foreach( ScriptAssetItem scriptItem in Global.AssetsBrowser.ScriptItems.Values )
                {
                    //Write the script's name with the extension
                    file.Write( Path.GetFileName( scriptItem.FilePath ) );
                }


                //Write the number of actortypes
                file.Write( Global.AssetsBrowser.ActorItems.Count );
                foreach( ActorAssetItem actorItem in Global.AssetsBrowser.ActorItems.Values )
                {
                    //Write the script's name
                    file.Write( actorItem.Actor.Name );
                }


                //Write the number of levels
                file.Write( world.Levels.Count );
                foreach( LevelEd level in world.Levels )
                {
                    //Write the level's name
                    file.Write( level.Name );
                }


                //Write the game script name if any
                if( world.Script == null )
                    file.Write( NO_SCRIPT );
                else
                    file.Write( world.Script.Name );

                //Write the number of fonts
                file.Write( Global.AssetsBrowser.FontItems.Count );
                foreach( FontAssetItem fontItem in Global.AssetsBrowser.FontItems.Values )
                {
                    //Write the font's name
                    file.Write( fontItem.Font.Name );
                }

                file.Close( );
            }

            if( string.IsNullOrEmpty( world.PluginsFilePath ) )
                world.PluginsFilePath = Path.Combine( world.WorldFolderPath, "Plugins.txt" );
            if( !File.Exists( world.PluginsFilePath ) )
                File.Create( world.PluginsFilePath );
        }
        /// <summary>
        /// Opens a World file given its path and returns a World object with the data.
        /// </summary>
        public static World LoadWorld( string filePath )
        {
            World world = new World( );

            world.FilePath = filePath;
            world.Name = Path.GetFileNameWithoutExtension( filePath );
            string path = Path.GetDirectoryName( filePath );
            world.WorldFolderPath = path;
            world.LevelsFolderPath = Path.Combine( path, Consts.Folders.LEVELS );
            world.BuildFolderPath = Path.Combine( path, Consts.Folders.BUILD );
            world.AssetsFolderPath = Path.Combine( path, Consts.Folders.ASSETS );

            path = Path.Combine( path, "Temp" );
            if( Directory.Exists( path ) )
                Directory.Delete( path, true );
            world.TempFolderPath = path;
            Directory.CreateDirectory( world.TempFolderPath );

            using( BinaryReader file = new BinaryReader( File.OpenRead( filePath ) ) )
            {
                // ---- Gets the file header and checks if it's a valid file

                if( file.ReadString( ) != Consts.Editor.FILE_HEADER_ID )
                {
                    file.Close( );
                    return null;
                }

                //Gets the version number
                int version = file.ReadInt32( );

                //Sets the name of the world
                world.Name = Path.GetFileNameWithoutExtension( filePath );

                // ---- Gets the game settings

                world.GameSettings.Title = file.ReadString( );
                world.GameSettings.Width = file.ReadInt32( );
                world.GameSettings.Height = file.ReadInt32( );
                world.GameSettings.Fullscreen = file.ReadBoolean( );
                world.GameSettings.EndWithEsc = file.ReadBoolean( );
                world.GameSettings.BackgroundColor = new Color( file.ReadByte( ), file.ReadByte( ), file.ReadByte( ) );

                if( version >= 2 )
                {
                    //Get the name of the audio project
                    string audioProj = file.ReadString( );
                    if( audioProj != NO_AUDIO )
                    {
                        string audioProjPath = Path.Combine( world.AssetsFolderPath, audioProj + ".xap" );
                        if( File.Exists( audioProjPath ) )
                            world.AudioProjectName = audioProj;
                    }
                }


                // ---- Sprites Data

                //Get the number of sprite references
                int spriteCount = file.ReadInt32( );

                if( spriteCount > 0 )
                {
                    string line;

                    world.TempSpritePaths = new string[spriteCount];
                    string folder = Path.Combine( world.AssetsFolderPath, Consts.Folders.SPRITES );

                    for( int i = 0; i < spriteCount; i++ )
                    {
                        //Get the sprite's name, which already comes with the extension
                        line = file.ReadString( );

                        world.TempSpritePaths[i] = Path.Combine( folder, line );
                    }
                }


                // ---- Scripts Data

                //Get the number of script references
                int scriptCount = file.ReadInt32( );

                if( scriptCount > 0 )
                {
                    string line;

                    world.TempScriptPaths = new string[scriptCount];
                    string folder = Path.Combine( world.AssetsFolderPath, Consts.Folders.SCRIPTS );

                    for( int i = 0; i < scriptCount; i++ )
                    {
                        //Get the script's name, which already comes with the extension
                        line = file.ReadString( );

                        world.TempScriptPaths[i] = Path.Combine( folder, line );
                    }
                }


                // ---- Actors Data

                //Get the number of actor references
                int actorCount = file.ReadInt32( );

                if( actorCount > 0 )
                {
                    string line;

                    world.TempActorPaths = new string[actorCount];
                    string folder = Path.Combine( world.AssetsFolderPath, Consts.Folders.ACTORS );

                    for( int i = 0; i < actorCount; i++ )
                    {
                        //Get the actor's name
                        line = file.ReadString( );

                        world.TempActorPaths[i] = Path.Combine( folder, line + Consts.Files.ACTORTYPE_EXTENSION );
                    }
                }


                // ---- Levels Data

                //Get the number of level references
                int levelsCount = file.ReadInt32( );

                if( levelsCount > 0 )
                {
                    string line;

                    //Initializes the TempLevelPaths array to hold the paths of the levels.
                    //These paths will be later used to load the levels.
                    world.TempLevelPaths = new string[levelsCount];

                    for( int i = 0; i < levelsCount; i++ )
                    {
                        //Gets the level's name
                        line = file.ReadString( );

                        //Combines the path of the Levels folder with the level name and add it to the array.
                        world.TempLevelPaths[i] = Path.Combine( world.LevelsFolderPath, line + Consts.Files.LEVEL_EXTENSION );
                    }
                }


                // ---- Read the world's script

                //Get the world's script name. It will be assigned later, after the assets have been properly loaded.
                world.TempScriptName = file.ReadString( );


                //This will check which version it is and will retrieve data that is only supported in version 2 and superior.
                if( version >= 2 )
                {
                    //Get the number of fonts
                    int fontCount = file.ReadInt32( );

                    //if the number of fonts is greater than zero then start retrieving their name references
                    if( fontCount > 0 )
                    {
                        string line;

                        //Initialize the array
                        world.TempFontPaths = new string[fontCount];
                        //Set up the correct folder path
                        string folder = Path.Combine( world.AssetsFolderPath, Consts.Folders.FONTS );

                        for( int i = 0; i < fontCount; i++ )
                        {
                            //Get the font's name
                            line = file.ReadString( );

                            world.TempFontPaths[i] = Path.Combine( folder, line + Consts.Files.FONT_EXTENSION );
                        }
                    }
                }

                file.Close( );
            }

            return world;
        }

        #endregion World File Methods

        #region Level File Methods

        private const int LEVEL_VERSION = 2;

        /// <summary>
        /// Creates a Level file given a Level object.
        /// </summary>
        public static void CreateLevelFile( LevelEd level )
        {
            using( BinaryWriter writer = new BinaryWriter( File.Create( level.FilePath ) ) )
            {
                // ---- Writes the file header

                writer.Write( Consts.Editor.FILE_HEADER_ID );

                //Writes the level file version
                writer.Write( LEVEL_VERSION );

                //Writes the level's script name, if any
                if( level.Script == null )
                    writer.Write( NO_SCRIPT );
                else
                    writer.Write( level.Script.Name );

                //Writes the number of layers
                writer.Write( level.Layers.Count );

                //Iterates through each layer and saves its data
                foreach( LayerEd layer in level.Layers )
                {
                    LevelLayerWriteData( layer, writer );
                }

                writer.Close( );
            }
        }

        #region Create Level File Private Methods

        private static void LevelLayerWriteData( LayerEd layer, BinaryWriter writer )
        {
            // ---- Writes the layer data

            writer.Write( layer.Name );
            writer.Write( layer.Visible );
            writer.Write( layer.Locked );
            writer.Write( layer.Scale );


            //Writes the number of actors
            writer.Write( layer.Actors.Count );

            //Iterates through each actor and saves its data
            foreach( ActorEd actor in layer.Actors )
            {
                LevelActorWriteData( actor, writer );
            }
        }

        private static void LevelActorWriteData( ActorEd actor, BinaryWriter writer )
        {
            writer.Write( actor.ID );
            writer.Write( actor.Parent.Name );
            writer.Write( actor.Name );
            writer.Write( actor.Position.X );
            writer.Write( actor.Position.Y );
            writer.Write( actor.Origin.X );
            writer.Write( actor.Origin.Y );
            writer.Write( actor.Scale );
            writer.Write( actor.Rotation );
            writer.Write( actor.Visible );

            if( actor.Tags == null )
                actor.Tags = new string[1] { actor.Parent.Name };
            writer.Write( actor.Tags.Length );
            foreach( string tag in actor.Tags )
            {
                writer.Write( tag );
            }

            writer.Write( actor.IsTextActor );
            if( actor.IsTextActor )
            {
                writer.Write( actor.Text );
                writer.Write( actor.TextColor.R );
                writer.Write( actor.TextColor.G );
                writer.Write( actor.TextColor.B );
                writer.Write( actor.TextColor.A );
            }
        }

        #endregion Create Level File Private Methods

        /// <summary>
        /// Opens a Level file given its path and returns a Level object with the data.
        /// </summary>
        public static LevelEd LoadLevel( string filePath )
        {
            LevelEd level = new LevelEd( );

            //Sets the name of the level
            level.Name = Path.GetFileNameWithoutExtension( filePath );

            using( BinaryReader reader = new BinaryReader( File.OpenRead( filePath ) ) )
            {
                // ---- Gets the header data

                if( reader.ReadString( ) != Consts.Editor.FILE_HEADER_ID )
                {
                    reader.Close( );
                    return null;
                }

                //Gets the version of the file
                int levelVersion = reader.ReadInt32( );




                // ---- Read and assign the level's script

                //Get the level's script name
                string scriptName = reader.ReadString( );
                
                //First check if the script name is a valid one
                if( scriptName != NO_SCRIPT )
                {
                    //Check if the assets list of scripts contains the given script name
                    if( Global.AssetsBrowser.ScriptItems.ContainsKey( scriptName ) )
                        level.Script = Global.AssetsBrowser.ScriptItems[scriptName].Script;
                    else
                        MessageBox.Show( scriptName + " could not be found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }

                

                // ---- Reads through the layers data

                //Gets the number of layers
                int layersCount = reader.ReadInt32( );

                for( int i = 0; i < layersCount; i++ )
                {
                    LevelLayerReadData( level, reader, levelVersion );
                }

                reader.Close( );
            }

            level.FilePath = filePath;
            level.LevelAdded = true;

            return level;

        }

        #region Load Level File Private Methods

        private static void LevelLayerReadData( LevelEd level, BinaryReader file, int version )
        {
            LayerEd layer = new LayerEd( file.ReadString( ) );
            layer.Visible = file.ReadBoolean( );
            layer.Locked = file.ReadBoolean( );
            layer.Scale = file.ReadSingle( );

            //Gets the number of actors
            int actorsCount = file.ReadInt32( );

            for( int i = 0; i < actorsCount; i++ )
            {
                LevelActorReadData( layer, file, version );
            }

            level.NewLayer( layer );
        }

        private static void LevelActorReadData( LayerEd layer, BinaryReader file, int version )
        {
            ActorEd actor;

            int id = file.ReadInt32( );
            string actorTypeName = file.ReadString( );
            if( Global.AssetsBrowser.ActorItems.ContainsKey( actorTypeName ) )
            {
                actor = Global.AssetsBrowser.ActorItems[actorTypeName].Actor.CreateActor( id );
                actor.Name = file.ReadString( );
                actor.Position = new Vector2( file.ReadSingle( ), file.ReadSingle( ) );
                actor.Origin = new Vector2( file.ReadSingle( ), file.ReadSingle( ) );
                actor.Scale = file.ReadSingle( );
                actor.Rotation = file.ReadSingle( );
                actor.Visible = file.ReadBoolean( );
                layer.AddActor( actor );

                if( version >= 2 )
                {
                    int tagCount = file.ReadInt32( );
                    actor.Tags = new string[tagCount];
                    for( int i = 0; i < tagCount; i++ )
                    {
                        actor.Tags[i] = file.ReadString( );
                    }

                    //Checks if the actor is a TextActor
                    if( file.ReadBoolean( ) )
                    {
                        actor.Text = file.ReadString( );
                        actor.TextColor = new Color( file.ReadByte( ), file.ReadByte( ), file.ReadByte( ), file.ReadByte( ) );
                    }
                }

                actor.AddedToLevel = true;
            }
            else
            {
                file.ReadString( ); //Name
                file.ReadSingle( ); //Pos X
                file.ReadSingle( ); //Pos Y
                file.ReadSingle( ); //Origin X
                file.ReadSingle( ); //Origin Y
                file.ReadSingle( ); //Scale
                file.ReadSingle( ); //Rotation
                file.ReadBoolean( );//Visible
                if( version >= 2 && file.ReadBoolean( ) ) //IsTextActor
                {
                    file.ReadString( );     //Text
                    file.ReadBytes( 4 );    //TextColor
                }
                MessageBox.Show( Global.EditorTxt.ActortypeNotFoundError, "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        #endregion Load Level File Private Methods

        #endregion Level File Methods

        #region ActorType File Methods

        private const int ACTOR_VERSION = 3;

        /// <summary>
        /// Creates an ActorType file given an ActorType object.
        /// </summary>
        internal static void CreateActorTypeFile( ActorTypeEd actorType )
        {
            try
            {
                using( BinaryWriter file = new BinaryWriter( File.Create( actorType.FilePath ) ) )
                {
                    // ---- Write the header data

                    file.Write( Consts.Editor.FILE_HEADER_ID );

                    //Writes the file version
                    file.Write( ACTOR_VERSION );


                    // ---- Write the actor data

                    //Write the name
                    file.Write( actorType.Name );

                    //Write the scale
                    file.Write( actorType.Scale );

                    //Write the rotation angle
                    file.Write( actorType.Rotation );

                    if( actorType.SpriteAsset != Global.AssetsBrowser.NoSpriteItem )
                        //Write the sprite name
                        file.Write( actorType.SpriteAsset.AssetName );
                    else
                        file.Write( NO_SPRITE );

                    //Write the script name, if this actortype has one associated
                    if( actorType.Script == null )
                        file.Write( NO_SCRIPT );
                    else
                        file.Write( actorType.Script.Name );

                    //Writes the number of tags
                    file.Write( actorType.Tags.Length );

                    //Write all tags
                    foreach( string tag in actorType.Tags )
                    {
                        file.Write( tag );
                    }

                    //Writes the IsTextActor flag
                    file.Write( actorType.IsTextActor );

                    //Checks if it's actually a TextActor, in order to write additional data
                    if( actorType.IsTextActor )
                    {
                        //Writes the font name
                        file.Write( actorType.FontAsset.Font.Name );

                        //Writes the text of the actor
                        file.Write( actorType.Text );

                        //Writes the text color
                        file.Write( actorType.TextColor.R );
                        file.Write( actorType.TextColor.G );
                        file.Write( actorType.TextColor.B );
                        file.Write( actorType.TextColor.A );
                    }


                    file.Close( );
                }
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        /// <summary>
        /// Opens an ActorType file given its path and returns an ActorType object with the data.
        /// </summary>
        internal static ActorTypeEd LoadActorTypeFile( string filePath )
        {
            ActorTypeEd actorType;

            if( !File.Exists( filePath ) )
            {
                MessageBox.Show( Path.GetFileName( filePath ) + Global.EditorTxt.FileNotFound, "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return null;
            }

            using( BinaryReader file = new BinaryReader( File.OpenRead( filePath ) ) )
            {
                // ---- Reads the header

                if( file.ReadString( ) != Consts.Editor.FILE_HEADER_ID )
                {
                    file.Close( );
                    return null;
                }

                //Get the version of this file.
                int version = file.ReadInt32( );

                //Initialize a new ActorType instance
                actorType = new ActorTypeEd( );

                //Get the actortype name
                actorType.Name = file.ReadString( );

                //Get the actortype scale
                actorType.Scale = file.ReadSingle( );

                //Get the actortype rotation angle
                actorType.Rotation = file.ReadSingle( );

                //Get the sprite name reference. It will later be used to attach the correct sprite to this actortype
                actorType.TempSpriteName = file.ReadString( );

                //Get the script name reference. It will later be used to attach the correct script to this actortype
                actorType.TempScriptName = file.ReadString( );


                actorType.TempFontName = "";

                actorType.Tags = new string[] { actorType.Name };
                if( version >= 3 )
                {
                    int tagCount = file.ReadInt32( );

                    actorType.Tags = new string[tagCount];
                    for( int i = 0; i < tagCount; i++ )
                    {
                        actorType.Tags[i] = file.ReadString( );
                    }
                }


                //Checks for the version and get data supported by the current version
                //Includes the addition from version 3
                if( version >= 2 )
                {
                    //Get the value determining whether the actortype is a TextActor
                    actorType.IsTextActor = file.ReadBoolean( );

                    if( actorType.IsTextActor )
                    {
                        //Get the name of the font
                        actorType.TempFontName = file.ReadString( );

                        //Get the text of the actor
                        actorType.Text = file.ReadString( );

                        //Get the text's color
                        actorType.TextColor = new Color( file.ReadByte( ), file.ReadByte( ), file.ReadByte( ) );

                        if( version >= 3 )
                            actorType.TextColor = new Color( actorType.TextColor, file.ReadByte( ) );
                    }
                }

                file.Close( );
            }

            actorType.FilePath = filePath;

            return actorType;
        }

        #endregion ActorType File Methods

        #region Script File Methods

        public static void CreateScriptFile( Script script )
        {
            using( StreamWriter writer = new StreamWriter( File.Create( script.FilePath ) ) )
            {
                //string[] lines = script.ScriptText.Split( '\n' );
                //foreach( string line in lines )
                //{
                //    writer.WriteLine( line );
                //}
                writer.Write( script.ScriptText );
                writer.Close( );
            }
        }

        public static Script LoadScriptFile( string filePath )
        {

            Script script = new Script( Path.GetFileNameWithoutExtension( filePath ) );

            switch( Path.GetExtension( filePath ) )
            {
                case Consts.Files.LUVISUAL_EXTENSION:

                    script.ScriptType = ScriptType.Visual;
                    break;

                case Consts.Files.CSHARP_EXTENSION:
                    using( StreamReader reader = new StreamReader( File.OpenRead( filePath ) ) )
                    {
                        script.ScriptText = reader.ReadToEnd( );
                        reader.Close( );
                    }
                    script.ScriptType = ScriptType.CSharp;
                    break;

                default:
                    MessageBox.Show( "Invalid extension for a script file!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    return null;
            }

            script.FilePath = filePath;
            return script;
        }

        #endregion

        #region Font File Methods

        public static void CreateFontFile( FontEd font )
        {
            using( StreamWriter writer = new StreamWriter( File.Create( font.FilePath ) ) )
            {
                writer.Write( font.Text );
                writer.Close( );
            }
        }

        public static FontEd LoadFontFile( string filePath )
        {
            if( !File.Exists( filePath ) )
            {
                MessageBox.Show( Path.GetFileName( filePath ) + Global.EditorTxt.FileNotFound, "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return null;
            }

            FontEd font = new FontEd( );
            font.Name = Path.GetFileNameWithoutExtension( filePath );

            if( Path.GetExtension( filePath ) == ".spritefont" )
            {
                using( StreamReader reader = new StreamReader( File.OpenRead( filePath ) ) )
                {
                    font.Text = reader.ReadToEnd( );
                    reader.Close( );
                }

                Global.MainWindow.AddFontToLoad( filePath );
            }
            else
            {
                MessageBox.Show( "Invalid extension for a sprite font file!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return null;
            }

            font.FilePath = filePath;
            return font;
        }

        #endregion

        #region Package File Methods

        public static void CreatePackageFile( string name, string description, AssetsTreeView assetsTree )
        {
            using( BinaryWriter writer = new BinaryWriter( File.Create( Consts.Folders.PACKAGES + name + Consts.Files.PACKAGE_EXTENSION ) ) )
            {
                writer.Write( name );
                writer.Write( description );
                writer.Write( "[Sprites]" );
                //PackageWriteData( assetsTree.SpritesNode.Nodes, writer );
                writer.Write( "[EndSprites]" );
                writer.Write( "[Archetypes]" );
                //PackageWriteData( assetsTree.ArchetypesNode.Nodes, writer );
                writer.Write( "[EndArchetypes]" );
                writer.Close( );
            }
        }

        public static void ImportPackageToWorld( string filePath )
        {
            if ( Global.World != null && File.Exists( filePath ) )
            {
                string str;

                using( BinaryReader reader = new BinaryReader( File.OpenRead( filePath ) ) )
                {
                    reader.ReadString( ); //Name
                    reader.ReadString( ); //Description
                    reader.ReadString( ); //[Sprites]

                    str = reader.ReadString( ); //[EndSprites] or other
                    while( str != "[EndSprites]" )
                    {
                        //AssetNode parent = Properties.Assets.AssetsTree.SpritesNode;

                        switch( str )
                        {
                            case "[Folder]":
                                //PackageReadData( NodeType.Folder, parent, reader );
                                break;

                            case "[Sprite]":
                                //PackageReadData( NodeType.Sprite, parent, reader );
                                break;
                        }

                        str = reader.ReadString( ); //[EndSprites] or other
                    }
                    reader.ReadString( ); //[Archetypes]

                    str = reader.ReadString( ); //[EndArchetypes] or other
                    while( str != "[EndArchetypes]" )
                    {
                        //AssetNode parent = Properties.Assets.AssetsTree.ArchetypesNode;

                        switch( str )
                        {
                            case "[Folder]":
                                //PackageReadData( NodeType.Folder, parent, reader );
                                break;

                            case "[Archetype]":
                                //PackageReadData( NodeType.Archetype, parent, reader );
                                break;
                        }

                        str = reader.ReadString( ); //[EndArchetypes] or other
                    }
                    reader.Close( );
                }
            }
        }

        #region Private Methods

        private static void PackageWriteData( TreeNodeCollection nodes, BinaryWriter writer )
        {
            foreach ( AssetNode node in nodes )
            {
                switch ( node.NodeType )
                {
                    case NodeType.Folder:
                        writer.Write( "[Folder]" );
                        writer.Write( node.Text );
                        PackageWriteData( node.Nodes, writer );
                        writer.Write( "[EndFolder]" );
                        break;

                    case NodeType.Sprite:
                        writer.Write( "[Sprite]" );
                        writer.Write( node.Text + node.FilePath.Remove( 0, node.FilePath.Length - 4 ) ); //Sprite Name + Extension

                        byte[] data = File.ReadAllBytes( node.FilePath );
                        writer.Write( data.LongLength );
                        foreach ( byte dat in data )
                            writer.Write( dat );

                        writer.Write( "[EndSprite]" );
                        break;

                    case NodeType.ActorType:
                        writer.Write( "[Archetype]" );
                        //ActorTypeWriteData( node.ActorType, writer );
                        writer.Write( "[EndArchetype]" );
                        break;
                }
            }
        }

        private static void PackageReadData( NodeType type, AssetNode parent, BinaryReader reader )
        {
            string str;

            switch ( type )
            {
                case NodeType.Folder:
                    str = reader.ReadString( ); //Folder Name
                    //Global.Assets.AssetsTree.AddFolder( str, parent, false );

                    str = reader.ReadString( );
                    while ( str != "[EndFolder]" )
                    {
                        //AssetNode newParent = Global.Assets.AssetsTree.LastCreatedNode;
                        //switch( str )
                        //{
                        //    case "[Folder]":
                        //        PackageReadData( NodeType.Folder, newParent, reader );
                        //        break;

                        //    case "[Sprite]":
                        //        PackageReadData( NodeType.Sprite, newParent, reader );
                        //        break;

                        //    case "[Archetype]":
                        //        PackageReadData( NodeType.ActorType, newParent, reader );
                        //        break;
                        //}

                        str = reader.ReadString( ); //[EndFolder] or other
                    }
                    break;

                case NodeType.Sprite:
                    str = reader.ReadString( ); //Sprite Name
                    string path = parent.FilePath + str;

                    long length = reader.ReadInt64( );
                    BinaryWriter writer = new BinaryWriter( File.Create( path ) );
                    for ( int i = 0; i < length; i++ )
                        writer.Write( reader.ReadByte( ) );
                    writer.Close( );

                    //Properties.Assets.AssetsTree.AddSprite( path, str, parent );
                    reader.ReadString( ); //[EndSprite]
                    break;

                case NodeType.ActorType:
                    //ActorTypeEd a = ActorTypeReadData( reader );

                    //a.FilePath = parent.FilePath + a.Name + Consts.Files.ACTORTYPE_EXTENSION;
                    //a.SpriteNode = Properties.Assets.AssetsTree.GetSpriteNode( a.InitialSpritePath );

                    //CreateActorTypeFile( a );

                    //Global.Assets.AssetsTree.AddActorType( a, parent );

                    reader.ReadString( ); //[EndArchetype]
                    break;
            }
        }

        #endregion

        #endregion

        #region Game File Methods

        private const int GAME_VERSION = 2;

        #region Create Game File
        public static void CreateGameFile( World world, string filePath )
        {
            if( !Directory.Exists( world.BuildFolderPath ) )
                Directory.CreateDirectory( world.BuildFolderPath );

            using( BinaryWriter file = new BinaryWriter( File.Create( filePath ) ) )
            {
                try
                {
                    // ---- Init local vars

                    string mainFolder = Path.GetDirectoryName( filePath );


                    // ---- Write the file header

                    file.Write( Consts.Editor.FILE_HEADER_ID );

                    //Writes the file version
                    file.Write( GAME_VERSION );


                    // ---- Writing the game settings to the file

                    file.Write( world.GameSettings.Title );
                    file.Write( world.GameSettings.Width );
                    file.Write( world.GameSettings.Height );
                    file.Write( world.GameSettings.Fullscreen );
                    file.Write( world.GameSettings.EndWithEsc );
                    file.Write( world.GameSettings.BackgroundColor.R );
                    file.Write( world.GameSettings.BackgroundColor.G );
                    file.Write( world.GameSettings.BackgroundColor.B );


                    if( string.IsNullOrEmpty( world.AudioProjectName ) )
                        file.Write( NO_AUDIO );
                    else
                        file.Write( world.AudioProjectName );


                    // ---- Writing the sprite references

                    //Write the number of sprites
                    file.Write( Global.AssetsBrowser.SpriteItems.Count );

                    foreach( SpriteAssetItem sprite in Global.AssetsBrowser.SpriteItems.Values )
                    {
                        file.Write( Path.GetFileNameWithoutExtension( sprite.FilePath ) );
                    }



                    // ---- Writing the font references

                    //Write the number of fonts
                    file.Write( Global.AssetsBrowser.FontItems.Count );

                    foreach( FontAssetItem font in Global.AssetsBrowser.FontItems.Values )
                    {
                        file.Write( Path.GetFileNameWithoutExtension( font.FilePath ) );
                    }




                    // ---- Writing the actortype references

                    //Write the number of actortypes
                    file.Write( Global.AssetsBrowser.ActorItems.Count );

                    foreach( ActorAssetItem actorItem in Global.AssetsBrowser.ActorItems.Values )
                    {
                        //Write the actor's name
                        file.Write( actorItem.Actor.Name );
                    }



                    // ---- Writing the level references

                    //Write the number of levels
                    file.Write( world.Levels.Count );

                    foreach( LevelEd level in world.Levels )
                    {
                        file.Write( level.Name );
                    }


                    //Write the game script name
                    if( world.Script == null )
                        file.Write( NO_SCRIPT );
                    else
                        file.Write( world.Script.Name );
                }
                catch( Exception e )
                {
                    ErrorReport.Throw( e );
                    return;
                }
                finally
                {
                    file.Close( );
                }
            }
        }
        #endregion


        private const int GAME_LEVEL_VERSION = 3;

        #region Create Game Level File

        public static void CreateGameLevelFile( LevelEd level, string filePath )
        {
            using( BinaryWriter file = new BinaryWriter( File.Create( filePath ) ) )
            {
                // ---- Write the header data

                file.Write( Consts.Editor.FILE_HEADER_ID );

                //Writes the file version
                file.Write( GAME_LEVEL_VERSION );


                //Write the script name reference
                if( level.Script == null )
                    file.Write( NO_SCRIPT );
                else
                    file.Write( level.Script.Name );



                // ---- Start to write the sprite and font references for this level

                //Create a local list of string values to store the sprites used in this level
                List<string> spriteNames = new List<string>( );
                //Create a local list of string values to store the fonts used in this level
                List<string> fontNames = new List<string>( );

                //iterate through each layer
                foreach( LayerEd layer in level.Layers )
                {
                    //then iterate through each actor of the current layer
                    foreach( ActorEd actor in layer.Actors )
                    {
                        if( !actor.IsTextActor )
                        {
                            //check if list contains the name of the sprite used by the current actor
                            if( !string.IsNullOrEmpty( actor.Sprite.Name ) && !spriteNames.Contains( actor.Sprite.Name ) )
                                //if not, then add the sprite name to the list
                                spriteNames.Add( actor.Sprite.Name );
                        }
                        else
                        {
                            //check if list contains the name of the font used by the current actor
                            if( actor.FontAsset != null && !fontNames.Contains( actor.FontAsset.AssetName ) )
                                //if not, then add the font name to the list
                                fontNames.Add( actor.FontAsset.AssetName );
                        }
                    }
                }

                //Write the number of sprite names
                file.Write( spriteNames.Count );

                //Iterate through each name in the list
                foreach( string spriteName in spriteNames )
                {
                    //and write the name to the file
                    file.Write( spriteName );
                }

                //Write the number of font names
                file.Write( fontNames.Count );

                //Iterate through each name in the list
                foreach( string fontName in fontNames )
                {
                    //and write the name to the file
                    file.Write( fontName );
                }




                // ---- Start to write the layers data

                //Write the number of layers
                file.Write( level.Layers.Count );
                foreach( LayerEd layer in level.Layers )
                {
                    //Write the layer data
                    GameLevelLayerWriteData( layer, file );
                }
                file.Close( );
            }
        }

        #region Write Game Level Data Private Methods

        private static void GameLevelLayerWriteData( LayerEd layer, BinaryWriter file )
        {
            file.Write( layer.Name );
            file.Write( layer.Visible );
            file.Write( layer.Scale );

            file.Write( layer.Actors.Count ); //Number of actors
            foreach( ActorEd actor in layer.Actors )
            {
                GameLevelActorWriteData( actor, file );
            }
        }

        private static void GameLevelActorWriteData( ActorEd actor, BinaryWriter file )
        {
            file.Write( actor.ID );
            if( actor.Sprite.Name != null )
                file.Write( actor.Sprite.Name );
            else
                file.Write( NO_SPRITE );

            if( actor.Parent.Script == null )
                file.Write( NO_SCRIPT );
            else
                file.Write( actor.Parent.Script.Name );
            file.Write( actor.Name );
            file.Write( actor.Position.X );
            file.Write( actor.Position.Y );
            file.Write( actor.Origin.X );
            file.Write( actor.Origin.Y );
            file.Write( actor.Scale );
            file.Write( actor.Rotation );
            file.Write( actor.Visible );

            file.Write( actor.Tags.Length );
            foreach( string tag in actor.Tags )
            {
                file.Write( tag );
            }

            file.Write( actor.IsTextActor );
            if( actor.IsTextActor )
            {
                file.Write( actor.FontAsset.Font.Name );
                file.Write( actor.Text );
                file.Write( actor.TextColor.R );
                file.Write( actor.TextColor.G );
                file.Write( actor.TextColor.B );
                file.Write( actor.TextColor.A );
            }
        }

        #endregion Write Level Data Private Methods

        #endregion


        private const int GAME_ACTOR_VERSION = 3;

        #region Create Game Actor File

        public static void CreateGameActorFile( ActorTypeEd actorType, string filePath )
        {
            using( BinaryWriter file = new BinaryWriter( File.Create( filePath ) ) )
            {
                // ---- Write the header data

                file.Write( Consts.Editor.FILE_HEADER_ID );

                //Writes the file version
                file.Write( GAME_ACTOR_VERSION );


                // ---- Write the actor data

                //Write the name
                file.Write( actorType.Name );

                //Write the scale
                file.Write( actorType.Scale );

                //Write the rotation angle
                file.Write( actorType.Rotation );
                
                //Write the sprite name
                if( actorType.SpriteAsset.AssetName == null )
                    file.Write( NO_SPRITE );
                else
                    file.Write( actorType.SpriteAsset.AssetName );

                //Write the script name, if this actortype has one associated
                if( actorType.Script == null )
                    file.Write( NO_SCRIPT );
                else
                    file.Write( actorType.Script.Name );

                file.Write( actorType.Tags.Length );
                foreach( string tag in actorType.Tags )
                {
                    file.Write( tag );
                }

                file.Write( actorType.IsTextActor );
                if( actorType.IsTextActor )
                {
                    file.Write( actorType.FontAsset.Font.Name );
                    file.Write( actorType.Text );
                    file.Write( actorType.TextColor.R );
                    file.Write( actorType.TextColor.G );
                    file.Write( actorType.TextColor.B );
                    file.Write( actorType.TextColor.A );
                }


                file.Close( );
            }
        }

        #endregion

        #endregion
    }
}
