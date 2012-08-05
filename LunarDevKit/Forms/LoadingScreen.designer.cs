namespace LunarDevKit.Forms
{
    partial class LoadingScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( LoadingScreen ) );
            this.timer = new System.Windows.Forms.Timer( this.components );
            this.progressBar1 = new System.Windows.Forms.ProgressBar( );
            this.opacityTimer = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout( );
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler( this.timer_Tick );
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point( 12, 340 );
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size( 670, 6 );
            this.progressBar1.TabIndex = 0;
            // 
            // opacityTimer
            // 
            this.opacityTimer.Interval = 30;
            this.opacityTimer.Tick += new System.EventHandler( this.opacityTimer_Tick );
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject( "$this.BackgroundImage" ) ) );
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size( 694, 358 );
            this.Controls.Add( this.progressBar1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer opacityTimer;
    }
}