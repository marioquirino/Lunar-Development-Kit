using System;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;

namespace LunarDevKit.Forms
{
    public partial class ScriptErrorsDock : DockContent
    {
        public ScriptErrorsDock( )
        {
            InitializeComponent( );
        }

        public void FillErrorList( CompilerErrorCollection errors )
        {
            _listErrors.Items.Clear( );
            _listWarnings.Items.Clear( );

            if( errors != null && errors.Count > 0 )
            {
                int errorNum = 0;
                foreach( CompilerError error in errors )
                {
                    ListViewItem item = new ListViewItem( );

                    //Error Number
                    errorNum++;
                    item.SubItems.Add( new ListViewItem.ListViewSubItem( item, errorNum.ToString( ) ) );
                    //Error Message
                    item.SubItems.Add( new ListViewItem.ListViewSubItem( item, error.ErrorText ) );
                    //Filename
                    item.SubItems.Add( new ListViewItem.ListViewSubItem( item, System.IO.Path.GetFileName( error.FileName ) ) );
                    //Line
                    item.SubItems.Add( new ListViewItem.ListViewSubItem( item, error.Line.ToString( ) ) );
                    //Column
                    item.SubItems.Add( new ListViewItem.ListViewSubItem( item, error.Column.ToString( ) ) );

                    if( error.IsWarning )
                        _listWarnings.Items.Add( item );
                    else
                        _listErrors.Items.Add( item );
                }
            }
        }
    }
}
