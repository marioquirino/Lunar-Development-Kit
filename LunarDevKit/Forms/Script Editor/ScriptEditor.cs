using System;
using System.Windows.Forms;
using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms.Script_Editor
{
    public partial class ScriptEditor : DockContent
    {
        #region Fields

        private DockPanel _dockPanel;
        private Dictionary<string, ScriptDocument> _scripts;
        private ScriptErrorsDock _errors;

        #endregion

        #region Properties

        public ScriptDocument ActiveScript
        {
            get { return _dockPanel.ActiveDocument as ScriptDocument; }
        }

        #endregion

        #region Init

        public ScriptEditor( )
        {
            InitializeComponent( );

            _dockPanel = new DockPanel( );
            _dockPanel.Dock = DockStyle.Fill;
            _dockPanel.BackColor = System.Drawing.Color.DarkGray;
            _dockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            Controls.Add( _dockPanel );
            _dockPanel.BringToFront( );

            _scripts = new Dictionary<string,ScriptDocument>( );
            _errors = new ScriptErrorsDock( );
            _errors.Show( _dockPanel );

            _btnCompile.Click += new EventHandler( Global.MainWindow.CompileScripts_Click );
        }

        #endregion

        #region Event Methods

        private void ScriptDoc_FormClosed( object sender, FormClosedEventArgs e )
        {
            ScriptDocument scriptDoc = sender as ScriptDocument;
            if( _scripts.ContainsValue( scriptDoc ) )
                _scripts.Remove( scriptDoc.ScriptName );
        }

        private void _btnNewScript_Click( object sender, EventArgs e )
        {
            NewScript( );
        }

        private void _btnSaveScript_Click( object sender, EventArgs e )
        {
            SaveActiveScript( );
        }

        private void _btnSaveAllScripts_Click( object sender, EventArgs e )
        {
            SaveAllScripts( );
        }

        #endregion

        #region Methods

        public void NewScript( )
        {
            Global.AssetsBrowser.AddNewScript( "Script", Classes.ScriptFormat.Blank );
            ScriptDocument scriptDoc = new ScriptDocument( Global.AssetsBrowser.LastCreatedScript );
        }

        public void OpenScript( ScriptAssetItem scriptItem )
        {
            if( _scripts.ContainsKey( scriptItem.Script.Name ) )
                return;

            ScriptDocument scriptDoc = new ScriptDocument( scriptItem );
            Global.MainWindow.ShowScriptEditor( );
            scriptDoc.Show( _dockPanel );
            scriptDoc.FormClosed += new FormClosedEventHandler( ScriptDoc_FormClosed );
            _scripts.Add( scriptDoc.ScriptName, scriptDoc );
        }

        public void SaveActiveScript( )
        {
            ActiveScript.Save( );
        }

        public void SaveAllScripts( )
        {
            foreach( ScriptDocument scriptDoc in _scripts.Values )
            {
                scriptDoc.Save( );
            }
        }

        public void CloseScript( ScriptAssetItem scriptItem, bool forceClose )
        {
            ScriptDocument scriptDoc = GetScriptDocument( scriptItem );
            if( scriptDoc != null )
            {
                if( forceClose )
                    scriptDoc.Dispose( );
                else
                    scriptDoc.Close( );
            }
        }

        public void CloseAllScripts( )
        {
            int i = 0;
            do
            {
                foreach( ScriptDocument scriptDoc in _scripts.Values )
                {
                    scriptDoc.Close( );
                    break;
                }
                i++;
            } while( i < _scripts.Count );
        }

        public void DisplayErrors( System.CodeDom.Compiler.CompilerErrorCollection errors )
        {
            _errors.FillErrorList( errors );
        }

        public void FocusErrorsDock( )
        {
            _errors.Show( _dockPanel );
            _errors.Focus( );
        }

        private ScriptDocument GetScriptDocument( ScriptAssetItem scriptItem )
        {
            foreach( ScriptDocument scriptDoc in _scripts.Values )
            {
                if( scriptDoc.Script == scriptItem )
                    return scriptDoc;
            }

            return null;
        }

        #endregion
    }
}
