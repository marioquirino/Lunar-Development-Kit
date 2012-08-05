//using System;
//using System.Threading;
//using System.Windows.Forms;
//using System.Collections.Generic;
//using System.IO;
//using System.Reflection;
//using System.Diagnostics;
//using Microsoft.Xna.Framework.Graphics;
//using LunarDevKit.Classes;
//using LunarDevKit.Classes.Collections;
//using LunarDevKit.Controls;

//namespace LunarDevKit.Forms
//{
//    public delegate void GameEventHandler( );

//    public partial class DevKitWindow : Form
//    {
//        #region Imported Stuff

//        [Flags( )]
//        private enum TCHITTESTFLAGS
//        {
//            TCHT_NOWHERE=1,
//            TCHT_ONITEMICON=2,
//            TCHT_ONITEMLABEL=4,
//            TCHT_ONITEM=TCHT_ONITEMICON | TCHT_ONITEMLABEL
//        }

//        private const int TCM_HITTEST = 0x130D;

//        [System.Runtime.InteropServices.StructLayout( System.Runtime.InteropServices.LayoutKind.Sequential )]
//        private struct TCHITTESTINFO
//        {
//            public System.Drawing.Point pt;
//            public TCHITTESTFLAGS flags;
//            public TCHITTESTINFO( int x, int y )
//            {
//                pt = new System.Drawing.Point( x, y );
//                flags = TCHITTESTFLAGS.TCHT_ONITEM;
//            }
//        }

//        [System.Runtime.InteropServices.DllImport( "user32.dll" )]
//        private static extern int SendMessage( IntPtr hwnd, int msg, IntPtr wParam, ref TCHITTESTINFO lParam );

//        #endregion

//        #region Fields

//        private Classes.GraphicsHandler.ContentBuilder _contentBuilder;
//        private Microsoft.Xna.Framework.Content.ContentManager _contentManager;

//        private HelpWindow _helpWindow;
//        private ScriptErrorsDock _scriptErrorsWindow;
//        //private LevelPropertiesWindow _levelProperties;
//        public ViewportControl tempViewport;

//        private ToolStripMenuItem _checkedDragSnapItem;
//        private ToolStripMenuItem _checkedScaleSnapItem;
//        private ToolStripMenuItem _checkedRotateSnapItem;


//        private bool _worldSaved = true;

//        #endregion

//        #region Events

//        public event GameEventHandler TestGameEnded;

//        #endregion

//        public DevKitWindow( )
//        {
//            InitializeComponent( );

//            InitDirectories( );
//            InitGlobalProperties( );

//            _contentBuilder = new Classes.GraphicsHandler.ContentBuilder( );
//            _contentManager = new Microsoft.Xna.Framework.Content.ContentManager( tempViewport.Services, _contentBuilder.OutputDirectory );

//            new LoadingScreen( ).ShowDialog( );

//        }

//        #region Properties

//        public bool RenderGrid
//        {
//            get { return _itemToggleGrid.Checked; }
//            set { _itemToggleGrid.Checked = _itemToggleGridShow.Checked = value; }
//        }
//        public bool ToggleGridEnabled
//        {
//            get { return _itemToggleGrid.Enabled; }
//        }
        
//        public bool RenderZones
//        {
//            get { return _itemToggleZones.Checked; }
//            set { _itemToggleZones.Checked = _btnToggleZones.Checked = value; }
//        }
//        public bool ToggleZonesEnabled
//        {
//            get { return _itemToggleZones.Enabled; }
//        }

//        public bool RenderLighting
//        {
//            get { return _itemToggleLight.Checked; }
//            set { _itemToggleLight.Checked = _btnToggleLight.Checked = value; }
//        }
//        public bool ToggleLightingEnabled
//        {
//            get { return _itemToggleLight.Enabled; }
//        }

//        public bool RenderEffects
//        {
//            get { return _itemToggleEffects.Checked; }
//            set { _itemToggleEffects.Checked = _btnToggleEffects.Checked = value; }
//        }
//        public bool ToggleEffectsEnabled
//        {
//            get { return _itemToggleEffects.Enabled; }
//        }

//        public bool IsSelectMode
//        {
//            get { return _itemSelectionTool.Checked; }
//            set { _itemSelectionTool.Checked = _btnSelectionTool.Checked = value; }
//        }
//        public bool SelectToolEnabled
//        {
//            get { return _itemSelectionTool.Enabled; }
//            set { _itemSelectionTool.Enabled = _btnSelectionTool.Enabled = value; }
//        }

