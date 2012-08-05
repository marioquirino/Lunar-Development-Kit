using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LunarDevKit.Classes;
using LunarEngine.Collections;
using WeifenLuo.WinFormsUI.Docking;

namespace LunarDevKit.Forms
{
    using Controls;

    public partial class AssetsBrowserWindow : DockContent
    {
        #region Fields

        private Dictionary<string, SpriteAssetItem> _spriteItems;
        public Dictionary<string, SpriteAssetItem> SpriteItems
        {
            get { return _spriteItems; }
        }

        private Dictionary<string, ActorAssetItem> _actorItems;
        public Dictionary<string, ActorAssetItem> ActorItems
        {
            get { return _actorItems; }
        }

        private Dictionary<string, ScriptAssetItem> _scriptItems;
        public Dictionary<string, ScriptAssetItem> ScriptItems
        {
            get { return _scriptItems; }
        }

        private Dictionary<string, FontAssetItem> _fontItems;
        public Dictionary<string, FontAssetItem> FontItems
        {
            get { return _fontItems; }
        }
                
        private SpriteAssetItem _selectedSpriteItem;
        private ScriptAssetItem _selectedScriptItem;
        private FontAssetItem _selectedFontItem;

        private ActorAssetItem _selectedActorItem;
        public ActorAssetItem SelectedActorType
        {
            get { return _selectedActorItem; }
        }

        public SpriteAssetItem NoSpriteItem
        {
            get
            {
                if( _spritesTab.Controls.Count <= 1 )
                    return null;
                return _spritesTab.Controls[1] as SpriteAssetItem;
            }
        }
        public SpriteEd NoSprite
        {
            get { return NoSpriteItem.Sprite; }
        }

        private ScriptAssetItem _lastCreatedScript;
        public ScriptAssetItem LastCreatedScript
        {
            get { return _lastCreatedScript; }
        }
        
        private bool _isReset = false;

        #endregion

        #region Initialization

        public AssetsBrowserWindow( Form owner )
        {
            InitializeComponent( );

            this.Owner = owner;

            _actorItems = new Dictionary<string, ActorAssetItem>( );
            _spriteItems = new Dictionary<string, SpriteAssetItem>( );
            _scriptItems = new Dictionary<string, ScriptAssetItem>( );
            _fontItems = new Dictionary<string, FontAssetItem>( );

            _addAssetTab.AssetType = AssetType.None;
            _actorsTab.AssetType = AssetType.Actor;
            _spritesTab.AssetType = AssetType.Sprite;
            _scriptsTab.AssetType = AssetType.Script;
            _fontsTab.AssetType = AssetType.Font;

            _addActorItem.LabelVisible = true;
            _addSpriteItem.LabelVisible = true;
            _addScriptItem.LabelVisible = true;
            _addFontItem.LabelVisible = true;
        }

        public void Initialize( string[] spritePaths, string[] scriptPaths, string[] actorPaths, string[] fontPaths )
        {
            if( !_isReset )
            {
#if( DEBUG )
                throw new Exception( "Initialize cannot be called without Reset( ) being called first!" );
#else
                return;
#endif
            }

            if( !Directory.Exists( GetAssetFolder( AssetType.Sprite ) ) )
                Directory.CreateDirectory( GetAssetFolder( AssetType.Sprite ) );
            if( !Directory.Exists( GetAssetFolder( AssetType.Actor ) ) )
                Directory.CreateDirectory( GetAssetFolder( AssetType.Actor ) );
            if( !Directory.Exists( GetAssetFolder( AssetType.Script ) ) )
                Directory.CreateDirectory( GetAssetFolder( AssetType.Script ) );
            if( !Directory.Exists( GetAssetFolder( AssetType.Font ) ) )
                Directory.CreateDirectory( GetAssetFolder( AssetType.Font ) );

            SpriteAssetItem noSpriteItem = new SpriteAssetItem( Helper.GetSpriteFromImage( Global.GraphicsDevice, Properties.Resources.NoSprite ) );
            noSpriteItem.Visible = false;
            _spritesTab.Controls.Add( noSpriteItem );

            _LoadAssets( spritePaths, scriptPaths, actorPaths, fontPaths );
        }

        public void Reset( )
        {
            _DisposeControls( );
            _ClearVars( );

            _isReset = true;
        }

