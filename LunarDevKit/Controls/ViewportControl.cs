#region File Description
//-----------------------------------------------------------------------------
// SpinningTriangleControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LunarDevKit.Classes.GraphicsHandler;
using LunarEngine;
#endregion

namespace LunarDevKit.Controls
{
    using Forms;
    using Classes;
    using Classes.Zones;
    using Classes.Collections;
    using Classes.GraphicsHandler;

    using Color=Microsoft.Xna.Framework.Graphics.Color;
    using Point=System.Drawing.Point;
    using Keys=System.Windows.Forms.Keys;
    using Keys2=Microsoft.Xna.Framework.Input.Keys;
    using GraphicsDeviceManager=Classes.GraphicsHandler.GraphicsDeviceControl;
    using RectangleF=LunarEngine.RectangleF;

    #region ActorEventArgs

    public class ActorSelectionEventArgs : EventArgs
    {
        private int _count = 0;
        /// <summary>
        /// Gets the number of actors that are currently selected.
        /// </summary>
        public int ActorCount
        {
            get { return _count; }
        }

        public ActorSelectionEventArgs( int actorCount )
        {
            _count = actorCount;
        }
    }

    #endregion 

    public class ViewportControl : GraphicsDeviceControl
    {
        #region Fields

        private SpriteBatch _spriteBatch;
        private GraphicsDevice _graphics;
        
        public new Forms.Main_Window.LevelDocument Parent
        {
            get { return base.Parent as Forms.Main_Window.LevelDocument; }
            set { base.Parent = value; }
        }

        public CameraEd Camera;
        //private InputEd _input;

        private RectangleZone _selectionBox;
        private RectangleZone _selectionBlueprint;

        private Point _mouseLastPos = new Point( );
        private Point _mouseFirstPos = new Point( );
        private MouseMoveMode _moveMode = MouseMoveMode.None;
        private ActorMode _actorMode;
        private float _actorInitialScale;
        private float _actorPrevRotation;

        private ActorEdPool _selectedActors = new ActorEdPool( );
        public ActorEdPool SelectedActors
        {
            get { return _selectedActors; }
        }
        public ActorEd SelectedActor
        {
            get { return _selectedActors[0]; }
        }


        private ActorEdPool _copiedActors = new ActorEdPool( );

        #endregion

        #region Events

        /// <summary>
        /// Occurs when the selection of actors is changed, whether an actor was selected or unselected.
        /// The sender object is the ViewportControl.
        /// </summary>
        public event EventHandler<ActorSelectionEventArgs> ActorSelectionChanged;

        #endregion

        #region Init

        public ViewportControl( )
            : base( )
        {
            Camera = new CameraEd( this );

            _selectionBox = new RectangleZone( Color.White, 0, 0, 1, 1 );
            _selectionBox.BorderColor = Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR;
            _selectionBox.FillColor = Consts.Viewport.ACTOR_SELECTION_COLOR;

            _selectionBlueprint = new RectangleZone( Color.White, 0, 0, 1, 1 );
            _selectionBlueprint.BorderColor = Consts.Viewport.ACTOR_SELECTION_BLUEPRINT_BORDER_COLOR;
            _selectionBlueprint.FillColor = Consts.Viewport.ACTOR_SELECTION_BLUEPRINT_COLOR;

            MouseDown += new MouseEventHandler( ViewportMouseDown );
            MouseMove += new MouseEventHandler( ViewportMouseMove );
            MouseUp += new MouseEventHandler( ViewportMouseUp );
            //KeyPress += new KeyPressEventHandler( ViewportKeyPress );
        }

        protected override void Initialize( )
        {
            base.Initialize( );

            _graphics = GraphicsDevice;

            Viewport vp = _graphics.Viewport;

            //Camera.VisibleArea.Width = this.Width;
            //Camera.VisibleArea.Height = this.Height;

            _spriteBatch = new SpriteBatch( _graphics );
        }

        #endregion

        #region Draw

        protected override void Draw( )
        {
            _graphics.Clear( Consts.Viewport.BACKGROUND_COLOR );

            //Draws everything
            _spriteBatch.Begin( SpriteBlendMode.AlphaBlend, SpriteSortMode.Immediate, SaveStateMode.SaveState, Camera.View );

            Parent.Level.Draw( _spriteBatch );

            if( Global.SelectedLevelDoc == this.Parent )
                DrawSelectionBoxes( );

            if( Global.Tools.DrawsGrid )
            {
                //_spriteBatch.Begin( );
                Grid.Draw( _spriteBatch, Parent.Level );
                //_spriteBatch.End( );
            }

            //Draws the selection box when selecting various actors
            if( _moveMode == MouseMoveMode.Selection )
                _selectionBox.Draw( _spriteBatch );

            _spriteBatch.End( );
        }

