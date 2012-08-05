namespace LunarDevKit.Forms
{
    partial class AssetsBrowserWindow
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AssetsBrowserWindow ) );
            this._tabControl = new System.Windows.Forms.CustomTabControl( );
            this._addAssetTab = new LunarDevKit.Controls.AssetsTabPage( );
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel( );
            this._addSpriteItem = new LunarDevKit.Controls.AssetItem( );
            this._addActorItem = new LunarDevKit.Controls.AssetItem( );
            this._addScriptItem = new LunarDevKit.Controls.AssetItem( );
            this._addFontItem = new LunarDevKit.Controls.AssetItem( );
            this._spritesTab = new LunarDevKit.Controls.AssetsTabPage( );
            this._spritesTabPanel = new System.Windows.Forms.FlowLayoutPanel( );
            this._actorsTab = new LunarDevKit.Controls.AssetsTabPage( );
            this._actorsTabPanel = new System.Windows.Forms.FlowLayoutPanel( );
            this._scriptsTab = new LunarDevKit.Controls.AssetsTabPage( );
            this._scriptsTabPanel = new System.Windows.Forms.FlowLayoutPanel( );
            this._fontsTab = new LunarDevKit.Controls.AssetsTabPage( );
            this._fontsTabPanel = new System.Windows.Forms.FlowLayoutPanel( );
            this._spriteItemContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemCreateActorFromSprite = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemSpriteEdit = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemSpriteDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemSpriteProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this._actorItemContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemActorEdit = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemActorDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemActorProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this._menuScriptItem = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemScriptEdit = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemScriptDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemScriptProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this.label1 = new System.Windows.Forms.Label( );
            this._txtSearch = new System.Windows.Forms.TextBox( );
            this._menuFontItem = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemFontEdit = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemFontDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemFontProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this._tabControl.SuspendLayout( );
            this._addAssetTab.SuspendLayout( );
            this.flowLayoutPanel4.SuspendLayout( );
            this._spritesTab.SuspendLayout( );
            this._actorsTab.SuspendLayout( );
            this._scriptsTab.SuspendLayout( );
            this._fontsTab.SuspendLayout( );
            this._spriteItemContextMenu.SuspendLayout( );
            this._actorItemContextMenu.SuspendLayout( );
            this._menuScriptItem.SuspendLayout( );
            this._menuFontItem.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._tabControl.Controls.Add( this._addAssetTab );
            this._tabControl.Controls.Add( this._spritesTab );
            this._tabControl.Controls.Add( this._actorsTab );
            this._tabControl.Controls.Add( this._scriptsTab );
            this._tabControl.Controls.Add( this._fontsTab );
            this._tabControl.DisplayStyle = System.Windows.Forms.TabStyle.VS2010;
            // 
            // 
            // 
            this._tabControl.DisplayStyleProvider.BorderColor = System.Drawing.Color.Transparent;
            this._tabControl.DisplayStyleProvider.BorderColorHot = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 155 ) ) ) ), ( (int)( ( (byte)( 167 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ) );
            this._tabControl.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 127 ) ) ) ), ( (int)( ( (byte)( 157 ) ) ) ), ( (int)( ( (byte)( 185 ) ) ) ) );
            this._tabControl.DisplayStyleProvider.CloserColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 117 ) ) ) ), ( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 61 ) ) ) ) );
            this._tabControl.DisplayStyleProvider.FocusTrack = false;
            this._tabControl.DisplayStyleProvider.HotTrack = true;
            this._tabControl.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tabControl.DisplayStyleProvider.Opacity = 1F;
            this._tabControl.DisplayStyleProvider.Overlap = 0;
            this._tabControl.DisplayStyleProvider.Padding = new System.Drawing.Point( 5, 5 );
            this._tabControl.DisplayStyleProvider.Radius = 6;
            this._tabControl.DisplayStyleProvider.ShowTabCloser = true;
            this._tabControl.DisplayStyleProvider.TextColor = System.Drawing.Color.White;
            this._tabControl.DisplayStyleProvider.TextColorDisabled = System.Drawing.Color.WhiteSmoke;
            this._tabControl.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this._tabControl.HotTrack = true;
            this._tabControl.Location = new System.Drawing.Point( 12, 49 );
            this._tabControl.Margin = new System.Windows.Forms.Padding( 4 );
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size( 396, 637 );
            this._tabControl.TabIndex = 18;
            this._tabControl.TabClosing += new System.EventHandler<System.Windows.Forms.TabControlCancelEventArgs>( this._tabControl_TabClosing );
            // 
            // _addAssetTab
            // 
            this._addAssetTab.AssetType = LunarDevKit.Classes.AssetType.None;
            this._addAssetTab.BackColor = System.Drawing.Color.LightGray;
            this._addAssetTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._addAssetTab.Controls.Add( this.flowLayoutPanel4 );
            this._addAssetTab.Location = new System.Drawing.Point( 4, 27 );
            this._addAssetTab.Margin = new System.Windows.Forms.Padding( 4 );
            this._addAssetTab.Name = "_addAssetTab";
            this._addAssetTab.Size = new System.Drawing.Size( 388, 606 );
            this._addAssetTab.TabIndex = 3;
            this._addAssetTab.Text = "Add Asset";
            this._addAssetTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this.flowLayoutPanel4.Controls.Add( this._addSpriteItem );
            this.flowLayoutPanel4.Controls.Add( this._addActorItem );
            this.flowLayoutPanel4.Controls.Add( this._addScriptItem );
            this.flowLayoutPanel4.Controls.Add( this._addFontItem );
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point( 0, 0 );
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding( 4 );
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size( 386, 604 );
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // _addSpriteItem
            // 
            this._addSpriteItem.AssetName = "Add Sprite";
            this._addSpriteItem.AssetThumbnail = ( (System.Drawing.Image)( resources.GetObject( "_addSpriteItem.AssetThumbnail" ) ) );
            this._addSpriteItem.BackColor = System.Drawing.Color.Transparent;
            this._addSpriteItem.DefaultBackColor = System.Drawing.Color.Transparent;
            this._addSpriteItem.DefaultLabelColor = System.Drawing.Color.White;
            this._addSpriteItem.FilePath = null;
            this._addSpriteItem.HighlightBackColor = System.Drawing.Color.LightGray;
            this._addSpriteItem.HighlightLabelColor = System.Drawing.SystemColors.ControlText;
            this._addSpriteItem.LabelFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this._addSpriteItem.LabelName = "Add Sprite";
            this._addSpriteItem.LabelVisible = false;
            this._addSpriteItem.Location = new System.Drawing.Point( 5, 5 );
            this._addSpriteItem.Margin = new System.Windows.Forms.Padding( 5 );
            this._addSpriteItem.MinimumSize = new System.Drawing.Size( 0, 78 );
            this._addSpriteItem.Name = "_addSpriteItem";
            this._addSpriteItem.SelectBackColor = System.Drawing.SystemColors.Control;
            this._addSpriteItem.SelectLabelColor = System.Drawing.SystemColors.ControlText;
            this._addSpriteItem.Size = new System.Drawing.Size( 358, 78 );
            this._addSpriteItem.TabIndex = 0;
            this._addSpriteItem.AssetClicked += new LunarDevKit.Controls.AssetItemEventHandler( this._addSpriteButton_AssetClicked );
            // 
            // _addActorItem
            // 
            this._addActorItem.AssetName = "Add Actor";
            this._addActorItem.AssetThumbnail = ( (System.Drawing.Image)( resources.GetObject( "_addActorItem.AssetThumbnail" ) ) );
            this._addActorItem.BackColor = System.Drawing.Color.Transparent;
            this._addActorItem.DefaultBackColor = System.Drawing.Color.Transparent;
            this._addActorItem.DefaultLabelColor = System.Drawing.Color.White;
            this._addActorItem.FilePath = null;
            this._addActorItem.HighlightBackColor = System.Drawing.Color.LightGray;
            this._addActorItem.HighlightLabelColor = System.Drawing.SystemColors.ControlText;
            this._addActorItem.LabelFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this._addActorItem.LabelName = "Add Actor";
            this._addActorItem.LabelVisible = false;
            this._addActorItem.Location = new System.Drawing.Point( 5, 93 );
            this._addActorItem.Margin = new System.Windows.Forms.Padding( 5 );
            this._addActorItem.MinimumSize = new System.Drawing.Size( 0, 78 );
            this._addActorItem.Name = "_addActorItem";
            this._addActorItem.SelectBackColor = System.Drawing.SystemColors.Control;
            this._addActorItem.SelectLabelColor = System.Drawing.SystemColors.ControlText;
            this._addActorItem.Size = new System.Drawing.Size( 357, 78 );
            this._addActorItem.TabIndex = 1;
            this._addActorItem.AssetClicked += new LunarDevKit.Controls.AssetItemEventHandler( this._addActorButton_AssetClicked );
            // 
            // _addScriptItem
            // 
            this._addScriptItem.AssetName = "Add Script";
            this._addScriptItem.AssetThumbnail = ( (System.Drawing.Image)( resources.GetObject( "_addScriptItem.AssetThumbnail" ) ) );
            this._addScriptItem.BackColor = System.Drawing.Color.Transparent;
            this._addScriptItem.DefaultBackColor = System.Drawing.Color.Transparent;
            this._addScriptItem.DefaultLabelColor = System.Drawing.Color.White;
            this._addScriptItem.FilePath = null;
            this._addScriptItem.HighlightBackColor = System.Drawing.Color.LightGray;
            this._addScriptItem.HighlightLabelColor = System.Drawing.SystemColors.ControlText;
            this._addScriptItem.LabelFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this._addScriptItem.LabelName = "Add Script";
            this._addScriptItem.LabelVisible = false;
            this._addScriptItem.Location = new System.Drawing.Point( 5, 181 );
            this._addScriptItem.Margin = new System.Windows.Forms.Padding( 5 );
            this._addScriptItem.MinimumSize = new System.Drawing.Size( 0, 78 );
            this._addScriptItem.Name = "_addScriptItem";
            this._addScriptItem.SelectBackColor = System.Drawing.SystemColors.Control;
            this._addScriptItem.SelectLabelColor = System.Drawing.SystemColors.ControlText;
            this._addScriptItem.Size = new System.Drawing.Size( 358, 78 );
            this._addScriptItem.TabIndex = 3;
            this._addScriptItem.AssetClicked += new LunarDevKit.Controls.AssetItemEventHandler( this._addScriptButton_AssetClicked );
            // 
            // _addFontItem
            // 
            this._addFontItem.AssetName = "Add Font";
            this._addFontItem.AssetThumbnail = global::LunarDevKit.Properties.Resources.FontIcon;
            this._addFontItem.BackColor = System.Drawing.Color.Transparent;
            this._addFontItem.DefaultBackColor = System.Drawing.Color.Transparent;
            this._addFontItem.DefaultLabelColor = System.Drawing.Color.White;
            this._addFontItem.FilePath = null;
            this._addFontItem.HighlightBackColor = System.Drawing.Color.LightGray;
            this._addFontItem.HighlightLabelColor = System.Drawing.SystemColors.ControlText;
            this._addFontItem.LabelFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this._addFontItem.LabelName = "Add Font";
            this._addFontItem.LabelVisible = false;
            this._addFontItem.Location = new System.Drawing.Point( 5, 269 );
            this._addFontItem.Margin = new System.Windows.Forms.Padding( 5 );
            this._addFontItem.MinimumSize = new System.Drawing.Size( 0, 78 );
            this._addFontItem.Name = "_addFontItem";
            this._addFontItem.SelectBackColor = System.Drawing.SystemColors.Control;
            this._addFontItem.SelectLabelColor = System.Drawing.SystemColors.ControlText;
            this._addFontItem.Size = new System.Drawing.Size( 358, 78 );
            this._addFontItem.TabIndex = 4;
            this._addFontItem.AssetClicked += new LunarDevKit.Controls.AssetItemEventHandler( this._addFontItem_AssetClicked );
            // 
            // _spritesTab
            // 
            this._spritesTab.AssetType = LunarDevKit.Classes.AssetType.Actor;
            this._spritesTab.BackColor = System.Drawing.Color.LightGray;
            this._spritesTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._spritesTab.Controls.Add( this._spritesTabPanel );
            this._spritesTab.Location = new System.Drawing.Point( 4, 27 );
            this._spritesTab.Margin = new System.Windows.Forms.Padding( 4 );
            this._spritesTab.Name = "_spritesTab";
            this._spritesTab.Padding = new System.Windows.Forms.Padding( 4 );
            this._spritesTab.Size = new System.Drawing.Size( 388, 606 );
            this._spritesTab.TabIndex = 0;
            this._spritesTab.Text = "Sprites";
            this._spritesTab.UseVisualStyleBackColor = true;
            // 
            // _spritesTabPanel
            // 
            this._spritesTabPanel.AutoScroll = true;
            this._spritesTabPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this._spritesTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._spritesTabPanel.Location = new System.Drawing.Point( 4, 4 );
            this._spritesTabPanel.Margin = new System.Windows.Forms.Padding( 4 );
            this._spritesTabPanel.Name = "_spritesTabPanel";
            this._spritesTabPanel.Size = new System.Drawing.Size( 378, 596 );
            this._spritesTabPanel.TabIndex = 0;
            // 
            // _actorsTab
            // 
            this._actorsTab.AssetType = LunarDevKit.Classes.AssetType.Actor;
            this._actorsTab.BackColor = System.Drawing.Color.LightGray;
            this._actorsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._actorsTab.Controls.Add( this._actorsTabPanel );
            this._actorsTab.Location = new System.Drawing.Point( 4, 27 );
            this._actorsTab.Margin = new System.Windows.Forms.Padding( 4 );
            this._actorsTab.Name = "_actorsTab";
            this._actorsTab.Padding = new System.Windows.Forms.Padding( 4 );
            this._actorsTab.Size = new System.Drawing.Size( 388, 606 );
            this._actorsTab.TabIndex = 1;
            this._actorsTab.Text = "Actors";
            this._actorsTab.UseVisualStyleBackColor = true;
            // 
            // _actorsTabPanel
            // 
            this._actorsTabPanel.AutoScroll = true;
            this._actorsTabPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this._actorsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._actorsTabPanel.Location = new System.Drawing.Point( 4, 4 );
            this._actorsTabPanel.Margin = new System.Windows.Forms.Padding( 4 );
            this._actorsTabPanel.Name = "_actorsTabPanel";
            this._actorsTabPanel.Size = new System.Drawing.Size( 378, 596 );
            this._actorsTabPanel.TabIndex = 1;
            // 
            // _scriptsTab
            // 
            this._scriptsTab.AssetType = LunarDevKit.Classes.AssetType.Actor;
            this._scriptsTab.BackColor = System.Drawing.Color.LightGray;
            this._scriptsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._scriptsTab.Controls.Add( this._scriptsTabPanel );
            this._scriptsTab.Location = new System.Drawing.Point( 4, 27 );
            this._scriptsTab.Margin = new System.Windows.Forms.Padding( 4 );
            this._scriptsTab.Name = "_scriptsTab";
            this._scriptsTab.Padding = new System.Windows.Forms.Padding( 4 );
            this._scriptsTab.Size = new System.Drawing.Size( 388, 606 );
            this._scriptsTab.TabIndex = 2;
            this._scriptsTab.Text = "Scripts";
            this._scriptsTab.UseVisualStyleBackColor = true;
            // 
            // _scriptsTabPanel
            // 
            this._scriptsTabPanel.AutoScroll = true;
            this._scriptsTabPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this._scriptsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scriptsTabPanel.Location = new System.Drawing.Point( 4, 4 );
            this._scriptsTabPanel.Margin = new System.Windows.Forms.Padding( 4 );
            this._scriptsTabPanel.Name = "_scriptsTabPanel";
            this._scriptsTabPanel.Size = new System.Drawing.Size( 378, 596 );
            this._scriptsTabPanel.TabIndex = 1;
            // 
            // _fontsTab
            // 
            this._fontsTab.AssetType = LunarDevKit.Classes.AssetType.None;
            this._fontsTab.BackColor = System.Drawing.Color.LightGray;
            this._fontsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._fontsTab.Controls.Add( this._fontsTabPanel );
            this._fontsTab.Location = new System.Drawing.Point( 4, 27 );
            this._fontsTab.Name = "_fontsTab";
            this._fontsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this._fontsTab.Size = new System.Drawing.Size( 407, 606 );
            this._fontsTab.TabIndex = 4;
            this._fontsTab.Text = "Fonts";
            this._fontsTab.UseVisualStyleBackColor = true;
            // 
            // _fontsTabPanel
            // 
            this._fontsTabPanel.AutoScroll = true;
            this._fontsTabPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this._fontsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fontsTabPanel.Location = new System.Drawing.Point( 3, 3 );
            this._fontsTabPanel.Margin = new System.Windows.Forms.Padding( 4 );
            this._fontsTabPanel.Name = "_fontsTabPanel";
            this._fontsTabPanel.Size = new System.Drawing.Size( 399, 598 );
            this._fontsTabPanel.TabIndex = 2;
            // 
            // _spriteItemContextMenu
            // 
            this._spriteItemContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemCreateActorFromSprite,
            this.toolStripSeparator1,
            this._itemSpriteEdit,
            this._itemSpriteDelete,
            this.toolStripMenuItem2,
            this._itemSpriteProperties} );
            this._spriteItemContextMenu.Name = "contextMenuStrip1";
            this._spriteItemContextMenu.Size = new System.Drawing.Size( 193, 104 );
            // 
            // _itemCreateActorFromSprite
            // 
            this._itemCreateActorFromSprite.Name = "_itemCreateActorFromSprite";
            this._itemCreateActorFromSprite.Size = new System.Drawing.Size( 192, 22 );
            this._itemCreateActorFromSprite.Text = "Create Actor from this";
            this._itemCreateActorFromSprite.Click += new System.EventHandler( this._itemCreateActorFromSprite_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 189, 6 );
            // 
            // _itemSpriteEdit
            // 
            this._itemSpriteEdit.Enabled = false;
            this._itemSpriteEdit.Name = "_itemSpriteEdit";
            this._itemSpriteEdit.Size = new System.Drawing.Size( 192, 22 );
            this._itemSpriteEdit.Text = "Edit";
            // 
            // _itemSpriteDelete
            // 
            this._itemSpriteDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
            this._itemSpriteDelete.Name = "_itemSpriteDelete";
            this._itemSpriteDelete.Size = new System.Drawing.Size( 192, 22 );
            this._itemSpriteDelete.Text = "Delete";
            this._itemSpriteDelete.Click += new System.EventHandler( this._itemSpriteDelete_Click );
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size( 189, 6 );
            // 
            // _itemSpriteProperties
            // 
            this._itemSpriteProperties.Name = "_itemSpriteProperties";
            this._itemSpriteProperties.Size = new System.Drawing.Size( 192, 22 );
            this._itemSpriteProperties.Text = "Properties";
            this._itemSpriteProperties.Click += new System.EventHandler( ShowProperties_Click );
            // 
            // _actorItemContextMenu
            // 
            this._actorItemContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemActorEdit,
            this._itemActorDelete,
            this.toolStripMenuItem1,
            this._itemActorProperties} );
            this._actorItemContextMenu.Name = "contextMenuStrip1";
            this._actorItemContextMenu.Size = new System.Drawing.Size( 135, 76 );
            // 
            // _itemActorEdit
            // 
            this._itemActorEdit.Name = "_itemActorEdit";
            this._itemActorEdit.Size = new System.Drawing.Size( 134, 22 );
            this._itemActorEdit.Text = "Edit";
            // 
            // _itemActorDelete
            // 
            this._itemActorDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
            this._itemActorDelete.Name = "_itemActorDelete";
            this._itemActorDelete.Size = new System.Drawing.Size( 134, 22 );
            this._itemActorDelete.Text = "Delete";
            this._itemActorDelete.Click += new System.EventHandler( this._itemActorDelete_Click );
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size( 131, 6 );
            // 
            // _itemActorProperties
            // 
            this._itemActorProperties.Name = "_itemActorProperties";
            this._itemActorProperties.Size = new System.Drawing.Size( 134, 22 );
            this._itemActorProperties.Text = "Properties";
            this._itemActorProperties.Click += new System.EventHandler( ShowProperties_Click );
            // 
            // _menuScriptItem
            // 
            this._menuScriptItem.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemScriptEdit,
            this._itemScriptDelete,
            this.toolStripMenuItem3,
            this._itemScriptProperties} );
            this._menuScriptItem.Name = "contextMenuStrip1";
            this._menuScriptItem.Size = new System.Drawing.Size( 135, 76 );
            // 
            // _itemScriptEdit
            // 
            this._itemScriptEdit.Name = "_itemScriptEdit";
            this._itemScriptEdit.Size = new System.Drawing.Size( 134, 22 );
            this._itemScriptEdit.Text = "Edit";
            this._itemScriptEdit.Click += new System.EventHandler( this._itemScriptEdit_Click );
            // 
            // _itemScriptDelete
            // 
            this._itemScriptDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
            this._itemScriptDelete.Name = "_itemScriptDelete";
            this._itemScriptDelete.Size = new System.Drawing.Size( 134, 22 );
            this._itemScriptDelete.Text = "Delete";
            this._itemScriptDelete.Click += new System.EventHandler( this._itemScriptDelete_Click );
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size( 131, 6 );
            // 
            // _itemScriptProperties
            // 
            this._itemScriptProperties.Name = "_itemScriptProperties";
            this._itemScriptProperties.Size = new System.Drawing.Size( 134, 22 );
            this._itemScriptProperties.Text = "Properties";
            this._itemScriptProperties.Click += new System.EventHandler( this.ShowProperties_Click );
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point( 40, 9 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 44, 13 );
            this.label1.TabIndex = 21;
            this.label1.Text = "Search:";
            // 
            // _txtSearch
            // 
            this._txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._txtSearch.Location = new System.Drawing.Point( 103, 8 );
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size( 272, 19 );
            this._txtSearch.TabIndex = 22;
            this._txtSearch.TextChanged += new System.EventHandler( this._txtSearch_TextChanged );
            // 
            // _menuFontItem
            // 
            this._menuFontItem.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemFontEdit,
            this._itemFontDelete,
            this.toolStripMenuItem4,
            this._itemFontProperties} );
            this._menuFontItem.Name = "contextMenuStrip1";
            this._menuFontItem.Size = new System.Drawing.Size( 135, 76 );
            // 
            // _itemFontEdit
            // 
            this._itemFontEdit.Name = "_itemFontEdit";
            this._itemFontEdit.Size = new System.Drawing.Size( 134, 22 );
            this._itemFontEdit.Text = "Edit";
            this._itemFontEdit.Click += new System.EventHandler( this._itemFontEdit_Click );
            // 
            // _itemFontDelete
            // 
            this._itemFontDelete.Name = "_itemFontDelete";
            this._itemFontDelete.Size = new System.Drawing.Size( 134, 22 );
            this._itemFontDelete.Text = "Delete";
            this._itemFontDelete.Click += new System.EventHandler( this._itemFontDelete_Click );
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size( 131, 6 );
            // 
            // _itemFontProperties
            // 
            this._itemFontProperties.Name = "_itemFontProperties";
            this._itemFontProperties.Size = new System.Drawing.Size( 134, 22 );
            this._itemFontProperties.Text = "Properties";
            this._itemFontProperties.Click += new System.EventHandler( this.ShowProperties_Click );
            // 
            // AssetsBrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 416, 697 );
            this.Controls.Add( this._tabControl );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this._txtSearch );
            this.DockAreas = ( (WeifenLuo.WinFormsUI.Docking.DockAreas)( ( ( ( ( WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom ) ) );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.Margin = new System.Windows.Forms.Padding( 5 );
            this.MinimumSize = new System.Drawing.Size( 177, 45 );
            this.Name = "AssetsBrowserWindow";
            this.ShowInTaskbar = false;
            this.Text = "Assets Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.AssetsBrowserWindow_FormClosing );
            this._tabControl.ResumeLayout( false );
            this._addAssetTab.ResumeLayout( false );
            this.flowLayoutPanel4.ResumeLayout( false );
            this._spritesTab.ResumeLayout( false );
            this._actorsTab.ResumeLayout( false );
            this._scriptsTab.ResumeLayout( false );
            this._fontsTab.ResumeLayout( false );
            this._spriteItemContextMenu.ResumeLayout( false );
            this._actorItemContextMenu.ResumeLayout( false );
            this._menuScriptItem.ResumeLayout( false );
            this._menuFontItem.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.CustomTabControl _tabControl;
        private LunarDevKit.Controls.AssetsTabPage _spritesTab;
        private LunarDevKit.Controls.AssetsTabPage _actorsTab;
        private LunarDevKit.Controls.AssetsTabPage _scriptsTab;
        private System.Windows.Forms.FlowLayoutPanel _spritesTabPanel;
        private System.Windows.Forms.FlowLayoutPanel _actorsTabPanel;
        private System.Windows.Forms.FlowLayoutPanel _scriptsTabPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private LunarDevKit.Controls.AssetItem _addSpriteItem;
        private LunarDevKit.Controls.AssetItem _addActorItem;
        private LunarDevKit.Controls.AssetItem _addScriptItem;
        private System.Windows.Forms.ContextMenuStrip _spriteItemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _itemCreateActorFromSprite;
        private System.Windows.Forms.ToolStripMenuItem _itemSpriteDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _itemSpriteEdit;
        private System.Windows.Forms.ContextMenuStrip _actorItemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _itemActorEdit;
        private System.Windows.Forms.ToolStripMenuItem _itemActorDelete;
        private System.Windows.Forms.ContextMenuStrip _menuScriptItem;
        private System.Windows.Forms.ToolStripMenuItem _itemScriptEdit;
        private System.Windows.Forms.ToolStripMenuItem _itemScriptDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.FlowLayoutPanel _fontsTabPanel;
        private LunarDevKit.Controls.AssetItem _addFontItem;
        private LunarDevKit.Controls.AssetsTabPage _addAssetTab;
        private LunarDevKit.Controls.AssetsTabPage _fontsTab;
        private System.Windows.Forms.ContextMenuStrip _menuFontItem;
        private System.Windows.Forms.ToolStripMenuItem _itemFontEdit;
        private System.Windows.Forms.ToolStripMenuItem _itemFontDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem _itemSpriteProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _itemActorProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem _itemScriptProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem _itemFontProperties;
    }
}