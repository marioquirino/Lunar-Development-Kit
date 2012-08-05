using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace LunarDevKit.Forms.Main_Window
{
    public partial class ToolsDock : Form
    {
        #region Fields

        private ToolStripMenuItem _checkedDragSnapItem;
        private ToolStripMenuItem _checkedScaleSnapItem;
        private ToolStripMenuItem _checkedRotateSnapItem;

        private MainWindow wnd;

        #endregion

        #region Properties

        #region Grid-related Properties

        /// <summary>
        /// Gets a value determining whether the Drag Grid Snap is enabled
        /// </summary>
        public bool IsDragSnapToGrid
        {
            get { return _itemDragSnapEnable.Checked; }
        }
        public int DragSnapAmount
        {
            get
            {
                if( _checkedDragSnapItem == _itemDragSnap1Pixels )
                    return 1;
                if( _checkedDragSnapItem == _itemDragSnap2Pixels )
                    return 2;
                if( _checkedDragSnapItem == _itemDragSnap4Pixels )
                    return 4;
                if( _checkedDragSnapItem == _itemDragSnap8Pixels )
                    return 8;
                if( _checkedDragSnapItem == _itemDragSnap16Pixels )
                    return 16;
                if( _checkedDragSnapItem == _itemDragSnap32Pixels )
                    return 32;
                if( _checkedDragSnapItem == _itemDragSnap64Pixels )
                    return 64;
                if( _checkedDragSnapItem == _itemDragSnap128Pixels )
                    return 128;

                return 1;
            }
        }

        /// <summary>
        /// Gets a value determining whether the Rotate Grid Snap is enabled
        /// </summary>
        //public bool IsRotationSnapToGrid
        //{
        //    get { return rotateGridSnapButton.Checked; }
        //}
        //public float RotateSnapAmount
        //{
        //    get
        //    {
        //        if( _checkedRotateSnapItem == degrees3RotateSnapButton )
        //            return 0.06654067773228381512021571054864f;
        //        if( _checkedRotateSnapItem == degrees6RotateSnapButton )
        //            return 0.09817477042468103870195760572751f;
        //        if( _checkedRotateSnapItem == degrees11RotateSnapButton )
        //            return 0.19634954084936207740391521145501f;
        //        if( _checkedRotateSnapItem == degrees22RotateSnapButton )
        //            return 0.39269908169872415480783042291003f;
        //        if( _checkedRotateSnapItem == degrees45RotateSnapButton )
        //            return 0.78539816339744830961566084582005f;
        //        if( _checkedRotateSnapItem == degrees90RotateSnapButton )
        //            return 1.5707963267948966192313216916401f;
        //        return 0f;
        //    }
        //}

        /// <summary>
        /// Gets a value determining whether the Scale Grid Snap is enabled
        /// </summary>
        //public bool IsScaleSnapToGrid
        //{
        //    get { return scaleGridSnapButton.Checked; }
        //}
        //public int ScaleSnapAmount
        //{
        //    get
        //    {
        //        if( _checkedScaleSnapItem == percent1scaleSnapButton )
        //            return 1;
        //        if( _checkedScaleSnapItem == percent2scaleSnapButton )
        //            return 2;
        //        if( _checkedScaleSnapItem == percent5scaleSnapButton )
        //            return 5;
        //        if( _checkedScaleSnapItem == percent10scaleSnapButton )
        //            return 10;
        //        if( _checkedScaleSnapItem == percent25scaleSnapButton )
        //            return 25;
        //        if( _checkedScaleSnapItem == percent50scaleSnapButton )
        //            return 50;
        //        return 1;
        //    }
        //}

        #endregion

        public bool DrawsGrid
        {
            get { return wnd.ToggleGridItem.Checked; }
            set { wnd.ToggleGridItem.Checked = value; }
        }

        public bool DrawsZones
        {
            get { return wnd.ToggleZonesItem.Checked; }
            set { wnd.ToggleZonesItem.Checked = _btnToggleZones.Checked = value; }
        }

        public bool DrawsLight
        {
            get { return wnd.ToggleLightingItem.Checked; }
            set { wnd.ToggleLightingItem.Checked = _btnToggleLight.Checked = value; }
        }

        public bool DrawsEffects
        {
            get { return wnd.ToggleEffectsItem.Checked; }
            set { wnd.ToggleEffectsItem.Checked = _btnToggleEffects.Checked = value; }
        }

        public bool IsSelectionMode
        {
            get { return wnd.SelectionTool.Checked; }
            set { wnd.SelectionTool.Checked = _btnSelectionTool.Checked = value; }
        }



        public bool ToggleGridEnabled
        {
            get { return wnd.ToggleGridItem.Enabled; }
        }

        public bool ToggleZonesEnabled
        {
            get { return wnd.ToggleZonesItem.Enabled; }
        }

        public bool ToggleLightingEnabled
        {
            get { return wnd.ToggleLightingItem.Enabled; }
        }

        public bool ToggleEffectsEnabled
        {
            get { return wnd.ToggleEffectsItem.Enabled; }
        }

        public bool SelectToolEnabled
        {
            get { return wnd.SelectionTool.Enabled; }
            set { wnd.SelectionTool.Enabled = _btnSelectionTool.Enabled = value; }
        }

        #endregion

        #region Init

        public ToolsDock( )
        {
            InitializeComponent( );
            Owner = Global.MainWindow;
            wnd = Global.MainWindow;

            pixelsDragButton_Click( _itemDragSnap64Pixels, null );
        }

        #endregion

        #region Event Methods

        public void SelectionTool_Click( object sender, EventArgs e )
        {
            wnd.SelectionTool.Checked = _btnSelectionTool.Checked = !_btnSelectionTool.Checked;
        }

        public void ToggleGrid_Click( object sender, EventArgs e )
        {
            wnd.ToggleGridItem.Checked = !wnd.ToggleGridItem.Checked;
        }

        public void ToggleZones_Click( object sender, EventArgs e )
        {
            wnd.ToggleZonesItem.Checked = _btnToggleZones.Checked = !_btnToggleZones.Checked;
        }

        public void ToggleLight_Click( object sender, EventArgs e )
        {
            wnd.ToggleLightingItem.Checked = _btnToggleLight.Checked = !_btnToggleLight.Checked;
        }

        public void ToggleEffects_Click( object sender, EventArgs e )
        {
            wnd.ToggleEffectsItem.Checked = _btnToggleEffects.Checked = !_btnToggleEffects.Checked;
        }



        private void pixelsDragButton_Click( object sender, EventArgs e )
        {
            if( _checkedDragSnapItem != null )
                _checkedDragSnapItem.Checked = false;
            _checkedDragSnapItem = sender as ToolStripMenuItem;
            _checkedDragSnapItem.Checked = true;
        }

        private void degreesRotateSnapButton_Click( object sender, EventArgs e )
        {
            if( _checkedRotateSnapItem != null )
                _checkedRotateSnapItem.Checked = false;
            _checkedRotateSnapItem = sender as ToolStripMenuItem;
            _checkedRotateSnapItem.Checked = true;
        }

        private void percentScaleSnapButton_Click( object sender, EventArgs e )
        {
            if( _checkedScaleSnapItem != null )
                _checkedScaleSnapItem.Checked = false;
            _checkedScaleSnapItem = sender as ToolStripMenuItem;
            _checkedScaleSnapItem.Checked = true;
        }

        #endregion
    }
}
