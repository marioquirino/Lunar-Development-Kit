//namespace LunarDevKit.Forms
//{
//    partial class DevKitWindow
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose( bool disposing )
//        {
//            if( disposing && (components != null) )
//            {
//                components.Dispose( );
//            }
//            base.Dispose( disposing );
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent( )
//        {
//            this.components = new System.ComponentModel.Container( );
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DevKitWindow ) );
//            this._mainMenu = new System.Windows.Forms.MenuStrip( );
//            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemNewLevel = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemSaveLevel = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemSaveAllLevels = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemRecentWorlds = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemExit = new System.Windows.Forms.ToolStripMenuItem( );
//            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemPreferences = new System.Windows.Forms.ToolStripMenuItem( );
//            this.viewportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemToggleZones = new System.Windows.Forms.ToolStripMenuItem( );
//            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemAssetsBrowser = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemGameSettings = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemBuildDropDown = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemBuildLevels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemBuildContent = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemBuildActors = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemBuildScripts = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemBuildAll = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemPackageWizard = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemTutorial = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemAbout = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemTips = new System.Windows.Forms.ToolStripMenuItem( );
//            this._mainButtonStrip = new System.Windows.Forms.ToolStrip( );
//            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
//            this._statusBar = new System.Windows.Forms.StatusStrip( );
//            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel( );
//            this._levelsTabPanel = new System.Windows.Forms.Panel( );
//            this._viewportTools = new System.Windows.Forms.ToolStrip( );
//            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator( );
//            this._levelsTabControl = new System.Windows.Forms.TabControl( );
//            this.tabPage1 = new System.Windows.Forms.TabPage( );
//            this._levelTabContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
//            this.saveThisLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator( );
//            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator( );
//            this.levelPropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
//            this._actorContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
//            this._itemActorBringFront = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorSendBack = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorSwap = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator( );
//            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemActorProperties = new System.Windows.Forms.ToolStripMenuItem( );
//            this._statusBarPanel = new System.Windows.Forms.Panel( );
//            this._btnSelectionTool = new System.Windows.Forms.ToolStripButton( );
//            this._btnToggleGrid = new System.Windows.Forms.ToolStripSplitButton( );
//            this._itemToggleGridShow = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemDragSnap = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnapEnable = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator( );
//            this._itemDragSnap1Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap2Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap4Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap8Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap16Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap32Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap64Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDragSnap128Pixels = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemRotateSnap = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemScaleSnap = new System.Windows.Forms.ToolStripMenuItem( );
//            this._btnToggleZones = new System.Windows.Forms.ToolStripButton( );
//            this._btnToggleLight = new System.Windows.Forms.ToolStripButton( );
//            this._btnToggleEffects = new System.Windows.Forms.ToolStripButton( );
//            this._btnNewWorld = new System.Windows.Forms.ToolStripButton( );
//            this._btnOpenWorld = new System.Windows.Forms.ToolStripButton( );
//            this._btnSaveWorld = new System.Windows.Forms.ToolStripButton( );
//            this._btnNewLevel = new System.Windows.Forms.ToolStripButton( );
//            this._btnSaveLevel = new System.Windows.Forms.ToolStripButton( );
//            this._btnAssetsBrowser = new System.Windows.Forms.ToolStripButton( );
//            this._btnTestGame = new System.Windows.Forms.ToolStripButton( );
//            this._itemNewWorld = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemOpenWorld = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemSaveWorld = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemSaveWorldAs = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemUndo = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemRedo = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemCut = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemCopy = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemPaste = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemDelete = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemSelectionTool = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemToggleGrid = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemToggleLight = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemToggleEffects = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemTestGame = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem( );
//            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorCut = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorCopy = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorPaste = new System.Windows.Forms.ToolStripMenuItem( );
//            this._itemActorDelete = new System.Windows.Forms.ToolStripMenuItem( );
//            this._mainMenu.SuspendLayout( );
//            this._mainButtonStrip.SuspendLayout( );
//            this._statusBar.SuspendLayout( );
//            this._levelsTabPanel.SuspendLayout( );
//            this._viewportTools.SuspendLayout( );
//            this._levelsTabControl.SuspendLayout( );
//            this._levelTabContextMenu.SuspendLayout( );
//            this._actorContextMenu.SuspendLayout( );
//            this._statusBarPanel.SuspendLayout( );
//            this.SuspendLayout( );
//            // 
//            // _mainMenu
//            // 
//            this._mainMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.fileToolStripMenuItem,
//            this.editToolStripMenuItem,
//            this.viewportToolStripMenuItem,
//            this.gameToolStripMenuItem,
//            this.toolsToolStripMenuItem,
//            this.toolStripMenuItem36,
//            this.toolStripMenuItem34,
//            this.toolStripMenuItem24,
//            this.toolStripMenuItem18,
//            this.toolStripMenuItem10,
//            this.helpToolStripMenuItem} );
//            this._mainMenu.Location = new System.Drawing.Point( 0, 0 );
//            this._mainMenu.Name = "_mainMenu";
//            this._mainMenu.Padding = new System.Windows.Forms.Padding( 4, 2, 0, 2 );
//            this._mainMenu.Size = new System.Drawing.Size( 347, 24 );
//            this._mainMenu.TabIndex = 0;
//            this._mainMenu.Text = "menuStrip1";
//            // 
//            // fileToolStripMenuItem
//            // 
//            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemNewWorld,
//            this._itemOpenWorld,
//            this.toolStripMenuItem5,
//            this._itemSaveWorld,
//            this._itemSaveWorldAs,
//            this.toolStripMenuItem6,
//            this._itemNewLevel,
//            this._itemSaveLevel,
//            this._itemSaveAllLevels,
//            this.toolStripMenuItem7,
//            this._itemRecentWorlds,
//            this.toolStripMenuItem8,
//            this._itemExit} );
//            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
//            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
//            this.fileToolStripMenuItem.Text = "File";
//            // 
//            // toolStripMenuItem5
//            // 
//            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
//            this.toolStripMenuItem5.Size = new System.Drawing.Size( 227, 6 );
//            // 
//            // toolStripMenuItem6
//            // 
//            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
//            this.toolStripMenuItem6.Size = new System.Drawing.Size( 227, 6 );
//            // 
//            // _itemNewLevel
//            // 
//            this._itemNewLevel.Enabled = false;
//            this._itemNewLevel.Name = "_itemNewLevel";
//            this._itemNewLevel.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
//            this._itemNewLevel.Size = new System.Drawing.Size( 230, 22 );
//            this._itemNewLevel.Text = "New Level";
//            this._itemNewLevel.Click += new System.EventHandler( this.newLevelMenuItem_Click );
//            // 
//            // _itemSaveLevel
//            // 
//            this._itemSaveLevel.Enabled = false;
//            this._itemSaveLevel.Name = "_itemSaveLevel";
//            this._itemSaveLevel.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S ) ) );
//            this._itemSaveLevel.Size = new System.Drawing.Size( 230, 22 );
//            this._itemSaveLevel.Text = "Save Current Level";
//            this._itemSaveLevel.Click += new System.EventHandler( this.saveCurrentLevelMenuItem_Click );
//            // 
//            // _itemSaveAllLevels
//            // 
//            this._itemSaveAllLevels.Enabled = false;
//            this._itemSaveAllLevels.Name = "_itemSaveAllLevels";
//            this._itemSaveAllLevels.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift )
//                        | System.Windows.Forms.Keys.S ) ) );
//            this._itemSaveAllLevels.Size = new System.Drawing.Size( 230, 22 );
//            this._itemSaveAllLevels.Text = "Save All Levels";
//            this._itemSaveAllLevels.Click += new System.EventHandler( this.saveAllLevelsMenuItem_Click );
//            // 
//            // toolStripMenuItem7
//            // 
//            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
//            this.toolStripMenuItem7.Size = new System.Drawing.Size( 227, 6 );
//            // 
//            // _itemRecentWorlds
//            // 
//            this._itemRecentWorlds.Enabled = false;
//            this._itemRecentWorlds.Name = "_itemRecentWorlds";
//            this._itemRecentWorlds.Size = new System.Drawing.Size( 230, 22 );
//            this._itemRecentWorlds.Text = "Recent Worlds";
//            // 
//            // toolStripMenuItem8
//            // 
//            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
//            this.toolStripMenuItem8.Size = new System.Drawing.Size( 227, 6 );
//            // 
//            // _itemExit
//            // 
//            this._itemExit.Name = "_itemExit";
//            this._itemExit.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4 ) ) );
//            this._itemExit.Size = new System.Drawing.Size( 230, 22 );
//            this._itemExit.Text = "Exit";
//            this._itemExit.Click += new System.EventHandler( this.exitMenuItem_Click );
//            // 
//            // editToolStripMenuItem
//            // 
//            this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemUndo,
//            this._itemRedo,
//            this.toolStripMenuItem2,
//            this._itemCut,
//            this._itemCopy,
//            this._itemPaste,
//            this._itemDelete,
//            this.toolStripMenuItem3,
//            this._itemPreferences} );
//            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
//            this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
//            this.editToolStripMenuItem.Text = "Edit";
//            // 
//            // toolStripMenuItem2
//            // 
//            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
//            this.toolStripMenuItem2.Size = new System.Drawing.Size( 141, 6 );
//            // 
//            // toolStripMenuItem3
//            // 
//            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
//            this.toolStripMenuItem3.Size = new System.Drawing.Size( 141, 6 );
//            // 
//            // _itemPreferences
//            // 
//            this._itemPreferences.Enabled = false;
//            this._itemPreferences.Name = "_itemPreferences";
//            this._itemPreferences.Size = new System.Drawing.Size( 144, 22 );
//            this._itemPreferences.Text = "Preferences";
//            // 
//            // viewportToolStripMenuItem
//            // 
//            this.viewportToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemSelectionTool,
//            this.toolStripMenuItem9,
//            this._itemToggleGrid,
//            this._itemToggleZones,
//            this._itemToggleLight,
//            this._itemToggleEffects} );
//            this.viewportToolStripMenuItem.Name = "viewportToolStripMenuItem";
//            this.viewportToolStripMenuItem.Size = new System.Drawing.Size( 66, 20 );
//            this.viewportToolStripMenuItem.Text = "Viewport";
//            // 
//            // toolStripMenuItem9
//            // 
//            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
//            this.toolStripMenuItem9.Size = new System.Drawing.Size( 211, 6 );
//            // 
//            // _itemToggleZones
//            // 
//            this._itemToggleZones.Enabled = false;
//            this._itemToggleZones.Name = "_itemToggleZones";
//            this._itemToggleZones.Size = new System.Drawing.Size( 214, 22 );
//            this._itemToggleZones.Text = "Zones";
//            this._itemToggleZones.Click += new System.EventHandler( this.toggleZones_Click );
//            // 
//            // gameToolStripMenuItem
//            // 
//            this.gameToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemAssetsBrowser,
//            this._itemGameSettings,
//            this.toolStripMenuItem1,
//            this._itemBuildDropDown,
//            this._itemBuildAll,
//            this.toolStripSeparator10,
//            this._itemTestGame} );
//            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
//            this.gameToolStripMenuItem.Size = new System.Drawing.Size( 50, 20 );
//            this.gameToolStripMenuItem.Text = "Game";
//            // 
//            // _itemAssetsBrowser
//            // 
//            this._itemAssetsBrowser.Enabled = false;
//            this._itemAssetsBrowser.Name = "_itemAssetsBrowser";
//            this._itemAssetsBrowser.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
//            this._itemAssetsBrowser.Size = new System.Drawing.Size( 194, 22 );
//            this._itemAssetsBrowser.Text = "Assets Browser";
//            this._itemAssetsBrowser.Click += new System.EventHandler( this.AssetsMenuItem_Click );
//            // 
//            // _itemGameSettings
//            // 
//            this._itemGameSettings.Enabled = false;
//            this._itemGameSettings.Name = "_itemGameSettings";
//            this._itemGameSettings.Size = new System.Drawing.Size( 194, 22 );
//            this._itemGameSettings.Text = "Settings";
//            this._itemGameSettings.Click += new System.EventHandler( this.GameSettingsMenuItem_Click );
//            // 
//            // toolStripMenuItem1
//            // 
//            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
//            this.toolStripMenuItem1.Size = new System.Drawing.Size( 191, 6 );
//            // 
//            // _itemBuildDropDown
//            // 
//            this._itemBuildDropDown.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemBuildLevels,
//            this._itemBuildContent,
//            this._itemBuildActors,
//            this._itemBuildScripts} );
//            this._itemBuildDropDown.Enabled = false;
//            this._itemBuildDropDown.Name = "_itemBuildDropDown";
//            this._itemBuildDropDown.Size = new System.Drawing.Size( 194, 22 );
//            this._itemBuildDropDown.Text = "Build...";
//            // 
//            // _itemBuildLevels
//            // 
//            this._itemBuildLevels.Enabled = false;
//            this._itemBuildLevels.Name = "_itemBuildLevels";
//            this._itemBuildLevels.ShortcutKeys = System.Windows.Forms.Keys.F7;
//            this._itemBuildLevels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemBuildLevels.Text = "Build Levels";
//            this._itemBuildLevels.Click += new System.EventHandler( this._itemBuildLevels_Click );
//            // 
//            // _itemBuildContent
//            // 
//            this._itemBuildContent.Enabled = false;
//            this._itemBuildContent.Name = "_itemBuildContent";
//            this._itemBuildContent.ShortcutKeys = System.Windows.Forms.Keys.F8;
//            this._itemBuildContent.Size = new System.Drawing.Size( 166, 22 );
//            this._itemBuildContent.Text = "Build Content";
//            this._itemBuildContent.Click += new System.EventHandler( this._itemBuildContent_Click );
//            // 
//            // _itemBuildActors
//            // 
//            this._itemBuildActors.Enabled = false;
//            this._itemBuildActors.Name = "_itemBuildActors";
//            this._itemBuildActors.ShortcutKeys = System.Windows.Forms.Keys.F9;
//            this._itemBuildActors.Size = new System.Drawing.Size( 166, 22 );
//            this._itemBuildActors.Text = "Build Actors";
//            this._itemBuildActors.Click += new System.EventHandler( this._itemBuildActors_Click );
//            // 
//            // _itemBuildScripts
//            // 
//            this._itemBuildScripts.Enabled = false;
//            this._itemBuildScripts.Name = "_itemBuildScripts";
//            this._itemBuildScripts.ShortcutKeys = System.Windows.Forms.Keys.F10;
//            this._itemBuildScripts.Size = new System.Drawing.Size( 166, 22 );
//            this._itemBuildScripts.Text = "Build Scripts";
//            this._itemBuildScripts.Click += new System.EventHandler( this._itemBuildScripts_Click );
//            // 
//            // _itemBuildAll
//            // 
//            this._itemBuildAll.Enabled = false;
//            this._itemBuildAll.Name = "_itemBuildAll";
//            this._itemBuildAll.ShortcutKeys = System.Windows.Forms.Keys.F6;
//            this._itemBuildAll.Size = new System.Drawing.Size( 194, 22 );
//            this._itemBuildAll.Text = "Build All";
//            this._itemBuildAll.Click += new System.EventHandler( this._itemBuildAll_Click );
//            // 
//            // toolStripSeparator10
//            // 
//            this.toolStripSeparator10.Name = "toolStripSeparator10";
//            this.toolStripSeparator10.Size = new System.Drawing.Size( 191, 6 );
//            // 
//            // toolsToolStripMenuItem
//            // 
//            this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemPackageWizard} );
//            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
//            this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
//            this.toolsToolStripMenuItem.Text = "Tools";
//            // 
//            // _itemPackageWizard
//            // 
//            this._itemPackageWizard.Enabled = false;
//            this._itemPackageWizard.Name = "_itemPackageWizard";
//            this._itemPackageWizard.Size = new System.Drawing.Size( 157, 22 );
//            this._itemPackageWizard.Text = "Package Wizard";
//            this._itemPackageWizard.Click += new System.EventHandler( this.packageWizardMenuItem_Click );
//            // 
//            // toolStripMenuItem36
//            // 
//            this.toolStripMenuItem36.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem37,
//            this.toolStripMenuItem38,
//            this.toolStripSeparator17,
//            this.toolStripMenuItem39} );
//            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
//            this.toolStripMenuItem36.Size = new System.Drawing.Size( 44, 20 );
//            this.toolStripMenuItem36.Text = "Help";
//            // 
//            // toolStripMenuItem37
//            // 
//            this.toolStripMenuItem37.Enabled = false;
//            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
//            this.toolStripMenuItem37.Size = new System.Drawing.Size( 150, 22 );
//            this.toolStripMenuItem37.Text = "Tutorial";
//            this.toolStripMenuItem37.Click += new System.EventHandler( this.TutorialButton_Click );
//            // 
//            // toolStripMenuItem38
//            // 
//            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
//            this.toolStripMenuItem38.Size = new System.Drawing.Size( 150, 22 );
//            this.toolStripMenuItem38.Text = "About";
//            this.toolStripMenuItem38.Click += new System.EventHandler( this.aboutMenuItem_Click );
//            // 
//            // toolStripSeparator17
//            // 
//            this.toolStripSeparator17.Name = "toolStripSeparator17";
//            this.toolStripSeparator17.Size = new System.Drawing.Size( 147, 6 );
//            // 
//            // toolStripMenuItem39
//            // 
//            this.toolStripMenuItem39.Enabled = false;
//            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
//            this.toolStripMenuItem39.Size = new System.Drawing.Size( 150, 22 );
//            this.toolStripMenuItem39.Text = "Hints and Tips";
//            // 
//            // toolStripMenuItem34
//            // 
//            this.toolStripMenuItem34.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem35} );
//            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
//            this.toolStripMenuItem34.Size = new System.Drawing.Size( 48, 20 );
//            this.toolStripMenuItem34.Text = "Tools";
//            // 
//            // toolStripMenuItem35
//            // 
//            this.toolStripMenuItem35.Enabled = false;
//            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
//            this.toolStripMenuItem35.Size = new System.Drawing.Size( 157, 22 );
//            this.toolStripMenuItem35.Text = "Package Wizard";
//            this.toolStripMenuItem35.Click += new System.EventHandler( this.packageWizardMenuItem_Click );
//            // 
//            // toolStripMenuItem24
//            // 
//            this.toolStripMenuItem24.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem25,
//            this.toolStripMenuItem26,
//            this.toolStripSeparator15,
//            this.toolStripMenuItem27,
//            this.toolStripMenuItem32,
//            this.toolStripSeparator16,
//            this.toolStripMenuItem33} );
//            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
//            this.toolStripMenuItem24.Size = new System.Drawing.Size( 50, 20 );
//            this.toolStripMenuItem24.Text = "Game";
//            // 
//            // toolStripMenuItem25
//            // 
//            this.toolStripMenuItem25.Enabled = false;
//            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
//            this.toolStripMenuItem25.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
//            this.toolStripMenuItem25.Size = new System.Drawing.Size( 194, 22 );
//            this.toolStripMenuItem25.Text = "Assets Browser";
//            this.toolStripMenuItem25.Click += new System.EventHandler( this.AssetsMenuItem_Click );
//            // 
//            // toolStripMenuItem26
//            // 
//            this.toolStripMenuItem26.Enabled = false;
//            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
//            this.toolStripMenuItem26.Size = new System.Drawing.Size( 194, 22 );
//            this.toolStripMenuItem26.Text = "Settings";
//            this.toolStripMenuItem26.Click += new System.EventHandler( this.GameSettingsMenuItem_Click );
//            // 
//            // toolStripSeparator15
//            // 
//            this.toolStripSeparator15.Name = "toolStripSeparator15";
//            this.toolStripSeparator15.Size = new System.Drawing.Size( 191, 6 );
//            // 
//            // toolStripMenuItem27
//            // 
//            this.toolStripMenuItem27.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem28,
//            this.toolStripMenuItem29,
//            this.toolStripMenuItem30,
//            this.toolStripMenuItem31} );
//            this.toolStripMenuItem27.Enabled = false;
//            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
//            this.toolStripMenuItem27.Size = new System.Drawing.Size( 194, 22 );
//            this.toolStripMenuItem27.Text = "Build...";
//            // 
//            // toolStripMenuItem28
//            // 
//            this.toolStripMenuItem28.Enabled = false;
//            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
//            this.toolStripMenuItem28.ShortcutKeys = System.Windows.Forms.Keys.F7;
//            this.toolStripMenuItem28.Size = new System.Drawing.Size( 166, 22 );
//            this.toolStripMenuItem28.Text = "Build Levels";
//            this.toolStripMenuItem28.Click += new System.EventHandler( this._itemBuildLevels_Click );
//            // 
//            // toolStripMenuItem29
//            // 
//            this.toolStripMenuItem29.Enabled = false;
//            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
//            this.toolStripMenuItem29.ShortcutKeys = System.Windows.Forms.Keys.F8;
//            this.toolStripMenuItem29.Size = new System.Drawing.Size( 166, 22 );
//            this.toolStripMenuItem29.Text = "Build Content";
//            this.toolStripMenuItem29.Click += new System.EventHandler( this._itemBuildContent_Click );
//            // 
//            // toolStripMenuItem30
//            // 
//            this.toolStripMenuItem30.Enabled = false;
//            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
//            this.toolStripMenuItem30.ShortcutKeys = System.Windows.Forms.Keys.F9;
//            this.toolStripMenuItem30.Size = new System.Drawing.Size( 166, 22 );
//            this.toolStripMenuItem30.Text = "Build Actors";
//            this.toolStripMenuItem30.Click += new System.EventHandler( this._itemBuildActors_Click );
//            // 
//            // toolStripMenuItem31
//            // 
//            this.toolStripMenuItem31.Enabled = false;
//            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
//            this.toolStripMenuItem31.ShortcutKeys = System.Windows.Forms.Keys.F10;
//            this.toolStripMenuItem31.Size = new System.Drawing.Size( 166, 22 );
//            this.toolStripMenuItem31.Text = "Build Scripts";
//            this.toolStripMenuItem31.Click += new System.EventHandler( this._itemBuildScripts_Click );
//            // 
//            // toolStripMenuItem32
//            // 
//            this.toolStripMenuItem32.Enabled = false;
//            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
//            this.toolStripMenuItem32.ShortcutKeys = System.Windows.Forms.Keys.F6;
//            this.toolStripMenuItem32.Size = new System.Drawing.Size( 194, 22 );
//            this.toolStripMenuItem32.Text = "Build All";
//            this.toolStripMenuItem32.Click += new System.EventHandler( this._itemBuildAll_Click );
//            // 
//            // toolStripSeparator16
//            // 
//            this.toolStripSeparator16.Name = "toolStripSeparator16";
//            this.toolStripSeparator16.Size = new System.Drawing.Size( 191, 6 );
//            // 
//            // toolStripMenuItem18
//            // 
//            this.toolStripMenuItem18.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem19,
//            this.toolStripSeparator14,
//            this.toolStripMenuItem20,
//            this.toolStripMenuItem21,
//            this.toolStripMenuItem22,
//            this.toolStripMenuItem23} );
//            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
//            this.toolStripMenuItem18.Size = new System.Drawing.Size( 66, 20 );
//            this.toolStripMenuItem18.Text = "Viewport";
//            // 
//            // toolStripSeparator14
//            // 
//            this.toolStripSeparator14.Name = "toolStripSeparator14";
//            this.toolStripSeparator14.Size = new System.Drawing.Size( 211, 6 );
//            // 
//            // toolStripMenuItem21
//            // 
//            this.toolStripMenuItem21.Enabled = false;
//            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
//            this.toolStripMenuItem21.Size = new System.Drawing.Size( 214, 22 );
//            this.toolStripMenuItem21.Text = "Zones";
//            this.toolStripMenuItem21.Click += new System.EventHandler( this.toggleZones_Click );
//            // 
//            // toolStripMenuItem10
//            // 
//            this.toolStripMenuItem10.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripMenuItem11,
//            this.toolStripMenuItem12,
//            this.toolStripSeparator12,
//            this.toolStripMenuItem13,
//            this.toolStripMenuItem14,
//            this.toolStripMenuItem15,
//            this.toolStripMenuItem16,
//            this.toolStripSeparator13,
//            this.toolStripMenuItem17} );
//            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
//            this.toolStripMenuItem10.Size = new System.Drawing.Size( 39, 20 );
//            this.toolStripMenuItem10.Text = "Edit";
//            // 
//            // toolStripSeparator12
//            // 
//            this.toolStripSeparator12.Name = "toolStripSeparator12";
//            this.toolStripSeparator12.Size = new System.Drawing.Size( 141, 6 );
//            // 
//            // toolStripSeparator13
//            // 
//            this.toolStripSeparator13.Name = "toolStripSeparator13";
//            this.toolStripSeparator13.Size = new System.Drawing.Size( 141, 6 );
//            // 
//            // toolStripMenuItem17
//            // 
//            this.toolStripMenuItem17.Enabled = false;
//            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
//            this.toolStripMenuItem17.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem17.Text = "Preferences";
//            // 
//            // helpToolStripMenuItem
//            // 
//            this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemTutorial,
//            this._itemAbout,
//            this.toolStripMenuItem4,
//            this._itemTips} );
//            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
//            this.helpToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
//            this.helpToolStripMenuItem.Text = "Help";
//            // 
//            // _itemTutorial
//            // 
//            this._itemTutorial.Enabled = false;
//            this._itemTutorial.Name = "_itemTutorial";
//            this._itemTutorial.Size = new System.Drawing.Size( 150, 22 );
//            this._itemTutorial.Text = "Tutorial";
//            this._itemTutorial.Click += new System.EventHandler( this.TutorialButton_Click );
//            // 
//            // _itemAbout
//            // 
//            this._itemAbout.Name = "_itemAbout";
//            this._itemAbout.Size = new System.Drawing.Size( 150, 22 );
//            this._itemAbout.Text = "About";
//            this._itemAbout.Click += new System.EventHandler( this.aboutMenuItem_Click );
//            // 
//            // toolStripMenuItem4
//            // 
//            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
//            this.toolStripMenuItem4.Size = new System.Drawing.Size( 147, 6 );
//            // 
//            // _itemTips
//            // 
//            this._itemTips.Enabled = false;
//            this._itemTips.Name = "_itemTips";
//            this._itemTips.Size = new System.Drawing.Size( 150, 22 );
//            this._itemTips.Text = "Hints and Tips";
//            // 
//            // _mainButtonStrip
//            // 
//            this._mainButtonStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
//            this._mainButtonStrip.ImageScalingSize = new System.Drawing.Size( 24, 24 );
//            this._mainButtonStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._btnNewWorld,
//            this._btnOpenWorld,
//            this._btnSaveWorld,
//            this.toolStripSeparator5,
//            this._btnNewLevel,
//            this._btnSaveLevel,
//            this.toolStripSeparator1,
//            this._btnAssetsBrowser,
//            this.toolStripSeparator2,
//            this._btnTestGame} );
//            this._mainButtonStrip.Location = new System.Drawing.Point( 0, 24 );
//            this._mainButtonStrip.Name = "_mainButtonStrip";
//            this._mainButtonStrip.Size = new System.Drawing.Size( 347, 31 );
//            this._mainButtonStrip.TabIndex = 1;
//            this._mainButtonStrip.Text = "toolStrip1";
//            // 
//            // toolStripSeparator5
//            // 
//            this.toolStripSeparator5.Name = "toolStripSeparator5";
//            this.toolStripSeparator5.Size = new System.Drawing.Size( 6, 31 );
//            // 
//            // toolStripSeparator1
//            // 
//            this.toolStripSeparator1.Name = "toolStripSeparator1";
//            this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 31 );
//            // 
//            // toolStripSeparator2
//            // 
//            this.toolStripSeparator2.Name = "toolStripSeparator2";
//            this.toolStripSeparator2.Size = new System.Drawing.Size( 6, 31 );
//            // 
//            // _statusBar
//            // 
//            this._statusBar.Dock = System.Windows.Forms.DockStyle.Fill;
//            this._statusBar.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._statusLabel} );
//            this._statusBar.Location = new System.Drawing.Point( 0, 0 );
//            this._statusBar.Name = "_statusBar";
//            this._statusBar.Padding = new System.Windows.Forms.Padding( 1, 0, 10, 0 );
//            this._statusBar.Size = new System.Drawing.Size( 345, 19 );
//            this._statusBar.TabIndex = 2;
//            this._statusBar.Text = "statusStrip1";
//            // 
//            // _statusLabel
//            // 
//            this._statusLabel.Name = "_statusLabel";
//            this._statusLabel.Size = new System.Drawing.Size( 118, 14 );
//            this._statusLabel.Text = "toolStripStatusLabel1";
//            // 
//            // _levelsTabPanel
//            // 
//            this._levelsTabPanel.BackColor = System.Drawing.Color.DimGray;
//            this._levelsTabPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this._levelsTabPanel.Controls.Add( this._viewportTools );
//            this._levelsTabPanel.Controls.Add( this._levelsTabControl );
//            this._levelsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
//            this._levelsTabPanel.Location = new System.Drawing.Point( 0, 55 );
//            this._levelsTabPanel.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this._levelsTabPanel.Name = "_levelsTabPanel";
//            this._levelsTabPanel.Size = new System.Drawing.Size( 347, 234 );
//            this._levelsTabPanel.TabIndex = 3;
//            // 
//            // _viewportTools
//            // 
//            this._viewportTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this._viewportTools.Dock = System.Windows.Forms.DockStyle.None;
//            this._viewportTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
//            this._viewportTools.ImageScalingSize = new System.Drawing.Size( 24, 24 );
//            this._viewportTools.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._btnSelectionTool,
//            this.toolStripDropDownButton1,
//            this._btnToggleGrid,
//            this._btnToggleZones,
//            this.toolStripSeparator11,
//            this._btnToggleLight,
//            this._btnToggleEffects} );
//            this._viewportTools.Location = new System.Drawing.Point( 97, 24 );
//            this._viewportTools.Name = "_viewportTools";
//            this._viewportTools.Size = new System.Drawing.Size( 167, 31 );
//            this._viewportTools.TabIndex = 4;
//            this._viewportTools.Text = "toolStrip2";
//            // 
//            // toolStripDropDownButton1
//            // 
//            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
//            this.toolStripDropDownButton1.Size = new System.Drawing.Size( 6, 31 );
//            // 
//            // toolStripSeparator11
//            // 
//            this.toolStripSeparator11.Name = "toolStripSeparator11";
//            this.toolStripSeparator11.Size = new System.Drawing.Size( 6, 31 );
//            // 
//            // _levelsTabControl
//            // 
//            this._levelsTabControl.Controls.Add( this.tabPage1 );
//            this._levelsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
//            this._levelsTabControl.Location = new System.Drawing.Point( 0, 0 );
//            this._levelsTabControl.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this._levelsTabControl.Name = "_levelsTabControl";
//            this._levelsTabControl.SelectedIndex = 0;
//            this._levelsTabControl.Size = new System.Drawing.Size( 345, 232 );
//            this._levelsTabControl.TabIndex = 0;
//            this._levelsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler( this.levelsTabControl_Selected );
//            this._levelsTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.levelsTabControl_MouseDoubleClick );
//            this._levelsTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler( this.levelsTabControl_MouseClick );
//            // 
//            // tabPage1
//            // 
//            this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
//            this.tabPage1.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this.tabPage1.Name = "tabPage1";
//            this.tabPage1.Padding = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this.tabPage1.Size = new System.Drawing.Size( 337, 206 );
//            this.tabPage1.TabIndex = 0;
//            this.tabPage1.Text = "Placeholder Tab";
//            this.tabPage1.UseVisualStyleBackColor = true;
//            // 
//            // _levelTabContextMenu
//            // 
//            this._levelTabContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this.saveThisLevelMenuItem,
//            this.toolStripSeparator6,
//            this.closeToolStripMenuItem,
//            this.closeAllButThisToolStripMenuItem,
//            this.toolStripSeparator7,
//            this.levelPropertiesMenuItem} );
//            this._levelTabContextMenu.Name = "levelTabContextMenu";
//            this._levelTabContextMenu.Size = new System.Drawing.Size( 167, 126 );
//            // 
//            // saveThisLevelMenuItem
//            // 
//            this.saveThisLevelMenuItem.Name = "saveThisLevelMenuItem";
//            this.saveThisLevelMenuItem.Size = new System.Drawing.Size( 166, 22 );
//            this.saveThisLevelMenuItem.Text = "Save This";
//            this.saveThisLevelMenuItem.Click += new System.EventHandler( this.saveCurrentLevelMenuItem_Click );
//            // 
//            // toolStripSeparator6
//            // 
//            this.toolStripSeparator6.Name = "toolStripSeparator6";
//            this.toolStripSeparator6.Size = new System.Drawing.Size( 163, 6 );
//            // 
//            // closeToolStripMenuItem
//            // 
//            this.closeToolStripMenuItem.Enabled = false;
//            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
//            this.closeToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
//            this.closeToolStripMenuItem.Text = "Close";
//            // 
//            // closeAllButThisToolStripMenuItem
//            // 
//            this.closeAllButThisToolStripMenuItem.Enabled = false;
//            this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
//            this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
//            this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
//            // 
//            // toolStripSeparator7
//            // 
//            this.toolStripSeparator7.Name = "toolStripSeparator7";
//            this.toolStripSeparator7.Size = new System.Drawing.Size( 163, 6 );
//            // 
//            // levelPropertiesMenuItem
//            // 
//            this.levelPropertiesMenuItem.Name = "levelPropertiesMenuItem";
//            this.levelPropertiesMenuItem.Size = new System.Drawing.Size( 166, 22 );
//            this.levelPropertiesMenuItem.Text = "Properties";
//            this.levelPropertiesMenuItem.Click += new System.EventHandler( this.levelLayersMenuItem_Click );
//            // 
//            // _actorContextMenu
//            // 
//            this._actorContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemActorBringFront,
//            this._itemActorSendBack,
//            this._itemActorSwap,
//            this.toolStripSeparator8,
//            this._itemActorCut,
//            this._itemActorCopy,
//            this._itemActorPaste,
//            this._itemActorDelete,
//            this.toolStripSeparator9,
//            this._itemActorProperties} );
//            this._actorContextMenu.Name = "ActorContextMenu";
//            this._actorContextMenu.Size = new System.Drawing.Size( 196, 192 );
//            // 
//            // _itemActorBringFront
//            // 
//            this._itemActorBringFront.Name = "_itemActorBringFront";
//            this._itemActorBringFront.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorBringFront.Text = "Bring To Front";
//            this._itemActorBringFront.Click += new System.EventHandler( this.ActorBringToFront );
//            // 
//            // _itemActorSendBack
//            // 
//            this._itemActorSendBack.Name = "_itemActorSendBack";
//            this._itemActorSendBack.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorSendBack.Text = "Send To Back";
//            this._itemActorSendBack.Click += new System.EventHandler( this.ActorSendToBack );
//            // 
//            // _itemActorSwap
//            // 
//            this._itemActorSwap.Name = "_itemActorSwap";
//            this._itemActorSwap.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorSwap.Text = "Swap With Other Actor";
//            this._itemActorSwap.Click += new System.EventHandler( this.ActorSwap );
//            // 
//            // toolStripSeparator8
//            // 
//            this.toolStripSeparator8.Name = "toolStripSeparator8";
//            this.toolStripSeparator8.Size = new System.Drawing.Size( 192, 6 );
//            // 
//            // toolStripSeparator9
//            // 
//            this.toolStripSeparator9.Name = "toolStripSeparator9";
//            this.toolStripSeparator9.Size = new System.Drawing.Size( 192, 6 );
//            // 
//            // _itemActorProperties
//            // 
//            this._itemActorProperties.Enabled = false;
//            this._itemActorProperties.Name = "_itemActorProperties";
//            this._itemActorProperties.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorProperties.Text = "Properties";
//            // 
//            // _statusBarPanel
//            // 
//            this._statusBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this._statusBarPanel.Controls.Add( this._statusBar );
//            this._statusBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this._statusBarPanel.Location = new System.Drawing.Point( 0, 289 );
//            this._statusBarPanel.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this._statusBarPanel.Name = "_statusBarPanel";
//            this._statusBarPanel.Size = new System.Drawing.Size( 347, 21 );
//            this._statusBarPanel.TabIndex = 4;
//            // 
//            // _btnSelectionTool
//            // 
//            this._btnSelectionTool.Checked = true;
//            this._btnSelectionTool.CheckState = System.Windows.Forms.CheckState.Checked;
//            this._btnSelectionTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnSelectionTool.Enabled = false;
//            this._btnSelectionTool.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSelectionTool.Image" ) ) );
//            this._btnSelectionTool.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnSelectionTool.Name = "_btnSelectionTool";
//            this._btnSelectionTool.Size = new System.Drawing.Size( 28, 28 );
//            this._btnSelectionTool.Text = "Selection Tool";
//            this._btnSelectionTool.Click += new System.EventHandler( this._itemSelectionTool_Click );
//            // 
//            // _btnToggleGrid
//            // 
//            this._btnToggleGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnToggleGrid.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemToggleGridShow,
//            this.toolStripSeparator4,
//            this._itemDragSnap,
//            this._itemRotateSnap,
//            this._itemScaleSnap} );
//            this._btnToggleGrid.Image = global::LunarDevKit.Properties.Resources.Render_Grid32;
//            this._btnToggleGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnToggleGrid.Name = "_btnToggleGrid";
//            this._btnToggleGrid.Size = new System.Drawing.Size( 40, 28 );
//            this._btnToggleGrid.Text = "Toggles the displaying of the grid.";
//            this._btnToggleGrid.ButtonClick += new System.EventHandler( this.toggleGrid_Click );
//            // 
//            // _itemToggleGridShow
//            // 
//            this._itemToggleGridShow.Name = "_itemToggleGridShow";
//            this._itemToggleGridShow.Size = new System.Drawing.Size( 137, 22 );
//            this._itemToggleGridShow.Text = "Show Grid";
//            this._itemToggleGridShow.Click += new System.EventHandler( this.toggleGrid_Click );
//            // 
//            // toolStripSeparator4
//            // 
//            this.toolStripSeparator4.Name = "toolStripSeparator4";
//            this.toolStripSeparator4.Size = new System.Drawing.Size( 134, 6 );
//            // 
//            // _itemDragSnap
//            // 
//            this._itemDragSnap.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
//            this._itemDragSnapEnable,
//            this.toolStripSeparator3,
//            this._itemDragSnap1Pixels,
//            this._itemDragSnap2Pixels,
//            this._itemDragSnap4Pixels,
//            this._itemDragSnap8Pixels,
//            this._itemDragSnap16Pixels,
//            this._itemDragSnap32Pixels,
//            this._itemDragSnap64Pixels,
//            this._itemDragSnap128Pixels} );
//            this._itemDragSnap.Name = "_itemDragSnap";
//            this._itemDragSnap.Size = new System.Drawing.Size( 137, 22 );
//            this._itemDragSnap.Text = "Drag Snap";
//            // 
//            // _itemDragSnapEnable
//            // 
//            this._itemDragSnapEnable.CheckOnClick = true;
//            this._itemDragSnapEnable.Name = "_itemDragSnapEnable";
//            this._itemDragSnapEnable.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnapEnable.Text = "Enable Drag Snap";
//            // 
//            // toolStripSeparator3
//            // 
//            this.toolStripSeparator3.Name = "toolStripSeparator3";
//            this.toolStripSeparator3.Size = new System.Drawing.Size( 163, 6 );
//            // 
//            // _itemDragSnap1Pixels
//            // 
//            this._itemDragSnap1Pixels.Name = "_itemDragSnap1Pixels";
//            this._itemDragSnap1Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap1Pixels.Text = "1 pixel";
//            this._itemDragSnap1Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap2Pixels
//            // 
//            this._itemDragSnap2Pixels.Name = "_itemDragSnap2Pixels";
//            this._itemDragSnap2Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap2Pixels.Text = "2 pixels";
//            this._itemDragSnap2Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap4Pixels
//            // 
//            this._itemDragSnap4Pixels.Name = "_itemDragSnap4Pixels";
//            this._itemDragSnap4Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap4Pixels.Text = "4 pixels";
//            this._itemDragSnap4Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap8Pixels
//            // 
//            this._itemDragSnap8Pixels.Name = "_itemDragSnap8Pixels";
//            this._itemDragSnap8Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap8Pixels.Text = "8 pixels";
//            this._itemDragSnap8Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap16Pixels
//            // 
//            this._itemDragSnap16Pixels.Name = "_itemDragSnap16Pixels";
//            this._itemDragSnap16Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap16Pixels.Text = "16 pixels";
//            this._itemDragSnap16Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap32Pixels
//            // 
//            this._itemDragSnap32Pixels.Name = "_itemDragSnap32Pixels";
//            this._itemDragSnap32Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap32Pixels.Text = "32 pixels";
//            this._itemDragSnap32Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap64Pixels
//            // 
//            this._itemDragSnap64Pixels.Name = "_itemDragSnap64Pixels";
//            this._itemDragSnap64Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap64Pixels.Text = "64 pixels";
//            this._itemDragSnap64Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemDragSnap128Pixels
//            // 
//            this._itemDragSnap128Pixels.Name = "_itemDragSnap128Pixels";
//            this._itemDragSnap128Pixels.Size = new System.Drawing.Size( 166, 22 );
//            this._itemDragSnap128Pixels.Text = "128 pixels";
//            this._itemDragSnap128Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
//            // 
//            // _itemRotateSnap
//            // 
//            this._itemRotateSnap.Enabled = false;
//            this._itemRotateSnap.Name = "_itemRotateSnap";
//            this._itemRotateSnap.Size = new System.Drawing.Size( 137, 22 );
//            this._itemRotateSnap.Text = "Rotate Snap";
//            // 
//            // _itemScaleSnap
//            // 
//            this._itemScaleSnap.Enabled = false;
//            this._itemScaleSnap.Name = "_itemScaleSnap";
//            this._itemScaleSnap.Size = new System.Drawing.Size( 137, 22 );
//            this._itemScaleSnap.Text = "Scale Snap";
//            // 
//            // _btnToggleZones
//            // 
//            this._btnToggleZones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnToggleZones.Enabled = false;
//            this._btnToggleZones.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleZones.Image" ) ) );
//            this._btnToggleZones.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnToggleZones.Name = "_btnToggleZones";
//            this._btnToggleZones.Size = new System.Drawing.Size( 28, 28 );
//            this._btnToggleZones.Text = "Toggle the display of Zones";
//            this._btnToggleZones.Click += new System.EventHandler( this.toggleZones_Click );
//            // 
//            // _btnToggleLight
//            // 
//            this._btnToggleLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnToggleLight.Enabled = false;
//            this._btnToggleLight.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleLight.Image" ) ) );
//            this._btnToggleLight.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnToggleLight.Name = "_btnToggleLight";
//            this._btnToggleLight.Size = new System.Drawing.Size( 28, 28 );
//            this._btnToggleLight.Text = "Toggles the rendering of the lighting.";
//            this._btnToggleLight.Click += new System.EventHandler( this.toggleLighting_Click );
//            // 
//            // _btnToggleEffects
//            // 
//            this._btnToggleEffects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnToggleEffects.Enabled = false;
//            this._btnToggleEffects.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleEffects.Image" ) ) );
//            this._btnToggleEffects.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnToggleEffects.Name = "_btnToggleEffects";
//            this._btnToggleEffects.Size = new System.Drawing.Size( 28, 28 );
//            this._btnToggleEffects.Text = "Toggle the rendering of the effects.";
//            this._btnToggleEffects.Click += new System.EventHandler( this.toggleEffects_Click );
//            // 
//            // _btnNewWorld
//            // 
//            this._btnNewWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnNewWorld.Image = global::LunarDevKit.Properties.Resources.New_World32;
//            this._btnNewWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnNewWorld.Name = "_btnNewWorld";
//            this._btnNewWorld.Size = new System.Drawing.Size( 28, 28 );
//            this._btnNewWorld.Text = "Starts a new world project.";
//            this._btnNewWorld.Click += new System.EventHandler( this.newWorldMenuItem_Click );
//            // 
//            // _btnOpenWorld
//            // 
//            this._btnOpenWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnOpenWorld.Image = global::LunarDevKit.Properties.Resources.Open_World32;
//            this._btnOpenWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnOpenWorld.Name = "_btnOpenWorld";
//            this._btnOpenWorld.Size = new System.Drawing.Size( 28, 28 );
//            this._btnOpenWorld.Text = "Opens an existing world project.";
//            this._btnOpenWorld.Click += new System.EventHandler( this.openWorldMenuItem_Click );
//            // 
//            // _btnSaveWorld
//            // 
//            this._btnSaveWorld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnSaveWorld.Enabled = false;
//            this._btnSaveWorld.Image = global::LunarDevKit.Properties.Resources.Save_World32;
//            this._btnSaveWorld.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnSaveWorld.Name = "_btnSaveWorld";
//            this._btnSaveWorld.Size = new System.Drawing.Size( 28, 28 );
//            this._btnSaveWorld.Text = "Saves this world project.";
//            this._btnSaveWorld.Click += new System.EventHandler( this.saveWorldMenuItem_Click );
//            // 
//            // _btnNewLevel
//            // 
//            this._btnNewLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnNewLevel.Enabled = false;
//            this._btnNewLevel.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnNewLevel.Image" ) ) );
//            this._btnNewLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnNewLevel.Name = "_btnNewLevel";
//            this._btnNewLevel.Size = new System.Drawing.Size( 28, 28 );
//            this._btnNewLevel.Text = "Creates a new level.";
//            this._btnNewLevel.Click += new System.EventHandler( this.newLevelMenuItem_Click );
//            // 
//            // _btnSaveLevel
//            // 
//            this._btnSaveLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnSaveLevel.Enabled = false;
//            this._btnSaveLevel.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSaveLevel.Image" ) ) );
//            this._btnSaveLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnSaveLevel.Name = "_btnSaveLevel";
//            this._btnSaveLevel.Size = new System.Drawing.Size( 28, 28 );
//            this._btnSaveLevel.Text = "Saves the currently selected level";
//            this._btnSaveLevel.Click += new System.EventHandler( this.saveCurrentLevelMenuItem_Click );
//            // 
//            // _btnAssetsBrowser
//            // 
//            this._btnAssetsBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnAssetsBrowser.Enabled = false;
//            this._btnAssetsBrowser.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnAssetsBrowser.Image" ) ) );
//            this._btnAssetsBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnAssetsBrowser.Name = "_btnAssetsBrowser";
//            this._btnAssetsBrowser.Size = new System.Drawing.Size( 28, 28 );
//            this._btnAssetsBrowser.Text = "Opens the Assets Browser.";
//            this._btnAssetsBrowser.Click += new System.EventHandler( this.AssetsMenuItem_Click );
//            // 
//            // _btnTestGame
//            // 
//            this._btnTestGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this._btnTestGame.Enabled = false;
//            this._btnTestGame.Image = global::LunarDevKit.Properties.Resources.TestGame32;
//            this._btnTestGame.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this._btnTestGame.Name = "_btnTestGame";
//            this._btnTestGame.Size = new System.Drawing.Size( 28, 28 );
//            this._btnTestGame.Text = "Tests the game.";
//            this._btnTestGame.Click += new System.EventHandler( this.testGame_Click );
//            // 
//            // _itemNewWorld
//            // 
//            this._itemNewWorld.Image = global::LunarDevKit.Properties.Resources.New_World32;
//            this._itemNewWorld.Name = "_itemNewWorld";
//            this._itemNewWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W ) ) );
//            this._itemNewWorld.Size = new System.Drawing.Size( 230, 22 );
//            this._itemNewWorld.Text = "New World";
//            this._itemNewWorld.Click += new System.EventHandler( this.newWorldMenuItem_Click );
//            // 
//            // _itemOpenWorld
//            // 
//            this._itemOpenWorld.Image = global::LunarDevKit.Properties.Resources.Open_World32;
//            this._itemOpenWorld.Name = "_itemOpenWorld";
//            this._itemOpenWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
//            this._itemOpenWorld.Size = new System.Drawing.Size( 230, 22 );
//            this._itemOpenWorld.Text = "Open World";
//            this._itemOpenWorld.Click += new System.EventHandler( this.openWorldMenuItem_Click );
//            // 
//            // _itemSaveWorld
//            // 
//            this._itemSaveWorld.Enabled = false;
//            this._itemSaveWorld.Image = global::LunarDevKit.Properties.Resources.Save_World32;
//            this._itemSaveWorld.Name = "_itemSaveWorld";
//            this._itemSaveWorld.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
//            this._itemSaveWorld.Size = new System.Drawing.Size( 230, 22 );
//            this._itemSaveWorld.Text = "Save World";
//            this._itemSaveWorld.Click += new System.EventHandler( this.saveWorldMenuItem_Click );
//            // 
//            // _itemSaveWorldAs
//            // 
//            this._itemSaveWorldAs.Enabled = false;
//            this._itemSaveWorldAs.Image = global::LunarDevKit.Properties.Resources.Save_World32;
//            this._itemSaveWorldAs.Name = "_itemSaveWorldAs";
//            this._itemSaveWorldAs.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift )
//                        | System.Windows.Forms.Keys.S ) ) );
//            this._itemSaveWorldAs.Size = new System.Drawing.Size( 230, 22 );
//            this._itemSaveWorldAs.Text = "Save World As...";
//            this._itemSaveWorldAs.Click += new System.EventHandler( this.saveWorldAsMenuItem_Click );
//            // 
//            // _itemUndo
//            // 
//            this._itemUndo.Enabled = false;
//            this._itemUndo.Image = global::LunarDevKit.Properties.Resources.Undo32;
//            this._itemUndo.Name = "_itemUndo";
//            this._itemUndo.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
//            this._itemUndo.Size = new System.Drawing.Size( 144, 22 );
//            this._itemUndo.Text = "Undo";
//            this._itemUndo.Click += new System.EventHandler( this.undoMenuItem_Click );
//            // 
//            // _itemRedo
//            // 
//            this._itemRedo.Enabled = false;
//            this._itemRedo.Image = global::LunarDevKit.Properties.Resources.Redo32;
//            this._itemRedo.Name = "_itemRedo";
//            this._itemRedo.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
//            this._itemRedo.Size = new System.Drawing.Size( 144, 22 );
//            this._itemRedo.Text = "Redo";
//            this._itemRedo.Click += new System.EventHandler( this.redoMenuItem_Click );
//            // 
//            // _itemCut
//            // 
//            this._itemCut.Enabled = false;
//            this._itemCut.Image = global::LunarDevKit.Properties.Resources.Cut32;
//            this._itemCut.Name = "_itemCut";
//            this._itemCut.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
//            this._itemCut.Size = new System.Drawing.Size( 144, 22 );
//            this._itemCut.Text = "Cut";
//            this._itemCut.Click += new System.EventHandler( this.cutMenuItem_Click );
//            // 
//            // _itemCopy
//            // 
//            this._itemCopy.Enabled = false;
//            this._itemCopy.Image = global::LunarDevKit.Properties.Resources.Copy32;
//            this._itemCopy.Name = "_itemCopy";
//            this._itemCopy.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
//            this._itemCopy.Size = new System.Drawing.Size( 144, 22 );
//            this._itemCopy.Text = "Copy";
//            this._itemCopy.Click += new System.EventHandler( this.copyMenuItem_Click );
//            // 
//            // _itemPaste
//            // 
//            this._itemPaste.Enabled = false;
//            this._itemPaste.Image = global::LunarDevKit.Properties.Resources.Paste32;
//            this._itemPaste.Name = "_itemPaste";
//            this._itemPaste.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
//            this._itemPaste.Size = new System.Drawing.Size( 144, 22 );
//            this._itemPaste.Text = "Paste";
//            this._itemPaste.Click += new System.EventHandler( this.pasteMenuItem_Click );
//            // 
//            // _itemDelete
//            // 
//            this._itemDelete.Enabled = false;
//            this._itemDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
//            this._itemDelete.Name = "_itemDelete";
//            this._itemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
//            this._itemDelete.Size = new System.Drawing.Size( 144, 22 );
//            this._itemDelete.Text = "Delete";
//            this._itemDelete.Click += new System.EventHandler( this.deleteMenuItem_Click );
//            // 
//            // _itemSelectionTool
//            // 
//            this._itemSelectionTool.Checked = true;
//            this._itemSelectionTool.CheckState = System.Windows.Forms.CheckState.Checked;
//            this._itemSelectionTool.Enabled = false;
//            this._itemSelectionTool.Image = global::LunarDevKit.Properties.Resources.Select32;
//            this._itemSelectionTool.Name = "_itemSelectionTool";
//            this._itemSelectionTool.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space ) ) );
//            this._itemSelectionTool.Size = new System.Drawing.Size( 214, 22 );
//            this._itemSelectionTool.Text = "Selection Tool";
//            this._itemSelectionTool.Click += new System.EventHandler( this._itemSelectionTool_Click );
//            // 
//            // _itemToggleGrid
//            // 
//            this._itemToggleGrid.Enabled = false;
//            this._itemToggleGrid.Image = global::LunarDevKit.Properties.Resources.Render_Grid32;
//            this._itemToggleGrid.Name = "_itemToggleGrid";
//            this._itemToggleGrid.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G ) ) );
//            this._itemToggleGrid.Size = new System.Drawing.Size( 214, 22 );
//            this._itemToggleGrid.Text = "Grid";
//            this._itemToggleGrid.Click += new System.EventHandler( this.toggleGrid_Click );
//            // 
//            // _itemToggleLight
//            // 
//            this._itemToggleLight.Enabled = false;
//            this._itemToggleLight.Image = global::LunarDevKit.Properties.Resources.Render_Lighting32;
//            this._itemToggleLight.Name = "_itemToggleLight";
//            this._itemToggleLight.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H ) ) );
//            this._itemToggleLight.Size = new System.Drawing.Size( 214, 22 );
//            this._itemToggleLight.Text = "Lighting";
//            this._itemToggleLight.Click += new System.EventHandler( this.toggleLighting_Click );
//            // 
//            // _itemToggleEffects
//            // 
//            this._itemToggleEffects.Enabled = false;
//            this._itemToggleEffects.Image = global::LunarDevKit.Properties.Resources.Render_Effects32;
//            this._itemToggleEffects.Name = "_itemToggleEffects";
//            this._itemToggleEffects.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E ) ) );
//            this._itemToggleEffects.Size = new System.Drawing.Size( 214, 22 );
//            this._itemToggleEffects.Text = "Effects";
//            this._itemToggleEffects.Click += new System.EventHandler( this.toggleEffects_Click );
//            // 
//            // _itemTestGame
//            // 
//            this._itemTestGame.Enabled = false;
//            this._itemTestGame.Image = global::LunarDevKit.Properties.Resources.TestGame32;
//            this._itemTestGame.Name = "_itemTestGame";
//            this._itemTestGame.ShortcutKeys = System.Windows.Forms.Keys.F5;
//            this._itemTestGame.Size = new System.Drawing.Size( 194, 22 );
//            this._itemTestGame.Text = "Test Game";
//            this._itemTestGame.Click += new System.EventHandler( this.testGame_Click );
//            // 
//            // toolStripMenuItem33
//            // 
//            this.toolStripMenuItem33.Enabled = false;
//            this.toolStripMenuItem33.Image = global::LunarDevKit.Properties.Resources.TestGame32;
//            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
//            this.toolStripMenuItem33.ShortcutKeys = System.Windows.Forms.Keys.F5;
//            this.toolStripMenuItem33.Size = new System.Drawing.Size( 194, 22 );
//            this.toolStripMenuItem33.Text = "Test Game";
//            this.toolStripMenuItem33.Click += new System.EventHandler( this.testGame_Click );
//            // 
//            // toolStripMenuItem19
//            // 
//            this.toolStripMenuItem19.Checked = true;
//            this.toolStripMenuItem19.CheckState = System.Windows.Forms.CheckState.Checked;
//            this.toolStripMenuItem19.Enabled = false;
//            this.toolStripMenuItem19.Image = global::LunarDevKit.Properties.Resources.Select32;
//            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
//            this.toolStripMenuItem19.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space ) ) );
//            this.toolStripMenuItem19.Size = new System.Drawing.Size( 214, 22 );
//            this.toolStripMenuItem19.Text = "Selection Tool";
//            this.toolStripMenuItem19.Click += new System.EventHandler( this._itemSelectionTool_Click );
//            // 
//            // toolStripMenuItem20
//            // 
//            this.toolStripMenuItem20.Enabled = false;
//            this.toolStripMenuItem20.Image = global::LunarDevKit.Properties.Resources.Render_Grid32;
//            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
//            this.toolStripMenuItem20.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G ) ) );
//            this.toolStripMenuItem20.Size = new System.Drawing.Size( 214, 22 );
//            this.toolStripMenuItem20.Text = "Grid";
//            this.toolStripMenuItem20.Click += new System.EventHandler( this.toggleGrid_Click );
//            // 
//            // toolStripMenuItem22
//            // 
//            this.toolStripMenuItem22.Enabled = false;
//            this.toolStripMenuItem22.Image = global::LunarDevKit.Properties.Resources.Render_Lighting32;
//            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
//            this.toolStripMenuItem22.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H ) ) );
//            this.toolStripMenuItem22.Size = new System.Drawing.Size( 214, 22 );
//            this.toolStripMenuItem22.Text = "Lighting";
//            this.toolStripMenuItem22.Click += new System.EventHandler( this.toggleLighting_Click );
//            // 
//            // toolStripMenuItem23
//            // 
//            this.toolStripMenuItem23.Enabled = false;
//            this.toolStripMenuItem23.Image = global::LunarDevKit.Properties.Resources.Render_Effects32;
//            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
//            this.toolStripMenuItem23.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E ) ) );
//            this.toolStripMenuItem23.Size = new System.Drawing.Size( 214, 22 );
//            this.toolStripMenuItem23.Text = "Effects";
//            this.toolStripMenuItem23.Click += new System.EventHandler( this.toggleEffects_Click );
//            // 
//            // toolStripMenuItem11
//            // 
//            this.toolStripMenuItem11.Enabled = false;
//            this.toolStripMenuItem11.Image = global::LunarDevKit.Properties.Resources.Undo32;
//            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
//            this.toolStripMenuItem11.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
//            this.toolStripMenuItem11.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem11.Text = "Undo";
//            this.toolStripMenuItem11.Click += new System.EventHandler( this.undoMenuItem_Click );
//            // 
//            // toolStripMenuItem12
//            // 
//            this.toolStripMenuItem12.Enabled = false;
//            this.toolStripMenuItem12.Image = global::LunarDevKit.Properties.Resources.Redo32;
//            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
//            this.toolStripMenuItem12.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
//            this.toolStripMenuItem12.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem12.Text = "Redo";
//            this.toolStripMenuItem12.Click += new System.EventHandler( this.redoMenuItem_Click );
//            // 
//            // toolStripMenuItem13
//            // 
//            this.toolStripMenuItem13.Enabled = false;
//            this.toolStripMenuItem13.Image = global::LunarDevKit.Properties.Resources.Cut32;
//            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
//            this.toolStripMenuItem13.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
//            this.toolStripMenuItem13.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem13.Text = "Cut";
//            this.toolStripMenuItem13.Click += new System.EventHandler( this.cutMenuItem_Click );
//            // 
//            // toolStripMenuItem14
//            // 
//            this.toolStripMenuItem14.Enabled = false;
//            this.toolStripMenuItem14.Image = global::LunarDevKit.Properties.Resources.Copy32;
//            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
//            this.toolStripMenuItem14.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
//            this.toolStripMenuItem14.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem14.Text = "Copy";
//            this.toolStripMenuItem14.Click += new System.EventHandler( this.copyMenuItem_Click );
//            // 
//            // toolStripMenuItem15
//            // 
//            this.toolStripMenuItem15.Enabled = false;
//            this.toolStripMenuItem15.Image = global::LunarDevKit.Properties.Resources.Paste32;
//            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
//            this.toolStripMenuItem15.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
//            this.toolStripMenuItem15.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem15.Text = "Paste";
//            this.toolStripMenuItem15.Click += new System.EventHandler( this.pasteMenuItem_Click );
//            // 
//            // toolStripMenuItem16
//            // 
//            this.toolStripMenuItem16.Enabled = false;
//            this.toolStripMenuItem16.Image = global::LunarDevKit.Properties.Resources.Delete32;
//            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
//            this.toolStripMenuItem16.ShortcutKeys = System.Windows.Forms.Keys.Delete;
//            this.toolStripMenuItem16.Size = new System.Drawing.Size( 144, 22 );
//            this.toolStripMenuItem16.Text = "Delete";
//            this.toolStripMenuItem16.Click += new System.EventHandler( this.deleteMenuItem_Click );
//            // 
//            // _itemActorCut
//            // 
//            this._itemActorCut.Image = global::LunarDevKit.Properties.Resources.Cut32;
//            this._itemActorCut.Name = "_itemActorCut";
//            this._itemActorCut.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorCut.Text = "Cut";
//            // 
//            // _itemActorCopy
//            // 
//            this._itemActorCopy.Image = global::LunarDevKit.Properties.Resources.Copy32;
//            this._itemActorCopy.Name = "_itemActorCopy";
//            this._itemActorCopy.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorCopy.Text = "Copy";
//            // 
//            // _itemActorPaste
//            // 
//            this._itemActorPaste.Image = global::LunarDevKit.Properties.Resources.Paste32;
//            this._itemActorPaste.Name = "_itemActorPaste";
//            this._itemActorPaste.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorPaste.Text = "Paste";
//            // 
//            // _itemActorDelete
//            // 
//            this._itemActorDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
//            this._itemActorDelete.Name = "_itemActorDelete";
//            this._itemActorDelete.Size = new System.Drawing.Size( 195, 22 );
//            this._itemActorDelete.Text = "Delete";
//            this._itemActorDelete.Click += new System.EventHandler( this.deleteMenuItem_Click );
//            // 
//            // DevKitWindow
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size( 347, 310 );
//            this.Controls.Add( this._levelsTabPanel );
//            this.Controls.Add( this._statusBarPanel );
//            this.Controls.Add( this._mainButtonStrip );
//            this.Controls.Add( this._mainMenu );
//            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
//            this.MainMenuStrip = this._mainMenu;
//            this.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
//            this.Name = "DevKitWindow";
//            this.Text = "Lunar Development Kit";
//            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.Shown += new System.EventHandler( this.DevKitWindow_Shown );
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.DevKitWindow_FormClosing );
//            this._mainMenu.ResumeLayout( false );
//            this._mainMenu.PerformLayout( );
//            this._mainButtonStrip.ResumeLayout( false );
//            this._mainButtonStrip.PerformLayout( );
//            this._statusBar.ResumeLayout( false );
//            this._statusBar.PerformLayout( );
//            this._levelsTabPanel.ResumeLayout( false );
//            this._levelsTabPanel.PerformLayout( );
//            this._viewportTools.ResumeLayout( false );
//            this._viewportTools.PerformLayout( );
//            this._levelsTabControl.ResumeLayout( false );
//            this._levelTabContextMenu.ResumeLayout( false );
//            this._actorContextMenu.ResumeLayout( false );
//            this._statusBarPanel.ResumeLayout( false );
//            this._statusBarPanel.PerformLayout( );
//            this.ResumeLayout( false );
//            this.PerformLayout( );