        private void DrawSelectionBoxes( )
        {
            if( Global.Tools.SelectToolEnabled && !Global.Tools.IsSelectionMode )
            {
                //Draws the actor type blueprint
                if( Global.AssetsBrowser.SelectedActorType != null )
                {
                    ActorTypeEd actorType = Global.AssetsBrowser.SelectedActorType.Actor;


                    if( !actorType.IsTextActor )
                    {
                        Vector2 center = new Vector2( actorType.SpriteAsset.Sprite.Width * 0.5f, actorType.SpriteAsset.Sprite.Height * 0.5f );
                        _spriteBatch.Draw( actorType.SpriteAsset.Sprite, Helper.ScreenToWorldPosition( Camera, _mouseLastPos.X, _mouseLastPos.Y ), null, Consts.Viewport.ACTOR_BLUEPRINT_COLOR, actorType.Rotation, center, actorType.Scale, SpriteEffects.None, 0f );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( actorType.Text ) )
                        {
                            Vector2 textSize = actorType.FontAsset.Font.SpriteFont.MeasureString( actorType.Text );
                            Vector2 center = new Vector2( textSize.X * 0.5f, textSize.Y * 0.5f );

                            _spriteBatch.DrawString( actorType.FontAsset.Font.SpriteFont, actorType.Text, Helper.ScreenToWorldPosition( Camera, _mouseLastPos.X, _mouseLastPos.Y ), new Color( actorType.TextColor, 125 ), actorType.Rotation, center, actorType.Scale, SpriteEffects.None, 0f );
                        }
                    }
                }
            }
            else
            {
                ActorEd actor = GetActor( _mouseLastPos.X, _mouseLastPos.Y );
                if( actor != null && !actor.IsSelected )
                {
                    _selectionBlueprint.SetProperties( actor.Bounds );
                    _selectionBlueprint.Draw( _spriteBatch, Consts.Viewport.ACTOR_SELECTION_BORDER_WIDTH );
                }
            }
        }

        #endregion

        #region Event Methods

        public void ViewportMouseDown( object sender, MouseEventArgs e )
        {
            switch ( e.Button )
            {
                case MouseButtons.Left:
                    _LeftMouseButtonDown( e );
                    break;

                case MouseButtons.Right:
                    _RightMouseButtonDown( e );
                    break;

                case MouseButtons.Middle:
                    _moveMode = MouseMoveMode.Zoom;
                    break;
            }

            _mouseLastPos = e.Location;
        }
        #region Private Methods
        private void _LeftMouseButtonDown( MouseEventArgs e )
        {
            ActorEd actor;

            if( !Global.SelectedLevel2.SelectedLayer.Locked )
            {
                if( Global.Tools.IsSelectionMode )
                {
                    actor = GetActor( e.X, e.Y );

                    if( actor != null )
                    {
                        if( Control.ModifierKeys == Keys.Shift )
                        {
                            if( _selectedActors.Contains( actor ) )
                                UnselectActor( actor );
                            else
                                SelectActor( actor, true );
                        }
                        else if( !_selectedActors.Contains( actor ) )
                            SelectActor( actor, false );

                        _moveMode = MouseMoveMode.Actor;

                        _actorMode = GetActorMode( actor, e.X, e.Y );
                        _mouseFirstPos = new Point( e.X, e.Y );
                        _actorInitialScale = actor.Scale;
                        Vector2 mousePos = Helper.ScreenToWorldPosition( Camera, e.X, e.Y );
                        _actorPrevRotation = (float)Math.Atan2( actor.Position.Y - mousePos.Y, actor.Position.X - mousePos.X );
                    }
                    else
                    {
                        UnselectAllActors( );
                        _moveMode = MouseMoveMode.Selection;
                        Vector2 pos = Helper.ScreenToWorldPosition( Camera, e.X, e.Y );
                        _selectionBox.X = (int)pos.X;
                        _selectionBox.Y = (int)pos.Y;
                    }
                }
                else
                {
                    _moveMode = MouseMoveMode.Create;
                }
            }
        }
        private void _RightMouseButtonDown( MouseEventArgs e )
        {
            ActorEd actor = GetActor( e.X, e.Y );

            if( actor != null )
            {
                if( Global.Tools.IsSelectionMode )
                {
                    if( !_selectedActors.Contains( actor ) )
                        SelectActor( actor, false );

                    ShowActorContextMenu( e.Location );
                }
            }

            _moveMode = MouseMoveMode.Camera;
        }
        #endregion

