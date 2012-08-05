namespace LunarDevKit.Forms
{
    partial class ProgressWindow
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
            this.messageLabel = new System.Windows.Forms.Label( );
            this.progressBar = new System.Windows.Forms.ProgressBar( );
            this.shutdownTimer = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout( );
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point( 12, 9 );
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size( 78, 13 );
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Loading Status";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.progressBar.Location = new System.Drawing.Point( 12, 29 );
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size( 325, 13 );
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // shutdownTimer
            // 
            this.shutdownTimer.Interval = 400;
            this.shutdownTimer.Tick += new System.EventHandler( this.shutdownTimer_Tick );
            // 
            // ProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 349, 54 );
            this.ControlBox = false;
            this.Controls.Add( this.progressBar );
            this.Controls.Add( this.messageLabel );
            this.Name = "ProgressWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressWindow";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer shutdownTimer;
    }
}