//        /// <summary>
//        /// Gets a value determining whether the Drag Grid Snap is enabled
//        /// </summary>
//        public bool IsDragSnapToGrid
//        {
//            get { return _itemDragSnapEnable.Checked; }
//        }
//        public int DragSnapAmount
//        {
//            get
//            {
//                if( _checkedDragSnapItem == _itemDragSnap1Pixels )
//                    return 1;
//                if( _checkedDragSnapItem == _itemDragSnap2Pixels )
//                    return 2;
//                if( _checkedDragSnapItem == _itemDragSnap4Pixels )
//                    return 4;
//                if( _checkedDragSnapItem == _itemDragSnap8Pixels )
//                    return 8;
//                if( _checkedDragSnapItem == _itemDragSnap16Pixels )
//                    return 16;
//                if( _checkedDragSnapItem == _itemDragSnap32Pixels )
//                    return 32;
//                if( _checkedDragSnapItem == _itemDragSnap64Pixels )
//                    return 64;
//                if( _checkedDragSnapItem == _itemDragSnap128Pixels )
//                    return 128;

//                return 1;
//            }
//        }

//        /// <summary>
//        /// Gets a value determining whether the Rotate Grid Snap is enabled
//        /// </summary>
//        //public bool IsRotationSnapToGrid
//        //{
//        //    get { return rotateGridSnapButton.Checked; }
//        //}
//        //public float RotateSnapAmount
//        //{
//        //    get
//        //    {
//        //        if( _checkedRotateSnapItem == degrees3RotateSnapButton )
//        //            return 0.06654067773228381512021571054864f;
//        //        if( _checkedRotateSnapItem == degrees6RotateSnapButton )
//        //            return 0.09817477042468103870195760572751f;
//        //        if( _checkedRotateSnapItem == degrees11RotateSnapButton )
//        //            return 0.19634954084936207740391521145501f;
//        //        if( _checkedRotateSnapItem == degrees22RotateSnapButton )
//        //            return 0.39269908169872415480783042291003f;
//        //        if( _checkedRotateSnapItem == degrees45RotateSnapButton )
//        //            return 0.78539816339744830961566084582005f;
//        //        if( _checkedRotateSnapItem == degrees90RotateSnapButton )
//        //            return 1.5707963267948966192313216916401f;
//        //        return 0f;
//        //    }
//        //}

//        /// <summary>
//        /// Gets a value determining whether the Scale Grid Snap is enabled
//        /// </summary>
//        //public bool IsScaleSnapToGrid
//        //{
//        //    get { return scaleGridSnapButton.Checked; }
//        //}
//        //public int ScaleSnapAmount
//        //{
//        //    get
//        //    {
//        //        if( _checkedScaleSnapItem == percent1scaleSnapButton )
//        //            return 1;
//        //        if( _checkedScaleSnapItem == percent2scaleSnapButton )
//        //            return 2;
//        //        if( _checkedScaleSnapItem == percent5scaleSnapButton )
//        //            return 5;
//        //        if( _checkedScaleSnapItem == percent10scaleSnapButton )
//        //            return 10;
//        //        if( _checkedScaleSnapItem == percent25scaleSnapButton )
//        //            return 25;
//        //        if( _checkedScaleSnapItem == percent50scaleSnapButton )
//        //            return 50;
//        //        return 1;
//        //    }
//        //}

//        public TabControl LevelsTabControl
//        {
//            get { return _levelsTabControl; }
//        }

//        public ContextMenuStrip ActorContextMenu
//        {
//            get { return _actorContextMenu; }
//        }

//        #endregion

//        #region Init

//        private void InitDirectories( )
//        {
//            if( !Directory.Exists( Consts.Folders.LUNAR_PROJECTS_PATH ) )
//                Directory.CreateDirectory( Consts.Folders.LUNAR_PROJECTS_PATH );

//            if( !Directory.Exists( Consts.Folders.PACKAGES ) )
//                Directory.CreateDirectory( Consts.Folders.PACKAGES );
//        }

//        private void InitGlobalProperties( )
//        {
//            this.MouseWheel += new MouseEventHandler( DevKitWindow_MouseWheel );

//            tempViewport = new ViewportControl( );
//            this.tempViewport.Location = new System.Drawing.Point( -20, 12 );
//            this.tempViewport.Name = "tempViewport";
//            this.tempViewport.Parent = null;
//            this.tempViewport.Size = new System.Drawing.Size( 10, 139 );
//            this.tempViewport.TabIndex = 5;
//            this.tempViewport.Text = "viewportControl1";
//            this.Controls.Add( this.tempViewport );


//            this.Text = Consts.Editor.TITLE;

//            //Global.AssetsBrowser = new AssetsBrowserWindow( this );
//            //Global.Layers = new LayersDock( );


//            _helpWindow = new HelpWindow( );
//            _scriptErrorsWindow = new ScriptErrorsDock( );
//            _levelProperties = new LevelPropertiesWindow( this );

//            InitAssetsTreeViewImages( );

//            _viewportTools.Hide( );
//            _levelsTabControl.TabPages.RemoveAt( 0 );
//            _levelsTabControl.Hide( );
//            _statusLabel.Text = "";


//            _itemDragSnapEnable.Checked = false;
//            pixelsDragButton_Click( _itemDragSnap32Pixels, null );
//            //scaleGridSnapButton.Checked = true;
//            //percentScaleSnapButton_Click( percent5scaleSnapButton, null );
//            //rotateGridSnapButton.Checked = true;
//            //degreesRotateSnapButton_Click( degrees6RotateSnapButton, null );
//        }