        public void ViewportMouseMove( object sender, MouseEventArgs e )
        {
            switch ( _moveMode )
            {
                case MouseMoveMode.Create:
                    _MouseMoveCreateMode( e );
                    break;

                case MouseMoveMode.Actor:
                    if( Global.Tools.IsSelectionMode )
                        _MouseMoveActorMode( e );
                    break;

                case MouseMoveMode.Camera:
                    _MouseMoveCameraMode( e );
                    break;

                case MouseMoveMode.Zoom:
                    _MouseMoveZoomMode( e );
                    break;

                case MouseMoveMode.Selection:
                    _MouseMoveSelectionMode( e );
                    break;
            }

            _mouseLastPos = e.Location;
        }
        #region Private Methods
        private void _MouseMoveCreateMode( MouseEventArgs e )
        {
            //if( Form.ModifierKeys == Keys.Shift )
            //{
            //    if( Global.Assets.AssetsTree.SelectedNode != null )
            //    {
            //        if( Global.Assets.AssetsTree.SelectedNode.NodeType == NodeType.ActorType )
            //            Parent.Level.NewActor( Global.Assets.AssetsTree.SelectedNode.ActorType, e.X, e.Y );
            //    }
            //}
        }
        private void _MouseMoveActorMode( MouseEventArgs e )
        {
            Vector2 pos;
            int dx = _mouseLastPos.X - e.X;
            int dy = _mouseLastPos.Y - e.Y;

            foreach( ActorEd actor in _selectedActors )
            {
                switch( _actorMode )
                {
                    case ActorMode.Move:
                            actor.Position -= new Vector2( dx / Camera.Zoom, dy / Camera.Zoom );
                        break;

                    case ActorMode.Rotate:
                        pos = actor.Position;
                        Vector2 mousePos = Helper.ScreenToWorldPosition( Camera, e.X, e.Y );
                        float rotation = (float)Math.Atan2( pos.Y - mousePos.Y, pos.X - mousePos.X );
                        actor.Rotation -= ( _actorPrevRotation - rotation );
                        _actorPrevRotation = rotation;
                        break;

                    case ActorMode.ScaleLeft:
                        actor.Scale = _actorInitialScale + ( _mouseFirstPos.X - e.X ) * 0.01f / Camera.Zoom;
                        break;

                    case ActorMode.ScaleRight:
                        actor.Scale = _actorInitialScale + ( e.X - _mouseFirstPos.X ) * 0.01f / Camera.Zoom;
                        break;

                    case ActorMode.ScaleTop:
                        actor.Scale = _actorInitialScale + ( _mouseFirstPos.Y - e.Y ) * 0.01f / Camera.Zoom;
                        break;

                    case ActorMode.ScaleBottom:
                        actor.Scale = _actorInitialScale + ( e.Y - _mouseFirstPos.Y ) * 0.01f / Camera.Zoom;
                        break;
                }
            }
        }
        private void _MouseMoveCameraMode( MouseEventArgs e )
        {
            int dx = _mouseLastPos.X - e.X;
            int dy = _mouseLastPos.Y - e.Y;
            Camera.Move( dx / Camera.Zoom, dy / Camera.Zoom );
        }
        private void _MouseMoveZoomMode( MouseEventArgs e )
        {
            int dy = e.Y - _mouseLastPos.Y;
            Camera.Zoom += dy * -Consts.Camera.ZOOM_FACTOR;
        }
        private void _MouseMoveSelectionMode( MouseEventArgs e )
        {
            Vector2 pos = Helper.ScreenToWorldPosition( Camera, e.X, e.Y );
            int dx = (int)( pos.X - _selectionBox.X );
            int dy = (int)( pos.Y - _selectionBox.Y );
            _selectionBox.Width = dx;
            _selectionBox.Height = dy;
        }
        #endregion

        public void ViewportMouseUp( object sender, MouseEventArgs e )
        {
            if ( _moveMode == MouseMoveMode.Selection )
            {
                if ( _selectionBox.Width < 0 )
                {
                    _selectionBox.X = _selectionBox.Right;
                    _selectionBox.Width *= -1;
                }
                if ( _selectionBox.Height < 0 )
                {
                    _selectionBox.Y = _selectionBox.Bottom;
                    _selectionBox.Height *= -1;
                }

                foreach ( ActorEd actor in Parent.Level.SelectedLayer.Actors )
                {
                    if( _selectionBox.Contains( actor.Position ) )
                        SelectActor( actor, true );
                }

                _selectionBox.Width = 1;
                _selectionBox.Height = 1;
            }
            else if( _moveMode == MouseMoveMode.Create )
            {
                CreateActor( e.X, e.Y );
            }
            else if( _moveMode == MouseMoveMode.Actor && _actorMode == ActorMode.Move && Global.Tools.IsDragSnapToGrid )
            {
                foreach( ActorEd actor in _selectedActors )
                {
                    actor.Position = Helper.DragSnap( actor.Position );
                }
            }

            Global.Properties.RefreshGrid( );

            _moveMode = MouseMoveMode.None;
        }

