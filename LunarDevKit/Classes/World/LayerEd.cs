using System;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Classes.Collections;

namespace LunarDevKit.Classes
{
    public class LayerEd
    {
        #region Fields

        private bool _visible;
        public bool Visible
        {
            get { return _visible; }
            set
            {
                _visible = value;
                if( AddedToLevel )
                    Global.MainWindow.OnLevelChanged( _container.Parent );
            }
        }

        private bool _locked;
        public bool Locked
        {
            get { return _locked; }
            set
            {
                _locked = value;
                if( AddedToLevel )
                    Global.MainWindow.OnLevelChanged( _container.Parent );
            }
        }

        private float _scale;
        public float Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                if( AddedToLevel )
                    Global.MainWindow.OnLevelChanged( _container.Parent );
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( AddedToLevel )
                {
                    if( _container.LayerExists( value ) )
                    {
                        MessageBox.Show( Global.EditorTxt.LayerWithSameNameExistsError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        return;
                    }

                    _name = value;

                    Global.MainWindow.OnLevelChanged( _container.Parent );
                    //Global.Layers.RefreshLayer( this );
                    if( NameChanged != null )
                        NameChanged( this, EventArgs.Empty );

                    return;
                }
                
                _name = value;
            }
        }

        private ActorEdPool _actors;
        public ActorEdPool Actors
        {
            get { return _actors; }
        }

        private int _idForNewActor = 0;
        public int IdForNewActor
        {
            get
            {
                if( _actors.Count != 0 )
                {
                    _idForNewActor++;
                    return _idForNewActor - 1;
                }
                else
                {
                    _idForNewActor = 1;
                    return 0;
                }
                    
            }
        }

        private LevelEd _container;
        public LevelEd Container
        {
            get { return _container; }
            set { _container = value; }
        }

        private LayerProperties _properties;
        public LayerProperties Properties
        {
            get { return _properties; }
        }


        public bool AddedToLevel = false;

        #endregion

        #region Events

        public event EventHandler NameChanged;

        #endregion

        #region Constructor

        public LayerEd( string name )
        {
            _actors = new ActorEdPool( );
            _name = name;
            _visible = true;
            _locked = false;
            _scale = 1f;
            _properties.Layer = this;
        }

        #endregion

        #region Methods

        public void Draw( SpriteBatch spriteBatch )
        {
            if( _visible )
            {
                foreach( ActorEd actor in _actors )
                    actor.Draw( spriteBatch );
            }
        }

        public void AddActor( ActorEd actor )
        {
            actor.Container = this;
            _actors.Add( actor );
        }

        public void RemoveActor( ActorEd actor )
        {
            _actors.Remove( actor );
            actor.Container = null;
        }

        public bool ActorExists( string name )
        {
            foreach( ActorEd actor in _actors )
            {
                if( actor.Name == name )
                    return true;
            }

            return false;
        }

        #endregion
    }



    public struct LayerProperties : IEdObject
    {
        public LayerEd Layer;


        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.LayerName )]
        public string Name
        {
            get { return Layer.Name; }
            set { Layer.Name = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.LayerVisible )]
        public bool Visible
        {
            get { return Layer.Visible; }
            set { Layer.Visible = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.LayerLocked )]
        public bool Locked
        {
            get { return Layer.Locked; }
            set { Layer.Locked = value; }
        }
    }
}
