using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    using Classes;
    using Classes.Collections;

    public class AssetsTreeView : TreeView
    {
        #region Fields

        private AssetNode _mainNode;
        private AssetNode _lastCreatedNode;

        private NodePool _spritesPool = new NodePool( );
        private NodePool _actorTypesPool = new NodePool( );
        private NodePool _scriptsPool = new NodePool( );

        private static Dictionary<ActorTypeEd, AssetNode> _tempArchetypePool = new Dictionary<ActorTypeEd, AssetNode>( );
        private static Dictionary<Script, AssetNode> _tempScriptPool = new Dictionary<Script, AssetNode>( );

        #endregion

        #region Properties

        public new AssetNode SelectedNode
        {
            get { return base.SelectedNode as AssetNode; }
            set { base.SelectedNode = value; }
        }

        public AssetNode LastCreatedNode
        {
            get { return _lastCreatedNode; }
        }

        public AssetNode MainNode
        {
            get { return _mainNode; }
        }

        public AssetNode NoSpriteNode
        {
            get { return _spritesPool[0]; }
        }

        public SpriteEd NoSprite
        {
            get { return _spritesPool[0].Sprite; }
        }

        public NodePool Sprites
        {
            get { return _spritesPool; }
        }

        public NodePool ActorTypes
        {
            get { return _actorTypesPool; }
        }

        public NodePool Scripts
        {
            get { return _scriptsPool; }
        }

        #endregion

        #region Init

        public void Initialization( )
        {
            this.ImageList = Global.AssetsTreeViewImages;

            this.Nodes.Clear( );
            _spritesPool.Clear( );
            _actorTypesPool.Clear( );
            _scriptsPool.Clear( );

            _mainNode = new AssetNode( "Assets" );
            _mainNode.FilePath = Global.World.AssetsFolderPath;
            _mainNode.ImageIndex = _mainNode.SelectedImageIndex = 3;
            _mainNode.NodeType = NodeType.Folder;
            this.Nodes.Add( _mainNode );

            AssetNode node = new AssetNode( );
            node.CreateFile = false;
            node.Sprite = Helper.GetSpriteFromImage( Global.GraphicsDevice, LunarDevKit.Properties.Resources.NoSprite );
            node.Sprite.Bitmap = LunarDevKit.Properties.Resources.NoSprite;
            _spritesPool.Add( 0, node );

            LoadAssets( Global.World.AssetsFolderPath, _mainNode );
            SetReferences( );

            _tempArchetypePool.Clear( );
            _tempScriptPool.Clear( );

            CollapseAll( );
            SelectedNode = null;
        }

        private void LoadAssets( string path, AssetNode parent )
        {
            //DirectoryInfo mainDir = new DirectoryInfo( path );
            //DirectoryInfo[] dirs = mainDir.GetDirectories( );
            //FileInfo[] files = mainDir.GetFiles( );

            //foreach( FileInfo file in files )
            //{
            //    if( Helper.IsFileSprite( file.Name ) )
            //    {
            //        SpriteEd sprite = FileManager.LoadSpriteFile( file.FullName );
            //        sprite.Name = file.Name.Substring( 0, file.Name.Length - Consts.Files.SPRITE_EXTENSION.Length );
            //        AddSprite( sprite, parent );
            //    }
            //    else if( Helper.IsFileArchetype( file.Name ) )
            //    {
            //        _tempArchetypePool.Add( FileManager.LoadActorTypeFile( file.FullName ), parent );
            //    }
            //    else if( Helper.IsFileScript( file.Name ) )
            //    {
            //        _tempScriptPool.Add( FileManager.LoadScriptFile( file.FullName ), parent );
            //    }
            //}

            //if( dirs.Length != 0 )
            //{
            //    foreach( DirectoryInfo dir in dirs )
            //    {
            //        AddFolder( dir.Name, parent, false );

            //        LoadAssets( dir.FullName, _lastCreatedNode );
            //    }
            //}
        }

        private void SetReferences( )
        {
            foreach( ActorTypeEd a in _tempArchetypePool.Keys )
            {
                //if( !_spritesPool.ContainsKey( a.TempSpriteID ) )
                //    a.SpriteNode = NoSpriteNode;
                //else
                //    a.SpriteNode = _spritesPool[a.TempSpriteID];
                AddActorType( a, _tempArchetypePool[a] );
            }

            foreach( Script s in _tempScriptPool.Keys )
            {
                AddScript( s, _tempScriptPool[s] );
            }
        }

        #endregion

        #region Methods

        #region Add Folder Methods

        /// <summary>
        /// Adds a new folder node given the folder's name. It will attach the node to the selected node.
        /// </summary>
        public void AddFolder( string folderName )
        {
            AddFolder( folderName, SelectedNode, true );
        }

        /// <summary>
        /// Adds a new folder node given the folder's name, the parent and a value indicating whether it will create a physical folder.
        /// </summary>
        public void AddFolder( string folderName, AssetNode parent, bool createPhysicalFolder )
        {
            if( parent != null )
            {
                AssetNode node = parent;
                AssetNode newNode = new AssetNode( folderName );
                if( node.NodeType == NodeType.Folder )
                    newNode.FilePath = node.FilePath + folderName + @"\";
                else
                {
                    node = parent.Parent;
                    newNode.FilePath = node.FilePath + folderName + @"\";
                }

                if( createPhysicalFolder && Directory.Exists( newNode.FilePath ) )
                    MessageBox.Show( "This folder already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                else
                {
                    if( createPhysicalFolder )
                        Directory.CreateDirectory( newNode.FilePath );

                    newNode.ImageIndex = newNode.SelectedImageIndex = 3;
                    //if( this == Global.Assets.AssetsTree )
                    //    newNode.ContextMenuStrip = Global.Assets.NodeContextMenu;

                    node.Nodes.Add( newNode );
                    Sort( );

                    SelectedNode = newNode;
                    _lastCreatedNode = newNode;

                    node.Expand( );
                }

            }

            //AssetNode newNode = new AssetNode( folderName );
            //newNode.ImageIndex = newNode.SelectedImageIndex = 3;
            //if( this == Properties.Assets.AssetsTree )
            //    newNode.ContextMenuStrip = Properties.Assets.NodeContextMenu;

            //if( parent == null )
            //{
            //    newNode.FilePath = Properties.World.AssetsFolderPath + folderName + "\\";
            //    this.Nodes.Add( newNode );
            //}
            //else
            //{
            //    if( parent.NodeType == NodeType.Folder )
            //    {
            //        parent.Nodes.Add( newNode );
            //    }
            //    else
            //    {
            //        parent.Parent.Nodes.Add( newNode );
            //    }
            //    newNode.FilePath = Properties.World.AssetsFolderPath + parent.FullPath + "\\" + folderName + "\\";
            //    parent.Expand( );
            //}

            //if( createPhysicalFolder && !Directory.Exists( newNode.FilePath ) )
            //{
            //    Directory.CreateDirectory( newNode.FilePath );
            //}
            //else
            //{
            //    MessageBox.Show( "This folder already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            //    return;
            //}

            //Sort( );

            //SelectedNode = newNode;
            //lastCreatedNode = newNode;
        }

        #endregion Add Folder Methods

        #region Add Sprite Methods

        /// <summary>
        /// Adds a new sprite node give the sprite. The node will be attached to the SelectedNode
        /// </summary>
        public void AddSprite( SpriteEd sprite )
        {
            AddSprite( sprite, SelectedNode );
        }

        /// <summary>
        /// Adds a new sprite node given the sprite and the parent node.
        /// </summary>
        public void AddSprite( SpriteEd sprite, AssetNode parent )
        {
            if( parent == null )
                parent = _mainNode;
            if( parent.NodeType != NodeType.Folder )
                parent = parent.Parent;

            sprite.FilePath = Global.World.WorldFolderPath + parent.FullPath + "\\" + sprite.Name + Consts.Files.SPRITE_EXTENSION;

            AssetNode newNode = new AssetNode( sprite.Name );
            newNode.Sprite = sprite;
            newNode.NodeType = NodeType.Sprite;

            newNode.ImageIndex = newNode.SelectedImageIndex = 0;
            //if ( this == Global.Assets.AssetsTree )
            //    newNode.ContextMenuStrip = Global.Assets.NodeContextMenu;

            if( parent == null )
                this.Nodes.Add( newNode );
            else
                parent.Nodes.Add( newNode );
            
            //_spritesPool.Add( newNode.Sprite.ID, newNode );
            Sort( );

            SelectedNode = newNode;
            _lastCreatedNode = newNode;

            parent.Expand( );
        }

        #endregion Add Sprite Methods

        #region Add ActorType Methods

        /// <summary>
        /// Adds a new archetype node to the Assets Tree View given the archetype object.
        /// </summary>
        public void AddActorType( ActorTypeEd actorType )
        {
            AddActorType( actorType, SelectedNode );
        }

        /// <summary>
        /// Adds a new archetype node given the archetype object and the parent node.
        /// </summary>
        public void AddActorType( ActorTypeEd actorType, AssetNode parent )
        {
            if( parent == null )
                parent = _mainNode;
            if( parent.NodeType != NodeType.Folder )
                parent = parent.Parent;

            actorType.FilePath = Global.World.WorldFolderPath + parent.FullPath + "\\" + actorType.Name + Consts.Files.ACTORTYPE_EXTENSION;

            AssetNode newNode = new AssetNode( actorType.Name );
            newNode.ActorType = actorType;
            newNode.NodeType = NodeType.ActorType;

            newNode.ImageIndex = newNode.SelectedImageIndex = 1;
            //if ( this == Global.Assets.AssetsTree )
            //    newNode.ContextMenuStrip = Global.Assets.NodeContextMenu;

            parent.Nodes.Add( newNode );
            //_actorTypesPool.Add( newNode.ActorType.ID, newNode );
            Sort( );

            SelectedNode = newNode;
            _lastCreatedNode = newNode;

            parent.Expand( );
        }

        #endregion Add Archetype Methods

        #region Add Script Methods

        public void AddScript( Script script )
        {
            AddScript( script, SelectedNode );
        }

        public void AddScript( Script script, AssetNode parent )
        {
            if( parent == null )
                parent = _mainNode;
            if ( parent.NodeType != NodeType.Folder )
                parent = parent.Parent;

            //script.FilePath = Global.World.WorldFolderPath + parent.FullPath + "\\" + script.Name + Consts.Files.LUASSEMBLY_EXTENSION;

            AssetNode newNode = new AssetNode( script.Name );
            newNode.Script = script;
            newNode.NodeType = NodeType.Script;

            newNode.ImageIndex = newNode.SelectedImageIndex = 4;
            //if ( this == Global.Assets.AssetsTree )
            //    newNode.ContextMenuStrip = Global.Assets.NodeContextMenu;

            parent.Nodes.Add( newNode );
            //_scriptsPool.Add( newNode.Script.ID, newNode );
            Sort( );

            SelectedNode = newNode;
            _lastCreatedNode = newNode;

            parent.Expand( );
        }

        #endregion Add Script Methods

        #endregion
    }
}