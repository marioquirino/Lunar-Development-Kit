namespace LunarDevKit.Forms.Main_Window
{
    partial class AssetsBrowserDock
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this._btnImportSprite = new System.Windows.Forms.ToolStripButton( );
            this._btnNewActor = new System.Windows.Forms.ToolStripButton( );
            this._btnNewScript = new System.Windows.Forms.ToolStripButton( );
            this._btnNewFont = new System.Windows.Forms.ToolStripButton( );
            this._listAssets = new System.Windows.Forms.ListView( );
            this._txtSearch = new System.Windows.Forms.TextBox( );
            this._btnClear = new System.Windows.Forms.Button( );
            this._groupTags = new System.Windows.Forms.GroupBox( );
            this._spritesImageList = new System.Windows.Forms.ImageList( this.components );
            this.toolStrip1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size( 20, 20 );
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnImportSprite,
            this._btnNewActor,
            this._btnNewScript,
            this._btnNewFont} );
            this.toolStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 290, 25 );
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btnImportSprite
            // 
            this._btnImportSprite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnImportSprite.Image = global::LunarDevKit.Properties.Resources.SpriteIcon;
            this._btnImportSprite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnImportSprite.Name = "_btnImportSprite";
            this._btnImportSprite.Size = new System.Drawing.Size( 23, 22 );
            this._btnImportSprite.Text = "Import Sprites";
            // 
            // _btnNewActor
            // 
            this._btnNewActor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewActor.Image = global::LunarDevKit.Properties.Resources.ArchetypeIcon;
            this._btnNewActor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewActor.Name = "_btnNewActor";
            this._btnNewActor.Size = new System.Drawing.Size( 23, 22 );
            this._btnNewActor.Text = "New Actor";
            // 
            // _btnNewScript
            // 
            this._btnNewScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewScript.Image = global::LunarDevKit.Properties.Resources.NewScriptIcon;
            this._btnNewScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewScript.Name = "_btnNewScript";
            this._btnNewScript.Size = new System.Drawing.Size( 23, 22 );
            this._btnNewScript.Text = "New Script";
            // 
            // _btnNewFont
            // 
            this._btnNewFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewFont.Image = global::LunarDevKit.Properties.Resources.FontIcon;
            this._btnNewFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewFont.Name = "_btnNewFont";
            this._btnNewFont.Size = new System.Drawing.Size( 23, 22 );
            this._btnNewFont.Text = "New Font";
            // 
            // _listAssets
            // 
            this._listAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listAssets.Location = new System.Drawing.Point( 12, 116 );
            this._listAssets.Name = "_listAssets";
            this._listAssets.Size = new System.Drawing.Size( 266, 427 );
            this._listAssets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._listAssets.TabIndex = 1;
            this._listAssets.UseCompatibleStateImageBehavior = false;
            // 
            // _txtSearch
            // 
            this._txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtSearch.Location = new System.Drawing.Point( 12, 28 );
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size( 219, 22 );
            this._txtSearch.TabIndex = 2;
            // 
            // _btnClear
            // 
            this._btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClear.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this._btnClear.Location = new System.Drawing.Point( 237, 27 );
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size( 53, 23 );
            this._btnClear.TabIndex = 3;
            this._btnClear.Text = "Clear";
            this._btnClear.UseVisualStyleBackColor = true;
            // 
            // _groupTags
            // 
            this._groupTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupTags.Location = new System.Drawing.Point( 12, 56 );
            this._groupTags.Name = "_groupTags";
            this._groupTags.Size = new System.Drawing.Size( 266, 54 );
            this._groupTags.TabIndex = 4;
            this._groupTags.TabStop = false;
            this._groupTags.Text = "Tags";
            // 
            // _spritesImageList
            // 
            this._spritesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this._spritesImageList.ImageSize = new System.Drawing.Size( 32, 32 );
            this._spritesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AssetsBrowserDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 290, 555 );
            this.Controls.Add( this._groupTags );
            this.Controls.Add( this._btnClear );
            this.Controls.Add( this._txtSearch );
            this.Controls.Add( this._listAssets );
            this.Controls.Add( this.toolStrip1 );
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.HideOnClose = true;
            this.Name = "AssetsBrowserDock";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRightAutoHide;
            this.Text = "Assets";
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _btnImportSprite;
        private System.Windows.Forms.ToolStripButton _btnNewActor;
        private System.Windows.Forms.ToolStripButton _btnNewScript;
        private System.Windows.Forms.ToolStripButton _btnNewFont;
        private System.Windows.Forms.ListView _listAssets;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.GroupBox _groupTags;
        private System.Windows.Forms.ImageList _spritesImageList;
    }
}