//        private void InitAssetsTreeViewImages( )
//        {
//            Global.AssetsTreeViewImages = new ImageList( );
//            Global.AssetsTreeViewImages.ColorDepth = ColorDepth.Depth32Bit;

//            Global.AssetsTreeViewImages.Images.Add( Properties.Resources.SpriteIcon );          //0 - Sprite
//            Global.AssetsTreeViewImages.Images.Add( Properties.Resources.ArchetypeIcon );       //1 - Archetype
//            Global.AssetsTreeViewImages.Images.Add( Properties.Resources.OpenFolderIcon );      //2 - Open Folder
//            Global.AssetsTreeViewImages.Images.Add( Properties.Resources.CloseFolderIcon );     //3 - Close Folder
//            Global.AssetsTreeViewImages.Images.Add( Properties.Resources.NewScriptIcon );       //4 - Script
//        }

//        #endregion Init

//        #region Event Methods


//        #region Form Events

//        private void DevKitWindow_FormClosing( object sender, FormClosingEventArgs e )
//        {
//            if( !_worldSaved )
//            {
//                switch( MessageBox.Show( "Do you want to save the project before exiting the program?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question ) )
//                {
//                    case DialogResult.Yes:
//                        saveWorldMenuItem_Click( null, null );
//                        CloseWorld( );
//                        Dispose( true );
//                        return;

//                    case DialogResult.No:
//                        CloseWorld( );
//                        Dispose( true );
//                        return;
                        
//                    case DialogResult.Cancel:
//                        e.Cancel = true;
//                        return;
//                }
//            }

//            if( MessageBox.Show( "Do you wish to exit Lunar Dev Kit?", "Exit Lunar Dev Kit", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
//                e.Cancel = true;
//            else
//            {
//                CloseWorld( );
//                Dispose( true );
//            }
//        }

//        private void DevKitWindow_MouseWheel( object sender, MouseEventArgs e )
//        {
//            if( Global.SelectedLevel != null )
//            {
//                if( e.Delta > 0 )
//                    Global.SelectedLevel.Viewport.Camera.Zoom += Consts.Camera.ZOOM_INCREMENT;
//                else
//                    Global.SelectedLevel.Viewport.Camera.Zoom -= Consts.Camera.ZOOM_INCREMENT;
//            }
//        }

//        #endregion

//        #region MenuStrip Events

//        #region File Menu

//        private void newWorldMenuItem_Click( object sender, EventArgs e )
//        {
//            new NewWorldWindow( ).ShowDialog( );
//        }

//        private void openWorldMenuItem_Click( object sender, EventArgs e )
//        {
//            OpenFileDialog openFile = new OpenFileDialog( );
//            openFile.InitialDirectory = Consts.Folders.LUNAR_PROJECTS_PATH;
//            openFile.CheckFileExists = openFile.CheckPathExists = true;
//            openFile.Multiselect = false;
//            openFile.Filter = "Lunar World Files (*luworld)|*.luworld";

//            if( openFile.ShowDialog( ) != DialogResult.Cancel )
//            {
//                if( Global.World != null && openFile.FileName == Global.World.FilePath )
//                {
//                    MessageBox.Show( Global.World.Name + " is already open!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
//                    return;
//                }

//                OpenWorld( openFile.FileName );
//            }
//        }

//        private void saveWorldMenuItem_Click( object sender, EventArgs e )
//        {
//            saveAllLevelsMenuItem_Click( sender, e );
//            FileManager.CreateWorldFile( Global.World );

//            this.Text = GetTitleName( );
//        }

//        private void saveWorldAsMenuItem_Click( object sender, EventArgs e )
//        {
//            //SaveFileDialog saveFile = new SaveFileDialog( );
//            //saveFile.ShowDialog( );

//            //this.Text = GetTitleName( );
//        }

//        private void newLevelMenuItem_Click( object sender, EventArgs e )
//        {
//            new NewLevelWindow( ).ShowDialog( );
//            _viewportTools.Show( );
//        }

//        private void saveCurrentLevelMenuItem_Click( object sender, EventArgs e )
//        {
//            FileManager.CreateLevelFile( Global.SelectedLevel.Level );
//        }

//        private void saveAllLevelsMenuItem_Click( object sender, EventArgs e )
//        {
//            foreach( LevelEd lvl in Global.World.Levels )
//                FileManager.CreateLevelFile( lvl );
//        }

//        private void exitMenuItem_Click( object sender, EventArgs e )
//        {
//            this.Close( );
//        }

//        #endregion

//        #region Edit Menu

//        private void undoMenuItem_Click( object sender, EventArgs e )
//        {

//        }

//        private void redoMenuItem_Click( object sender, EventArgs e )
//        {

//        }

