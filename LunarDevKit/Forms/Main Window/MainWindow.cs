using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using WeifenLuo.WinFormsUI.Docking;
using LunarDevKit.Classes;
using LunarDevKit.Classes.Collections;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms
{
    using Main_Window;
    using Script_Editor;

    public partial class MainWindow : Form
    {
        #region Fields
        
        private Classes.GraphicsHandler.ContentBuilder _contentBuilder;
        private Microsoft.Xna.Framework.Content.ContentManager _contentManager;
        private ViewportControl _tempViewport;

        private DockPanel _dockPanel;

        private AssetsBrowserWindow _assets;
        public AssetsBrowserWindow AssetsBrowser
        {
            get { return _assets; }
        }

        private ScriptEditor _scriptEditor;
        public ScriptEditor ScriptEditor
        {
            get { return _scriptEditor; }
        }

        private ToolsDock _tools;
        public ToolsDock Tools
        {
            get { return _tools; }
        }

        private PopUpWindow _popUpWindow;

        private PropertiesDock _properties;
        public PropertiesDock Properties
        {
            get { return _properties; }
        }

        private LayersDock _layers;
        public LayersDock Layers
        {
            get { return _layers; }
        }

        private UndoProvider _undoProvider;
        internal UndoProvider UndoProvider
        {
            get { return _undoProvider; }
        }


        private bool _builtLevels = false;
        private bool _builtAssets = false;
        private bool _builtGame = false;
        private bool _compiledScripts = false;
        private bool _worldSaved = true;
        private bool _assetsSaved = true;

        #endregion

        #region Properties

        #region Viewport Menu Properties

        public ToolStripMenuItem SelectionTool
        {
            get { return _itemSelectionTool; }
        }

        public ToolStripMenuItem ToggleGridItem
        {
            get { return _itemToggleGrid; }
        }

        public ToolStripMenuItem ToggleZonesItem
        {
            get { return _itemToggleZones; }
        }

        public ToolStripMenuItem ToggleLightingItem
        {
            get { return _itemToggleLight; }
        }

        public ToolStripMenuItem ToggleEffectsItem
        {
            get { return _itemToggleEffects; }
        }

        #endregion

        #region Dock Panel Properties

        public LevelDocument SelectedLevel
        {
            get { return _dockPanel.ActiveDocument as LevelDocument; }
        }

        #endregion

        #endregion

        #region Init

        public MainWindow( )
        {
            InitializeComponent( );

            Global.MainWindow = this;
            Global.EditorTxt = global::LunarDevKit.lang_English.Default;

            InitDockLayout( );
            InitDirectories( );
            InitGlobalProperties( );

            _contentBuilder = new Classes.GraphicsHandler.ContentBuilder( );
            _contentManager = new ContentManager( _tempViewport.Services, _contentBuilder.OutputDirectory );

            new LoadingScreen( ).ShowDialog( );
        }

        private void InitDockLayout( )
        {
            _dockPanel = new DockPanel( );
            _dockPanel.Dock = DockStyle.Fill;
            _dockPanel.BackColor = System.Drawing.Color.DarkGray;
            _dockPanel.ActiveDocumentChanged += new EventHandler( _dockPanel_ActiveDocumentChanged );
            Controls.Add( _dockPanel );
            _dockPanel.BringToFront( );
            

            _assets = new AssetsBrowserWindow( this );
            _properties = new PropertiesDock( );
            _layers = new LayersDock( );
            _tools = new ToolsDock( );
            _scriptEditor = new ScriptEditor( );
        }

        private void InitDirectories( )
        {
            try
            {
                if( !Directory.Exists( Consts.Folders.LUNAR_PROJECTS_PATH ) )
                    Directory.CreateDirectory( Consts.Folders.LUNAR_PROJECTS_PATH );

                //if( !Directory.Exists( Consts.Folders.PACKAGES ) )
                //    Directory.CreateDirectory( Consts.Folders.PACKAGES );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        private void InitGlobalProperties( )
        {
            _popUpWindow = new PopUpWindow( this );

            _tempViewport = new ViewportControl( );
            _tempViewport.Location = new System.Drawing.Point( -20, 12 );
            Controls.Add( _tempViewport );

            _itemSelectionTool.Click += new EventHandler( _tools.SelectionTool_Click );
            _itemToggleGrid.Click += new EventHandler( _tools.ToggleGrid_Click );
            _itemToggleZones.Click += new EventHandler( _tools.ToggleZones_Click );
            _itemToggleLight.Click += new EventHandler( _tools.ToggleLight_Click );
            _itemToggleEffects.Click += new EventHandler( _tools.ToggleEffects_Click );

            this.Text = Consts.Editor.TITLE;

            _undoProvider = new UndoProvider( );
            _undoProvider.CanRedoChanged += new EventHandler( UndoProvider_CanRedoChanged );
            _undoProvider.CanUndoChanged += new EventHandler( UndoProvider_CanUndoChanged );
        }
        
        #endregion


        #region Event Methods

        #region Editor-related Event Methods

        private void _dockPanel_ActiveDocumentChanged( object sender, EventArgs e )
        {
            _layers.RefreshList( );
        }

        private void MainWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            e.Cancel = false;
            if( !_assetsSaved )
            {
                if( MessageBox.Show( Global.EditorTxt.SaveAssetsPrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                    SaveAllAssets( );
            }
            if( !_worldSaved )
            {
                switch( MessageBox.Show( Global.EditorTxt.SaveWorldMsg, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question ) )
                {
                    case DialogResult.Yes:
                        SaveWorld_Click( null, null );
                        CloseWorld( );
                        return;

                    case DialogResult.No:
                        CloseWorld( );
                        return;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }

            if( MessageBox.Show( Global.EditorTxt.ExitEditorMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                e.Cancel = true;
            else
            {
                CloseWorld( );
            }
        }

        private void Exit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        #endregion

        #region World-related Event Methods

        private void NewWorld_Click( object sender, EventArgs e )
        {
            using( NewWorldWindow newWorldWnd = new NewWorldWindow( ) )
            {
                World world = newWorldWnd.ShowDialog( );
                if( world != null )
                {
                    string folderPath = Path.GetDirectoryName( world.FilePath );
                    world.WorldFolderPath = folderPath;
                    world.LevelsFolderPath = Path.Combine( folderPath, "Levels" );
                    world.BuildFolderPath = Path.Combine( folderPath, Consts.Folders.BUILD );
                    world.AssetsFolderPath = Path.Combine( folderPath, Consts.Folders.ASSETS );
                    Directory.CreateDirectory( world.LevelsFolderPath );
                    Directory.CreateDirectory( world.BuildFolderPath );
                    Directory.CreateDirectory( world.AssetsFolderPath );

                    OpenWorld( world );

                    FileManager.CreateWorldFile( world );

                    DisplayMessage( Global.EditorTxt.CreateWorldSuccess, 1.5f );
                }
            }
        }

        private void OpenWorld_Click( object sender, EventArgs e )
        {
            using( OpenFileDialog openFile = new OpenFileDialog( ) )
            {
                openFile.Title = Global.EditorTxt.OpenWorld;
                openFile.InitialDirectory = Consts.Folders.LUNAR_PROJECTS_PATH;
                openFile.CheckFileExists = openFile.CheckPathExists = true;
                openFile.Multiselect = false;
                openFile.Filter = "Lunar World Files (*luworld)|*.luworld";

                if( openFile.ShowDialog( ) != DialogResult.Cancel )
                {
                    if( Global.World != null && openFile.FileName == Global.World.FilePath )
                    {
                        MessageBox.Show( Global.World.Name + Global.EditorTxt.IsAlreadyOpen, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        return;
                    }

                    OpenWorld( openFile.FileName );

                    DisplayMessage( Global.EditorTxt.OpenWorldSuccess, 1.5f );
                }
            }
        }

        private void SaveWorld_Click( object sender, EventArgs e )
        {
            SaveAllAssets( );
            SaveAllLevels_Click( null, null );

            SaveWorld( );


            DisplayMessage( Global.EditorTxt.SaveWorldSuccess, 1.5f );
        }

        #endregion

        #region Level-related Event Methods

        private void NewLevel_Click( object sender, EventArgs e )
        {
            using( NewLevelWindow newLevelWnd = new NewLevelWindow( ) )
            {
                LevelEd level = newLevelWnd.ShowDialog( );
                if( level != null )
                {
                    try
                    {
                        if( !Directory.Exists( Global.World.LevelsFolderPath ) )
                            Directory.CreateDirectory( Global.World.LevelsFolderPath );
                    }
                    catch
                    {
                        DisplayMessage( Global.EditorTxt.CreateDirectoryFailed, 1.5f );
                        return;
                    }

                    Global.World.OpenLevel( level );

                    OnLevelAdded( level.Parent );

                    DisplayMessage( Global.EditorTxt.CreateLevelSuccess, 1.5f );
                }
            }
        }

        private void SaveLevel_Click( object sender, EventArgs e )
        {
            LevelDocument lvlDoc = SelectedLevel;
            if( !lvlDoc.Level.Saved )
            {
                lvlDoc.Save( );

                DisplayMessage( Global.EditorTxt.SaveLevelSuccess, 1.5f );
            }
        }

        private void SaveAllLevels_Click( object sender, EventArgs e )
        {
            foreach( IDockContent levelDoc in _dockPanel.Documents )
            {
                (levelDoc as LevelDocument).Save( );
            }

            DisplayMessage( Global.EditorTxt.SaveLevelsSuccess, 1.5f );
        }

        #endregion

        #region Edit Menu Event Methods

        private void Undo_Click( object sender, EventArgs e )
        {
            UndoProvider.Undo( );
        }

        private void Redo_Click( object sender, EventArgs e )
        {
            UndoProvider.Redo( );
        }

        private void Cut_Click( object sender, EventArgs e )
        {
            SelectedLevel.ActorCut( );
        }

        private void Copy_Click( object sender, EventArgs e )
        {
            SelectedLevel.ActorCopy( );
        }

        private void Paste_Click( object sender, EventArgs e )
        {
            SelectedLevel.ActorPaste( );
        }

        private void Delete_Click( object sender, EventArgs e )
        {
            SelectedLevel.ActorDelete( );
        }

        private void Preferences_Click( object sender, EventArgs e )
        {

        }

        #endregion

        #region Game Menu Event Methods

        private void AssetsBrowser_Click( object sender, EventArgs e )
        {
            _assets.Show( _dockPanel );
        }

        private void GameSettings_Click( object sender, EventArgs e )
        {
            using( GameSettingsWindow gameSettingsWnd = new GameSettingsWindow( ) )
            {
                gameSettingsWnd.ShowDialog( );
            }
        }

        private void TestGame_Click( object sender, EventArgs e )
        {
            if( !_builtGame )
                BuildGameFile( );

#if DEBUG
            Thread thread = new Thread( ( ) => 
            {
                using( LDKGameTester.TestGame testGame = new LDKGameTester.TestGame( Global.World.GameFilePath ) )
                {
                    testGame.Run( ); 
                }
            });
            thread.Start( );
            thread.Join( );
#else
            Process.Start( "LDKGameTester.exe", Global.World.GameFilePath );
#endif
        }

        #endregion

        #region Build Menu Event Methods

        public void CompileScripts_Click( object sender, EventArgs e )
        {
            _scriptEditor.SaveAllScripts( );

            if( CompileScripts( ) )
                DisplayMessage( Global.EditorTxt.CompileScriptsSuccess, 1.5f );
        }

        private void BuildLevels_Click( object sender, EventArgs e )
        {
            SaveAllLevels_Click( null, null );

            if( BuildLevels( ) )
                DisplayMessage( Global.EditorTxt.BuildLevelsSuccess, 1.5f );
        }

        private void BuildAssets_Click( object sender, EventArgs e )
        {

            if( BuildAssets( ) )
                DisplayMessage( Global.EditorTxt.BuildAssetsSuccess, 1.5f );
        }

        private void BuildGame_Click( object sender, EventArgs e )
        {
            SaveWorld_Click( null, null );

            Global.World.GameFilePath = BuildGameFile( );
            if( Global.World.GameFilePath != null )
                DisplayMessage( Global.EditorTxt.BuildGameSuccess, 1.5f );
        }

        private void BuildAll_Click( object sender, EventArgs e )
        {
            if( string.IsNullOrEmpty( BuildAll( ) ) )
                DisplayMessage( Global.EditorTxt.BuildGameFailed, 1.5f );
            else
                DisplayMessage( Global.EditorTxt.BuildGameSuccess, 1.5f );
        }

        #endregion

        #region Tools Menu Event Methods

        private void ScriptEditor_Click( object sender, EventArgs e )
        {
            ShowScriptEditor( );
        }

        #endregion

        #region Undo Provider Methods

        private void UndoProvider_CanUndoChanged( object sender, EventArgs e )
        {
            _itemUndo.Enabled = _btnUndo.Enabled = _undoProvider.CanUndo;
        }

        private void UndoProvider_CanRedoChanged( object sender, EventArgs e )
        {
            _itemRedo.Enabled = _btnRedo.Enabled = _undoProvider.CanRedo;
        }

        #endregion

        #region Other Event Methods

        private void _itemAbout_Click( object sender, EventArgs e )
        {
            using( AboutWindow aboutWnd = new AboutWindow( ) )
            {
                aboutWnd.ShowDialog( );
            }
        }

        #endregion


        private void LevelTabLayers_Click( object sender, EventArgs e )
        {
            ShowLayers( );
        }
        private void LevelTabProperties_Click( object sender, EventArgs e )
        {
            _properties.SelectObject( ( _dockPanel.ActiveDocument as LevelDocument ).Level.Properties );
            ShowProperties( );
        }

        #endregion


        #region Methods

        #region Raise Events

        public void OnWorldChanged( )
        {
            _builtGame = false;
            this.Text = GetTitle( ) + "*";
            _itemBuildGame.Enabled = true;
        }

        #region Level
        public void OnLevelChanged( LevelDocument levelDoc )
        {
            _builtLevels = false;
            levelDoc.Text = levelDoc.Level.Name + "*";
            levelDoc.Level.Changed( );
            _itemBuildLevels.Enabled = true;
        }

        public void OnLevelAdded( LevelDocument levelDoc )
        {
            OnWorldChanged( );
            OnLevelChanged( levelDoc );
            levelDoc.Level.LevelAdded = true;

            ShowTools( );
        }

        public void OnLevelSelected( LevelDocument levelDoc )
        {
            //<In here it selects the level in the Properties window>
        }
        #endregion

        #region Asset
        public void OnAssetChanged( )
        {
            _builtAssets = false;
            _itemBuildAssets.Enabled = true;
            _assetsSaved = false;
            _assets.Text = "Assets Browser*";
        }

        public void OnAssetAdded( )
        {
            OnWorldChanged( );
            OnAssetChanged( );
        }

        public void OnAssetRemoved( )
        {
            OnWorldChanged( );
            OnAssetChanged( );
        }
        #endregion

        #region Script
        public void OnScriptChanged( )
        {
            _compiledScripts = false;
            _itemBuildScripts.Enabled = true;
        }

        public void OnScriptAdded( )
        {
            OnWorldChanged( );
            OnScriptChanged( );
        }

        public void OnScriptRemoved( )
        {
            OnWorldChanged( );
            OnScriptChanged( );
        }
        #endregion

        #endregion

        #region World-related Methods

        public void SaveWorld( )
        {
            FileManager.CreateWorldFile( Global.World );
            this.Text = GetTitle( );
            _worldSaved = true;

            _builtGame = false;
            _itemBuildGame.Enabled = true;
        }

        private void OpenWorld( string filePath )
        {
            OpenWorld( FileManager.LoadWorld( filePath ) );
        }

        private void OpenWorld( World world )
        {
            CloseWorld( );

            if( world == null )
                throw new Exception( Global.EditorTxt.OpenWorldFileFailed );

            Global.World = world;

            this.Text = GetTitle( );

            EnableWorldButtons( );

            _assets.Initialize( world.TempSpritePaths, world.TempScriptPaths, world.TempActorPaths, world.TempFontPaths );

            Global.World.TempSpritePaths = null;
            Global.World.TempScriptPaths = null;
            Global.World.TempActorPaths = null;
            Global.World.TempFontPaths = null;

            if( Global.World.TempLevelPaths != null && Global.World.TempLevelPaths.Length > 0 )
            {
                ShowTools( );

                foreach( string levelPath in Global.World.TempLevelPaths )
                {
                    if( !File.Exists( levelPath ) )
                        MessageBox.Show( Path.GetFileName( levelPath ) + Global.EditorTxt.FileNotFound, "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    else
                    {
                        Global.World.OpenLevel( levelPath );
                    }
                }
                Global.World.TempLevelPaths = null;
            }

            if( Global.World.TempScriptName == null )
                Global.World.TempScriptName = FileManager.NO_SCRIPT;

            string scriptName = Global.World.TempScriptName;
            if( scriptName != FileManager.NO_SCRIPT )
            {
                //Check if the assets list of scripts contains the given script name
                if( _assets.ScriptItems.ContainsKey( scriptName ) )
                    //if so, assign the script
                    Global.World.Script = _assets.ScriptItems[scriptName].Script;
                else
                    //if not, display a warning message
                    Global.DisplayMessage( scriptName + Consts.Files.CSHARP_EXTENSION + Global.EditorTxt.FileNotFound, 1.5f );
            }
        }

        private void CloseWorld( )
        {
            if( Global.World != null && Directory.Exists( Global.World.TempFolderPath ) )
                Directory.Delete( Global.World.TempFolderPath, true );

            this.Text = GetTitle( ); ;
            _itemToggleGrid.Checked = true;

            DisableWorldButtons( );

            _scriptEditor.CloseAllScripts( );
            CloseAllLevels( );
            HideTools( );
            _properties.Hide( );
            _scriptEditor.Hide( );
            _assets.Hide( );

            DisableLevelButtons( );

            _assets.Reset( );

            Global.World = null;
        }

        private void CloseAllLevels( )
        {
            int count = _dockPanel.DocumentsCount;
            for( int i = 0; i < count; i++ )
            {
                foreach( LevelDocument levelDoc in _dockPanel.Documents )
                {
                    if( !levelDoc.Level.Saved )
                    {
                        if( MessageBox.Show( Global.EditorTxt.SaveFilePrompt + levelDoc.Level.Name + " " + Global.EditorTxt.LevelName + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                        {
                            levelDoc.Level.Save( );
                        }
                    }

                    levelDoc.HideOnClose = false;
                    levelDoc.Dispose( );
                    break;
                }
            }
        }

        #endregion

        #region UI-related Methods

        public void AddLevelDoc( LevelDocument levelDoc )
        {
            levelDoc.Show( _dockPanel );

            levelDoc.TabPageContextMenuStrip = this._levelTabContextMenu;
        }

        #endregion

        #region Build Methods

        private bool BuildLevels( )
        {
            try
            {
                string folder = Path.Combine( Global.World.BuildFolderPath, "Levels" );
                if( !Directory.Exists( folder ) )
                    Directory.CreateDirectory( folder );

                foreach( LevelEd level in Global.World.Levels )
                {
                    FileManager.CreateGameLevelFile( level, Path.Combine( folder, level.Name + Consts.Files.GAME_LEVEL_EXTENSION ) );
                }
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
                return false;
            }

            _builtLevels = true;
            _itemBuildLevels.Enabled = false;
            return true;
        }

        private bool CompileScripts( )
        {
            if( _assets.ScriptItems.Count != 0 )
            {

                string folder = Path.Combine( Global.World.BuildFolderPath, "Content" );
                if( !Directory.Exists( folder ) )
                    Directory.CreateDirectory( folder );

                string[] scripts = new string[_assets.ScriptItems.Count];
                int i = 0;
                foreach( ScriptAssetItem scriptItem in _assets.ScriptItems.Values )
                {
                    scripts[i] = scriptItem.FilePath;
                    i++;
                }

                string dllPath = Path.Combine( folder, "scripts.dll" );

                Microsoft.CSharp.CSharpCodeProvider codeProvider = new Microsoft.CSharp.CSharpCodeProvider( );

                System.CodeDom.Compiler.CompilerParameters parameters = new System.CodeDom.Compiler.CompilerParameters( );
                parameters.GenerateExecutable = false;
                parameters.OutputAssembly = dllPath;
                parameters.ReferencedAssemblies.Add( "mscorlib.dll" );
                parameters.ReferencedAssemblies.Add( "LunarEngine.dll" );
                parameters.ReferencedAssemblies.Add( "Farseer Physics 3.0.dll" );
                parameters.ReferencedAssemblies.Add( Assembly.GetAssembly( typeof( Microsoft.Xna.Framework.Input.Keys ) ).Location );
                parameters.ReferencedAssemblies.Add( Assembly.GetAssembly( typeof( Microsoft.Xna.Framework.Game ) ).Location );
                if( File.Exists( Global.World.PluginsFilePath ) )
                {
                    using( StreamReader file = new StreamReader( File.OpenRead( Global.World.PluginsFilePath ) ) )
                    {
                        while( !file.EndOfStream )
                        {
                            string path = Path.Combine( Global.World.WorldFolderPath, file.ReadLine( ) );
                            if( File.Exists( path ) )
                                parameters.ReferencedAssemblies.Add( path );
                            else
                            {
                                MessageBox.Show( Path.GetFileName( path ) + " plugin is missing!" );
                                return false;
                            }
                        }
                    }
                }

                System.CodeDom.Compiler.CompilerResults results = codeProvider.CompileAssemblyFromFile( parameters, scripts );


                _scriptEditor.DisplayErrors( results.Errors );

                if( results.Errors.HasErrors || results.Errors.HasWarnings )
                {
                    _scriptEditor.FocusErrorsDock( );

                    if( results.Errors.HasErrors )
                        return false;
                }
            }

            _compiledScripts = true;
            _itemBuildScripts.Enabled = false;
            return true;
        }

        private bool BuildAssets( )
        {
            List<string> contentPaths = new List<string>( );

            string folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Sprites" );
            if( !Directory.Exists( folder ) )
                Directory.CreateDirectory( folder );

            foreach( SpriteAssetItem spriteItem in _assets.SpriteItems.Values )
            {
                contentPaths.Add( spriteItem.FilePath );
            }

            ConvertContentToXNB( contentPaths.ToArray( ), folder, true, null, null );



            contentPaths.Clear( );

            folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Fonts" );
            if( !Directory.Exists( folder ) )
                Directory.CreateDirectory( folder );

            foreach( FontAssetItem fontItem in _assets.FontItems.Values )
            {
                contentPaths.Add( fontItem.FilePath );
            }

            ConvertContentToXNB( contentPaths.ToArray( ), folder, true, "FontDescriptionImporter", "FontDescriptionProcessor" );

            contentPaths.Clear( );



            folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Actors" );
            if( !Directory.Exists( folder ) )
                Directory.CreateDirectory( folder );

            foreach( ActorAssetItem actorItem in _assets.ActorItems.Values )
            {
                FileManager.CreateGameActorFile( actorItem.Actor, Path.Combine( folder, actorItem.Actor.Name + Consts.Files.GAME_ACTORTYPE_EXTENSION ) );
            }


            //if( !string.IsNullOrEmpty( Global.World.AudioProjectName ) )
            //{
            //    folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Audio" );
            //    if( !Directory.Exists( folder ) )
            //        Directory.CreateDirectory( folder );

            //    string audioProjPath = Path.Combine( Global.World.AssetsFolderPath, Global.World.AudioProjectName + ".xap" );

            //    _contentBuilder.Clear( );
            //    _contentBuilder.Add( audioProjPath, Global.World.AudioProjectName, "XactImporter", "XactProcessor" );
            //    string errors = _contentBuilder.Build( );
            //    if( !string.IsNullOrEmpty( errors ) )
            //        return false;

            //    string[] files = Directory.GetFiles( _contentBuilder.OutputDirectory );
            //    foreach( string file in files )
            //    {
            //        string name = Path.GetFileName( file );
            //        if( name.EndsWith( ".xgs" ) || name.EndsWith( ".xwb" ) || name.EndsWith( ".xsb" ) )
            //        {
            //            string newPath = Path.Combine( folder, name );
            //            if( File.Exists( newPath ) )
            //                File.Delete( newPath );
            //            File.Move( file, newPath );
            //        }
            //    }
            //}

            _builtAssets = true;
            _itemBuildAssets.Enabled = false;
            return true;
        }

        private string BuildGameFile( )
        {
            if( !_compiledScripts )
            {
                if( !CompileScripts( ) )
                    return null;
            }

            if( !_builtAssets )
            {
                if( !BuildAssets( ) )
                    return null;
            }

            if( !_builtLevels )
            {
                if( !BuildLevels( ) )
                    return null;
            }

            string folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Effects" );

            Global.World.GameFilePath = Path.Combine( Global.World.BuildFolderPath, Global.World.Name + Consts.Files.GAME_EXTENSION );
            FileManager.CreateGameFile( Global.World, Global.World.GameFilePath );

            if( !File.Exists( Global.World.GameFilePath ) )
                return null;

            _builtGame = true;
            _itemBuildGame.Enabled = false;

            return Global.World.GameFilePath;
        }

        private string BuildAll( )
        {
            if( !CompileScripts( ) )
                return null;

            if( !BuildAssets( ) )
                return null;

            if( !BuildLevels( ) )
                return null;

            Global.World.GameFilePath = BuildGameFile( );
            if( Global.World.GameFilePath == null )
                return null;

            return Global.World.GameFilePath;
        }

        #endregion

        #region Content Loading Methods

        #region Font-loading related methods

        public void AddFontToLoad( string fontPath )
        {
            string name = Path.GetFileNameWithoutExtension( fontPath );
            string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
            if( File.Exists( newPath ) )
                File.Delete( newPath );

            _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
        }

        public SpriteFont GetLoadedFont( string name )
        {
            return _contentManager.Load<SpriteFont>( name );
        }

        public SpriteFont LoadFont( string fontPath )
        {
            _contentBuilder.Clear( );

            string name = Path.GetFileNameWithoutExtension( fontPath );
            string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
            if( File.Exists( newPath ) )
                File.Delete( newPath );

            _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
            string buildError = _contentBuilder.Build( );
            if( string.IsNullOrEmpty( buildError ) )
            {
                return _contentManager.Load<SpriteFont>( name );
            }
            else
            {
                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return null;
        }

        public SpriteFont[] LoadFont( string[] fontPaths )
        {
            _contentBuilder.Clear( );

            foreach( string fontPath in fontPaths )
            {
                string name = Path.GetFileNameWithoutExtension( fontPath );
                string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
                if( File.Exists( newPath ) )
                    File.Delete( newPath );

                _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
            }

            string buildError = _contentBuilder.Build( );
            if( string.IsNullOrEmpty( buildError ) )
            {
                SpriteFont[] fonts = new SpriteFont[fontPaths.Length];

                for( int i = 0; i < fontPaths.Length; i++ )
                    fonts[i] = _contentManager.Load<SpriteFont>( Path.GetFileNameWithoutExtension( fontPaths[i] ) );

                return fonts;
            }
            else
            {
                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return null;
        }

        #endregion

        public bool BuildAllContent( )
        {
            string buildError = _contentBuilder.Build( );
            if( !string.IsNullOrEmpty( buildError ) )
            {
                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }

            return true;
        }

        public void ConvertContentToXNB( string contentPath, string targetFolder, string importer, string processor )
        {
            if( !Directory.Exists( targetFolder ) )
            {
                MessageBox.Show( "The output folder doesn't exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

            _contentBuilder.Clear( );

            string name = Path.GetFileNameWithoutExtension( contentPath );
            string newPath = Path.Combine( targetFolder, name + ".xnb" );
            if( File.Exists( newPath ) )
                return;

            _contentBuilder.Add( contentPath, name, importer, processor );
            string buildError = _contentBuilder.Build( );
            if( string.IsNullOrEmpty( buildError ) )
            {
                File.Move( Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" ), newPath );
            }
            else
            {
                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public void ConvertContentToXNB( string[] contentPaths, string targetFolder, bool convertAll, string importer, string processor )
        {
            if( !Directory.Exists( targetFolder ) )
            {
                MessageBox.Show( "The output folder doesn't exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

            _contentBuilder.Clear( );

            string name;
            string newPath;
            List<string> newPaths = new List<string>( );

            foreach( string file in contentPaths )
            {
                name = Path.GetFileNameWithoutExtension( file );
                newPath = Path.Combine( targetFolder, name + ".xnb" );
                if( File.Exists( newPath ) && !convertAll )
                    continue;

                _contentBuilder.Add( file, name, importer, processor );
                newPaths.Add( Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" ) );
            }

            string buildError = _contentBuilder.Build( );
            if( string.IsNullOrEmpty( buildError ) )
            {
                foreach( string file in newPaths )
                {
                    string targetPath = Path.Combine( targetFolder, Path.GetFileName( file ) );
                    if( File.Exists( targetPath ) )
                        File.Delete( targetPath );
                    File.Move( file, targetPath );
                }
            }
            else
            {
                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            newPaths.Clear( );
        }

        #endregion

        #region Button Enabling and Disabling

        public void EnableWorldButtons( )
        {
            _itemSaveWorld.Enabled = _btnSaveWorld.Enabled = true;
            _itemNewLevel.Enabled = _btnNewLevel.Enabled = true;
            _itemGameSettings.Enabled = true;
        }

        public void DisableWorldButtons( )
        {
            _itemSaveWorld.Enabled = _btnSaveWorld.Enabled = false;
            _itemNewLevel.Enabled = _btnNewLevel.Enabled = false;
            _itemGameSettings.Enabled = false;
        }

        public void EnableLevelButtons( )
        {
            _itemSelectionTool.Enabled = true;
            _itemToggleGrid.Enabled = true;
            _itemSaveLevel.Enabled = _itemSaveAllLevels.Enabled = _btnSaveLevel.Enabled = true;

            _itemCut.Enabled = true;
            _itemCopy.Enabled = true;
            _itemPaste.Enabled = true;
            _itemDelete.Enabled = true;

            _itemAssetsBrowser.Enabled = _btnAssetsBrowser.Enabled = true;
            _itemScriptEditor.Enabled = _btnScriptEditor.Enabled = true;
            _itemBuildAssets.Enabled = true;
            _itemBuildGame.Enabled = true;
            _itemBuildLevels.Enabled = true;
            _itemBuildScripts.Enabled = true;
            _itemBuildAll.Enabled = true;
            _itemTestGame.Enabled = _btnTestGame.Enabled = true;
        }

        public void DisableLevelButtons( )
        {
            _itemSelectionTool.Enabled = false;
            _itemToggleGrid.Enabled = false;
            _itemSaveLevel.Enabled = _itemSaveAllLevels.Enabled = _btnSaveLevel.Enabled = false;

            _itemCut.Enabled = false;
            _itemCopy.Enabled = false;
            _itemPaste.Enabled = false;
            _itemDelete.Enabled = false;

            _itemAssetsBrowser.Enabled = _btnAssetsBrowser.Enabled = false;
            _itemScriptEditor.Enabled = _btnScriptEditor.Enabled = false;
            _itemBuildAssets.Enabled = false;
            _itemBuildGame.Enabled = false;
            _itemBuildLevels.Enabled = false;
            _itemBuildScripts.Enabled = false;
            _itemBuildAll.Enabled = false;
            _itemTestGame.Enabled = _btnTestGame.Enabled = false;
        }

        #endregion

        #region Other Methods

        public string GetTitle( )
        {
            if( Global.World == null )
                return Consts.Editor.TITLE;
            else
                return Consts.Editor.TITLE + " - " + Global.World.Name;
        }

        private void SaveAllAssets( )
        {
            if( _assetsSaved )
                return;

            _assets.SaveAssets( );

            Global.ScriptEditor.SaveAllScripts( );

            _assetsSaved = true;
            _assets.Text = "Assets Browser";
        }

        public void DisplayMessage( string message, float duration )
        {
            _popUpWindow.Display( message, duration );
        }

        public void ShowTools( )
        {
            _tools.Show( );
        }

        public void HideTools( )
        {
            _tools.Hide( );
        }

        public void ShowProperties( )
        {
            _properties.Show( _dockPanel );
        }

        public void ShowLayers( )
        {
            _layers.Show( _dockPanel );
        }

        bool _scriptEditorFirstTimeShown = false;
        public void ShowScriptEditor( )
        {
            if( !_scriptEditorFirstTimeShown )
            {
                _scriptEditor.Show( _dockPanel, new System.Drawing.Rectangle( 100, 100, 800, 600 ) );
                _scriptEditorFirstTimeShown = true;
            }
            else
                _scriptEditor.Show( _dockPanel );
            //_scriptEditor.FloatPane.ClientSize = new System.Drawing.Size( 700, 500 );
        }

        private void DisposeResources( )
        {
            _undoProvider = null;

            _assets.Dispose( );
            _tools.Dispose( );
            _popUpWindow.Dispose( );
            _properties.Dispose( );
            _layers.Dispose( );
            _scriptEditor.Dispose( );

            _contentBuilder.Dispose( );
            _contentManager.Unload( );
            _contentManager.Dispose( );

            _dockPanel.Dispose( );
        }

        #endregion

        #endregion
    }
}
