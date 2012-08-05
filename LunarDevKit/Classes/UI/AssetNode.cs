using System;
using System.IO;
using System.Windows.Forms;

namespace LunarDevKit.Classes
{
    public class AssetNode : TreeNode
    {
        #region Fields

        public string FilePath;
        public NodeType NodeType = NodeType.Folder;
        public bool CreateFile = true;

        private SpriteEd _sprite = null;
        public SpriteEd Sprite
        {
            get { return _sprite; }
            set
            {
                _sprite = value;

                if( _sprite != null && CreateFile )
                {
                    //_sprite.Save( );
                    FilePath = _sprite.FilePath;
                }
            }
        }

        private ActorTypeEd _actorType;
        public ActorTypeEd ActorType
        {
            get { return _actorType; }
            set
            {
                _actorType = value;
                //_actorType.Parent = this;

                if( _actorType != null && CreateFile )
                {
                    _actorType.Save( );
                    FilePath = _actorType.FilePath;
                }
            }
        }

        private Script _script;
        public Script Script
        {
            get { return _script; }
            set
            {
                _script = value;

                if( _script != null && CreateFile )
                {
                    _script.Save( );
                    FilePath = _script.FilePath;
                }
            }
        }

        public new string Text
        {
            get { return base.Text; }
            set
            {
                string newPath = FilePath.Replace( base.Text + FileExtension, value + FileExtension );
                File.Move( FilePath, newPath );

                FilePath = newPath;

                switch( NodeType )
                {
                    case NodeType.ActorType:
                        ActorType.FilePath = FilePath;
                        ActorType.Name = value;
                        break;

                    case NodeType.Sprite:
                        Sprite.FilePath = FilePath;
                        Sprite.Name = value;
                        break;

                    case NodeType.Script:
                        Script.FilePath = FilePath;
                        Script.Name = value;
                        break;
                }

                base.Text = value;
            }
        }

        public string FileExtension
        {
            get
            {
                switch ( NodeType )
                {
                    case NodeType.ActorType:
                        return Consts.Files.ACTORTYPE_EXTENSION;

                    case NodeType.Sprite:
                        return Consts.Files.SPRITE_EXTENSION;

                    default:
                        return "";
                }
            }
        }

        /// <summary>
        /// The parent node of this node.
        /// </summary>
        public new AssetNode Parent
        {
            get { return base.Parent as AssetNode; }
        }
        /// <summary>
        /// The top-most parent of this node.
        /// </summary>
        public AssetNode TopParent
        {
            get 
            {
                AssetNode node = this;

                while ( node.Parent != null )
                {
                    node = node.Parent;
                }

                return node;
            }
        }

        #endregion Fields

        #region Constructors

        public AssetNode( ) : base( ) { }

        public AssetNode( string text )
            : base( text ) { }

        public AssetNode( string text, int imageIndex, int selectedImageIndex )
            : base( text, imageIndex, selectedImageIndex ) { }

        #endregion Construtors

        #region Event Methods



        #endregion

        ~AssetNode( )
        {
            if( Sprite != null )
                Sprite.Dispose( );
        }
    }
}
