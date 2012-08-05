using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    public partial class TagEditor : Form
    {
        private bool _cancel = false;

        public TagEditor( )
        {
            InitializeComponent( );
        }



        private void _btnCancel_Click( object sender, EventArgs e )
        {
            _cancel = true;
        }



        private void DisplayTags( string[] tags )
        {
            if( tags == null || tags.Length == 0 )
                return;

            int lastIndex = tags.Length - 1;
            for( int i = 0; i < tags.Length; i++ )
            {
                _txtTags.Text += tags[i];
                if( i < lastIndex )
                    _txtTags.Text += Environment.NewLine;
            }
        }

        private string[] GetTags( )
        {
            if( _cancel )
                return null;

            string[] lines = _txtTags.Text.Split( new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries );

            for( int i = 0; i < lines.Length; i++ )
            {
                lines[i] = lines[i].Trim( );
            }

            List<string> tags = new List<string>( );
            foreach( string line in lines )
            {
                if( !tags.Contains( line ) )
                    tags.Add( line );
            }

            return tags.ToArray( );
        }

        public new string[] Show( )
        {
            return ShowDialog( );
        }

        public new string[] Show( IWin32Window owner )
        {
            return ShowDialog( owner );
        }

        public string[] Show( string[] tags )
        {
            return ShowDialog( tags );
        }

        public new string[] ShowDialog( )
        {
            base.ShowDialog( );
            return GetTags( );
        }

        public new string[] ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );
            return GetTags( );
        }

        public string[] ShowDialog( string[] tags )
        {
            DisplayTags( tags );
            base.ShowDialog( );
            return GetTags( );
        }
    }
}
