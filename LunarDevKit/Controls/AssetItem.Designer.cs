namespace LunarDevKit.Controls
{
    partial class AssetItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this._label = new System.Windows.Forms.Label( );
            this._image = new System.Windows.Forms.PictureBox( );
            ((System.ComponentModel.ISupportInitialize)(this._image)).BeginInit( );
            this.SuspendLayout( );
            // 
            // _label
            // 
            this._label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point( 82, 31 );
            this._label.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size( 46, 17 );
            this._label.TabIndex = 2;
            this._label.Text = "label1";
            this._label.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseDoubleClick );
            this._label.MouseClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseClick );
            // 
            // _image
            // 
            this._image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._image.Location = new System.Drawing.Point( 4, 4 );
            this._image.Margin = new System.Windows.Forms.Padding( 4 );
            this._image.Name = "_image";
            this._image.Size = new System.Drawing.Size( 70, 70 );
            this._image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._image.TabIndex = 3;
            this._image.TabStop = false;
            this._image.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseDoubleClick );
            this._image.MouseClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseClick );
            // 
            // AssetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this._image );
            this.Controls.Add( this._label );
            this.Margin = new System.Windows.Forms.Padding( 4 );
            this.MinimumSize = new System.Drawing.Size( 0, 78 );
            this.Name = "AssetItem";
            this.Size = new System.Drawing.Size( 224, 78 );
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseDoubleClick );
            this.MouseClick += new System.Windows.Forms.MouseEventHandler( this.AssetItem_MouseClick );
            ((System.ComponentModel.ISupportInitialize)(this._image)).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        protected System.Windows.Forms.Label _label;
        protected System.Windows.Forms.PictureBox _image;

    }
}