//        private void cutMenuItem_Click( object sender, EventArgs e )
//        {

//        }

//        private void copyMenuItem_Click( object sender, EventArgs e )
//        {

//        }

//        private void pasteMenuItem_Click( object sender, EventArgs e )
//        {

//        }

//        private void deleteMenuItem_Click( object sender, EventArgs e )
//        {
//            Global.SelectedLevel.Viewport.DeleteSelectedActors( );
//        }

//        #endregion

//        #region Viewport Menu
        
//        private void _itemSelectionTool_Click( object sender, EventArgs e )
//        {
//            _itemSelectionTool.Checked = _btnSelectionTool.Checked = !_btnSelectionTool.Checked;
//        }

//        private void pixelsDragButton_Click( object sender, EventArgs e )
//        {
//            if( _checkedDragSnapItem != null )
//                _checkedDragSnapItem.Checked = false;
//            _checkedDragSnapItem = sender as ToolStripMenuItem;
//            _checkedDragSnapItem.Checked = true;
//        }

//        private void degreesRotateSnapButton_Click( object sender, EventArgs e )
//        {
//            if( _checkedRotateSnapItem != null )
//                _checkedRotateSnapItem.Checked = false;
//            _checkedRotateSnapItem = sender as ToolStripMenuItem;
//            _checkedRotateSnapItem.Checked = true;
//        }

//        private void percentScaleSnapButton_Click( object sender, EventArgs e )
//        {
//            if( _checkedScaleSnapItem != null )
//                _checkedScaleSnapItem.Checked = false;
//            _checkedScaleSnapItem = sender as ToolStripMenuItem;
//            _checkedScaleSnapItem.Checked = true;
//        }

//        #endregion

//        #region Game Menu

//        private void AssetsMenuItem_Click( object sender, EventArgs e )
//        {
//            Global.AssetsBrowser.Show( );
//        }

//        private void GameSettingsMenuItem_Click( object sender, EventArgs e )
//        {
//            new GameSettingsWindow( ).ShowDialog( );
//        }

//        private void testGame_Click( object sender, EventArgs e )
//        {
//            if( Global.World.GameFilePath == null )
//                return;

//#if DEBUG
//            Thread thread = new Thread( ( ) => { new LDKGameTester.TestGame( Global.World.GameFilePath ).Run( ); } );
//            thread.Start( );
//            thread.Join( );
//            if( TestGameEnded != null )
//                TestGameEnded( );
//#else
//            Process.Start( "LDKGameTester.exe", Global.World.GameFilePath );
//#endif
//        }

//        private void _itemBuildAll_Click( object sender, EventArgs e )
//        {
//            saveWorldMenuItem_Click( null, null );

//            Global.World.GameFilePath = BuildGame( );
//        }

//        private void _itemBuildLevels_Click( object sender, EventArgs e )
//        {
//            saveWorldMenuItem_Click( null, null );
//            BuildLevels( );
//        }

//        private void _itemBuildContent_Click( object sender, EventArgs e )
//        {
//            saveWorldMenuItem_Click( null, null );
//            BuildContent( );
//        }

//        private void _itemBuildActors_Click( object sender, EventArgs e )
//        {
//            saveWorldMenuItem_Click( null, null );
//            BuildActors( );
//        }

//        private void _itemBuildScripts_Click( object sender, EventArgs e )
//        {
//            saveWorldMenuItem_Click( null, null );
//            BuildScripts( );
//        }

//        #endregion

//        #region Tools Menu

//        private void packageWizardMenuItem_Click( object sender, EventArgs e )
//        {
//            PackageWizardWindow pkgWnd = new PackageWizardWindow( );
//            pkgWnd.Owner = this;
//            pkgWnd.ShowDialog( );
//        }

//        #endregion

//        #region Help Menu

//        private void aboutMenuItem_Click( object sender, EventArgs e )
//        {
//            new AboutWindow( ).ShowDialog( );
//        }

//        private void TutorialButton_Click( object sender, EventArgs e )
//        {
//            _helpWindow.Show( );
//        }

//        #endregion

//        #endregion

//        #region ToolStrip Events

//        #region Viewport Control Toolstrip

//        public void toggleGrid_Click( object sender, EventArgs e )
//        {
//            _itemToggleGrid.Checked = _itemToggleGridShow.Checked = !_itemToggleGridShow.Checked;
//        }

//        public void toggleZones_Click( object sender, EventArgs e )
//        {
//            _itemToggleZones.Checked = _btnToggleZones.Checked = !_btnToggleZones.Checked;
//        }

//        public void toggleLighting_Click( object sender, EventArgs e )
//        {
//            _itemToggleLight.Checked = _btnToggleLight.Checked = !_btnToggleLight.Checked;
//        }

//        public void toggleEffects_Click( object sender, EventArgs e )
//        {
//            _itemToggleEffects.Checked = _btnToggleEffects.Checked = !_btnToggleEffects.Checked;
//        }

//        #endregion

//        #endregion

