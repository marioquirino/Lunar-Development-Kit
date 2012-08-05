using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace LunarDevKit.Forms.Main_Window
{
    public partial class PropertiesDock : DockContent
    {
        public PropertiesDock( )
        {
            InitializeComponent( );
        }

        public void RefreshGrid( )
        {
            _grid.Refresh( );
        }

        public void SelectObject( object obj )
        {
            _grid.SelectedObject = obj;
            UpdateTitle( );
        }

        public void AddObjectToSelection( object obj )
        {
            if( _grid.SelectedObject == null )
            {
                _grid.SelectedObject = obj;
                UpdateTitle( );
                return;
            }

            int size = _grid.SelectedObjects.Length + 1;
            object[] objects = new object[size];
            for( int i = 0; i < _grid.SelectedObjects.Length; i++ )
            {
                objects[i] = _grid.SelectedObjects[i];
            }
            objects[size - 1] = obj;

            _grid.SelectedObjects = objects;
            UpdateTitle( );
        }

        public void UnselectObject( object obj )
        {
            if( _grid.SelectedObject == null )
                return;

            if( _grid.SelectedObjects.Length == 1 && _grid.SelectedObject == obj )
            {
                _grid.SelectedObject = null;
                UpdateTitle( );
                return;
            }

            int size = _grid.SelectedObjects.Length - 1;
            object[] objs = new object[size];
            int i = 0;
            foreach( object obj2 in _grid.SelectedObjects )
            {
                if( obj != obj2 )
                {
                    objs[i] = obj2;
                    i++;
                }
            }

            _grid.SelectedObjects = objs;
            UpdateTitle( );
        }

        public void UnselectAllObjects( )
        {
            _grid.SelectedObject = null;
            UpdateTitle( );
        }

        public void UpdateTitle( )
        {
            if( _grid.SelectedObject == null )
            {
                this.Text = Global.EditorTxt.PropertiesName + " - <" + Global.EditorTxt.NoObjectSelected + ">";
                return;
            }

            this.Text = Global.EditorTxt.PropertiesName + " - ";
            for( int i = 0; i < _grid.SelectedObjects.Length; i++ )
            {
                this.Text += ( _grid.SelectedObjects[i] as IEdObject ).Name;

                if( i == _grid.SelectedObjects.Length - 1 )
                    break;

                this.Text += ", ";
            }
        }
    }
}
