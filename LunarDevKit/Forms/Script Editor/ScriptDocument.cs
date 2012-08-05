using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using LunarDevKit.Classes;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms.Script_Editor
{
    public partial class ScriptDocument : DockContent
    {
        #region Fields

        private ScriptAssetItem _scriptItem;
        public ScriptAssetItem Script
        {
            get { return _scriptItem; }
        }

        private bool _saved = true;
        public bool Saved
        {
            get { return _saved; }
        }

        public string ScriptName
        {
            get { return _scriptItem.Script.Name; }
        }

        private bool _scriptLoaded = false;

        #endregion



        public ScriptDocument( ScriptAssetItem scriptItem )
        {
            InitializeComponent( );
            _txtScript.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);

            this._scriptItem = scriptItem;
            this.Text = _scriptItem.Script.Name;
            this._txtScript.Text = _scriptItem.Script.ScriptText;
            _scriptLoaded = true;
        }

        #region Event Methods

        private void ScriptDocument_FormClosing( object sender, FormClosingEventArgs e )
        {
            if( !_saved )
            {
                switch( MessageBox.Show( Global.EditorTxt.ScriptSavePrompt, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question ) )
                {
                    case DialogResult.Yes:
                        Save( );
                        break;
                        
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void ScriptDocument_FormClosed( object sender, FormClosedEventArgs e )
        {
            this.Dispose( );
        }

        private void _txtScript_TextChanged( object sender, EventArgs e )
        {
            if( _scriptLoaded && !_saved )
            {
                _saved = false;
                this.Text = _scriptItem.Script.Name + "*";
            }
        }

        private void Document_DocumentChanged( object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e )
        {
            if( _scriptLoaded && _saved )
            {
                _saved = false;
                this.Text = _scriptItem.Script.Name + "*";
            }
        }

        #endregion

        #region Methods

        public void Save( )
        {
            if( !_saved )
            {
                _scriptItem.Script.ScriptText = _txtScript.Text;
                _scriptItem.Script.Save( );
                _saved = true;
                this.Text = _scriptItem.Script.Name;
                Global.MainWindow.OnScriptChanged( );
            }
        }

        public void Changed( )
        {
            _txtScript_TextChanged( null, null );
        }

        #endregion
    }
}
