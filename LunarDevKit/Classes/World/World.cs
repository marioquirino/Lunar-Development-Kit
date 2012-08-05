using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit.Classes
{
    using Forms;
    using Forms.Main_Window;
    using Zones;
    using Controls;
    using Collections;
    using Classes;

    public class World
    {
        #region Fields

        private LevelEdPool levels = new LevelEdPool( );

        public string Name;
        public string FilePath;

        public string GameFilePath;

        public string LevelsFolderPath;
        public string AssetsFolderPath;
        public string WorldFolderPath;
        public string BuildFolderPath;
        public string TempFolderPath;
        public string PluginsFilePath;

        public string[] TempLevelPaths;
        public string[] TempSpritePaths;
        public string[] TempScriptPaths;
        public string[] TempActorPaths;
        public string[] TempFontPaths;
        public string TempScriptName;

        public GameSettings GameSettings;

        public string AudioProjectName;

        #endregion

        #region Properties

        public LevelEdPool Levels
        {
            get { return levels; }
        }

        private Script _script;
        public Script Script
        {
            get { return _script; }
            set { _script = value; }
        }

        #endregion

        #region Constructors

        public World( )
        {
            GameSettings.Title = "My Game";
            GameSettings.Width = 800;
            GameSettings.Height = 600;
            GameSettings.Fullscreen = false;
            GameSettings.EndWithEsc = true;
            GameSettings.BackgroundColor = Color.Black;
        }

        #endregion
        
        #region Methods

        public void OpenLevel( LevelEd level )
        {
            levels.Add( level );

            MainWindow wnd = Global.MainWindow;

            LevelDocument levelDoc = new LevelDocument( );
            levelDoc.Level = level;
            levelDoc.Text = level.Name;
            wnd.AddLevelDoc( levelDoc );

            levelDoc.Viewport.Camera.Position = Vector2.Zero;

            wnd.EnableLevelButtons( );
        }

        public void OpenLevel( string levelFilePath )
        {
            OpenLevel( FileManager.LoadLevel( levelFilePath ) );
        }

        public bool LevelExists( string name )
        {
            foreach( LevelEd level in levels )
            {
                if( level.Name == name )
                    return true;
            }

            return false;
        }

        #endregion
    }
}
