namespace LunarDevKit.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                DisposeResources( );
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainWindow ) );
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip( );
            this._itemFile = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemNewWorld = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemOpenWorld = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemSaveWorld = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemNewLevel = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemSaveLevel = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemSaveAllLevels = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemRecentWorlds = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemExit = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemUndo = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemRedo = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemCut = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemCopy = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemPaste = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemPreferences = new System.Windows.Forms.ToolStripMenuItem( );
            this.viewportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemSelectionTool = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemToggleGrid = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemToggleZones = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemToggleLight = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemToggleEffects = new System.Windows.Forms.ToolStripMenuItem( );
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemAssetsBrowser = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemGameSettings = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemTestGame = new System.Windows.Forms.ToolStripMenuItem( );
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemBuildScripts = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemBuildAssets = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemBuildLevels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemBuildGame = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemBuildAll = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemScriptEditor = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemPackageWizard = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemTutorial = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemAbout = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemHints = new System.Windows.Forms.ToolStripMenuItem( );
            this._mainToolStrip = new System.Windows.Forms.ToolStrip( );
            this._btnNewWorld = new System.Windows.Forms.ToolStripButton( );
            this._btnOpenWorld = new System.Windows.Forms.ToolStripButton( );
            this._btnSaveWorld = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnUndo = new System.Windows.Forms.ToolStripButton( );
            this._btnRedo = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnNewLevel = new System.Windows.Forms.ToolStripButton( );
            this._btnSaveLevel = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnAssetsBrowser = new System.Windows.Forms.ToolStripButton( );
            this._btnScriptEditor = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnTestGame = new System.Windows.Forms.ToolStripButton( );
            this._statusStrip = new System.Windows.Forms.StatusStrip( );
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel( );
            this._levelTabContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemLevelTabLayers = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemLevelTabProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this._mainMenuStrip.SuspendLayout( );
            this._mainToolStrip.SuspendLayout( );
            this._statusStrip.SuspendLayout( );
            this._levelTabContextMenu.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemFile,
            this.toolStripMenuItem10,
            this.viewportToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem36} );
            this._mainMenuStrip.Location = new System.Drawing.Point( 0, 0 );
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding( 4, 2, 0, 2 );
            this._mainMenuStrip.Size = new System.Drawing.Size( 492, 24 );
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _itemFile
            // 
            this._itemFile.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemNewWorld,
            this._itemOpenWorld,
            this.toolStripMenuItem5,
            this._itemSaveWorld,
            this.toolStripMenuItem6,
            this._itemNewLevel,
            this._itemSaveLevel,
            this._itemSaveAllLevels,
            this.toolStripMenuItem7,
            this._itemRecentWorlds,
            this.toolStripMenuItem8,
            this._itemExit} );
            this._itemFile.Name = "_itemFile";
            this._itemFile.Size = new System.Drawing.Size( 37, 20 );
            this._itemFile.Text = "File";
            // 
            // _itemNewWorld
            // 
            this._itemNewWorld.Image = global::LunarDevKit.Properties.Resources.New_World32;
            this._itemNewWorld.Name = "_itemNewWorld";
            this._itemNewWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W ) ) );
            this._itemNewWorld.Size = new System.Drawing.Size( 218, 22 );
            this._itemNewWorld.Text = "New World";
            this._itemNewWorld.Click += new System.EventHandler( this.NewWorld_Click );
            // 
            // _itemOpenWorld
            // 
            this._itemOpenWorld.Image = global::LunarDevKit.Properties.Resources.Open_World32;
            this._itemOpenWorld.Name = "_itemOpenWorld";
            this._itemOpenWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
            this._itemOpenWorld.Size = new System.Drawing.Size( 218, 22 );
            this._itemOpenWorld.Text = "Open World";
            this._itemOpenWorld.Click += new System.EventHandler( this.OpenWorld_Click );
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size( 215, 6 );
            // 
            // _itemSaveWorld
            // 
            this._itemSaveWorld.Enabled = false;
            this._itemSaveWorld.Image = global::LunarDevKit.Properties.Resources.Save_World32;
            this._itemSaveWorld.Name = "_itemSaveWorld";
            this._itemSaveWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
            this._itemSaveWorld.Size = new System.Drawing.Size( 218, 22 );
            this._itemSaveWorld.Text = "Save World";
            this._itemSaveWorld.Click += new System.EventHandler( this.SaveWorld_Click );
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size( 215, 6 );
            // 
            // _itemNewLevel
            // 
            this._itemNewLevel.Enabled = false;
            this._itemNewLevel.Name = "_itemNewLevel";
            this._itemNewLevel.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
            this._itemNewLevel.Size = new System.Drawing.Size( 218, 22 );
            this._itemNewLevel.Text = "New Level";
            this._itemNewLevel.Click += new System.EventHandler( this.NewLevel_Click );
            // 
            // _itemSaveLevel
            // 
            this._itemSaveLevel.Enabled = false;
            this._itemSaveLevel.Name = "_itemSaveLevel";
            this._itemSaveLevel.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S ) ) );
            this._itemSaveLevel.Size = new System.Drawing.Size( 218, 22 );
            this._itemSaveLevel.Text = "Save Current Level";
            this._itemSaveLevel.Click += new System.EventHandler( this.SaveLevel_Click );
            // 
            // _itemSaveAllLevels
            // 
            this._itemSaveAllLevels.Enabled = false;
            this._itemSaveAllLevels.Name = "_itemSaveAllLevels";
            this._itemSaveAllLevels.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift ) 
            | System.Windows.Forms.Keys.S ) ) );
            this._itemSaveAllLevels.Size = new System.Drawing.Size( 218, 22 );
            this._itemSaveAllLevels.Text = "Save All Levels";
            this._itemSaveAllLevels.Click += new System.EventHandler( this.SaveAllLevels_Click );
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size( 215, 6 );
            // 
            // _itemRecentWorlds
            // 
            this._itemRecentWorlds.Enabled = false;
            this._itemRecentWorlds.Name = "_itemRecentWorlds";
            this._itemRecentWorlds.Size = new System.Drawing.Size( 218, 22 );
            this._itemRecentWorlds.Text = "Recent Worlds";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size( 215, 6 );
            // 
            // _itemExit
            // 
            this._itemExit.Name = "_itemExit";
            this._itemExit.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4 ) ) );
            this._itemExit.Size = new System.Drawing.Size( 218, 22 );
            this._itemExit.Text = "Exit";
            this._itemExit.Click += new System.EventHandler( this.Exit_Click );
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemUndo,
            this._itemRedo,
            this.toolStripSeparator12,
            this._itemCut,
            this._itemCopy,
            this._itemPaste,
            this._itemDelete,
            this.toolStripSeparator13,
            this._itemPreferences} );
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size( 39, 20 );
            this.toolStripMenuItem10.Text = "Edit";
            // 
            // _itemUndo
            // 
            this._itemUndo.Enabled = false;
            this._itemUndo.Image = global::LunarDevKit.Properties.Resources.Undo32;
            this._itemUndo.Name = "_itemUndo";
            this._itemUndo.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
            this._itemUndo.Size = new System.Drawing.Size( 152, 22 );
            this._itemUndo.Text = "Undo";
            this._itemUndo.Click += new System.EventHandler( this.Undo_Click );
            // 
            // _itemRedo
            // 
            this._itemRedo.Enabled = false;
            this._itemRedo.Image = global::LunarDevKit.Properties.Resources.Redo32;
            this._itemRedo.Name = "_itemRedo";
            this._itemRedo.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
            this._itemRedo.Size = new System.Drawing.Size( 152, 22 );
            this._itemRedo.Text = "Redo";
            this._itemRedo.Click += new System.EventHandler( this.Redo_Click );
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size( 149, 6 );
            // 
            // _itemCut
            // 
            this._itemCut.Enabled = false;
            this._itemCut.Image = global::LunarDevKit.Properties.Resources.Cut32;
            this._itemCut.Name = "_itemCut";
            this._itemCut.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
            this._itemCut.Size = new System.Drawing.Size( 152, 22 );
            this._itemCut.Text = "Cut";
            this._itemCut.Click += new System.EventHandler( this.Cut_Click );
            // 
            // _itemCopy
            // 
            this._itemCopy.Enabled = false;
            this._itemCopy.Image = global::LunarDevKit.Properties.Resources.Copy32;
            this._itemCopy.Name = "_itemCopy";
            this._itemCopy.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
            this._itemCopy.Size = new System.Drawing.Size( 152, 22 );
            this._itemCopy.Text = "Copy";
            this._itemCopy.Click += new System.EventHandler( this.Copy_Click );
            // 
            // _itemPaste
            // 
            this._itemPaste.Enabled = false;
            this._itemPaste.Image = global::LunarDevKit.Properties.Resources.Paste32;
            this._itemPaste.Name = "_itemPaste";
            this._itemPaste.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
            this._itemPaste.Size = new System.Drawing.Size( 152, 22 );
            this._itemPaste.Text = "Paste";
            this._itemPaste.Click += new System.EventHandler( this.Paste_Click );
            // 
            // _itemDelete
            // 
            this._itemDelete.Enabled = false;
            this._itemDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
            this._itemDelete.Name = "_itemDelete";
            this._itemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._itemDelete.Size = new System.Drawing.Size( 152, 22 );
            this._itemDelete.Text = "Delete";
            this._itemDelete.Click += new System.EventHandler( this.Delete_Click );
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size( 149, 6 );
            // 
            // _itemPreferences
            // 
            this._itemPreferences.Enabled = false;
            this._itemPreferences.Name = "_itemPreferences";
            this._itemPreferences.Size = new System.Drawing.Size( 152, 22 );
            this._itemPreferences.Text = "Preferences";
            this._itemPreferences.Click += new System.EventHandler( this.Preferences_Click );
            // 
            // viewportToolStripMenuItem
            // 
            this.viewportToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemSelectionTool,
            this.toolStripMenuItem9,
            this._itemToggleGrid,
            this._itemToggleZones,
            this._itemToggleLight,
            this._itemToggleEffects} );
            this.viewportToolStripMenuItem.Name = "viewportToolStripMenuItem";
            this.viewportToolStripMenuItem.Size = new System.Drawing.Size( 66, 20 );
            this.viewportToolStripMenuItem.Text = "Viewport";
            // 
            // _itemSelectionTool
            // 
            this._itemSelectionTool.Checked = true;
            this._itemSelectionTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this._itemSelectionTool.Enabled = false;
            this._itemSelectionTool.Image = global::LunarDevKit.Properties.Resources.Select32;
            this._itemSelectionTool.Name = "_itemSelectionTool";
            this._itemSelectionTool.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space ) ) );
            this._itemSelectionTool.Size = new System.Drawing.Size( 214, 22 );
            this._itemSelectionTool.Text = "Selection Tool";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size( 211, 6 );
            // 
            // _itemToggleGrid
            // 
            this._itemToggleGrid.Enabled = false;
            this._itemToggleGrid.Image = global::LunarDevKit.Properties.Resources.Render_Grid32;
            this._itemToggleGrid.Name = "_itemToggleGrid";
            this._itemToggleGrid.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G ) ) );
            this._itemToggleGrid.Size = new System.Drawing.Size( 214, 22 );
            this._itemToggleGrid.Text = "Grid";
            // 
            // _itemToggleZones
            // 
            this._itemToggleZones.Enabled = false;
            this._itemToggleZones.Name = "_itemToggleZones";
            this._itemToggleZones.Size = new System.Drawing.Size( 214, 22 );
            this._itemToggleZones.Text = "Zones";
            // 
            // _itemToggleLight
            // 
            this._itemToggleLight.Enabled = false;
            this._itemToggleLight.Image = global::LunarDevKit.Properties.Resources.Render_Lighting32;
            this._itemToggleLight.Name = "_itemToggleLight";
            this._itemToggleLight.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H ) ) );
            this._itemToggleLight.Size = new System.Drawing.Size( 214, 22 );
            this._itemToggleLight.Text = "Lighting";
            // 
            // _itemToggleEffects
            // 
            this._itemToggleEffects.Enabled = false;
            this._itemToggleEffects.Image = global::LunarDevKit.Properties.Resources.Render_Effects32;
            this._itemToggleEffects.Name = "_itemToggleEffects";
            this._itemToggleEffects.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E ) ) );
            this._itemToggleEffects.Size = new System.Drawing.Size( 214, 22 );
            this._itemToggleEffects.Text = "Effects";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemAssetsBrowser,
            this._itemGameSettings,
            this.toolStripSeparator10,
            this._itemTestGame} );
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size( 50, 20 );
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // _itemAssetsBrowser
            // 
            this._itemAssetsBrowser.Enabled = false;
            this._itemAssetsBrowser.Name = "_itemAssetsBrowser";
            this._itemAssetsBrowser.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
            this._itemAssetsBrowser.Size = new System.Drawing.Size( 194, 22 );
            this._itemAssetsBrowser.Text = "Assets Browser";
            this._itemAssetsBrowser.Click += new System.EventHandler( this.AssetsBrowser_Click );
            // 
            // _itemGameSettings
            // 
            this._itemGameSettings.Enabled = false;
            this._itemGameSettings.Name = "_itemGameSettings";
            this._itemGameSettings.Size = new System.Drawing.Size( 194, 22 );
            this._itemGameSettings.Text = "Settings";
            this._itemGameSettings.Click += new System.EventHandler( this.GameSettings_Click );
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size( 191, 6 );
            // 
            // _itemTestGame
            // 
            this._itemTestGame.Enabled = false;
            this._itemTestGame.Image = global::LunarDevKit.Properties.Resources.TestGame32;
            this._itemTestGame.Name = "_itemTestGame";
            this._itemTestGame.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this._itemTestGame.Size = new System.Drawing.Size( 194, 22 );
            this._itemTestGame.Text = "Run";
            this._itemTestGame.Click += new System.EventHandler( this.TestGame_Click );
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemBuildScripts,
            this._itemBuildAssets,
            this._itemBuildLevels,
            this._itemBuildGame,
            this.toolStripMenuItem2,
            this._itemBuildAll} );
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size( 46, 20 );
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // _itemBuildScripts
            // 
            this._itemBuildScripts.Enabled = false;
            this._itemBuildScripts.Name = "_itemBuildScripts";
            this._itemBuildScripts.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._itemBuildScripts.Size = new System.Drawing.Size( 176, 22 );
            this._itemBuildScripts.Text = "Compile Scripts";
            this._itemBuildScripts.Click += new System.EventHandler( this.CompileScripts_Click );
            // 
            // _itemBuildAssets
            // 
            this._itemBuildAssets.Enabled = false;
            this._itemBuildAssets.Name = "_itemBuildAssets";
            this._itemBuildAssets.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this._itemBuildAssets.Size = new System.Drawing.Size( 176, 22 );
            this._itemBuildAssets.Text = "Build Assets";
            this._itemBuildAssets.Click += new System.EventHandler( this.BuildAssets_Click );
            // 
            // _itemBuildLevels
            // 
            this._itemBuildLevels.Enabled = false;
            this._itemBuildLevels.Name = "_itemBuildLevels";
            this._itemBuildLevels.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this._itemBuildLevels.Size = new System.Drawing.Size( 176, 22 );
            this._itemBuildLevels.Text = "Build Levels";
            this._itemBuildLevels.Click += new System.EventHandler( this.BuildLevels_Click );
            // 
            // _itemBuildGame
            // 
            this._itemBuildGame.Enabled = false;
            this._itemBuildGame.Name = "_itemBuildGame";
            this._itemBuildGame.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this._itemBuildGame.Size = new System.Drawing.Size( 176, 22 );
            this._itemBuildGame.Text = "Build Game File";
            this._itemBuildGame.Click += new System.EventHandler( this.BuildGame_Click );
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size( 173, 6 );
            // 
            // _itemBuildAll
            // 
            this._itemBuildAll.Enabled = false;
            this._itemBuildAll.Name = "_itemBuildAll";
            this._itemBuildAll.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this._itemBuildAll.Size = new System.Drawing.Size( 176, 22 );
            this._itemBuildAll.Text = "Build All";
            this._itemBuildAll.Click += new System.EventHandler( this.BuildAll_Click );
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemScriptEditor,
            this.toolStripSeparator3,
            this._itemPackageWizard} );
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // _itemScriptEditor
            // 
            this._itemScriptEditor.Name = "_itemScriptEditor";
            this._itemScriptEditor.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift ) 
            | System.Windows.Forms.Keys.S ) ) );
            this._itemScriptEditor.Size = new System.Drawing.Size( 210, 22 );
            this._itemScriptEditor.Text = "Script Editor";
            this._itemScriptEditor.Click += new System.EventHandler( this.ScriptEditor_Click );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 207, 6 );
            // 
            // _itemPackageWizard
            // 
            this._itemPackageWizard.Enabled = false;
            this._itemPackageWizard.Name = "_itemPackageWizard";
            this._itemPackageWizard.Size = new System.Drawing.Size( 210, 22 );
            this._itemPackageWizard.Text = "Package Wizard";
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemTutorial,
            this._itemAbout,
            this.toolStripSeparator17,
            this._itemHints} );
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size( 44, 20 );
            this.toolStripMenuItem36.Text = "Help";
            // 
            // _itemTutorial
            // 
            this._itemTutorial.Enabled = false;
            this._itemTutorial.Name = "_itemTutorial";
            this._itemTutorial.Size = new System.Drawing.Size( 150, 22 );
            this._itemTutorial.Text = "Tutorial";
            // 
            // _itemAbout
            // 
            this._itemAbout.Name = "_itemAbout";
            this._itemAbout.Size = new System.Drawing.Size( 150, 22 );
            this._itemAbout.Text = "About";
            this._itemAbout.Click += new System.EventHandler( this._itemAbout_Click );
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size( 147, 6 );
            // 
            // _itemHints
            // 
            this._itemHints.Enabled = false;
            this._itemHints.Name = "_itemHints";
            this._itemHints.Size = new System.Drawing.Size( 150, 22 );
            this._itemHints.Text = "Hints and Tips";
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._mainToolStrip.ImageScalingSize = new System.Drawing.Size( 24, 24 );
            this._mainToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnNewWorld,
            this._btnOpenWorld,
            this._btnSaveWorld,
            this.toolStripSeparator5,
            this._btnUndo,
            this._btnRedo,
            this.toolStripSeparator4,
            this._btnNewLevel,
            this._btnSaveLevel,
            this.toolStripSeparator1,
            this._btnAssetsBrowser,
            this._btnScriptEditor,
            this.toolStripSeparator2,
            this._btnTestGame} );
            this._mainToolStrip.Location = new System.Drawing.Point( 0, 24 );
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size( 492, 31 );
            this._mainToolStrip.TabIndex = 1;
            this._mainToolStrip.Text = "toolStrip1";
            // 
            // _btnNewWorld
            // 
            this._btnNewWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewWorld.Image = global::LunarDevKit.Properties.Resources.New_World32;
            this._btnNewWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewWorld.Name = "_btnNewWorld";
            this._btnNewWorld.Size = new System.Drawing.Size( 28, 28 );
            this._btnNewWorld.Text = "Starts a new world project.";
            this._btnNewWorld.Click += new System.EventHandler( this.NewWorld_Click );
            // 
            // _btnOpenWorld
            // 
            this._btnOpenWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnOpenWorld.Image = global::LunarDevKit.Properties.Resources.Open_World32;
            this._btnOpenWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnOpenWorld.Name = "_btnOpenWorld";
            this._btnOpenWorld.Size = new System.Drawing.Size( 28, 28 );
            this._btnOpenWorld.Text = "Opens an existing world project.";
            this._btnOpenWorld.Click += new System.EventHandler( this.OpenWorld_Click );
            // 
            // _btnSaveWorld
            // 
            this._btnSaveWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSaveWorld.Enabled = false;
            this._btnSaveWorld.Image = global::LunarDevKit.Properties.Resources.Save_World32;
            this._btnSaveWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSaveWorld.Name = "_btnSaveWorld";
            this._btnSaveWorld.Size = new System.Drawing.Size( 28, 28 );
            this._btnSaveWorld.Text = "Saves this world project.";
            this._btnSaveWorld.Click += new System.EventHandler( this.SaveWorld_Click );
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnUndo
            // 
            this._btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnUndo.Enabled = false;
            this._btnUndo.Image = global::LunarDevKit.Properties.Resources.Undo32;
            this._btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnUndo.Name = "_btnUndo";
            this._btnUndo.Size = new System.Drawing.Size( 28, 28 );
            this._btnUndo.Text = "Undo";
            this._btnUndo.Click += new System.EventHandler( this.Undo_Click );
            // 
            // _btnRedo
            // 
            this._btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnRedo.Enabled = false;
            this._btnRedo.Image = global::LunarDevKit.Properties.Resources.Redo32;
            this._btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnRedo.Name = "_btnRedo";
            this._btnRedo.Size = new System.Drawing.Size( 28, 28 );
            this._btnRedo.Text = "Redo";
            this._btnRedo.Click += new System.EventHandler( this.Redo_Click );
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnNewLevel
            // 
            this._btnNewLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewLevel.Enabled = false;
            this._btnNewLevel.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnNewLevel.Image" ) ) );
            this._btnNewLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewLevel.Name = "_btnNewLevel";
            this._btnNewLevel.Size = new System.Drawing.Size( 28, 28 );
            this._btnNewLevel.Text = "Creates a new level.";
            this._btnNewLevel.Click += new System.EventHandler( this.NewLevel_Click );
            // 
            // _btnSaveLevel
            // 
            this._btnSaveLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSaveLevel.Enabled = false;
            this._btnSaveLevel.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSaveLevel.Image" ) ) );
            this._btnSaveLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSaveLevel.Name = "_btnSaveLevel";
            this._btnSaveLevel.Size = new System.Drawing.Size( 28, 28 );
            this._btnSaveLevel.Text = "Saves the currently selected level";
            this._btnSaveLevel.Click += new System.EventHandler( this.SaveLevel_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnAssetsBrowser
            // 
            this._btnAssetsBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnAssetsBrowser.Enabled = false;
            this._btnAssetsBrowser.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnAssetsBrowser.Image" ) ) );
            this._btnAssetsBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAssetsBrowser.Name = "_btnAssetsBrowser";
            this._btnAssetsBrowser.Size = new System.Drawing.Size( 28, 28 );
            this._btnAssetsBrowser.Text = "Opens the Assets Browser.";
            this._btnAssetsBrowser.Click += new System.EventHandler( this.AssetsBrowser_Click );
            // 
            // _btnScriptEditor
            // 
            this._btnScriptEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnScriptEditor.Enabled = false;
            this._btnScriptEditor.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnScriptEditor.Image" ) ) );
            this._btnScriptEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnScriptEditor.Name = "_btnScriptEditor";
            this._btnScriptEditor.Size = new System.Drawing.Size( 28, 28 );
            this._btnScriptEditor.Text = "Open up the Script Editor.";
            this._btnScriptEditor.Click += new System.EventHandler( this.ScriptEditor_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnTestGame
            // 
            this._btnTestGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnTestGame.Enabled = false;
            this._btnTestGame.Image = global::LunarDevKit.Properties.Resources.TestGame32;
            this._btnTestGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnTestGame.Name = "_btnTestGame";
            this._btnTestGame.Size = new System.Drawing.Size( 28, 28 );
            this._btnTestGame.Text = "Tests the game.";
            this._btnTestGame.Click += new System.EventHandler( this.TestGame_Click );
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel} );
            this._statusStrip.Location = new System.Drawing.Point( 0, 397 );
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Padding = new System.Windows.Forms.Padding( 1, 0, 10, 0 );
            this._statusStrip.Size = new System.Drawing.Size( 492, 22 );
            this._statusStrip.TabIndex = 3;
            this._statusStrip.Text = "statusStrip1";
            this._statusStrip.Visible = false;
            // 
            // _statusLabel
            // 
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size( 118, 17 );
            this._statusLabel.Text = "toolStripStatusLabel1";
            // 
            // _levelTabContextMenu
            // 
            this._levelTabContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemLevelTabLayers,
            this._itemLevelTabProperties} );
            this._levelTabContextMenu.Name = "levelTabContextMenu";
            this._levelTabContextMenu.Size = new System.Drawing.Size( 128, 48 );
            // 
            // _itemLevelTabLayers
            // 
            this._itemLevelTabLayers.Name = "_itemLevelTabLayers";
            this._itemLevelTabLayers.Size = new System.Drawing.Size( 127, 22 );
            this._itemLevelTabLayers.Text = "Layers";
            this._itemLevelTabLayers.Click += new System.EventHandler( this.LevelTabLayers_Click );
            // 
            // _itemLevelTabProperties
            // 
            this._itemLevelTabProperties.Name = "_itemLevelTabProperties";
            this._itemLevelTabProperties.Size = new System.Drawing.Size( 127, 22 );
            this._itemLevelTabProperties.Text = "Properties";
            this._itemLevelTabProperties.Click += new System.EventHandler( this.LevelTabProperties_Click );
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 492, 419 );
            this.Controls.Add( this._statusStrip );
            this.Controls.Add( this._mainToolStrip );
            this.Controls.Add( this._mainMenuStrip );
            this.IsMdiContainer = true;
            this.MainMenuStrip = this._mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding( 2 );
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.MainWindow_FormClosing );
            this._mainMenuStrip.ResumeLayout( false );
            this._mainMenuStrip.PerformLayout( );
            this._mainToolStrip.ResumeLayout( false );
            this._mainToolStrip.PerformLayout( );
            this._statusStrip.ResumeLayout( false );
            this._statusStrip.PerformLayout( );
            this._levelTabContextMenu.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStrip _mainToolStrip;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripMenuItem _itemFile;
        private System.Windows.Forms.ToolStripMenuItem _itemNewWorld;
        private System.Windows.Forms.ToolStripMenuItem _itemOpenWorld;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem _itemSaveWorld;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem _itemNewLevel;
        private System.Windows.Forms.ToolStripMenuItem _itemSaveLevel;
        private System.Windows.Forms.ToolStripMenuItem _itemSaveAllLevels;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem _itemRecentWorlds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem _itemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem _itemUndo;
        private System.Windows.Forms.ToolStripMenuItem _itemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem _itemCut;
        private System.Windows.Forms.ToolStripMenuItem _itemCopy;
        private System.Windows.Forms.ToolStripMenuItem _itemPaste;
        private System.Windows.Forms.ToolStripMenuItem _itemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem _itemPreferences;
        private System.Windows.Forms.ToolStripMenuItem viewportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _itemSelectionTool;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem _itemToggleGrid;
        private System.Windows.Forms.ToolStripMenuItem _itemToggleZones;
        private System.Windows.Forms.ToolStripMenuItem _itemToggleLight;
        private System.Windows.Forms.ToolStripMenuItem _itemToggleEffects;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _itemAssetsBrowser;
        private System.Windows.Forms.ToolStripMenuItem _itemGameSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem _itemTestGame;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _itemPackageWizard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolStripMenuItem _itemTutorial;
        private System.Windows.Forms.ToolStripMenuItem _itemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem _itemHints;
        private System.Windows.Forms.ToolStripMenuItem _itemBuildScripts;
        private System.Windows.Forms.ToolStripMenuItem _itemBuildLevels;
        private System.Windows.Forms.ToolStripMenuItem _itemBuildAssets;
        private System.Windows.Forms.ToolStripMenuItem _itemBuildGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem _itemBuildAll;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
        private System.Windows.Forms.ToolStripButton _btnNewWorld;
        private System.Windows.Forms.ToolStripButton _btnOpenWorld;
        private System.Windows.Forms.ToolStripButton _btnSaveWorld;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _btnNewLevel;
        private System.Windows.Forms.ToolStripButton _btnSaveLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _btnAssetsBrowser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _btnTestGame;
        public System.Windows.Forms.ContextMenuStrip _levelTabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _itemLevelTabLayers;
        private System.Windows.Forms.ToolStripMenuItem _itemLevelTabProperties;
        private System.Windows.Forms.ToolStripMenuItem _itemScriptEditor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _btnScriptEditor;
        private System.Windows.Forms.ToolStripButton _btnUndo;
        private System.Windows.Forms.ToolStripButton _btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}