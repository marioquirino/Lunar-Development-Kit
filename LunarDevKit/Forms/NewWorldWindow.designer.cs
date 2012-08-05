namespace LunarDevKit.Forms
{
    partial class NewWorldWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( NewWorldWindow ) );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.worldNameText = new System.Windows.Forms.TextBox( );
            this.locationText = new System.Windows.Forms.TextBox( );
            this.browseButton = new System.Windows.Forms.Button( );
            this.createButton = new System.Windows.Forms.Button( );
            this.cancelButton = new System.Windows.Forms.Button( );
            this.fullPathLabel = new System.Windows.Forms.Label( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.Location = new System.Drawing.Point( 16, 11 );
            this.label1.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 52, 18 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label2.Location = new System.Drawing.Point( 16, 47 );
            this.label2.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 69, 18 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // worldNameText
            // 
            this.worldNameText.Location = new System.Drawing.Point( 116, 7 );
            this.worldNameText.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.worldNameText.Name = "worldNameText";
            this.worldNameText.Size = new System.Drawing.Size( 253, 22 );
            this.worldNameText.TabIndex = 5;
            this.worldNameText.Text = "<World Name>";
            this.worldNameText.TextChanged += new System.EventHandler( this.worldNameText_TextChanged );
            this.worldNameText.GotFocus += new System.EventHandler( this.worldNameText_GotFocus );
            this.worldNameText.LostFocus += new System.EventHandler( this.worldNameText_LostFocus );
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point( 116, 43 );
            this.locationText.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size( 423, 22 );
            this.locationText.TabIndex = 6;
            this.locationText.DoubleClick += new System.EventHandler( this.locationText_DoubleClick );
            this.locationText.TextChanged += new System.EventHandler( this.worldNameText_TextChanged );
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point( 548, 41 );
            this.browseButton.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size( 100, 28 );
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler( this.browseButton_Click );
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point( 449, 110 );
            this.createButton.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size( 91, 26 );
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler( this.createButton_Click );
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 557, 110 );
            this.cancelButton.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 91, 26 );
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // fullPathLabel
            // 
            this.fullPathLabel.AutoSize = true;
            this.fullPathLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.fullPathLabel.ForeColor = System.Drawing.Color.Gray;
            this.fullPathLabel.Location = new System.Drawing.Point( 112, 71 );
            this.fullPathLabel.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.fullPathLabel.Name = "fullPathLabel";
            this.fullPathLabel.Size = new System.Drawing.Size( 74, 15 );
            this.fullPathLabel.TabIndex = 11;
            this.fullPathLabel.Text = "Nothin\' here";
            // 
            // NewWorldWindow
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size( 664, 150 );
            this.Controls.Add( this.fullPathLabel );
            this.Controls.Add( this.cancelButton );
            this.Controls.Add( this.createButton );
            this.Controls.Add( this.browseButton );
            this.Controls.Add( this.locationText );
            this.Controls.Add( this.worldNameText );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.Margin = new System.Windows.Forms.Padding( 4, 4, 4, 4 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewWorldWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New World";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox worldNameText;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fullPathLabel;
    }
}