namespace LunarDevKit.Forms
{
    partial class LayersDock
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
            if ( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( LayersDock ) );
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this._btnLayerNew = new System.Windows.Forms.ToolStripButton( );
            this._btnLayerDelete = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnLayerUp = new System.Windows.Forms.ToolStripButton( );
            this._btnLayerDown = new System.Windows.Forms.ToolStripButton( );
            this._listLayers = new LunarDevKit.Controls.ListBox2( );
            this.toolStrip1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size( 20, 20 );
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnLayerNew,
            this._btnLayerDelete,
            this.toolStripSeparator1,
            this._btnLayerUp,
            this._btnLayerDown} );
            this.toolStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 304, 27 );
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btnLayerNew
            // 
            this._btnLayerNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnLayerNew.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnLayerNew.Image" ) ) );
            this._btnLayerNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnLayerNew.Name = "_btnLayerNew";
            this._btnLayerNew.Size = new System.Drawing.Size( 24, 24 );
            this._btnLayerNew.Text = "toolStripButton1";
            this._btnLayerNew.ToolTipText = "Creates a new layer";
            this._btnLayerNew.Click += new System.EventHandler( this.newLayerButton_Click );
            // 
            // _btnLayerDelete
            // 
            this._btnLayerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnLayerDelete.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnLayerDelete.Image" ) ) );
            this._btnLayerDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnLayerDelete.Name = "_btnLayerDelete";
            this._btnLayerDelete.Size = new System.Drawing.Size( 24, 24 );
            this._btnLayerDelete.Text = "toolStripButton1";
            this._btnLayerDelete.ToolTipText = "Deletes the selected layer";
            this._btnLayerDelete.Click += new System.EventHandler( this.deleteLayerButton_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 27 );
            // 
            // _btnLayerUp
            // 
            this._btnLayerUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnLayerUp.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnLayerUp.Image" ) ) );
            this._btnLayerUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnLayerUp.Name = "_btnLayerUp";
            this._btnLayerUp.Size = new System.Drawing.Size( 24, 24 );
            this._btnLayerUp.Text = "toolStripButton1";
            this._btnLayerUp.ToolTipText = "Moves the layer one position up on the list";
            this._btnLayerUp.Click += new System.EventHandler( this.layerGoUpButton_Click );
            // 
            // _btnLayerDown
            // 
            this._btnLayerDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnLayerDown.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnLayerDown.Image" ) ) );
            this._btnLayerDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnLayerDown.Name = "_btnLayerDown";
            this._btnLayerDown.Size = new System.Drawing.Size( 24, 24 );
            this._btnLayerDown.Text = "toolStripButton1";
            this._btnLayerDown.ToolTipText = "Moves the layer one position down on the list";
            this._btnLayerDown.Click += new System.EventHandler( this.layerGoDownButton_Click );
            // 
            // _listLayers
            // 
            this._listLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listLayers.FormattingEnabled = true;
            this._listLayers.Location = new System.Drawing.Point( 0, 27 );
            this._listLayers.Name = "_listLayers";
            this._listLayers.Size = new System.Drawing.Size( 304, 303 );
            this._listLayers.TabIndex = 2;
            this._listLayers.MouseClick += new System.Windows.Forms.MouseEventHandler( this.ListLayers_MouseClick );
            this._listLayers.SelectedIndexChanged += new System.EventHandler( this.ListLayers_SelectedIndexChanged );
            // 
            // LayersDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 304, 333 );
            this.Controls.Add( this._listLayers );
            this.Controls.Add( this.toolStrip1 );
            this.DockAreas = ( (WeifenLuo.WinFormsUI.Docking.DockAreas)( ( ( ( ( WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom ) ) );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HideOnClose = true;
            this.Margin = new System.Windows.Forms.Padding( 4 );
            this.MinimumSize = new System.Drawing.Size( 186, 217 );
            this.Name = "LayersDock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Layers";
            this.VisibleChanged += new System.EventHandler( this.LayersWindow_VisibleChanged );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.LayersWindow_FormClosing );
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _btnLayerNew;
        private System.Windows.Forms.ToolStripButton _btnLayerDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _btnLayerUp;
        private System.Windows.Forms.ToolStripButton _btnLayerDown;
        private LunarDevKit.Controls.ListBox2 _listLayers;
    }
}