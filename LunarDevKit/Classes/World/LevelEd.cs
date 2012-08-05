using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Classes.Collections;
using LunarDevKit.Classes.Zones;

namespace LunarDevKit.Classes
{
    public class LevelEd
    {
        #region Fields

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( !LevelAdded )
                {
                    _name = value;
                    return;
                }

                if( string.IsNullOrEmpty( value ) || string.IsNullOrEmpty( _filePath ) )
                    return;

                if( Global.World.LevelExists( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.LevelWithSameNameExists, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                _name = value;
                string newPath = Helper.ChangeFilePathName( _filePath, _name );
                if( File.Exists( _filePath ) )
                    File.Move( _filePath, newPath );

                _filePath = newPath;
                Global.MainWindow.OnWorldChanged( );
                Global.MainWindow.OnLevelChanged( Parent );
                Global.Properties.UpdateTitle( );

                Parent.Text = _name;
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private LayerEdPool _layers;
        public LayerEdPool Layers
        {
            get { return _layers; }
        }

        private LayerEd _selectedLayer;
        public LayerEd SelectedLayer
        {
            get
            {
                if( _selectedLayer == null )
                {
                    if( _layers.Count == 0 )
                        NewLayer( new LayerEd( "Layer"+_layers.Count ) );
                    _selectedLayer = _layers[0];
                }
                return _selectedLayer;
            }
            set { _selectedLayer = value; }
        }

        private Script _script;
        public Script Script
        {
            get { return _script; }
            set { _script = value; }
        }

        private Forms.Main_Window.LevelDocument _parent;
        public Forms.Main_Window.LevelDocument Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private bool _saved = true;
        public bool Saved
        {
            get { return _saved; }
        }

        private LevelProperties _properties;
        public LevelProperties Properties
        {
            get { return _properties; }
        }

        public bool LevelAdded = false;

        #endregion

        #region Constructor

        public LevelEd( )
        {
            _layers = new LayerEdPool( );

            _properties.Level = this;
        }

        #endregion
        
        #region Methods

        public void NewActor( ActorTypeEd actorType, int x, int y )
        {
            Vector2 pos = Helper.ScreenToWorldPosition( Global.SelectedLevelDoc.Viewport.Camera, x, y );
            if( Global.Tools.IsDragSnapToGrid )
                Helper.DragSnap( ref pos );


            ActorEd actor = actorType.CreateActor( SelectedLayer.IdForNewActor );

            string name = "";
            int i = 1;
            do
            {
                name = actorType.Name + i;
                i++;
            } while( SelectedLayer.ActorExists( name ) );
            actor.Name = name;

            actor.Position = pos;

            SelectedLayer.AddActor( actor );
            actor.AddedToLevel = true;

            Global.MainWindow.OnLevelChanged( this.Parent );
        }

        public void NewActor( ActorEd actor )
        {
            //Vector2 pos = Helper.ScreenToWorldPosition( Global.SelectedLevelDoc.Viewport.Camera, x, y );
            //if( Global.Tools.IsDragSnapToGrid )
            //    Helper.DragSnap( ref pos );

            //actor.Position = pos;

            SelectedLayer.AddActor( actor );
            actor.AddedToLevel = true;

            Global.MainWindow.OnLevelChanged( this.Parent );
        }

        public void DeleteActor( ActorEd actor )
        {
            SelectedLayer.RemoveActor( actor );
        }

        public void NewLayer( LayerEd layer )
        {
            layer.Container = this;
            _layers.Add( layer );
            layer.AddedToLevel = true;
        }

        public LayerEd NewLayer( )
        {
            string name = "";
            int i = 1;
            bool valid = false;
            do
            {
                name = "Layer" + i;
                i++;
                valid = true;
                foreach( LayerEd layer in _layers )
                {
                    if( layer.Name == name )
                    {
                        valid = false;
                        break;
                    }
                }

            } while( !valid );

            LayerEd layer2 = new LayerEd( name );
            NewLayer( layer2 );
            return layer2;
        }

        public void DeleteLayer( LayerEd layer )
        {
            _layers.Remove( layer );
        }

        public bool LayerExists( string name )
        {
            foreach( LayerEd layer in _layers )
            {
                if( layer.Name == name )
                    return true;
            }

            return false;
        }

        public void Draw( SpriteBatch spriteBatch )
        {
            foreach( LayerEd layer in _layers )
                layer.Draw( spriteBatch );
        }

        public void Save( )
        {
            if( !_saved )
            {
                FileManager.CreateLevelFile( this );
                _saved = true;
            }
        }

        public void Changed( )
        {
            _saved = false;
        }

        #endregion Methods
    }





    public struct LevelProperties : IEdObject
    {
        public LevelEd Level;

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.LevelName )]
        public string Name
        {
            get { return Level.Name; }
            set { Level.Name = value; }
        }

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.LevelScript ),
        TypeConverter( typeof( PropertyGridStuff.ScriptNameConverter ) )]
        public string Script
        {
            get
            {
                if( Level.Script == null )
                    return null;
                return Level.Script.Name;
            }
            set
            {
                if( string.IsNullOrEmpty( value ) )
                {
                    Level.Script = null;
                    return;
                }

                if( Global.AssetsBrowser.ScriptItems.ContainsKey( value ) )
                {
                    Level.Script = Global.AssetsBrowser.ScriptItems[value].Script;
                    return;
                }

                Global.AssetsBrowser.AddNewScript( value, ScriptFormat.Level );

                Level.Script = Global.AssetsBrowser.LastCreatedScript.Script;
            }
        }
    }
}
