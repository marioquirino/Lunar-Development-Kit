namespace LunarDevKit.Forms.Main_Window
{
    partial class LevelDocument
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
            this._actorContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemActorBringFront = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemActorSendBack = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemActorSwap = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemActorCut = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemActorCopy = new System.Windows.Forms.ToolStripMenuItem( );
            this._itemActorDelete = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator( );
            this._itemActorProperties = new System.Windows.Forms.ToolStripMenuItem( );
            this._actorContextMenu.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _actorContextMenu
            // 
            this._actorContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemActorBringFront,
            this._itemActorSendBack,
            this._itemActorSwap,
            this.toolStripSeparator8,
            this._itemActorCut,
            this._itemActorCopy,
            this._itemActorDelete,
            this.toolStripSeparator9,
            this._itemActorProperties} );
            this._actorContextMenu.Name = "ActorContextMenu";
            this._actorContextMenu.Size = new System.Drawing.Size( 196, 192 );
            // 
            // _itemActorBringFront
            // 
            this._itemActorBringFront.Name = "_itemActorBringFront";
            this._itemActorBringFront.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorBringFront.Text = "Bring To Front";
            this._itemActorBringFront.Click += new System.EventHandler( this.ActorBringToFront );
            // 
            // _itemActorSendBack
            // 
            this._itemActorSendBack.Name = "_itemActorSendBack";
            this._itemActorSendBack.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorSendBack.Text = "Send To Back";
            this._itemActorSendBack.Click += new System.EventHandler( this.ActorSendToBack );
            // 
            // _itemActorSwap
            // 
            this._itemActorSwap.Name = "_itemActorSwap";
            this._itemActorSwap.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorSwap.Text = "Swap With Other Actor";
            this._itemActorSwap.Click += new System.EventHandler( this.ActorSwap );
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size( 192, 6 );
            // 
            // _itemActorCut
            // 
            this._itemActorCut.Image = global::LunarDevKit.Properties.Resources.Cut32;
            this._itemActorCut.Name = "_itemActorCut";
            this._itemActorCut.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorCut.Text = "Cut";
            this._itemActorCut.Click += new System.EventHandler( this._itemActorCut_Click );
            // 
            // _itemActorCopy
            // 
            this._itemActorCopy.Image = global::LunarDevKit.Properties.Resources.Copy32;
            this._itemActorCopy.Name = "_itemActorCopy";
            this._itemActorCopy.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorCopy.Text = "Copy";
            this._itemActorCopy.Click += new System.EventHandler( this._itemActorCopy_Click );
            // 
            // _itemActorDelete
            // 
            this._itemActorDelete.Image = global::LunarDevKit.Properties.Resources.Delete32;
            this._itemActorDelete.Name = "_itemActorDelete";
            this._itemActorDelete.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorDelete.Text = "Delete";
            this._itemActorDelete.Click += new System.EventHandler( this._itemActorDelete_Click );
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size( 192, 6 );
            // 
            // _itemActorProperties
            // 
            this._itemActorProperties.Name = "_itemActorProperties";
            this._itemActorProperties.Size = new System.Drawing.Size( 195, 22 );
            this._itemActorProperties.Text = "Properties";
            this._itemActorProperties.Click += new System.EventHandler( this._itemActorProperties_Click );
            // 
            // LevelDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 282, 255 );
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.Name = "LevelDocument";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.ShowIcon = false;
            this.Text = "LevelDocument";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.LevelDoc_KeyPress );
            this._actorContextMenu.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip _actorContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem _itemActorCut;
        private System.Windows.Forms.ToolStripMenuItem _itemActorCopy;
        private System.Windows.Forms.ToolStripMenuItem _itemActorDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem _itemActorProperties;
        private System.Windows.Forms.ToolStripMenuItem _itemActorBringFront;
        private System.Windows.Forms.ToolStripMenuItem _itemActorSendBack;
        private System.Windows.Forms.ToolStripMenuItem _itemActorSwap;
    }
}