using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    public delegate void AssetItemEventHandler( AssetItem sender, MouseEventArgs e );

    public partial class AssetItem : UserControl
    {
        #region Events

        [Category( "_Asset Item Own Events" )]
        public event AssetItemEventHandler AssetClicked;
        [Category( "_Asset Item Own Events" )]
        public event AssetItemEventHandler AssetDoubleClicked;

        #endregion

        #region Fields

        private static Timer _timer;

        protected string _filePath;
        [Browsable( false )]
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if( _filePath == value )
                    return;

                if( !string.IsNullOrEmpty( _filePath ) && File.Exists( _filePath ) && !string.IsNullOrEmpty( value ) )
                    File.Move( _filePath, value );

                _filePath = value;
            }
        }

        public new bool Visible
        {
            get { return base.Visible; }
            set
            {
                if( value )
                {
                    _timer.Tick += _timer_Tick;
                }
                else
                {
                    _timer.Tick -= _timer_Tick;
                }
                base.Visible = value;
            }
        }

        [Browsable( false )]
        public string LabelName
        {
            get { return _label.Text; }
            set { _label.Text = value; }
        }

        private Dictionary<string, bool> _tags;

        #region UI Fields

        private bool _isSelected;
        [Browsable( false )]
        public bool IsSelected
        {
            get { return _isSelected; }
        }
            
        [Category( "_Asset Properties" )]
        public Image AssetThumbnail
        {
            get { return _image.Image; }
            set { _image.Image = value; }
        }

        [Category( "_Asset Properties" )]
        public string AssetName
        {
            get { return _label.Text; }
            set
            {
                _label.Text = value;
                if( !Global.DesignMode && !string.IsNullOrEmpty( _filePath ) )
                {
                    _filePath = Path.Combine( Path.GetDirectoryName( _filePath ), _label.Text );
                }
            }
        }
        [Category( "_Asset Properties" )]
        public Font LabelFont
        {
            get { return _label.Font; }
            set { _label.Font = value; }
        }
        [Category( "_Asset Properties" )]
        public bool LabelVisible
        {
            get { return _label.Visible; }
            set { _label.Visible = value; }
        }

        private Color _defaultBackColor;
        [Category( "_Asset Properties" )]
        public new Color DefaultBackColor
        {
            get { return _defaultBackColor; }
            set
            {
                _defaultBackColor = value;
                this.BackColor = value;
            }
        }

        private Color _highlightBackColor;
        [Category( "_Asset Properties" )]
        public Color HighlightBackColor
        {
            get { return _highlightBackColor; }
            set { _highlightBackColor = value; }
        }

        private Color _selectBackColor;
        [Category( "_Asset Properties" )]
        public Color SelectBackColor
        {
            get { return _selectBackColor; }
            set { _selectBackColor = value; }
        }

        private Color _defaultLabelColor;
        [Category( "_Asset Properties" )]
        public Color DefaultLabelColor
        {
            get { return _defaultLabelColor; }
            set
            {
                _defaultLabelColor = value;
                _label.ForeColor = value;
            }
        }

        private Color _highlightLabelColor;
        [Category( "_Asset Properties" )]
        public Color HighlightLabelColor
        {
            get { return _highlightLabelColor; }
            set { _highlightLabelColor = value; }
        }

        private Color _selectLabelColor;
        [Category( "_Asset Properties" )]
        public Color SelectLabelColor
        {
            get { return _selectLabelColor; }
            set { _selectLabelColor = value; }
        }

        #endregion

        #endregion

        static AssetItem( )
        {
            if( !Global.DesignMode )
            {
                _timer = new Timer( );
                _timer.Interval = 100;
                _timer.Enabled = true;
            }
        }

        public AssetItem( )
        {
            InitializeComponent( );

            _tags = new Dictionary<string, bool>( );

            _defaultBackColor = this.BackColor;
            _highlightBackColor = this.BackColor;
            _selectBackColor = this.BackColor;

            _defaultLabelColor = _label.ForeColor;
            _highlightLabelColor = _label.ForeColor;
            _selectLabelColor = _label.ForeColor;

            if( !Global.DesignMode )
            {
                _timer.Tick += _timer_Tick;
            }
        }


        #region Event Methods

        private void _timer_Tick( object sender, EventArgs e )
        {
            if( this.Parent == null )
            {
                _timer.Tick -= _timer_Tick;
                return;
            }

            if( this.Bounds.Contains( this.Parent.PointToClient( Cursor.Position ) ) )
            {
                this.BackColor = _highlightBackColor;
                _label.ForeColor = _highlightLabelColor;
            }
            else
            {
                this.BackColor = _defaultBackColor;
                _label.ForeColor = _defaultLabelColor;
            }
        }

        private void AssetItem_MouseClick( object sender, MouseEventArgs e )
        {
            if( AssetClicked != null )
                AssetClicked( this, e );
        }

        private void AssetItem_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if( AssetDoubleClicked != null )
                AssetDoubleClicked( this, e );
        }

        #endregion

        #region Methods

        #region Tag-related Methods
        public bool ContainsTag( string tag )
        {
            return _tags.ContainsKey( tag );
        }

        public bool ContainsTag( string[] tags )
        {
            foreach( string tag in tags )
            {
                if( !_tags.ContainsKey( tag ) )
                    return false;
            }
            return true;
        }

        public void AddTag( string tag )
        {
            if( !_tags.ContainsKey( tag ) )
                _tags.Add( tag, false );
        }

        public void RemoveTag( string tag )
        {
            if( _tags.ContainsKey( tag ) )
                _tags.Remove( tag );
        }
        #endregion

        public new void Dispose( )
        {
            _timer.Tick -= _timer_Tick;
            base.Dispose( );
        }

        protected virtual void DisposeResources( )
        {

        }

        public void SelectMe( )
        {
            if( _isSelected )
                return;

            _isSelected = true;
            this.BackColor = _selectBackColor;
            _label.ForeColor = _selectLabelColor;
            _label.Font = new Font( _label.Font, FontStyle.Bold );

            _timer.Tick -= _timer_Tick;
        }

        public void DeselectMe( )
        {
            _isSelected = false;
            this.BackColor = _defaultBackColor;
            _label.ForeColor = _defaultLabelColor;
            _label.Font = new Font( _label.Font, FontStyle.Regular );

            _timer.Tick += _timer_Tick;
        }

        #endregion
    }
}
