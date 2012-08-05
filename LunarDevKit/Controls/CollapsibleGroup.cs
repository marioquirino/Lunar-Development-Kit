using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public delegate void CollapsibleGroupEventHandler( CollapsibleGroup sender );

    public partial class CollapsibleGroup : UserControl
    {
        private const int MAX_HEIGHT = 550;

        [Category( "_Group Events" )]
        public event CollapsibleGroupEventHandler GroupClicked;

        #region Fields

        private bool _displayControls = true;

        #endregion

        #region Properties

        [Category( "_Group Properties" )]
        public string Title
        {
            get { return _titleLabel.Text; }
            set { _titleLabel.Text = value; }
        }

        [Category( "_Group Properties" )]
        public Font TitleFont
        {
            get { return _titleLabel.Font; }
            set { _titleLabel.Font = value; }
        }

        [Category( "_Group Properties" )]
        public Color TitleColor
        {
            get { return _titleLabel.ForeColor; }
            set { _titleLabel.ForeColor = value; }
        }

        [Category( "_Group Properties" )]
        public FlowDirection ItemsFlowDirection
        {
            get { return _controlsPanel.FlowDirection; }
            set { _controlsPanel.FlowDirection = value; }
        }

        [Category( "_Group Properties" )]
        public bool EditGroupNameVisible
        {
            get { return _editTitleButton.Visible; }
            set { _editTitleButton.Visible = value; }
        }

        #endregion

        public CollapsibleGroup( )
        {
            InitializeComponent( );
        }

        #region Event Methods

        private void collapseButton_Click( object sender, EventArgs e )
        {
            _displayControls = !_displayControls;

            if( _displayControls )
            {
                base.Controls.Add( _controlsPanel );
                _controlsPanel.Height = 500;
                this.AutoSize = false;
                _collapseButton.BackgroundImage = global::LunarDevKit.Properties.Resources.ArrwDwn;
            }
            else
            {
                base.Controls.Remove( _controlsPanel );
                this.AutoSize = true;
                _collapseButton.BackgroundImage = global::LunarDevKit.Properties.Resources.ArrwRght;
            }
        }

        private void editTitle_Click( object sender, EventArgs e )
        {
            string name = "";
            if(Helper.InputBox( "Group Name", "Type the new name for this group:", ref name ) != DialogResult.Cancel)
            {
                if(!string.IsNullOrEmpty( name ) && name != " ")
                    this.Title = name;
            }
        }

        #endregion

        #region Methods

        public void AddControl( Control control )
        {
            _controlsPanel.Controls.Add( control );
        }

        #endregion

        private void Group_MouseClick( object sender, MouseEventArgs e )
        {
            if( GroupClicked != null )
                GroupClicked( this );
        }
    }
}
