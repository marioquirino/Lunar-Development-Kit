using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    public partial class TitleBar : UserControl
    {
        #region Fields

        Form _form;
        event EventHandler mDown;
        event EventHandler mMoveL;
        event EventHandler mMoveR;
        event EventHandler mMoveT;
        event EventHandler mUp;

        #endregion

        #region Properties

        public new Form ParentForm
        {
            get { return this._form; }
            set { this._form = value; }
        }

        public Image Icon
        {
            get { return iconBox.Image; }
            set { this.iconBox.Image = value; }
        }

        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        public bool MinimizeBoxEnabled
        {
            get { return MinimizeBox.Visible; }
            set { MinimizeBox.Visible = value; }
        }

        public bool MaximizeBoxEnabled
        {
            get { return MaximizeBox.Visible; }
            set { MaximizeBox.Visible = value; }
        }

        #endregion

        public TitleBar( )
        {
            InitializeComponent();
            _form = new Form( ); // temp
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            _form.Close();
        }
        private void MaximizeBox_Click(object sender, EventArgs e)
        {
            if (_form.WindowState == FormWindowState.Normal)
            {
                _form.WindowState = FormWindowState.Maximized;
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.Maximize;
            }
            else
            {
                _form.WindowState = FormWindowState.Normal;
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.Shrink;
            }
        }
        private void MinimizeBox_Click(object sender, EventArgs e)
        {
            _form.WindowState = FormWindowState.Minimized;
        }

        private void CloseBox_MouseHover(object sender, EventArgs e)
        {
            CloseBox.Image = global::LunarDevKit.Properties.Resources.CloseHover;
            //this.Refresh();
        }
        private void MaximizeBox_MouseHover(object sender, EventArgs e)
        {
            if (_form.WindowState == FormWindowState.Maximized)
            {
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.ShrinkHover; 
            }
            else if (_form.WindowState == FormWindowState.Normal)
            {
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.MaximizeHover; 
            }
            //this.Refresh();
        }
        private void MinimizeBox_MouseHover(object sender, EventArgs e)
        {
            MinimizeBox.Image = global::LunarDevKit.Properties.Resources.MinimizeHover;
            //this.Refresh();
        }

        private void CloseBox_MouseLeave(object sender, EventArgs e)
        {
            CloseBox.Image = global::LunarDevKit.Properties.Resources.Close;
        }
        private void MaximizeBox_MouseLeave(object sender, EventArgs e)
        {
            if (_form.WindowState == FormWindowState.Maximized)
            {
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.Shrink;
            }
            else if (_form.WindowState == FormWindowState.Normal)
            {
                MaximizeBox.Image = global::LunarDevKit.Properties.Resources.Maximize;
            }
        }
        private void MinimizeBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBox.Image = global::LunarDevKit.Properties.Resources.Minimize;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (mDown != null)
                mDown(this, EventArgs.Empty);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mMoveL != null)
                mMoveL(this, EventArgs.Empty);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mMoveR != null)
                mMoveR(this, EventArgs.Empty);
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mMoveT != null)
                mMoveT(this, EventArgs.Empty);
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            if (mUp != null)
                mUp(this, EventArgs.Empty);
        }
                
        public event EventHandler ResizeMouseDown
        {
            add
            {
                this.mDown += value;
            }
            remove
            {
                this.mDown -= value;
            }
        }
        public event EventHandler ResizeMouseMoveL
        {
            add
            {
                this.mMoveL += value;
            }
            remove
            {
                this.mMoveL -= value;
            }
        }
        public event EventHandler ResizeMouseMoveR
        {
            add
            {
                this.mMoveR += value;
            }
            remove
            {
                this.mMoveR -= value;
            }
        }
        public event EventHandler ResizeMouseMoveT
        {
            add
            {
                this.mMoveT += value;
            }
            remove
            {
                this.mMoveT -= value;
            }
        }
        public event EventHandler ResizeMouseUp
        {
            add
            {
                this.mUp += value;
            }
            remove
            {
                this.mUp -= value;
            }
        }


        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (!(this._form.WindowState == FormWindowState.Maximized))
                this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNS;
        }
        private void panel2_MouseHover(object sender, EventArgs e)
        {
            if (!(this._form.WindowState == FormWindowState.Maximized))
                this.panel2.Cursor = System.Windows.Forms.Cursors.SizeWE;
        }
        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (!(this._form.WindowState == FormWindowState.Maximized))
                this.panel3.Cursor = System.Windows.Forms.Cursors.SizeWE;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
