namespace LunarDevKit.Forms.Script_Editor
{
    partial class ScriptEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ScriptEditor ) );
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this._btnNewScript = new System.Windows.Forms.ToolStripButton( );
            this._btnSaveScript = new System.Windows.Forms.ToolStripButton( );
            this._btnSaveAllScripts = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this._btnCompile = new System.Windows.Forms.ToolStripButton( );
            this.toolStrip1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size( 20, 20 );
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._btnNewScript,
            this._btnSaveScript,
            this._btnSaveAllScripts,
            this.toolStripSeparator1,
            this._btnCompile} );
            this.toolStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 826, 27 );
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btnNewScript
            // 
            this._btnNewScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNewScript.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnNewScript.Image" ) ) );
            this._btnNewScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNewScript.Name = "_btnNewScript";
            this._btnNewScript.Size = new System.Drawing.Size( 24, 24 );
            this._btnNewScript.Text = "Create a new C# script.";
            this._btnNewScript.Click += new System.EventHandler( this._btnNewScript_Click );
            // 
            // _btnSaveScript
            // 
            this._btnSaveScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSaveScript.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSaveScript.Image" ) ) );
            this._btnSaveScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSaveScript.Name = "_btnSaveScript";
            this._btnSaveScript.Size = new System.Drawing.Size( 24, 24 );
            this._btnSaveScript.Text = "Save the active script.";
            this._btnSaveScript.Click += new System.EventHandler( this._btnSaveScript_Click );
            // 
            // _btnSaveAllScripts
            // 
            this._btnSaveAllScripts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSaveAllScripts.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnSaveAllScripts.Image" ) ) );
            this._btnSaveAllScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSaveAllScripts.Name = "_btnSaveAllScripts";
            this._btnSaveAllScripts.Size = new System.Drawing.Size( 24, 24 );
            this._btnSaveAllScripts.Text = "Save all scripts.";
            this._btnSaveAllScripts.Click += new System.EventHandler( this._btnSaveAllScripts_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 27 );
            // 
            // _btnCompile
            // 
            this._btnCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnCompile.Image = ( (System.Drawing.Image)( resources.GetObject( "_btnCompile.Image" ) ) );
            this._btnCompile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnCompile.Name = "_btnCompile";
            this._btnCompile.Size = new System.Drawing.Size( 24, 24 );
            this._btnCompile.Text = "Compile all scripts.";
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 826, 397 );
            this.Controls.Add( this.toolStrip1 );
            this.DockAreas = ( (WeifenLuo.WinFormsUI.Docking.DockAreas)( ( ( ( ( WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom ) ) );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.HideOnClose = true;
            this.Name = "ScriptEditor";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Float;
            this.Text = "Script Editor";
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _btnNewScript;
        private System.Windows.Forms.ToolStripButton _btnSaveScript;
        private System.Windows.Forms.ToolStripButton _btnSaveAllScripts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _btnCompile;
    }
}