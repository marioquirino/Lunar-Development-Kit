namespace LunarDevKit.Controls
{
    partial class TitleBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label( );
            this.CloseBox = new System.Windows.Forms.PictureBox( );
            this.MaximizeBox = new System.Windows.Forms.PictureBox( );
            this.MinimizeBox = new System.Windows.Forms.PictureBox( );
            this.panel1 = new System.Windows.Forms.Panel( );
            this.panel2 = new System.Windows.Forms.Panel( );
            this.panel3 = new System.Windows.Forms.Panel( );
            this.iconBox = new System.Windows.Forms.PictureBox( );
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBox)).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit( );
            this.SuspendLayout( );
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.titleLabel.Location = new System.Drawing.Point( 44, 11 );
            this.titleLabel.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size( 40, 17 );
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.Image = global::LunarDevKit.Properties.Resources.Close;
            this.CloseBox.Location = new System.Drawing.Point( 332, 11 );
            this.CloseBox.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size( 16, 15 );
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 2;
            this.CloseBox.TabStop = false;
            this.CloseBox.MouseLeave += new System.EventHandler( this.CloseBox_MouseLeave );
            this.CloseBox.Click += new System.EventHandler( this.CloseBox_Click );
            this.CloseBox.MouseHover += new System.EventHandler( this.CloseBox_MouseHover );
            // 
            // MaximizeBox
            // 
            this.MaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBox.Image = global::LunarDevKit.Properties.Resources.Maximize;
            this.MaximizeBox.Location = new System.Drawing.Point( 308, 11 );
            this.MaximizeBox.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.MaximizeBox.Name = "MaximizeBox";
            this.MaximizeBox.Size = new System.Drawing.Size( 16, 15 );
            this.MaximizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizeBox.TabIndex = 3;
            this.MaximizeBox.TabStop = false;
            this.MaximizeBox.MouseLeave += new System.EventHandler( this.MaximizeBox_MouseLeave );
            this.MaximizeBox.Click += new System.EventHandler( this.MaximizeBox_Click );
            this.MaximizeBox.MouseHover += new System.EventHandler( this.MaximizeBox_MouseHover );
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBox.Image = global::LunarDevKit.Properties.Resources.Minimize;
            this.MinimizeBox.Location = new System.Drawing.Point( 284, 11 );
            this.MinimizeBox.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size( 16, 15 );
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBox.TabIndex = 4;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.MouseLeave += new System.EventHandler( this.MinimizeBox_MouseLeave );
            this.MinimizeBox.Click += new System.EventHandler( this.MinimizeBox_Click );
            this.MinimizeBox.MouseHover += new System.EventHandler( this.MinimizeBox_MouseHover );
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(134)))) );
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel1.Location = new System.Drawing.Point( 0, 37 );
            this.panel1.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 4, 25 );
            this.panel1.TabIndex = 5;
            this.panel1.MouseLeave += new System.EventHandler( this.panel1_MouseLeave );
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler( this.panel1_MouseMove );
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseDown );
            this.panel1.MouseHover += new System.EventHandler( this.panel1_MouseHover );
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseUp );
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(134)))) );
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel2.Location = new System.Drawing.Point( 352, 37 );
            this.panel2.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 4, 25 );
            this.panel2.TabIndex = 6;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler( this.panel2_MouseMove );
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseDown );
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseUp );
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::LunarDevKit.Properties.Resources.Brdr3x;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point( 0, 0 );
            this.panel3.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size( 356, 4 );
            this.panel3.TabIndex = 7;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseMove );
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseDown );
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler( this.panel3_MouseUp );
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Image = global::LunarDevKit.Properties.Resources.NoSprite;
            this.iconBox.InitialImage = global::LunarDevKit.Properties.Resources.NoSprite;
            this.iconBox.Location = new System.Drawing.Point( 4, 5 );
            this.iconBox.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size( 32, 30 );
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 8;
            this.iconBox.TabStop = false;
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))) );
            this.BackgroundImage = global::LunarDevKit.Properties.Resources.brdr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add( this.iconBox );
            this.Controls.Add( this.panel3 );
            this.Controls.Add( this.panel2 );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.MinimizeBox );
            this.Controls.Add( this.MaximizeBox );
            this.Controls.Add( this.CloseBox );
            this.Controls.Add( this.titleLabel );
            this.ForeColor = System.Drawing.Color.FromArgb( ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))) );
            this.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.MaximumSize = new System.Drawing.Size( 6667, 62 );
            this.MinimumSize = new System.Drawing.Size( 133, 0 );
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size( 356, 39 );
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit( );
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBox)).EndInit( );
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit( );
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox MaximizeBox;
        private System.Windows.Forms.PictureBox MinimizeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconBox;
    }
}
