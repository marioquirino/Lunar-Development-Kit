namespace LunarDevKit.Forms.Script_Editor
{
    partial class ScriptDocument
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
            this._txtScript = new ICSharpCode.TextEditor.TextEditorControl( );
            this.SuspendLayout( );
            // 
            // _txtScript
            // 
            this._txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtScript.IsReadOnly = false;
            this._txtScript.Location = new System.Drawing.Point( 0, 0 );
            this._txtScript.Name = "_txtScript";
            this._txtScript.Size = new System.Drawing.Size( 590, 365 );
            this._txtScript.TabIndex = 1;
            // 
            // ScriptDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 590, 365 );
            this.Controls.Add( this._txtScript );
            this.DockAreas = ( (WeifenLuo.WinFormsUI.Docking.DockAreas)( ( WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document ) ) );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.Name = "ScriptDocument";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.Text = "ScriptDocument";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.ScriptDocument_FormClosed );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ScriptDocument_FormClosing );
            this.ResumeLayout( false );

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl _txtScript;


    }
}