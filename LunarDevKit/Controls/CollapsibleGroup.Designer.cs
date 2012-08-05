namespace LunarDevKit.Controls
{
    partial class CollapsibleGroup
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
            this._titleBar = new System.Windows.Forms.Panel( );
            this._editTitleButton = new System.Windows.Forms.Button( );
            this._collapseButton = new System.Windows.Forms.Button( );
            this._titleLabel = new System.Windows.Forms.Label( );
            this._controlsPanel = new System.Windows.Forms.FlowLayoutPanel( );
            this._titleBar.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _titleBar
            // 
            this._titleBar.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._titleBar.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 57 ) ) ) ), ( (int)( ( (byte)( 57 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ) );
            this._titleBar.BackgroundImage = global::LunarDevKit.Properties.Resources.brdr;
            this._titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._titleBar.Controls.Add( this._editTitleButton );
            this._titleBar.Controls.Add( this._collapseButton );
            this._titleBar.Controls.Add( this._titleLabel );
            this._titleBar.Location = new System.Drawing.Point( 0, 0 );
            this._titleBar.MinimumSize = new System.Drawing.Size( 50, 20 );
            this._titleBar.Name = "_titleBar";
            this._titleBar.Size = new System.Drawing.Size( 239, 20 );
            this._titleBar.TabIndex = 13;
            this._titleBar.MouseClick += new System.Windows.Forms.MouseEventHandler( this.Group_MouseClick );
            // 
            // _editTitleButton
            // 
            this._editTitleButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._editTitleButton.BackColor = System.Drawing.Color.Transparent;
            this._editTitleButton.BackgroundImage = global::LunarDevKit.Properties.Resources.NoSprite16;
            this._editTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._editTitleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 115 ) ) ) ), ( (int)( ( (byte)( 115 ) ) ) ), ( (int)( ( (byte)( 132 ) ) ) ) );
            this._editTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editTitleButton.Location = new System.Drawing.Point( 188, 3 );
            this._editTitleButton.Name = "_editTitleButton";
            this._editTitleButton.Size = new System.Drawing.Size( 21, 11 );
            this._editTitleButton.TabIndex = 9;
            this._editTitleButton.UseVisualStyleBackColor = false;
            this._editTitleButton.Click += new System.EventHandler( this.editTitle_Click );
            // 
            // _collapseButton
            // 
            this._collapseButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._collapseButton.BackColor = System.Drawing.Color.Transparent;
            this._collapseButton.BackgroundImage = global::LunarDevKit.Properties.Resources.ArrwDwn;
            this._collapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._collapseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 115 ) ) ) ), ( (int)( ( (byte)( 115 ) ) ) ), ( (int)( ( (byte)( 132 ) ) ) ) );
            this._collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._collapseButton.Location = new System.Drawing.Point( 215, 3 );
            this._collapseButton.Name = "_collapseButton";
            this._collapseButton.Size = new System.Drawing.Size( 21, 11 );
            this._collapseButton.TabIndex = 8;
            this._collapseButton.UseVisualStyleBackColor = false;
            this._collapseButton.Click += new System.EventHandler( this.collapseButton_Click );
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.BackColor = System.Drawing.Color.Transparent;
            this._titleLabel.Font = new System.Drawing.Font( "Estrangelo Edessa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this._titleLabel.ForeColor = System.Drawing.Color.LightGray;
            this._titleLabel.Location = new System.Drawing.Point( 3, 3 );
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size( 75, 14 );
            this._titleLabel.TabIndex = 1;
            this._titleLabel.Text = "Group Name";
            this._titleLabel.MouseClick += new System.Windows.Forms.MouseEventHandler( this.Group_MouseClick );
            // 
            // _controlsPanel
            // 
            this._controlsPanel.AllowDrop = true;
            this._controlsPanel.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._controlsPanel.AutoScroll = true;
            this._controlsPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ), ( (int)( ( (byte)( 50 ) ) ) ) );
            this._controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._controlsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._controlsPanel.Location = new System.Drawing.Point( 0, 20 );
            this._controlsPanel.MinimumSize = new System.Drawing.Size( 239, 205 );
            this._controlsPanel.Name = "_controlsPanel";
            this._controlsPanel.Size = new System.Drawing.Size( 239, 212 );
            this._controlsPanel.TabIndex = 14;
            this._controlsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler( this.Group_MouseClick );
            // 
            // CollapsibleGroup
            // 
            this.Controls.Add( this._titleBar );
            this.Controls.Add( this._controlsPanel );
            this.Name = "CollapsibleGroup";
            this.Size = new System.Drawing.Size( 239, 232 );
            this._titleBar.ResumeLayout( false );
            this._titleBar.PerformLayout( );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel _titleBar;
        private System.Windows.Forms.Button _collapseButton;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.FlowLayoutPanel _controlsPanel;
        private System.Windows.Forms.Button _editTitleButton;
    }
}
