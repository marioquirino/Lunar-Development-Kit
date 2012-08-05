using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LunarDevKit.Classes;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms
{
    public partial class NewActorWindow : Form
    {
        #region Fields

        private ActorTypeEd _actor;
        private SpriteAssetItem _selectedSprite;


        private bool IsTextActor
        {
            get { return _checkIsTextActor.Checked; }
        }

        #endregion

        public NewActorWindow( )
        {
            InitializeComponent( );

            _txtActorName.GotFocus += ActorNameText_GotFocus;
            _txtActorName.LostFocus += ActorNameText_LostFocus;

            NoSpriteMenuItem_Click( _itemNoSprite, null );

            _LoadSpriteAssetsList( );
            _LoadScriptList( );
            _LoadFontList( );

            _actor = new ActorTypeEd( );
        }

        private void _LoadScriptList( )
        {
            _comboScriptList.Items.Clear( );
            _comboScriptList.Items.Add( new ScriptItem( null ) );
            _comboScriptList.SelectedIndex = 0;

            foreach( ScriptAssetItem scriptAsset in Global.AssetsBrowser.ScriptItems.Values )
            {
                ScriptItem scriptItem = new ScriptItem( scriptAsset.Script );
                _comboScriptList.Items.Add( scriptItem );
            }
        }

        private void _LoadFontList( )
        {
            _comboFontList.Items.Clear( );
            _comboFontList.Items.Add( new FontItem( null ) );
            _comboFontList.SelectedIndex = 0;

            foreach( FontAssetItem fontAsset in Global.AssetsBrowser.FontItems.Values )
            {
                FontItem fontItem = new FontItem( fontAsset );
                _comboFontList.Items.Add( fontItem );
            }
        }

        #region Events

        #region ActorNameText methods

        private void ActorNameText_TextChanged( object sender, EventArgs e )
        {
            _btnCreate.Enabled = (_txtActorName.Text != string.Empty && _txtActorName.Text != "<Actor Name>");
        }

        private void ActorNameText_LostFocus( object sender, System.EventArgs e )
        {
            if( _txtActorName.Text == string.Empty )
                _txtActorName.Text = "<Actor Name>";

            if( _txtActorName.Text != "<Actor Name>" )
                _txtActorName.Text = Helper.CheckLetterDigitInput( _txtActorName.Text );
        }

        private void ActorNameText_GotFocus( object sender, System.EventArgs e )
        {
            if( _txtActorName.Text == "<Actor Name>" )
                _txtActorName.Text = string.Empty;
        }

        #endregion

        private void _checkIsTextActor_CheckedChanged( object sender, EventArgs e )
        {
            spriteGroup.Enabled = !IsTextActor;
            textGroup.Enabled = IsTextActor;
        }

        private void originCenterCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            _lblOriginX.Enabled = _txtOriginX.Enabled = _lblOriginY.Enabled = _txtOriginY.Enabled = !_checkOriginCenter.Checked;
            ///----------------------------------------------------------------------
            //in here I must set the centerX and centerY of the texture on the labels
            ///----------------------------------------------------------------------
        }

        private void SpriteListMenuItem_Click( object sender, EventArgs e )
        {
            _selectedSprite = (sender as SpriteMenuItem).SpriteItem;
            _imageSprite.ImageLocation = _selectedSprite.FilePath;
        }

        private void NoSpriteMenuItem_Click( object sender, EventArgs e )
        {
            _selectedSprite = Global.AssetsBrowser.NoSpriteItem;
            _imageSprite.ImageLocation = _selectedSprite.FilePath;
        }

        private void _btnCreate_Click( object sender, EventArgs e )
        {
            _actor.IsTextActor = IsTextActor;
            if( IsTextActor )
            {
                FontAssetItem fontAsset = ((FontItem)_comboFontList.Items[_comboFontList.SelectedIndex]).FontAsset;
                if( fontAsset == null )
                {
                    MessageBox.Show( "It's required that you choose a font for the Text Actor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    _comboFontList.Focus( );
                    return;
                }

                _actor.FontAsset = fontAsset;
                _actor.Text = _txtActorText.Text;
            }
            else
                _actor.SpriteAsset = _selectedSprite;

            _actor.Name = _txtActorName.Text;
            _actor.Scale = (float)_upDownScale.Value;
            _actor.Rotation = (float)_upDownRotation.Value;
            _actor.Script = ((ScriptItem)_comboScriptList.Items[_comboScriptList.SelectedIndex]).Script;
            this.Close( );
        }

        private void _btnCancel_Click( object sender, EventArgs e )
        {
            _actor = null;
            this.Close( );
        }

        #endregion

        #region Methods

        private void _LoadSpriteAssetsList( )
        {
            if( Global.AssetsBrowser.SpriteItems.Count == 0 )
                return;

            foreach( SpriteAssetItem sprite in Global.AssetsBrowser.SpriteItems.Values )
            {
                SpriteMenuItem item = new SpriteMenuItem( sprite.AssetName );
                item.SpriteItem = sprite;
                item.Image = Image.FromFile( sprite.FilePath );
                item.Click += new EventHandler( SpriteListMenuItem_Click );
                _spriteListContextMenu.Items.Add( item );
            }
        }

        public new ActorTypeEd Show( )
        {
            base.Show( );

            return _actor;
        }

        public new ActorTypeEd Show( IWin32Window owner )
        {
            base.Show( owner );

            return _actor;
        }

        public new ActorTypeEd ShowDialog( )
        {
            base.ShowDialog( );

            return _actor;
        }

        public new ActorTypeEd ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );

            return _actor;
        }

        #endregion
    }
}
