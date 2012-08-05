using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Classes;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms.Main_Window
{
    public partial class AssetsBrowserDock : DockContent
    {
        #region Fields

        private Dictionary<string, AssetViewItem> _spriteItems;
        public Dictionary<string, AssetViewItem> SpriteItems
        {
            get { return _spriteItems; }
        }

        private Dictionary<string, AssetViewItem> _actorItems;
        public Dictionary<string, AssetViewItem> ActorItems
        {
            get { return _actorItems; }
        }

        private Dictionary<string, AssetViewItem> _scriptItems;
        public Dictionary<string, AssetViewItem> ScriptItems
        {
            get { return _scriptItems; }
        }

        private Dictionary<string, AssetViewItem> _fontItems;
        public Dictionary<string, AssetViewItem> FontItems
        {
            get { return _fontItems; }
        }



        private AssetViewItem _noSpriteItem;
        public AssetViewItem NoSpriteItem
        {
            get { return _noSpriteItem; }
        }

        private bool _isReset = false;

        #endregion

        #region Init

        public AssetsBrowserDock( )
        {
            InitializeComponent( );

            _actorItems = new Dictionary<string, AssetViewItem>( );
            _spriteItems = new Dictionary<string, AssetViewItem>( );
            _scriptItems = new Dictionary<string, AssetViewItem>( );
            _fontItems = new Dictionary<string, AssetViewItem>( );

            InitImageLists( );
        }

        private void InitImageLists( )
        {
            _spritesImageList.Images.Add( "*[Font]*", LunarDevKit.Properties.Resources.FontIcon );
            _spritesImageList.Images.Add( "*[Script]*", LunarDevKit.Properties.Resources.buttonscrpt2 );
            _spritesImageList.Images.Add( "*[NoSprite]*", LunarDevKit.Properties.Resources.NoSprite32 );
        }

        public void Initialize( string[] spritePaths, string[] scriptPaths, string[] actorPaths, string[] fontPaths )
        {
            try
            {
                if( !_isReset )
                    throw new Exception( Global.EditorTxt.AssetsInitializeError );

                if( !Directory.Exists( GetAssetFolder( AssetType.Sprite ) ) )
                    Directory.CreateDirectory( GetAssetFolder( AssetType.Sprite ) );
                if( !Directory.Exists( GetAssetFolder( AssetType.Actor ) ) )
                    Directory.CreateDirectory( GetAssetFolder( AssetType.Actor ) );
                if( !Directory.Exists( GetAssetFolder( AssetType.Script ) ) )
                    Directory.CreateDirectory( GetAssetFolder( AssetType.Script ) );
                if( !Directory.Exists( GetAssetFolder( AssetType.Font ) ) )
                    Directory.CreateDirectory( GetAssetFolder( AssetType.Font ) );

                _noSpriteItem = new AssetViewItem( AssetType.Sprite, "NoSprite" );
                _noSpriteItem.Sprite = Helper.GetSpriteFromImage( Global.GraphicsDevice, Properties.Resources.NoSprite );

                LoadAssets( spritePaths, scriptPaths, actorPaths, fontPaths );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        public void Reset( )
        {


            _isReset = true;
        }

        private void LoadAssets( string[] spritePaths, string[] scriptPaths, string[] actorPaths, string[] fontPaths )
        {
            if( spritePaths != null && spritePaths.Length > 0 )
            {
                foreach( string file in spritePaths )
                {
                    LoadSprite( file );
                }
            }

            if( scriptPaths != null && scriptPaths.Length > 0 )
            {
                foreach( string file in scriptPaths )
                {
                    LoadScript( file );
                }
            }

            if( fontPaths != null && fontPaths.Length > 0 )
            {
                foreach( string file in fontPaths )
                {
                    LoadFont( file );
                }

                if( Global.MainWindow.BuildAllContent( ) )
                {
                    foreach( AssetViewItem fontItem in _fontItems.Values )
                    {
                        //fontItem.Font.SpriteFont = Global.MainWindow.GetLoadedFont( fontItem.AssetName );
                    }
                }
            }

            if( actorPaths != null && actorPaths.Length > 0 )
            {
                foreach( string file in actorPaths )
                {
                    LoadActor( file );
                }
            }
        }

        #endregion

        #region Event Methods



        #endregion

        #region Methods

        #region Actor Methods

        private void AddActor( ActorTypeEd actor )
        {
            try
            {
                AssetViewItem item = new AssetViewItem( AssetType.Actor, actor.Name );
                _listAssets.Items.Add( item );
                item.Init( );
                item.Actor = actor;

                _actorItems.Add( actor.Name, item );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void AddNewActor( )
        {
            ActorTypeEd actor = new ActorTypeEd( );
            string name = "";
            int i = 1;
            do
            {
                name = "Actor" + i;
                i++;
            } while( _actorItems.ContainsKey( name ) );
            actor.Name = name;
            actor.Scale = 1f;
            actor.Rotation = 0f;
            actor.IsTextActor = false;
            actor.Text = "";
            actor.TextColor = Color.White;

            actor.FilePath = Path.Combine( GetAssetFolder( AssetType.Actor ), actor.Name + Consts.Files.ACTORTYPE_EXTENSION );
            actor.Save( );

            AddActor( actor );

            Global.MainWindow.OnAssetAdded( );
        }

        private void LoadActor( string filePath )
        {
            try
            {
                ActorTypeEd actor = FileManager.LoadActorTypeFile( filePath );

                //Checks if _spriteItems contains the actor sprite name reference
                //if( _spriteItems.ContainsKey( actor.TempSpriteName ) )
                //    //if so assign that sprite to the actor
                //    //actor.Sprite = _spriteItems[actor.TempSpriteName];
                //else
                //    //otherwise assign a defaul NoSprite to the actor
                //    actor.Sprite = _noSpriteItem;

                //Checks if _scriptItems contains the actor script name reference
                if( _scriptItems.ContainsKey( actor.TempScriptName ) )
                    //if so assign the script to the actor
                    actor.Script = _scriptItems[actor.TempScriptName].Script;

                //Checks if _fontItems contains the actor font name reference
                //if( _fontItems.ContainsKey( actor.TempFontName ) )
                //    //if so assign the font to the actor
                //    actor.FontAsset = _fontItems[actor.TempFontName];

                AddActor( actor );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void DeleteActor( AssetViewItem actorItem )
        {
            try
            {
                ActorTypeEd actorType = actorItem.Actor;

                Classes.Collections.ActorEdPool pool = new Classes.Collections.ActorEdPool( );

                foreach( LevelEd level in Global.World.Levels )
                {
                    foreach( LayerEd layer in level.Layers )
                    {
                        if( layer.Actors.Count == 0 )
                            continue;

                        foreach( ActorEd actor in layer.Actors )
                        {
                            if( actor.Parent == actorType )
                                pool.Add( actor );
                        }
                        foreach( ActorEd actor in pool )
                        {
                            layer.RemoveActor( actor );
                        }
                    }
                }

                File.Delete( actorItem.Actor.FilePath );

                _actorItems.Remove( actorType.Name );
                actorItem.Remove( );

                Global.MainWindow.OnAssetRemoved( );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        #endregion

        #region Sprite Methods

        private void AddSprite( SpriteEd sprite )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void AddNewSprite( )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void LoadSprite( string filepath )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void DeleteSprite( AssetViewItem spriteItem )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        #endregion

        #region Script Methods

        private void AddScript( Script script )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void AddNewScript( )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void LoadScript( string filepath )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void DeleteScript( AssetViewItem scriptItem )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        #endregion

        #region Font Methods

        private void AddFont( FontEd sprite )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void AddNewFont( )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void LoadFont( string filepath )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void DeleteFont( AssetViewItem fontItem )
        {
            try
            {

            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        #endregion

        #region Helper

        private string GetAssetFolder( AssetType assetType )
        {
            switch( assetType )
            {
                case AssetType.Actor:
                    return Path.Combine( Global.World.AssetsFolderPath, Consts.Folders.ACTORS );
                case AssetType.Sprite:
                    return Path.Combine( Global.World.AssetsFolderPath, Consts.Folders.SPRITES );
                case AssetType.Script:
                    return Path.Combine( Global.World.AssetsFolderPath, Consts.Folders.SCRIPTS );
                case AssetType.Font:
                    return Path.Combine( Global.World.AssetsFolderPath, Consts.Folders.FONTS );

                default:
                    return null;
            }
        }

        #endregion

        #endregion
    }
}
