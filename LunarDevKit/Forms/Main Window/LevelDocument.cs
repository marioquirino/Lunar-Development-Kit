using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using LunarDevKit.Classes;
using LunarDevKit.Classes.Collections;
using LunarDevKit.Controls;

namespace LunarDevKit.Forms.Main_Window
{
    public partial class LevelDocument : DockContent
    {
        #region Fields

        private ViewportControl _viewport;
        public ViewportControl Viewport
        {
            get { return _viewport; }
        }

        private LevelEd _level;
        public LevelEd Level
        {
            get { return _level; }
            set
            {
                _level = value;
                _level.Parent = this;
            }
        }

        public string LevelName
        {
            get { return _level.Name; }
            set { _level.Name = value; }
        }

        #endregion

        #region Properties

        public bool ActorBringToFrontEnabled
        {
            get { return _itemActorBringFront.Enabled; }
            set { _itemActorBringFront.Enabled = value; }
        }

        public bool ActorSendToBackEnabled
        {
            get { return _itemActorSendBack.Enabled; }
            set { _itemActorSendBack.Enabled = value; }
        }

        public bool ActorSwapEnabled
        {
            get { return _itemActorSwap.Enabled; }
            set { _itemActorSwap.Enabled = value; }
        }

        public ContextMenuStrip ActorContextMenu
        {
            get { return _actorContextMenu; }
        }

        #endregion


        #region Init

        public LevelDocument( )
        {
            InitializeComponent( );

            _viewport = new ViewportControl( );
            _viewport.Dock = DockStyle.Fill;
            this.Controls.Add( _viewport );
        }

        #endregion


        #region Event Methods

        #region Actor Context Menu

        public void ActorBringToFront( object sender, EventArgs e )
        {
            ActorEdPool selectedActors = Global.SelectedLevelDoc.Viewport.SelectedActors;
            ActorEdPool actors = Global.SelectedLevel2.SelectedLayer.Actors;

            actors.Remove( selectedActors[0] );
            actors.Add( selectedActors[0] );
        }

        public void ActorSendToBack( object sender, EventArgs e )
        {
            ActorEdPool selectedActors = Global.SelectedLevelDoc.Viewport.SelectedActors;
            ActorEdPool actors = Global.SelectedLevel2.SelectedLayer.Actors;

            actors.Remove( selectedActors[0] );
            actors.Insert( 0, selectedActors[0] );
        }

        public void ActorSwap( object sender, EventArgs e )
        {
            ActorEdPool selectedActors = Global.SelectedLevelDoc.Viewport.SelectedActors;
            ActorEdPool actors = Global.SelectedLevel2.SelectedLayer.Actors;

            int[] index = new int[2]
            {
                actors.IndexOf( selectedActors[0] ),
                actors.IndexOf( selectedActors[1] )
            };

            ActorEd actor = actors[index[0]];
            actors[index[0]] = actors[index[1]];
            actors[index[1]] = actor;
        }

        #endregion

        /// <summary>
        /// Not WORKING!!! Move this method to the MainWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LevelDoc_KeyPress( object sender, KeyPressEventArgs e )
        {
            Forms.Main_Window.ToolsDock tools = Global.Tools;
            if( e.KeyChar == ' ' && tools.SelectToolEnabled )
            {
                tools.IsSelectionMode = !tools.IsSelectionMode;
                return;
            }
            if( (e.KeyChar == 'g' || e.KeyChar == 'G') && tools.ToggleGridEnabled )
            {
                tools.DrawsGrid = !tools.DrawsGrid;
                return;
            }
            if( (e.KeyChar == 'z' || e.KeyChar == 'Z') && tools.ToggleZonesEnabled )
            {
                tools.DrawsZones = !tools.DrawsZones;
                return;
            }
            if( (e.KeyChar == 'l' || e.KeyChar == 'L') && tools.ToggleLightingEnabled )
            {
                tools.DrawsLight = !tools.DrawsLight;
                return;
            }
            if( (e.KeyChar == 'e' || e.KeyChar == 'E') && tools.ToggleEffectsEnabled )
            {
                tools.DrawsEffects = !tools.DrawsEffects;
                return;
            }
        }

        private void _itemActorProperties_Click( object sender, EventArgs e )
        {
            Global.MainWindow.ShowProperties( );
        }

        private void _itemActorCut_Click( object sender, EventArgs e )
        {
            ActorCut( );
        }

        private void _itemActorCopy_Click( object sender, EventArgs e )
        {
            ActorCopy( );
        }

        private void _itemActorDelete_Click( object sender, EventArgs e )
        {
            ActorDelete( );
        }

        #endregion


        #region Methods

        /// <summary>
        /// Saves the level data into the file.
        /// </summary>
        public void Save( )
        {
            _level.Save( );
            this.Text = _level.Name;
        }


        public void ShowActorContextMenu( int x, int y )
        {
            _actorContextMenu.Show( x, y );
        }

        public void ActorCut( )
        {
            _viewport.CutActors( );
        }

        public void ActorCopy( )
        {
            _viewport.CopyActors( );
        }

        public void ActorPaste( )
        {
            _viewport.PasteActors( );
        }

        public void ActorDelete( )
        {
            _viewport.DeleteSelectedActors( );
        }

        protected virtual void DisposeResources( )
        {
            _viewport.Dispose( );
            _level = null;
        }

        #endregion
    }
}