//        #region Context Menus Events

//        #region Actor Context Menu

//        public void ActorBringToFront( object sender, EventArgs e )
//        {
//            ActorEdPool selectedActors = Global.SelectedLevel.Viewport.SelectedActors;
//            ActorEdPool actors = Global.SelectedLevel.Level.SelectedLayer.Actors;

//            actors.Remove( selectedActors[0] );
//            actors.Add( selectedActors[0] );
//        }

//        public void ActorSendToBack( object sender, EventArgs e )
//        {
//            ActorEdPool selectedActors = Global.SelectedLevel.Viewport.SelectedActors;
//            ActorEdPool actors = Global.SelectedLevel.Level.SelectedLayer.Actors;

//            actors.Remove( selectedActors[0] );
//            actors.Insert( 0, selectedActors[0] );
//        }

//        public void ActorSwap( object sender, EventArgs e )
//        {
//            ActorEdPool selectedActors = Global.SelectedLevel.Viewport.SelectedActors;
//            ActorEdPool actors = Global.SelectedLevel.Level.SelectedLayer.Actors;

//            int[] index = new int[2]
//            {
//                actors.IndexOf( selectedActors[0] ),
//                actors.IndexOf( selectedActors[1] )
//            };

//            ActorEd actor = actors[index[0]];
//            actors[index[0]] = actors[index[1]];
//            actors[index[1]] = actor;
//        }

//        #endregion
        
//        #region Level Tab Context Menu Events

//        private void levelLayersMenuItem_Click( object sender, EventArgs e )
//        {
//            _levelProperties.Show( );
//        }

//        #endregion

//        #endregion

//        #region Level Tabs Events

//        private void levelsTabControl_Selected( object sender, TabControlEventArgs e )
//        {
//            Global.SelectedLevel = e.TabPage as LevelTabPage;
//            if( Global.SelectedLevel != null )
//                Global.Layers.RefreshList( );
//        }

//        private void levelsTabControl_MouseClick( object sender, MouseEventArgs e )
//        {
//            if( e.Button == MouseButtons.Right )
//            {
//                TCHITTESTINFO HTI = new TCHITTESTINFO( e.X, e.Y );
//                TabPage page = _levelsTabControl.TabPages[SendMessage( _levelsTabControl.Handle, TCM_HITTEST, IntPtr.Zero, ref HTI )];
//                if( page != null )
//                {
//                    _levelsTabControl.SelectTab( page );
//                    _levelTabContextMenu.Show( _levelsTabControl, e.Location );
//                }
//            }
//        }

//        private void levelsTabControl_MouseDoubleClick( object sender, MouseEventArgs e )
//        {
//            TCHITTESTINFO HTI = new TCHITTESTINFO( e.X, e.Y );
//            TabPage page = _levelsTabControl.TabPages[SendMessage( _levelsTabControl.Handle, TCM_HITTEST, IntPtr.Zero, ref HTI )];
//            if( page != null )
//            {
//                _levelsTabControl.SelectTab( page );
//                levelLayersMenuItem_Click( null, null );
//            }
//        }

//        #endregion


//        #endregion Event Methods

//        #region Methods

//        #region Other Methods

//        public string GetTitleName( )
//        {
//            if( Global.World == null )
//                return Consts.Editor.TITLE;
//            else
//                return Consts.Editor.TITLE + " - " + Global.World.Name;
//        }


//        public void WorldProjectChanged( )
//        {
//            this.Text = GetTitleName( ) + "*";
//            _worldSaved = false;
//        }

//        #endregion

//        #region Content

//        public void AddFontToLoad( string fontPath )
//        {
//            string name = Path.GetFileNameWithoutExtension( fontPath );
//            string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
//            if( File.Exists( newPath ) )
//                File.Delete( newPath );

//            _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
//        }

//        public SpriteFont GetLoadedFont( string name )
//        {
//            return _contentManager.Load<SpriteFont>( name );
//        }

//        public bool BuildAllContent( )
//        {
//            string buildError = _contentBuilder.Build( );
//            if( !string.IsNullOrEmpty( buildError ) )
//            {
//                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//                return false;
//            }

//            return true;
//        }

//        public SpriteFont LoadFont( string fontPath )
//        {
//            _contentBuilder.Clear( );

//            string name = Path.GetFileNameWithoutExtension( fontPath );
//            string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
//            if( File.Exists( newPath ) )
//                File.Delete( newPath );

//            _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
//            string buildError = _contentBuilder.Build( );
//            if( string.IsNullOrEmpty( buildError ) )
//            {
//                return _contentManager.Load<SpriteFont>( name );
//            }
//            else
//            {
//                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//            }

//            return null;
//        }
//        public SpriteFont[] LoadFont( string[] fontPaths )
//        {
//            _contentBuilder.Clear( );

//            foreach( string fontPath in fontPaths )
//            {
//                string name = Path.GetFileNameWithoutExtension( fontPath );
//                string newPath = Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" );
//                if( File.Exists( newPath ) )
//                    File.Delete( newPath );