        private void _DisposeControls( )
        {
            foreach( Control control in _spritesTabPanel.Controls )
            {
                control.Dispose( );
            }
            foreach( Control control in _actorsTabPanel.Controls )
            {
                control.Dispose( );
            }
            foreach( Control control in _scriptsTabPanel.Controls )
            {
                control.Dispose( );
            }
            foreach( Control control in _fontsTabPanel.Controls )
            {
                control.Dispose( );
            }
        }

        private void _ClearVars( )
        {
            _selectedScriptItem = null;
            _spritesTabPanel.Controls.Clear( );
            _spriteItems.Clear( );

            _selectedActorItem = null;
            _actorsTabPanel.Controls.Clear( );
            _actorItems.Clear( );

            _selectedScriptItem = null;
            _scriptsTabPanel.Controls.Clear( );
            _scriptItems.Clear( );

            _selectedFontItem = null;
            _fontsTabPanel.Controls.Clear( );
            _fontItems.Clear( );
        }

        private void _LoadAssets( string[] spritePaths, string[] scriptPaths, string[] actorPaths, string[] fontPaths )
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
                    foreach( FontAssetItem fontItem in _fontItems.Values )
                    {
                        fontItem.Font.SpriteFont = Global.MainWindow.GetLoadedFont( fontItem.AssetName );
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

        #region Form Events

        private void AssetsBrowserWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            e.Cancel = true;
            this.Hide( );
        }

        #endregion

        #region TabControl Events

        private void _tabControl_TabClosing( object sender, TabControlCancelEventArgs e )
        {
            e.Cancel = true;
        }

        #endregion

        #region Add Asset Events