//        }

//        #endregion

//        private System.Windows.Forms.MenuStrip _mainMenu;
//        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem viewportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem _itemAssetsBrowser;
//        private System.Windows.Forms.ToolStripMenuItem _itemGameSettings;
//        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem _itemPackageWizard;
//        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem _itemNewWorld;
//        private System.Windows.Forms.ToolStripMenuItem _itemOpenWorld;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
//        private System.Windows.Forms.ToolStripMenuItem _itemSaveWorld;
//        private System.Windows.Forms.ToolStripMenuItem _itemSaveWorldAs;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
//        private System.Windows.Forms.ToolStripMenuItem _itemNewLevel;
//        private System.Windows.Forms.ToolStripMenuItem _itemSaveLevel;
//        private System.Windows.Forms.ToolStripMenuItem _itemSaveAllLevels;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
//        private System.Windows.Forms.ToolStripMenuItem _itemRecentWorlds;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
//        private System.Windows.Forms.ToolStripMenuItem _itemExit;
//        private System.Windows.Forms.ToolStripMenuItem _itemUndo;
//        private System.Windows.Forms.ToolStripMenuItem _itemRedo;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
//        private System.Windows.Forms.ToolStripMenuItem _itemCut;
//        private System.Windows.Forms.ToolStripMenuItem _itemCopy;
//        private System.Windows.Forms.ToolStripMenuItem _itemPaste;
//        private System.Windows.Forms.ToolStripMenuItem _itemDelete;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
//        private System.Windows.Forms.ToolStripMenuItem _itemPreferences;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
//        private System.Windows.Forms.ToolStripMenuItem _itemTestGame;
//        private System.Windows.Forms.ToolStripMenuItem _itemTutorial;
//        private System.Windows.Forms.ToolStripMenuItem _itemAbout;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
//        private System.Windows.Forms.ToolStripMenuItem _itemTips;
//        private System.Windows.Forms.ToolStripMenuItem _itemSelectionTool;
//        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
//        private System.Windows.Forms.ToolStripMenuItem _itemToggleGrid;
//        private System.Windows.Forms.ToolStripMenuItem _itemToggleZones;
//        private System.Windows.Forms.ToolStripMenuItem _itemToggleEffects;
//        private System.Windows.Forms.ToolStripMenuItem _itemToggleLight;
//        private System.Windows.Forms.ToolStrip _mainButtonStrip;
//        private System.Windows.Forms.StatusStrip _statusBar;
//        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
//        private System.Windows.Forms.ToolStripButton _btnNewLevel;
//        private System.Windows.Forms.ToolStripButton _btnSaveLevel;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripButton _btnAssetsBrowser;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
//        private System.Windows.Forms.ToolStripButton _btnTestGame;
//        private System.Windows.Forms.Panel _levelsTabPanel;
//        private System.Windows.Forms.TabControl _levelsTabControl;
//        private System.Windows.Forms.TabPage tabPage1;
//        public System.Windows.Forms.ToolStrip _viewportTools;
//        public System.Windows.Forms.ToolStripButton _btnSelectionTool;
//        private System.Windows.Forms.ToolStripSeparator toolStripDropDownButton1;
//        public System.Windows.Forms.ToolStripButton _btnToggleZones;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
//        public System.Windows.Forms.ToolStripButton _btnToggleLight;
//        public System.Windows.Forms.ToolStripButton _btnToggleEffects;
//        private System.Windows.Forms.ToolStripSplitButton _btnToggleGrid;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnapEnable;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap1Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap2Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap4Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap8Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap16Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap32Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap64Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap128Pixels;
//        private System.Windows.Forms.ToolStripMenuItem _itemRotateSnap;
//        private System.Windows.Forms.ToolStripMenuItem _itemScaleSnap;
//        private System.Windows.Forms.ToolStripMenuItem _itemToggleGridShow;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
//        private System.Windows.Forms.ToolStripButton _btnNewWorld;
//        private System.Windows.Forms.ToolStripButton _btnOpenWorld;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
//        private System.Windows.Forms.ToolStripButton _btnSaveWorld;
//        public System.Windows.Forms.ContextMenuStrip _levelTabContextMenu;
//        private System.Windows.Forms.ToolStripMenuItem saveThisLevelMenuItem;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
//        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
//        private System.Windows.Forms.ToolStripMenuItem levelPropertiesMenuItem;
//        public System.Windows.Forms.ContextMenuStrip _actorContextMenu;
//        public System.Windows.Forms.ToolStripMenuItem _itemActorBringFront;
//        public System.Windows.Forms.ToolStripMenuItem _itemActorSendBack;
//        public System.Windows.Forms.ToolStripMenuItem _itemActorSwap;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
//        private System.Windows.Forms.ToolStripMenuItem _itemActorCut;
//        private System.Windows.Forms.ToolStripMenuItem _itemActorCopy;
//        private System.Windows.Forms.ToolStripMenuItem _itemActorPaste;
//        private System.Windows.Forms.ToolStripMenuItem _itemActorDelete;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
//        private System.Windows.Forms.ToolStripMenuItem _itemActorProperties;
//        private System.Windows.Forms.Panel _statusBarPanel;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildDropDown;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildAll;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildLevels;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildContent;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildActors;
//        private System.Windows.Forms.ToolStripMenuItem _itemBuildScripts;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
//    }
//}