//                _contentBuilder.Add( fontPath, name, "FontDescriptionImporter", "FontDescriptionProcessor" );
//            }

//            string buildError = _contentBuilder.Build( );
//            if( string.IsNullOrEmpty( buildError ) )
//            {
//                SpriteFont[] fonts = new SpriteFont[fontPaths.Length];

//                for( int i = 0; i < fontPaths.Length; i++ )
//                    fonts[i] = _contentManager.Load<SpriteFont>( Path.GetFileNameWithoutExtension( fontPaths[i] ) );

//                return fonts;
//            }
//            else
//            {
//                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//            }

//            return null;
//        }

//        public void ConvertContentToXNB( string contentPath, string targetFolder, string importer, string processor )
//        {
//            if( !Directory.Exists( targetFolder ) )
//            {
//                MessageBox.Show( "The output folder doesn't exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
//                return;
//            }

//            _contentBuilder.Clear( );

//            string name = Path.GetFileNameWithoutExtension( contentPath );
//            string newPath = Path.Combine( targetFolder, name + ".xnb" );
//            if( File.Exists( newPath ) )
//                return;

//            _contentBuilder.Add( contentPath, name, importer, processor );
//            string buildError = _contentBuilder.Build( );
//            if( string.IsNullOrEmpty( buildError ) )
//            {
//                File.Move( Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" ), newPath );
//            }
//            else
//            {
//                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//            }
//        }

//        public void ConvertContentToXNB( string[] contentPaths, string targetFolder, bool convertAll, string importer, string processor )
//        {
//            if( !Directory.Exists( targetFolder ) )
//            {
//                MessageBox.Show( "The output folder doesn't exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
//                return;
//            }

//            _contentBuilder.Clear( );

//            string name;
//            string newPath;
//            List<string> newPaths = new List<string>( );

//            foreach( string file in contentPaths )
//            {
//                name = Path.GetFileNameWithoutExtension( file );
//                newPath = Path.Combine( targetFolder, name + ".xnb" );
//                if( File.Exists( newPath ) && !convertAll )
//                    continue;

//                _contentBuilder.Add( file, name, importer, processor );
//                newPaths.Add( Path.Combine( _contentBuilder.OutputDirectory, name + ".xnb" ) );
//            }

//            string buildError = _contentBuilder.Build( );
//            if( string.IsNullOrEmpty( buildError ) )
//            {
//                foreach( string file in newPaths )
//                {
//                    string targetPath = Path.Combine( targetFolder, Path.GetFileName( file ) );
//                    if( File.Exists( targetPath ) )
//                        File.Delete( targetPath );
//                    File.Move( file, targetPath );
//                }
//            }
//            else
//            {
//                MessageBox.Show( buildError, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//            }

//            newPaths.Clear( );
//        }

//        #endregion

//        #region Game Build

//        private string BuildGame( )
//        {
//            //The method BuildSprites returns a bool value determing whether it was a successful build or not
//            if( !BuildContent( ) )
//                //if not, return a null string
//                return null;

//            //The method BuildScripts returns a bool value determing whether it was a successful build or not
//            if( !BuildScripts( ) )
//                //if not, return a null string
//                return null;

//            //The method BuildActors returns a bool value determing whether it was a successful build or not
//            if( !BuildActors( ) )
//                //if not, return a null string
//                return null;

//            //The method BuildLevels returns a bool value determing whether it was a successful build or not
//            if( !BuildLevels( ) )
//                //if not, return a null string
//                return null;


//            try
//            {
//                string path = Path.Combine( Global.World.BuildFolderPath, Global.World.Name + Consts.Files.GAME_EXTENSION );

//                FileManager.CreateGameFile( Global.World, path );

//                return path;
//            }
//            catch ( Exception e )
//            {
//                MessageBox.Show( "The game failed to build!\n\n" + e.Message );
//                return null;
//            }
//        }

//        private bool BuildLevels( )
//        {
//            try
//            {
//                string folder = Path.Combine( Global.World.BuildFolderPath, "Levels" );
//                if( !Directory.Exists( folder ) )
//                    Directory.CreateDirectory( folder );

//                foreach( LevelEd level in Global.World.Levels )
//                {
//                    FileManager.CreateGameLevelFile( level, Path.Combine( folder, level.Name + Consts.Files.GAME_LEVEL_EXTENSION ) );
//                }
//            }
//            catch( Exception e )
//            {
//                MessageBox.Show( "Levels failed to build!\n\n" + e.Message );
//                return false;
//            }

//            return true;
//        }

//        private bool BuildActors( )
//        {
//            try
//            {
//                string folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Actors" );
//                if( !Directory.Exists( folder ) )
//                    Directory.CreateDirectory( folder );

