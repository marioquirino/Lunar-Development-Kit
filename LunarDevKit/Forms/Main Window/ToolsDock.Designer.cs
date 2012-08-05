namespace LunarDevKit.Forms.Main_Window
{
    partial class ToolsDock
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
            if( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ToolsDock ) );
            this._viewportTools = new System.Windows.Forms.ToolStrip( );
            this._btnSelectionTool = new System.Windows.Forms.ToolStripButton( );
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnToggleGrid = new System.Windows.Forms.ToolStripSplitButton( );
            this._itemDragSnap = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnapEnable = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemDragSnap1Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap2Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap4Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap8Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap16Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap32Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap64Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemDragSnap128Pixels = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemRotateSnap = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemScaleSnap = new System.Windows.Forms.ToolStripMenuItem( );
            this._btnToggleZones = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnToggleLight = new System.Windows.Forms.ToolStripButton( );
            this._btnToggleEffects = new System.Windows.Forms.ToolStripButton( );
            this._viewportTools.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _viewportTools
            // 
            this._viewportTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._viewportTools.Dock = System.Windows.Forms.DockStyle.None;
            this._viewportTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._viewportTools.ImageScalingSize = new System.Drawing.Size( 24, 24 );
            this._viewportTools.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnSelectionTool,
            this.toolStripDropDownButton1,
            this._btnToggleGrid,
            this._btnToggleZones,
            this.toolStripSeparator11,
            this._btnToggleLight,
            this._btnToggleEffects} );
            this._viewportTools.Location = new System.Drawing.Point( 45, 0 );
            this._viewportTools.Name = "_viewportTools";
            this._viewportTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._viewportTools.Size = new System.Drawing.Size( 167, 31 );
            this._viewportTools.TabIndex = 6;
            this._viewportTools.Text = "toolStrip2";
            // 
            // _btnSelectionTool
            // 
            this._btnSelectionTool.Checked = true;
            this._btnSelectionTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this._btnSelectionTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSelectionTool.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSelectionTool.Image" ) ) );
            this._btnSelectionTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSelectionTool.Name = "_btnSelectionTool";
            this._btnSelectionTool.Size = new System.Drawing.Size( 28, 28 );
            this._btnSelectionTool.Text = "Selection Tool";
            this._btnSelectionTool.Click += new System.EventHandler( this.SelectionTool_Click );
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnToggleGrid
            // 
            this._btnToggleGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnToggleGrid.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemDragSnap,
            this._itemRotateSnap,
            this._itemScaleSnap} );
            this._btnToggleGrid.Image = global::LunarDevKit.Properties.Resources.Render_Grid32;
            this._btnToggleGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnToggleGrid.Name = "_btnToggleGrid";
            this._btnToggleGrid.Size = new System.Drawing.Size( 40, 28 );
            this._btnToggleGrid.Text = "Toggles the displaying of the grid.";
            this._btnToggleGrid.ButtonClick += new System.EventHandler( this.ToggleGrid_Click );
            // 
            // _itemDragSnap
            // 
            this._itemDragSnap.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemDragSnapEnable,
            this.toolStripSeparator1,
            this._itemDragSnap1Pixels,
            this._itemDragSnap2Pixels,
            this._itemDragSnap4Pixels,
            this._itemDragSnap8Pixels,
            this._itemDragSnap16Pixels,
            this._itemDragSnap32Pixels,
            this._itemDragSnap64Pixels,
            this._itemDragSnap128Pixels} );
            this._itemDragSnap.Name = "_itemDragSnap";
            this._itemDragSnap.Size = new System.Drawing.Size( 137, 22 );
            this._itemDragSnap.Text = "Drag Snap";
            // 
            // _itemDragSnapEnable
            // 
            this._itemDragSnapEnable.CheckOnClick = true;
            this._itemDragSnapEnable.Name = "_itemDragSnapEnable";
            this._itemDragSnapEnable.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnapEnable.Text = "Enabled Drag Snap";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 170, 6 );
            // 
            // _itemDragSnap1Pixels
            // 
            this._itemDragSnap1Pixels.Name = "_itemDragSnap1Pixels";
            this._itemDragSnap1Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap1Pixels.Text = "1 pixel";
            this._itemDragSnap1Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap2Pixels
            // 
            this._itemDragSnap2Pixels.Name = "_itemDragSnap2Pixels";
            this._itemDragSnap2Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap2Pixels.Text = "2 pixels";
            this._itemDragSnap2Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap4Pixels
            // 
            this._itemDragSnap4Pixels.Name = "_itemDragSnap4Pixels";
            this._itemDragSnap4Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap4Pixels.Text = "4 pixels";
            this._itemDragSnap4Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap8Pixels
            // 
            this._itemDragSnap8Pixels.Name = "_itemDragSnap8Pixels";
            this._itemDragSnap8Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap8Pixels.Text = "8 pixels";
            this._itemDragSnap8Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap16Pixels
            // 
            this._itemDragSnap16Pixels.Name = "_itemDragSnap16Pixels";
            this._itemDragSnap16Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap16Pixels.Text = "16 pixels";
            this._itemDragSnap16Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap32Pixels
            // 
            this._itemDragSnap32Pixels.Name = "_itemDragSnap32Pixels";
            this._itemDragSnap32Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap32Pixels.Text = "32 pixels";
            this._itemDragSnap32Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap64Pixels
            // 
            this._itemDragSnap64Pixels.Name = "_itemDragSnap64Pixels";
            this._itemDragSnap64Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap64Pixels.Text = "64 pixels";
            this._itemDragSnap64Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemDragSnap128Pixels
            // 
            this._itemDragSnap128Pixels.Name = "_itemDragSnap128Pixels";
            this._itemDragSnap128Pixels.Size = new System.Drawing.Size( 173, 22 );
            this._itemDragSnap128Pixels.Text = "128 pixels";
            this._itemDragSnap128Pixels.Click += new System.EventHandler( this.pixelsDragButton_Click );
            // 
            // _itemRotateSnap
            // 
            this._itemRotateSnap.Enabled = false;
            this._itemRotateSnap.Name = "_itemRotateSnap";
            this._itemRotateSnap.Size = new System.Drawing.Size( 137, 22 );
            this._itemRotateSnap.Text = "Rotate Snap";
            // 
            // _itemScaleSnap
            // 
            this._itemScaleSnap.Enabled = false;
            this._itemScaleSnap.Name = "_itemScaleSnap";
            this._itemScaleSnap.Size = new System.Drawing.Size( 137, 22 );
            this._itemScaleSnap.Text = "Scale Snap";
            // 
            // _btnToggleZones
            // 
            this._btnToggleZones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnToggleZones.Enabled = false;
            this._btnToggleZones.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleZones.Image" ) ) );
            this._btnToggleZones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnToggleZones.Name = "_btnToggleZones";
            this._btnToggleZones.Size = new System.Drawing.Size( 28, 28 );
            this._btnToggleZones.Text = "Toggle the display of Zones";
            this._btnToggleZones.Click += new System.EventHandler( this.ToggleZones_Click );
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size( 6, 31 );
            // 
            // _btnToggleLight
            // 
            this._btnToggleLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnToggleLight.Enabled = false;
            this._btnToggleLight.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleLight.Image" ) ) );
            this._btnToggleLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnToggleLight.Name = "_btnToggleLight";
            this._btnToggleLight.Size = new System.Drawing.Size( 28, 28 );
            this._btnToggleLight.Text = "Toggles the rendering of the lighting.";
            this._btnToggleLight.Click += new System.EventHandler( this.ToggleLight_Click );
            // 
            // _btnToggleEffects
            // 
            this._btnToggleEffects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnToggleEffects.Enabled = false;
            this._btnToggleEffects.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnToggleEffects.Image" ) ) );
            this._btnToggleEffects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnToggleEffects.Name = "_btnToggleEffects";
            this._btnToggleEffects.Size = new System.Drawing.Size( 28, 28 );
            this._btnToggleEffects.Text = "Toggle the rendering of the effects.";
            this._btnToggleEffects.Click += new System.EventHandler( this.ToggleEffects_Click );
            // 
            // ToolsDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 255, 32 );
            this.ControlBox = false;
            this.Controls.Add( this._viewportTools );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ToolsDock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tools";
            this._viewportTools.ResumeLayout( false );
            this._viewportTools.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        public System.Windows.Forms.ToolStrip _viewportTools;
        public System.Windows.Forms.ToolStripButton _btnSelectionTool;
        private System.Windows.Forms.ToolStripSeparator toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSplitButton _btnToggleGrid;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap1Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap2Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap4Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap8Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap16Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap32Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap64Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnap128Pixels;
        private System.Windows.Forms.ToolStripMenuItem _itemRotateSnap;
        private System.Windows.Forms.ToolStripMenuItem _itemScaleSnap;
        public System.Windows.Forms.ToolStripButton _btnToggleZones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        public System.Windows.Forms.ToolStripButton _btnToggleLight;
        public System.Windows.Forms.ToolStripButton _btnToggleEffects;
        private System.Windows.Forms.ToolStripMenuItem _itemDragSnapEnable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}