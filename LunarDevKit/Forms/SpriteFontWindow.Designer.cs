namespace LunarDevKit.Forms
{
    partial class SpriteFontWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( SpriteFontWindow ) );
            this._mainTools = new System.Windows.Forms.ToolStrip( );
            this._btnSave = new System.Windows.Forms.ToolStripButton( );
            this._txtScript = new System.Windows.Forms.RichTextBox( );
            this._mainTools.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _mainTools
            // 
            this._mainTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._mainTools.ImageScalingSize = new System.Drawing.Size( 24, 24 );
            this._mainTools.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnSave} );
            this._mainTools.Location = new System.Drawing.Point( 0, 0 );
            this._mainTools.Name = "_mainTools";
            this._mainTools.Size = new System.Drawing.Size( 417, 31 );
            this._mainTools.TabIndex = 2;
            this._mainTools.Text = "toolStrip1";
            // 
            // _btnSave
            // 
            this._btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSave.Image = ((System.Drawing.Image)(resources.GetObject( "_btnSave.Image" )));
            this._btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size( 28, 28 );
            this._btnSave.Text = "Save this script";
            this._btnSave.Click += new System.EventHandler( this._btnSave_Click );
            // 
            // _txtScript
            // 
            this._txtScript.AcceptsTab = true;
            this._txtScript.AutoWordSelection = true;
            this._txtScript.DetectUrls = false;
            this._txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtScript.Location = new System.Drawing.Point( 0, 31 );
            this._txtScript.Name = "_txtScript";
            this._txtScript.Size = new System.Drawing.Size( 417, 437 );
            this._txtScript.TabIndex = 3;
            this._txtScript.Text = "";
            this._txtScript.WordWrap = false;
            this._txtScript.TextChanged += new System.EventHandler( this._txtScript_TextChanged );
            // 
            // SpriteFontWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 417, 468 );
            this.Controls.Add( this._txtScript );
            this.Controls.Add( this._mainTools );
            this.Name = "SpriteFontWindow";
            this.ShowInTaskbar = false;
            this.Text = "SpriteFontWindow";
            this._mainTools.ResumeLayout( false );
            this._mainTools.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ToolStrip _mainTools;
        private System.Windows.Forms.ToolStripButton _btnSave;
        private System.Windows.Forms.RichTextBox _txtScript;

    }
}