        private void _addSpriteButton_AssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                using( OpenFileDialog openFile = new OpenFileDialog( ) )
                {
                    openFile.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
                    openFile.CheckFileExists = openFile.CheckPathExists = true;
                    openFile.Filter = "Image Files (*.bmp;*jpg;*.gif;*.tga;*.png)|*.bmp;*.jpg;*gif;*.tga;*.png";
                    openFile.Multiselect = true;
                    if( openFile.ShowDialog( ) != DialogResult.Cancel )
                    {
                        foreach( string file in openFile.FileNames )
                        {
                            AddNewSprite( file );
                        }
                    }
                }
            }
        }

        private void _addActorButton_AssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                AddNewActor( );
            }
        }

        private void _addScriptButton_AssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                AddNewScript( "Script", ScriptFormat.Blank );
            }
        }

        private void _addFontItem_AssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                AddNewFont( );
            }
        }

        #endregion

        #region Asset Events

        private void SpriteAssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( _selectedSpriteItem != null )
                _selectedSpriteItem.DeselectMe( );

            _selectedSpriteItem = sender as SpriteAssetItem;
            _selectedSpriteItem.SelectMe( );

            Global.Properties.SelectObject( _selectedSpriteItem.Sprite.Properties );

            if( e.Button == MouseButtons.Right )
            {
                _spriteItemContextMenu.Show( sender, e.Location );
            }
        }

        private void ActorAssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( _selectedActorItem != null )
                _selectedActorItem.DeselectMe( );

            _selectedActorItem = sender as ActorAssetItem;
            _selectedActorItem.SelectMe( );

            Global.Properties.SelectObject( _selectedActorItem.Actor.Properties );

            Global.Tools.IsSelectionMode = false;

            if( e.Button == MouseButtons.Right )
            {
                _actorItemContextMenu.Show( sender, e.Location );
            }
        }

        private void ScriptAssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( _selectedScriptItem != null )
                _selectedScriptItem.DeselectMe( );

            _selectedScriptItem = sender as ScriptAssetItem;
            _selectedScriptItem.SelectMe( );

            Global.Properties.SelectObject( _selectedScriptItem.Script.Properties );

            if( e.Button == MouseButtons.Right )
            {
                _menuScriptItem.Show( sender, e.Location );
            }
        }

        private void ScriptAssetDoubleClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                Global.ScriptEditor.OpenScript( sender as ScriptAssetItem );
            }
        }

        private void FontAssetClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                _selectedFontItem = sender as FontAssetItem;
                _menuFontItem.Show( sender, e.Location );
            }
        }

        private void FontAssetDoubleClicked( AssetItem sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
            {
                (sender as FontAssetItem).SpriteFontWindow.Show( );
            }
        }

        #endregion

        #region Context Menus

        #region Sprite Context Menu

        private void _itemCreateActorFromSprite_Click( object sender, EventArgs e )
        {
            //ActorTypeEd actor = new ActorTypeEd( );
            //actor.Name = _selectedSpriteItem.AssetName;
            //actor.Scale = 1f;
            //actor.SpriteAsset = _selectedSpriteItem;
            //actor.Origin = new Microsoft.Xna.Framework.Vector2( actor.SpriteAsset.Sprite.Width * 0.5f, actor.SpriteAsset.Sprite.Height * 0.5f );
            //AddNewActor( actor );
            AddActorFromSprite( _selectedSpriteItem );
        }

        private void _itemSpriteDelete_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show( "Are you sure you want to delete this sprite?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                return;

            DeleteSprite( _selectedSpriteItem );
        }

        #endregion

        #region Actor Context Menu

        private void _itemActorDelete_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show( "Are you sure you want to delete this actor and all its instances?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                return;

            DeleteActor( _selectedActorItem );
        }

        #endregion

        #region Script Context Menu

        private void _itemScriptEdit_Click( object sender, EventArgs e )
        {
            Global.ScriptEditor.OpenScript( _selectedScriptItem );
        }

        private void _itemScriptDelete_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show( "Are you sure you want to delete this script?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                return;

            DeleteScript( _selectedScriptItem );
        }

        #endregion

        #region Font Context Menu

        private void _itemFontEdit_Click( object sender, EventArgs e )
        {
            _selectedFontItem.SpriteFontWindow.Show( );
        }

        private void _itemFontDelete_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show( "Are you sure you want to delete this font?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                return;

            DeleteFont( _selectedFontItem );
        }

        #endregion

        #endregion

        private void _txtSearch_TextChanged( object sender, EventArgs e )
        {
            if( _tabControl.SelectedTab == _spritesTab )
            {
                SpriteAssetItem spriteItem;

                foreach( Control item in _spritesTabPanel.Controls )
                {
                    spriteItem = item as SpriteAssetItem;

                    string searchText = _txtSearch.Text.ToUpper( );
                    string assetName = spriteItem.AssetName.ToUpper( );

                    spriteItem.Visible = assetName.Contains( searchText );
                }
            }
            else if( _tabControl.SelectedTab == _actorsTab )
            {
                ActorAssetItem actorItem;

                foreach( Control item in _actorsTabPanel.Controls )
                {
                    actorItem = item as ActorAssetItem;

                    string searchText = _txtSearch.Text.ToUpper( );
                    string assetName = actorItem.AssetName.ToUpper( );

                    actorItem.Visible = assetName.Contains( searchText );
                }
            }
            else if( _tabControl.SelectedTab == _scriptsTab )
            {
                ScriptAssetItem scriptItem;

                foreach( Control item in _scriptsTabPanel.Controls )
                {
                    scriptItem = item as ScriptAssetItem;

                    string searchText = _txtSearch.Text.ToUpper( );
                    string assetName = scriptItem.AssetName.ToUpper( );

                    scriptItem.Visible = assetName.Contains( searchText );
                }
            }
            else if( _tabControl.SelectedTab == _fontsTab )
            {
                FontAssetItem fontItem;

                foreach( Control item in _fontsTabPanel.Controls )
                {
                    fontItem = item as FontAssetItem;

                    string searchText = _txtSearch.Text.ToUpper( );
                    string assetName = fontItem.AssetName.ToUpper( );

                    fontItem.Visible = assetName.Contains( searchText );
                }
            }
        }

        private void ShowProperties_Click( object sender, EventArgs e )
        {
            Global.MainWindow.ShowProperties( );
        }

        #endregion

        #region Methods

        #region Sprite Methods

        private void AddSprite( SpriteEd sprite )
        {
            SpriteAssetItem spriteItem = new SpriteAssetItem( sprite );
            _SetAssetItemProperties( spriteItem );
            spriteItem.AssetName = sprite.Name;
            spriteItem.AssetClicked += new AssetItemEventHandler( SpriteAssetClicked );

            _spritesTabPanel.Controls.Add( spriteItem );
            _spriteItems.Add( sprite.Name, spriteItem );

            sprite.SpriteAdded = true;
        }

        public void AddNewSprite( string filePath )
        {
            try
            {
                string spriteName = Path.GetFileNameWithoutExtension( filePath );

                while( _spriteItems.ContainsKey( spriteName ) )
                {
                    if( MessageBox.Show( Global.EditorTxt.SpriteWithSameNameExistsError + "\n" + Global.EditorTxt.ChooseNewNameMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                        Helper.InputBox( Global.EditorTxt.NewSpriteMsg, Global.EditorTxt.SpriteTypeNewName, ref spriteName );
                    else
                        return;
                }

                string newPath = Path.Combine( GetAssetFolder( AssetType.Sprite ), spriteName + Path.GetExtension( filePath ) );
                //Copies the image file
                File.Copy( filePath, newPath, true );
                
                SpriteEd sprite = Helper.GetSpriteFromImageFile( Global.GraphicsDevice, filePath );
                sprite.Name = spriteName;
                sprite.FilePath = newPath;

                AddSprite( sprite );

                Global.MainWindow.OnAssetAdded( );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        public void LoadSprite( string filePath )
        {
            SpriteEd sprite = Helper.GetSpriteFromImageFile( Global.GraphicsDevice, filePath );
            if( sprite != null )
            {
                sprite.Name = Path.GetFileNameWithoutExtension( filePath );
                sprite.FilePath = filePath;

                AddSprite( sprite );
            }
        }

        public void DeleteSprite( SpriteAssetItem spriteItem )
        {
            try
            {
                foreach( ActorAssetItem actorItem in _actorItems.Values )
                {
                    if( actorItem.Actor.SpriteAsset == spriteItem )
                    {
                        actorItem.Actor.SpriteAsset = NoSpriteItem;
                        actorItem.UpdateAssetThumbnail( );
                        actorItem.Actor.Save( );
                    }
                }

                _spritesTabPanel.Controls.Remove( spriteItem );
                _spriteItems.Remove( spriteItem.Sprite.Name );

                File.Delete( spriteItem.FilePath );

                spriteItem.Sprite.Dispose( );
                spriteItem.Dispose( );

                Global.MainWindow.OnAssetRemoved( );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        #endregion

        #region Actor Methods

        private void AddActor( ActorTypeEd actor )
        {
            ActorAssetItem actorItem = new ActorAssetItem( actor );
            _SetAssetItemProperties( actorItem );
            actorItem.AssetClicked += new AssetItemEventHandler( ActorAssetClicked );

            _actorsTabPanel.Controls.Add( actorItem );
            _actorItems.Add( actor.Name, actorItem );

            actor.ActorAdded = true;
        }

        private void AddActorFromSprite( SpriteAssetItem spriteItem )
        {
            string actorName = spriteItem.AssetName;

            while( _actorItems.ContainsKey( actorName ) )
            {
                if( MessageBox.Show( Global.EditorTxt.ActorTypeWithSameNameExistsError + "\n" + Global.EditorTxt.ChooseNewNameMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                    Helper.InputBox( Global.EditorTxt.NewActorTypeMsg, Global.EditorTxt.ActorTypeTypeNewName, ref actorName );
                else
                    return;
            }

            ActorTypeEd actor = new ActorTypeEd( );
            actor.Name = actorName;
            actor.Tags = new string[] { actorName };
            actor.Scale = 1f;
            actor.Rotation = 0f;
            actor.SpriteAsset = spriteItem;
            actor.Origin = new Microsoft.Xna.Framework.Vector2( spriteItem.Sprite.Width * 0.5f, spriteItem.Sprite.Height * 0.5f );
            actor.IsTextActor = false;
            actor.Text = "";
            actor.TextColor = Microsoft.Xna.Framework.Graphics.Color.White;

            actor.FilePath = Path.Combine( GetAssetFolder( AssetType.Actor ), actor.Name + Consts.Files.ACTORTYPE_EXTENSION );
            actor.Save( );

            AddActor( actor );

            Global.MainWindow.OnAssetAdded( );
        }

        public void AddNewActor( )
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
            actor.Tags = new string[] { name };
            actor.Scale = 1f;
            actor.Rotation = 0f;
            actor.IsTextActor = false;
            actor.Text = "";
            actor.TextColor = Microsoft.Xna.Framework.Graphics.Color.White;
            actor.SpriteAsset = NoSpriteItem;

            actor.FilePath = Path.Combine( GetAssetFolder( AssetType.Actor ), actor.Name + Consts.Files.ACTORTYPE_EXTENSION );
            actor.Save( );

            AddActor( actor );

            Global.MainWindow.OnAssetAdded( );
        }

        public void LoadActor( string filePath )
        {
            //Loads an actortype from the file
            ActorTypeEd actor = FileManager.LoadActorTypeFile( filePath );
            if( actor == null )
                return;

            //Checks if the _actorItems pool already contains this actor reference
            if( _actorItems.ContainsKey( actor.Name ) )
                return;


            //Checks if _spriteItems contains the actor sprite name reference
            if( _spriteItems.ContainsKey( actor.TempSpriteName ) )
                //if so assign that sprite to the actor
                actor.SpriteAsset = _spriteItems[actor.TempSpriteName];
            else
                //otherwise assign a defaul NoSprite to the actor
                actor.SpriteAsset = NoSpriteItem;


            //Checks if _scriptItems contains the actor script name reference
            if( _scriptItems.ContainsKey( actor.TempScriptName ) )
                //if so assign the script to the actor
                actor.Script = _scriptItems[actor.TempScriptName].Script;


            //Checks if _fontItems contains the actor font name reference
            if( _fontItems.ContainsKey( actor.TempFontName ) )
                //if so assign the font to the actor
                actor.FontAsset = _fontItems[actor.TempFontName];

            AddActor( actor );
        }

        public void DeleteActor( ActorAssetItem actorItem )
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

                    pool.Clear( );
                }
            }

            File.Delete( actorItem.FilePath );

            _actorsTabPanel.Controls.Remove( actorItem );
            _actorItems.Remove( actorType.Name );
            _selectedActorItem = null;

            actorItem.Dispose( );

            Global.MainWindow.OnAssetRemoved( );
        }

        #endregion

        #region Script Methods

        private void AddScript( Script script )
        {
            ScriptAssetItem scriptItem = new ScriptAssetItem( script );
            _SetAssetItemProperties( scriptItem );
            scriptItem.AssetClicked += new AssetItemEventHandler( ScriptAssetClicked );
            scriptItem.AssetDoubleClicked += new AssetItemEventHandler( ScriptAssetDoubleClicked );

            _scriptsTabPanel.Controls.Add( scriptItem );
            _scriptItems.Add( script.Name, scriptItem );

            script.ScriptAdded = true;
        }

        public void AddNewScript( string name, ScriptFormat format )
        {
            string scriptName = name;
            int i = 1;
            while( _scriptItems.ContainsKey( scriptName ) )
            {
                scriptName = name + i;
                i++;
            };

            Script script = new Script( scriptName );
            script.ScriptText = GetScriptGeneratedCode( scriptName, format );
            script.ScriptType = ScriptType.CSharp;
            script.FilePath = Path.Combine( GetAssetFolder( AssetType.Script ), scriptName + GetScriptExtension( script.ScriptType ) );

            AddScript( script );

            script.Save( );

            _lastCreatedScript = script.Parent;

            Global.ScriptEditor.OpenScript( script.Parent );

            Global.MainWindow.OnScriptAdded( );
        }

        public void LoadScript( string filePath )
        {
            Script script = FileManager.LoadScriptFile( filePath );
            if( script != null )
                AddScript( script );
        }

        public void DeleteScript( ScriptAssetItem scriptItem )
        {
            Global.ScriptEditor.CloseScript( scriptItem, true );

            Script script = scriptItem.Script;

            if( Global.World.Script == script )
                Global.World.Script = null;

            foreach( LevelEd lvl in Global.World.Levels )
            {
                if( lvl.Script == script )
                    lvl.Script = null;
            }

            foreach( ActorAssetItem actorItem in _actorItems.Values )
            {
                if( actorItem.Actor.Script == script )
                    actorItem.Actor.Script = null;
            }

            File.Delete( scriptItem.FilePath );

            _scriptsTabPanel.Controls.Remove( scriptItem );
            _scriptItems.Remove( scriptItem.AssetName );

            scriptItem.Dispose( );

            Global.MainWindow.OnScriptRemoved( );
        }

        #endregion

        #region Font Methods

        private void AddFont( FontEd font, bool showFontWindow )
        {
            FontAssetItem fontItem = new FontAssetItem( font );
            _SetAssetItemProperties( fontItem );
            fontItem.AssetClicked += new AssetItemEventHandler( FontAssetClicked );
            fontItem.AssetDoubleClicked += new AssetItemEventHandler( FontAssetDoubleClicked );

            _fontsTabPanel.Controls.Add( fontItem );
            _fontItems.Add( font.Name, fontItem );

            font.FontAdded = true;

            if( showFontWindow )
                fontItem.SpriteFontWindow.Show( );
        }

        public void AddNewFont( )
        {
            string fontName = "";
            Helper.InputBox( Global.EditorTxt.NewFontMsg, Global.EditorTxt.FontTypeNewName, ref fontName );

            while( _fontItems.ContainsKey( fontName ) )
            {
                if( MessageBox.Show( Global.EditorTxt.FontWithSameNameExistsError + "\n" + Global.EditorTxt.ChooseNewNameMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                    Helper.InputBox( Global.EditorTxt.NewFontMsg, Global.EditorTxt.FontTypeNewName, ref fontName );
                else
                    return;
            }

            FontEd font = new FontEd( );
            font.Name = fontName;
            font.Text = GetFontGeneratedCode( fontName );
            font.FilePath = Path.Combine( GetAssetFolder( AssetType.Font ), font.Name + Consts.Files.FONT_EXTENSION );
            if( font.Save( ) )
            {

                AddFont( font, true );

                Global.MainWindow.OnAssetAdded( );
                Global.DisplayMessage( Global.EditorTxt.CreateFontSuccess, 1f );
            }
            else
                Global.DisplayMessage( Global.EditorTxt.CreateFontFailed, 1f );
        }

        public void LoadFont( string filePath )
        {
            FontEd font = FileManager.LoadFontFile( filePath );
            if( font != null )
                AddFont( font, false );
        }

        public void DeleteFont( FontAssetItem fontItem )
        {
            Classes.Collections.ActorEdPool actorPool = new Classes.Collections.ActorEdPool( );
            //In here, it searches for all TextActors and delete them if they share the same SpriteFont
            foreach( LevelEd level in Global.World.Levels )
            {
                foreach( LayerEd layer in level.Layers )
                {
                    if( layer.Actors.Count == 0 )
                        continue;

                    foreach( ActorEd actor in layer.Actors )
                    {
                        if( actor.IsTextActor )
                            if( actor.FontAsset == fontItem )
                                actorPool.Add( actor );
                    }
                    foreach( ActorEd actor in layer.Actors )
                    {
                        layer.RemoveActor( actor );
                    }

                    actorPool.Clear( );
                }
            }



            File.Delete( fontItem.FilePath );

            _fontsTabPanel.Controls.Remove( fontItem );
            _fontItems.Remove( fontItem.AssetName );

            fontItem.Dispose( );

            Global.MainWindow.OnAssetRemoved( );
        }

        #endregion


        #region Other

        public void SaveAssets( )
        {
            foreach( ActorAssetItem item in ActorItems.Values )
            {
                item.Actor.Save( );
            }
            foreach( FontAssetItem item in FontItems.Values )
            {
                item.Font.Save( );
            }
        }

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

        private AssetType GetCurrentAssetTabType( )
        {
            return (_tabControl.SelectedTab as AssetsTabPage).AssetType;
        }

        private FlowLayoutPanel _GetCurrentAssetTabPanel( )
        {
            return _tabControl.SelectedTab.Controls[0] as FlowLayoutPanel;
        }

        private void _SetAssetItemProperties( AssetItem asset )
        {
            asset.DefaultBackColor = Color.Transparent;
            asset.DefaultLabelColor = Color.White;
            asset.HighlightBackColor = Color.LightGray;
            asset.HighlightLabelColor = Color.Black;
            asset.LabelFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ( (byte)( 0 ) ) );
            asset.LabelVisible = true;
            asset.SelectBackColor = Color.White; //Color.Gainsboro
            asset.SelectLabelColor = Color.Black;
            asset.Size = new System.Drawing.Size( 300, 70 );
        }

        private string GetScriptExtension( ScriptType type )
        {
            switch( type )
            {
                case ScriptType.Visual:
                    return Consts.Files.LUVISUAL_EXTENSION;

                //C# extension
                default:
                    return Consts.Files.CSHARP_EXTENSION;
            }
        }

        private string GetScriptGeneratedCode( string className, ScriptFormat format )
        {
            string defaultMethods =
                        "\t\t//This is called once, when the object is created.\n" +
                        "\t\tpublic override void Init( )\n" +
                        "\t\t{\n" + 
                        "\t\t\t\n" + 
                        "\t\t}\n\n" +
                        "\t\t//This is called every frame.\n" +
                        "\t\tpublic override void Update( GameTime gameTime )\n" +
                        "\t\t{\n" + 
                        "\t\t\t\n" + 
                        "\t\t}\n\n" +
                        "\t\t//This is called when the object is about to be destroyed.\n" +
                        "\t\tpublic override void End( )\n" +
                        "\t\t{\n" + 
                        "\t\t\t\n" + 
                        "\t\t}\n\n";
            switch( format )
            {
                case ScriptFormat.Blank:
                    return
                        "using LunarEngine;\n\n" +
                        "namespace " + Global.World.Name + "\n" +
                        "{\n\t\n}";

                case ScriptFormat.Game:
                    return
                        "using LunarEngine;\n" +
                        "using Microsoft.Xna.Framework;\n\n" +
                        "namespace " + Global.World.Name + "\n" +
                        "{\n"+
                        "\tpublic class " + className + " : LunarGame\n" +
                        "\t{\n" +
                        "\t\t//This is called when the game is being initialized.\n" +
                        "\t\tpublic override void Init( )\n" +
                        "\t\t{\n" + 
                        "\t\t\t\n" + 
                        "\t\t}\n\n" +
                        "\t\t//This is called every frame.\n" +
                        "\t\tpublic override void Update( GameTime gameTime )\n" +
                        "\t\t{\n" + 
                        "\t\t\t\n" + 
                        "\t\t}\n\n" +
                        "\t}\n" + 
                        "}";

                case ScriptFormat.Level:
                    return
                        "using LunarEngine;\n" +
                        "using Microsoft.Xna.Framework;\n\n" +
                        "namespace " + Global.World.Name + "\n" +
                        "{\n"+
                        "\tpublic class " + className + " : Level\n" +
                        "\t{\n" +
                        defaultMethods +
                        "\t}\n" + 
                        "}";

                case ScriptFormat.Actor:
                    return
                        "using LunarEngine;\n" +
                        "using Microsoft.Xna.Framework;\n\n" +
                        "namespace " + Global.World.Name + "\n" +
                        "{\n"+
                        "\tpublic class " + className + " : Actor\n" +
                        "\t{\n" +
                        defaultMethods +
                        "\t}\n" + 
                        "}";

                case ScriptFormat.TextActor:
                    return
                        "using LunarEngine;\n" +
                        "using Microsoft.Xna.Framework;\n\n" +
                        "namespace " + Global.World.Name + "\n" +
                        "{\n"+
                        "\tpublic class " + className + " : TextActor\n" +
                        "\t{\n" +
                        defaultMethods +
                        "\t}\n" + 
                        "}";

                default:
                    return "";
            }
        }

        private string GetFontGeneratedCode( string fontName )
        {
            return
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                "<XnaContent xmlns:Graphics=\"Microsoft.Xna.Framework.Content.Pipeline.Graphics\">\n" +
                "\t<Asset Type=\"Graphics:FontDescription\">\n" +
                "\t\t<FontName>"+fontName+"</FontName>\n" +
                "\t\t<Size>14</Size>\n" +
                "\t\t<Spacing>0</Spacing>\n" +
                "\t\t<UseKerning>true</UseKerning>\n" +
                "\t\t<Style>Regular</Style>\n" +
                "\t\t<CharacterRegions>\n" +
                "\t\t\t<CharacterRegion>\n" +
                "\t\t\t\t<Start>&#32;</Start>\n" +
                "\t\t\t\t<End>&#126;</End>\n" +
                "\t\t\t</CharacterRegion>\n" +
                "\t\t</CharacterRegions>\n" +
                "\t</Asset>\n" +
                "</XnaContent>";
        }



        private void DisposeResources( )
        {
            Reset( );

            _spriteItems = null;
            _actorItems = null;
            _scriptItems = null;
            _fontItems = null;

            if( NoSpriteItem != null )
                NoSpriteItem.Dispose( );
        }

        #endregion

        #endregion
    }
}
