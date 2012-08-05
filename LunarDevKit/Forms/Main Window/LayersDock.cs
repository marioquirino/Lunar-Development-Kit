using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace LunarDevKit.Forms
{
    using Classes;

    public partial class LayersDock : DockContent
    {
        public LayersDock( )
        {
            InitializeComponent( );

            Owner = Global.MainWindow;
        }

        #region Event Methods

        private void LayersWindow_VisibleChanged( object sender, EventArgs e )
        {
            if ( this.Visible )
            {
                RefreshList( );
            }
        }

        private void LayersWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            e.Cancel = true;
            this.Hide( );
        }

        private void ListLayers_MouseClick( object sender, MouseEventArgs e )
        {
            int index = _listLayers.IndexFromPoint( e.Location );
            if( index != ListBox.NoMatches )
                _listLayers.SelectedIndex = index;
        }

        private void ListLayers_SelectedIndexChanged( object sender, EventArgs e )
        {
            LayerItem item = _listLayers.SelectedItem as LayerItem;
            if( item != null )
            {
                Global.SelectedLevel2.SelectedLayer = item.Layer;
                Global.Properties.SelectObject( item.Layer.Properties );
            }

        }

        private void Layer_NameChanged( object sender, EventArgs e )
        {
            RefreshLayer( sender as LayerEd );
        }

        #region Button Events

        private void newLayerButton_Click( object sender, EventArgs e )
        {
            AddLayerItem( new LayerItem( Global.SelectedLevel2.NewLayer( ) ) );
        }

        private void deleteLayerButton_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( Global.EditorTxt.LayerDeletePrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                return;

            LayerItem item = (LayerItem)_listLayers.SelectedItem;
            int index = _listLayers.Items.IndexOf( item ) - 1;
            if( index < 0 )
                index = 0;
            RemoveLayerItem( item );
            _listLayers.SelectedIndex = index;
        }

        private void layerGoUpButton_Click( object sender, EventArgs e )
        {
            LayerItem item = (LayerItem)_listLayers.SelectedItem;
            int index = Global.SelectedLevel2.Layers.IndexOf( item.Layer );

            if ( index == Global.SelectedLevel2.Layers.Count )
                return;

            Global.SelectedLevel2.Layers.Remove( item.Layer );
            _listLayers.Items.Remove( item );

            if( index + 1 >= Global.SelectedLevel2.Layers.Count )
                Global.SelectedLevel2.Layers.Add( item.Layer );
            else
                Global.SelectedLevel2.Layers.Insert( index + 1, item.Layer );

            RefreshList( );

            SelectLayer( item.Layer );
        }

        private void layerGoDownButton_Click( object sender, EventArgs e )
        {
            LayerItem item = (LayerItem)_listLayers.SelectedItem;
            int index = Global.SelectedLevel2.Layers.IndexOf( item.Layer );

            if ( index == 0 )
                return;

            Global.SelectedLevel2.Layers.Remove( item.Layer );

            Global.SelectedLevel2.Layers.Insert( index - 1, item.Layer );

            RefreshList( );
            SelectLayer( item.Layer );
        }

        #endregion

        #endregion

        #region Methods

        private void AddLayerItem( LayerItem item )
        {
            _listLayers.Items.Insert( 0, item );
            _listLayers.SelectedItem = item;
            item.Layer.NameChanged += new EventHandler( Layer_NameChanged );

            _btnLayerDelete.Enabled = ( _listLayers.Items.Count > 1 );
        }

        private void RemoveLayerItem( LayerItem item )
        {
            Global.SelectedLevel2.DeleteLayer( item.Layer );
            _listLayers.Items.Remove( item );

            _btnLayerDelete.Enabled = ( _listLayers.Items.Count > 1 );
        }

        public void RefreshList( )
        {
            _listLayers.Items.Clear( );

            if( Global.SelectedLevel2 != null )
            {
                foreach( LayerEd layer in Global.SelectedLevel2.Layers )
                {
                    AddLayerItem( new LayerItem( layer ) );
                }
            }
        }

        public void RefreshLayer( LayerEd layer )
        {
            int index = GetLayerItemIndex( layer );
            if( index != ListBox.NoMatches )
            {
                _listLayers.RefreshItem( index );
                _listLayers.SelectedIndex = index;
            }
        }

        private void SelectLayer( LayerEd layer )
        {
            LayerItem item = GetLayerItem( layer );
            if( item != null )
                _listLayers.SelectedItem = item;
        }

        private LayerItem GetLayerItem( LayerEd layer )
        {
            foreach( LayerItem item in _listLayers.Items )
            {
                if( item.Layer == layer )
                    return item;
            }
            return null;
        }

        private int GetLayerItemIndex( LayerEd layer )
        {
            for( int i = 0; i < _listLayers.Items.Count; i++ )
            {
                if( ( _listLayers.Items[i] as LayerItem ).Layer == layer )
                    return i;
            }
            return ListBox.NoMatches;
        }

        #endregion
    }
}
