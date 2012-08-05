using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit
{
    using Classes;
    using Controls;
    using Forms;
    using Forms.Main_Window;
    using Forms.Script_Editor;

    public static class Global
    {
        internal static lang_English EditorTxt;

        public static MainWindow MainWindow;

        /// <summary>
        /// Global wrapper for the MainWindow's UndoProvider object.
        /// </summary>
        public static UndoProvider UndoProvider
        {
            get { return MainWindow.UndoProvider; }
        }

        public static LevelDocument SelectedLevelDoc
        {
            get { return MainWindow.SelectedLevel; }
        }
        public static LevelEd SelectedLevel2
        {
            get
            {
                if( SelectedLevelDoc == null )
                    return null;

                return SelectedLevelDoc.Level;
            }
        }

        public static LevelTabPage SelectedLevel;

        public static LayersDock Layers
        {
            get { return MainWindow.Layers; }
        }

        public static ImageList AssetsTreeViewImages;
        public static AssetsBrowserWindow AssetsBrowser
        {
            get { return MainWindow.AssetsBrowser; }
        }

        public static ToolsDock Tools
        {
            get { return MainWindow.Tools; }
        }

        public static PropertiesDock Properties
        {
            get { return MainWindow.Properties; }
        }

        public static ScriptEditor ScriptEditor
        {
            get { return MainWindow.ScriptEditor; }
        }

        public static GraphicsDevice GraphicsDevice;
        public static Texture2D Pixel;

        public static SpriteEd LastCreatedSprite;

        public static World World;



        public static bool DesignMode
        {
            get { return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime; }
        }

        public static void DisplayMessage( string message, float duration )
        {
            Global.MainWindow.DisplayMessage( message, duration );
        }
    }
}