        #endregion

        #region Methods

        public ActorEd GetActor( float X, float Y )
        {
            Vector2 pos = Helper.ScreenToWorldPosition( Camera, X, Y );

            int count = Parent.Level.SelectedLayer.Actors.Count;
            for ( int i = count - 1; i >= 0; i-- )
            {
                ActorEd actor = Parent.Level.SelectedLayer.Actors[i];
                if( actor != null )
                {
                    if( actor.Bounds.Contains( pos ) )
                        return actor;
                }
            }

            return null;
        }

        private ActorMode GetActorMode( ActorEd actor, float X, float Y )
        {
            int width = Consts.Viewport.ACTOR_SELECTION_EDGE_WIDTH;
            Vector2 pos = Helper.ScreenToWorldPosition( Camera, X, Y );
            if( actor != null )
            {
                RectangleF bounds = actor.Bounds;
                if( ( pos.X <= bounds.X + width && pos.Y <= bounds.Y + width ) ||         //Top-Left corner
                    ( pos.X <= bounds.X + width && pos.Y >= bounds.Bottom - width ) ||    //Bottom-Left corner
                    ( pos.X >= bounds.Right - width && pos.Y <= bounds.Y + width ) ||     //Top-Right corner
                    ( pos.X >= bounds.Right - width && pos.Y >= bounds.Bottom - width ) ) //Bottom-Right corner
                {
                    return ActorMode.Rotate;
                }

                if( pos.X <= bounds.X + width )
                    return ActorMode.ScaleLeft;
                else if( pos.Y <= bounds.Y + width )
                    return ActorMode.ScaleTop;
                else if( pos.X >= bounds.Right - width )
                    return ActorMode.ScaleRight;
                else if( pos.Y >= bounds.Bottom - width )
                    return ActorMode.ScaleBottom;
            }

            return ActorMode.Move;
        }

        public void SelectActor( ActorEd actor, bool addToSelection )
        {
            actor.IsSelected = true;
            if( !addToSelection )
            {
                UnselectAllActors( );
                Global.Properties.SelectObject( actor.Properties );
            }
            else
                Global.Properties.AddObjectToSelection( actor.Properties );

            _selectedActors.Add( actor );

            OnActorSelectionChanged( );
        }

        public void UnselectActor( ActorEd actor )
        {
            actor.IsSelected = false;
            _selectedActors.Remove( actor );
            Global.Properties.UnselectObject( actor.Properties );
            OnActorSelectionChanged( );
        }

        public void UnselectAllActors( )
        {
            foreach ( ActorEd actor in _selectedActors )
                actor.IsSelected = false;
            _selectedActors.Clear( );
            Global.Properties.UnselectAllObjects( );
            OnActorSelectionChanged( );
        }

        public void CreateActor( int x, int y )
        {
            if( Global.AssetsBrowser.SelectedActorType != null )
            {
                Parent.Level.NewActor( Global.AssetsBrowser.SelectedActorType.Actor, x, y );
            }
        }

        public void CutActors( )
        {
            CopyActors( );
            DeleteSelectedActors( );
        }

        public void CopyActors( )
        {
            _copiedActors.Clear( );

            foreach( ActorEd actor in _selectedActors )
            {
                _copiedActors.Add( actor );
            }
        }

        public void PasteActors( )
        {
            if( _copiedActors.Count == 0 )
                return;

            UnselectAllActors( );
            foreach( ActorEd actor in _copiedActors )
            {
                ActorEd newActor = actor.Clone( );
                newActor.Position += new Vector2( 25 );
                Parent.Level.NewActor( newActor );
                SelectActor( newActor, true );
            }
        }

        public void DeleteSelectedActor( )
        {
            if ( SelectedActor != null )
                Parent.Level.DeleteActor( SelectedActor );
        }

        public void DeleteSelectedActors( )
        {
            foreach ( ActorEd actor in _selectedActors )
                Parent.Level.DeleteActor( actor );
            _selectedActors.Clear( );
        }

        public void ShowActorContextMenu( Point point )
        {
            Parent.ActorBringToFrontEnabled = Parent.ActorSendToBackEnabled = ( _selectedActors.Count == 1 );
            Parent.ActorSwapEnabled = ( _selectedActors.Count == 2 );
            Parent.ShowActorContextMenu( point.X, (int)( point.Y + Parent.ActorContextMenu.Height * 0.5f ) );
        }



        protected virtual void OnActorSelectionChanged( )
        {
            if( ActorSelectionChanged != null )
                ActorSelectionChanged( this, new ActorSelectionEventArgs( _selectedActors.Count ) );
        }

        #endregion

        ~ViewportControl( )
        {
            _spriteBatch.Dispose( );
        }
    }
}