//                foreach( ActorAssetItem actorItem in Global.AssetsBrowser.ActorItems.Values )
//                {
//                    FileManager.CreateGameActorFile( actorItem.Actor, Path.Combine( folder, actorItem.Actor.Name + Consts.Files.GAME_ACTORTYPE_EXTENSION ) );
//                }
//            }
//            catch( Exception e )
//            {
//                MessageBox.Show( "Actors failed to build!\n\n" + e.Message );
//                return false;
//            }

//            return true;
//        }

//        private bool BuildContent( )
//        {
//            try
//            {
//                List<string> contentPaths = new List<string>( );

//                string folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Sprites" );
//                if( !Directory.Exists( folder ) )
//                    Directory.CreateDirectory( folder );

//                foreach( SpriteAssetItem spriteItem in Global.AssetsBrowser.SpriteItems.Values )
//                {
//                    contentPaths.Add( spriteItem.FilePath );
//                }

//                ConvertContentToXNB( contentPaths.ToArray( ), folder, true, null, null );



//                contentPaths.Clear( );

//                folder = Path.Combine( Global.World.BuildFolderPath, "Content\\Fonts" );
//                if( !Directory.Exists( folder ) )
//                    Directory.CreateDirectory( folder );

//                foreach( FontAssetItem fontItem in Global.AssetsBrowser.FontItems.Values )
//                {
//                    contentPaths.Add( fontItem.FilePath );
//                }

//                ConvertContentToXNB( contentPaths.ToArray( ), folder, true, "FontDescriptionImporter", "FontDescriptionProcessor" );

//                contentPaths.Clear( );
//            }
//            catch( Exception e )
//            {
//                MessageBox.Show( "Sprites failed to build!\n\n" + e.Message );
//                return false;
//            }

//            return true;
//        }

//        private bool BuildScripts( )
//        {
//            try
//            {
//                if( Global.AssetsBrowser.ScriptItems.Count == 0 )
//                    return true;

//                string folder = Path.Combine( Global.World.BuildFolderPath, "Content" );
//                if( !Directory.Exists( folder ) )
//                    Directory.CreateDirectory( folder );

//                string[] scripts = new string[Global.AssetsBrowser.ScriptItems.Count];
//                int i = 0;
//                foreach( ScriptAssetItem scriptItem in Global.AssetsBrowser.ScriptItems.Values )
//                {
//                    scripts[i] = scriptItem.FilePath;
//                    i++;
//                }

//                string dllPath = Path.Combine( Global.World.BuildFolderPath, "Content\\scripts.dll" );

//                Microsoft.CSharp.CSharpCodeProvider codeProvider = new Microsoft.CSharp.CSharpCodeProvider( );

//                System.CodeDom.Compiler.CompilerParameters parameters = new System.CodeDom.Compiler.CompilerParameters( );
//                parameters.GenerateExecutable = false;
//                parameters.OutputAssembly = dllPath;
//                parameters.ReferencedAssemblies.Add( "LunarEngine.dll" );
//                parameters.ReferencedAssemblies.Add( Assembly.GetAssembly( typeof( Microsoft.Xna.Framework.Input.Keys ) ).Location );
//                parameters.ReferencedAssemblies.Add( Assembly.GetAssembly( typeof( Microsoft.Xna.Framework.Game ) ).Location );

//                System.CodeDom.Compiler.CompilerResults results = codeProvider.CompileAssemblyFromFile( parameters, scripts );


//                _scriptErrorsWindow.FillErrorList( results.Errors );

//                if( results.Errors.HasErrors || results.Errors.HasWarnings )
//                {
//                    _scriptErrorsWindow.Show( );

//                    if( results.Errors.HasErrors )
//                        return false;
//                }
//            }
//            catch( Exception e )
//            {
//                MessageBox.Show( "Actors failed to build!\n\n" + e.Message );
//                return false;
//            }

//            return true;
//        }

//        #endregion

//        #region World Methods

//        public void OpenWorld( string worldFilePath )
//        {
//            CloseWorld( );

//            Global.World = FileManager.LoadWorld( worldFilePath );
//            if( Global.World == null )
//            {
//                MessageBox.Show( "The world file could not be opened! Maybe tried to open a file with the wrong format, the file is corrupted or is an older version that is no longer compatible!", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
//                return;
//            }

//            foreach( string file in Directory.GetFiles( Global.World.BuildFolderPath ) )
//            {
//                if( Path.GetFileName( file ) == Global.World.Name + Consts.Files.GAME_EXTENSION )
//                {
//                    Global.World.GameFilePath = file;
//                    break;
//                }
//            }

//            this.Text = GetTitleName( );

//            EnableWorldButtons( );

//            Global.AssetsBrowser.Initialize( Global.World.TempSpritePaths, Global.World.TempScriptPaths, Global.World.TempActorPaths, Global.World.TempFontPaths );

//            Global.World.TempSpritePaths = null;
//            Global.World.TempScriptPaths = null;
//            Global.World.TempActorPaths = null;
//            Global.World.TempFontPaths = null;

//            if( Global.World.TempLevelPaths != null && Global.World.TempLevelPaths.Length > 0 )
//            {
//                //Global.MainWindow.LevelsTabControl.Show( );
//                //Global.MainWindow._viewportTools.Show( );
//                foreach( string levelPath in Global.World.TempLevelPaths )
//                {
//                    if( !File.Exists( levelPath ) )
//                        MessageBox.Show( Path.GetFileName( levelPath ) + " could not be found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
//                    else
//                    {
//                        Global.World.OpenLevel( levelPath );
//                    }
//                }
//                Global.World.TempLevelPaths = null;
//            }

//            string scriptName = Global.World.TempScriptName;
//            if( scriptName != FileManager.NO_SCRIPT )
//            {
//                //Check if the assets list of scripts contains the given script name
//                if( Global.AssetsBrowser.ScriptItems.ContainsKey( scriptName ) )
//                    //if so, assign the script
//                    Global.World.Script = Global.AssetsBrowser.ScriptItems[scriptName].Script;
//                else
//                    //if not, display a message box with a warning message
//                    MessageBox.Show( scriptName + " could not be found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
//            }
//        }

//        private void CloseWorld( )
//        {
//            if( Global.World != null && Directory.Exists( Global.World.TempFolderPath ) )
//                Directory.Delete( Global.World.TempFolderPath, true );

//            this.Text = Consts.Editor.TITLE;
//            _itemToggleGridShow.Checked = true;
//            _itemToggleGrid.Checked = true;

//            DisableWorldButtons( );

//            _levelsTabControl.TabPages.Clear( );
//            _levelsTabControl.Hide( );
//            _viewportTools.Hide( );

//            DisableLevelButtons( );

//            Global.Layers.Hide( );

//            Global.AssetsBrowser.Reset( );

//            Global.World = null;
//        }

//        #endregion

//        #region Display Status Message Methods

//        /// <summary>
//        /// Displays a message on the Status Bar
//        /// </summary>
//        public void DisplayStatusMessage( string message )
//        {
//            _statusLabel.Text = message;
//        }

//        #endregion Display Status Message Methods

//        #region Buttons Enabling/Disabling Methods

//        public void EnableWorldButtons( )
//        {
//            _itemSaveWorld.Enabled = _btnSaveWorld.Enabled = true;
//            _itemNewLevel.Enabled = _btnNewLevel.Enabled = true;
//            _itemGameSettings.Enabled = true;
//        }

//        public void DisableWorldButtons( )
//        {
//            _itemSaveWorld.Enabled = _btnSaveWorld.Enabled = false;
//            _itemNewLevel.Enabled = _btnNewLevel.Enabled = false;
//            _itemGameSettings.Enabled = false;
//        }

//        public void EnableLevelButtons( )
//        {
//            _itemSelectionTool.Enabled = _btnSelectionTool.Enabled = true;
//            _itemToggleGrid.Enabled = _btnToggleGrid.Enabled = true;
//            _itemSaveLevel.Enabled = _itemSaveAllLevels.Enabled = _btnSaveLevel.Enabled = true;
//            _itemDragSnapEnable.Enabled = true;
//            //rotateGridSnapButton.Enabled = true;
//            //scaleGridSnapButton.Enabled = true;

//            _itemDelete.Enabled = true;

//            _itemAssetsBrowser.Enabled = _btnAssetsBrowser.Enabled = true;
//            _itemBuildDropDown.Enabled = true;
//            _itemBuildActors.Enabled = true;
//            _itemBuildContent.Enabled = true;
//            _itemBuildLevels.Enabled = true;
//            _itemBuildScripts.Enabled = true;
//            _itemBuildAll.Enabled = true;
//            _itemTestGame.Enabled = _btnTestGame.Enabled = true;
//        }

//        public void DisableLevelButtons( )
//        {
//            _itemSelectionTool.Enabled = _btnSelectionTool.Enabled = false;
//            _itemToggleGrid.Enabled = _btnToggleGrid.Enabled = false;
//            _itemSaveLevel.Enabled = _itemSaveAllLevels.Enabled = _btnSaveLevel.Enabled = false;
//            _itemDragSnapEnable.Enabled = false;
//            //rotateGridSnapButton.Enabled = false;
//            //scaleGridSnapButton.Enabled = false;

//            _itemDelete.Enabled = false;

//            _itemAssetsBrowser.Enabled = _btnAssetsBrowser.Enabled = false;

//            _itemBuildDropDown.Enabled = false;
//            _itemBuildActors.Enabled = false;
//            _itemBuildContent.Enabled = false;
//            _itemBuildLevels.Enabled = false;
//            _itemBuildScripts.Enabled = false;
//            _itemBuildAll.Enabled = false;
//            _itemTestGame.Enabled = _btnTestGame.Enabled = false;
//        }

//        #endregion Buttons Enabling/Disabling Methods

//        #endregion

//        private void DevKitWindow_Shown( object sender, EventArgs e )
//        {
//            //helpWindow.Show( );
//        }
//    }
//}
