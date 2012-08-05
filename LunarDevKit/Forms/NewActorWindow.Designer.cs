namespace LunarDevKit.Forms
{
    partial class NewActorWindow
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
            if( disposing && (components != null) )
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
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this._comboScriptList = new System.Windows.Forms.ComboBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this._upDownRotation = new System.Windows.Forms.NumericUpDown( );
            this.label2 = new System.Windows.Forms.Label( );
            this._upDownScale = new System.Windows.Forms.NumericUpDown( );
            this.spriteGroup = new System.Windows.Forms.GroupBox( );
            this.groupBox3 = new System.Windows.Forms.GroupBox( );
            this._txtOriginY = new System.Windows.Forms.TextBox( );
            this._lblOriginY = new System.Windows.Forms.Label( );
            this._txtOriginX = new System.Windows.Forms.TextBox( );
            this._lblOriginX = new System.Windows.Forms.Label( );
            this._checkOriginCenter = new System.Windows.Forms.CheckBox( );
            this._imageSprite = new System.Windows.Forms.PictureBox( );
            this._spriteListContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this._itemNoSprite = new System.Windows.Forms.ToolStripMenuItem( );
            this._txtActorName = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this._btnCancel = new System.Windows.Forms.Button( );
            this._btnCreate = new System.Windows.Forms.Button( );
            this.textGroup = new System.Windows.Forms.GroupBox( );
            this._checkIsTextActor = new System.Windows.Forms.CheckBox( );
            this._comboFontList = new System.Windows.Forms.ComboBox( );
            this.label5 = new System.Windows.Forms.Label( );
            this.label6 = new System.Windows.Forms.Label( );
            this._txtActorText = new System.Windows.Forms.TextBox( );
            this.groupBox2.SuspendLayout( );
            ((System.ComponentModel.ISupportInitialize)(this._upDownRotation)).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)(this._upDownScale)).BeginInit( );
            this.spriteGroup.SuspendLayout( );
            this.groupBox3.SuspendLayout( );
            ((System.ComponentModel.ISupportInitialize)(this._imageSprite)).BeginInit( );
            this._spriteListContextMenu.SuspendLayout( );
            this.textGroup.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add( this._comboScriptList );
            this.groupBox2.Controls.Add( this.label4 );
            this.groupBox2.Controls.Add( this.label3 );
            this.groupBox2.Controls.Add( this._upDownRotation );
            this.groupBox2.Controls.Add( this.label2 );
            this.groupBox2.Controls.Add( this._upDownScale );
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point( 242, 37 );
            this.groupBox2.Margin = new System.Windows.Forms.Padding( 4 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding( 4 );
            this.groupBox2.Size = new System.Drawing.Size( 267, 116 );
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // _comboScriptList
            // 
            this._comboScriptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboScriptList.FormattingEnabled = true;
            this._comboScriptList.Location = new System.Drawing.Point( 72, 81 );
            this._comboScriptList.MaxDropDownItems = 20;
            this._comboScriptList.Name = "_comboScriptList";
            this._comboScriptList.Size = new System.Drawing.Size( 188, 24 );
            this._comboScriptList.Sorted = true;
            this._comboScriptList.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 8, 82 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 48, 17 );
            this.label4.TabIndex = 26;
            this.label4.Text = "Script:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 8, 53 );
            this.label3.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 65, 17 );
            this.label3.TabIndex = 9;
            this.label3.Text = "Rotation:";
            // 
            // _upDownRotation
            // 
            this._upDownRotation.DecimalPlaces = 2;
            this._upDownRotation.Increment = new decimal( new int[] {
            5,
            0,
            0,
            0} );
            this._upDownRotation.Location = new System.Drawing.Point( 72, 52 );
            this._upDownRotation.Margin = new System.Windows.Forms.Padding( 4 );
            this._upDownRotation.Maximum = new decimal( new int[] {
            360,
            0,
            0,
            0} );
            this._upDownRotation.Name = "_upDownRotation";
            this._upDownRotation.Size = new System.Drawing.Size( 72, 22 );
            this._upDownRotation.TabIndex = 8;
            this._upDownRotation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 8, 23 );
            this.label2.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 47, 17 );
            this.label2.TabIndex = 7;
            this.label2.Text = "Scale:";
            // 
            // _upDownScale
            // 
            this._upDownScale.DecimalPlaces = 2;
            this._upDownScale.Increment = new decimal( new int[] {
            25,
            0,
            0,
            131072} );
            this._upDownScale.Location = new System.Drawing.Point( 72, 23 );
            this._upDownScale.Margin = new System.Windows.Forms.Padding( 4 );
            this._upDownScale.Maximum = new decimal( new int[] {
            50,
            0,
            0,
            0} );
            this._upDownScale.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
            this._upDownScale.Name = "_upDownScale";
            this._upDownScale.Size = new System.Drawing.Size( 72, 22 );
            this._upDownScale.TabIndex = 1;
            this._upDownScale.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this._upDownScale.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            // 
            // spriteGroup
            // 
            this.spriteGroup.Controls.Add( this.groupBox3 );
            this.spriteGroup.Controls.Add( this._imageSprite );
            this.spriteGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spriteGroup.Location = new System.Drawing.Point( 13, 75 );
            this.spriteGroup.Margin = new System.Windows.Forms.Padding( 4 );
            this.spriteGroup.Name = "spriteGroup";
            this.spriteGroup.Padding = new System.Windows.Forms.Padding( 4 );
            this.spriteGroup.Size = new System.Drawing.Size( 217, 318 );
            this.spriteGroup.TabIndex = 21;
            this.spriteGroup.TabStop = false;
            this.spriteGroup.Text = "Sprite";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add( this._txtOriginY );
            this.groupBox3.Controls.Add( this._lblOriginY );
            this.groupBox3.Controls.Add( this._txtOriginX );
            this.groupBox3.Controls.Add( this._lblOriginX );
            this.groupBox3.Controls.Add( this._checkOriginCenter );
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point( 8, 219 );
            this.groupBox3.Margin = new System.Windows.Forms.Padding( 4 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding( 4 );
            this.groupBox3.Size = new System.Drawing.Size( 201, 90 );
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origin";
            // 
            // _txtOriginY
            // 
            this._txtOriginY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOriginY.Location = new System.Drawing.Point( 139, 55 );
            this._txtOriginY.Margin = new System.Windows.Forms.Padding( 4 );
            this._txtOriginY.Name = "_txtOriginY";
            this._txtOriginY.Size = new System.Drawing.Size( 52, 22 );
            this._txtOriginY.TabIndex = 14;
            this._txtOriginY.Text = "0";
            // 
            // _lblOriginY
            // 
            this._lblOriginY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblOriginY.AutoSize = true;
            this._lblOriginY.Location = new System.Drawing.Point( 112, 59 );
            this._lblOriginY.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this._lblOriginY.Name = "_lblOriginY";
            this._lblOriginY.Size = new System.Drawing.Size( 21, 17 );
            this._lblOriginY.TabIndex = 13;
            this._lblOriginY.Text = "Y:";
            // 
            // _txtOriginX
            // 
            this._txtOriginX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._txtOriginX.Location = new System.Drawing.Point( 35, 55 );
            this._txtOriginX.Margin = new System.Windows.Forms.Padding( 4 );
            this._txtOriginX.Name = "_txtOriginX";
            this._txtOriginX.Size = new System.Drawing.Size( 52, 22 );
            this._txtOriginX.TabIndex = 12;
            this._txtOriginX.Text = "0";
            // 
            // _lblOriginX
            // 
            this._lblOriginX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblOriginX.AutoSize = true;
            this._lblOriginX.Location = new System.Drawing.Point( 8, 59 );
            this._lblOriginX.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this._lblOriginX.Name = "_lblOriginX";
            this._lblOriginX.Size = new System.Drawing.Size( 21, 17 );
            this._lblOriginX.TabIndex = 6;
            this._lblOriginX.Text = "X:";
            // 
            // _checkOriginCenter
            // 
            this._checkOriginCenter.AutoSize = true;
            this._checkOriginCenter.Location = new System.Drawing.Point( 8, 23 );
            this._checkOriginCenter.Margin = new System.Windows.Forms.Padding( 4 );
            this._checkOriginCenter.Name = "_checkOriginCenter";
            this._checkOriginCenter.Size = new System.Drawing.Size( 72, 21 );
            this._checkOriginCenter.TabIndex = 5;
            this._checkOriginCenter.Text = "Center";
            this._checkOriginCenter.UseVisualStyleBackColor = true;
            this._checkOriginCenter.CheckedChanged += new System.EventHandler( this.originCenterCheckBox_CheckedChanged );
            // 
            // _imageSprite
            // 
            this._imageSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imageSprite.ContextMenuStrip = this._spriteListContextMenu;
            this._imageSprite.Location = new System.Drawing.Point( 8, 23 );
            this._imageSprite.Margin = new System.Windows.Forms.Padding( 4 );
            this._imageSprite.Name = "_imageSprite";
            this._imageSprite.Size = new System.Drawing.Size( 201, 185 );
            this._imageSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imageSprite.TabIndex = 3;
            this._imageSprite.TabStop = false;
            // 
            // _spriteListContextMenu
            // 
            this._spriteListContextMenu.ImageScalingSize = new System.Drawing.Size( 24, 24 );
            this._spriteListContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._itemNoSprite} );
            this._spriteListContextMenu.Name = "spriteListContextMenu";
            this._spriteListContextMenu.Size = new System.Drawing.Size( 162, 28 );
            // 
            // _itemNoSprite
            // 
            this._itemNoSprite.Name = "_itemNoSprite";
            this._itemNoSprite.Size = new System.Drawing.Size( 161, 24 );
            this._itemNoSprite.Text = "<No Sprite>";
            this._itemNoSprite.Click += new System.EventHandler( this.NoSpriteMenuItem_Click );
            // 
            // _txtActorName
            // 
            this._txtActorName.Location = new System.Drawing.Point( 72, 5 );
            this._txtActorName.Margin = new System.Windows.Forms.Padding( 4 );
            this._txtActorName.Name = "_txtActorName";
            this._txtActorName.Size = new System.Drawing.Size( 144, 22 );
            this._txtActorName.TabIndex = 20;
            this._txtActorName.Text = "<Actor Name>";
            this._txtActorName.TextChanged += new System.EventHandler( this.ActorNameText_TextChanged );
            this._txtActorName.Click += new System.EventHandler( this.ActorNameText_TextChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point( 13, 9 );
            this.label1.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 49, 17 );
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point( 417, 367 );
            this._btnCancel.Margin = new System.Windows.Forms.Padding( 4 );
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size( 91, 26 );
            this._btnCancel.TabIndex = 24;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler( this._btnCancel_Click );
            // 
            // _btnCreate
            // 
            this._btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCreate.Enabled = false;
            this._btnCreate.Location = new System.Drawing.Point( 314, 367 );
            this._btnCreate.Margin = new System.Windows.Forms.Padding( 4 );
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size( 91, 26 );
            this._btnCreate.TabIndex = 23;
            this._btnCreate.Text = "Create";
            this._btnCreate.UseVisualStyleBackColor = true;
            this._btnCreate.Click += new System.EventHandler( this._btnCreate_Click );
            // 
            // textGroup
            // 
            this.textGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textGroup.Controls.Add( this._txtActorText );
            this.textGroup.Controls.Add( this.label6 );
            this.textGroup.Controls.Add( this._comboFontList );
            this.textGroup.Controls.Add( this.label5 );
            this.textGroup.Enabled = false;
            this.textGroup.Location = new System.Drawing.Point( 243, 161 );
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size( 265, 193 );
            this.textGroup.TabIndex = 25;
            this.textGroup.TabStop = false;
            this.textGroup.Text = "Text Actor";
            // 
            // _checkIsTextActor
            // 
            this._checkIsTextActor.AutoSize = true;
            this._checkIsTextActor.Location = new System.Drawing.Point( 16, 34 );
            this._checkIsTextActor.Name = "_checkIsTextActor";
            this._checkIsTextActor.Size = new System.Drawing.Size( 172, 21 );
            this._checkIsTextActor.TabIndex = 0;
            this._checkIsTextActor.Text = "Text instead of Sprite?";
            this._checkIsTextActor.UseVisualStyleBackColor = true;
            this._checkIsTextActor.CheckedChanged += new System.EventHandler( this._checkIsTextActor_CheckedChanged );
            // 
            // _comboFontList
            // 
            this._comboFontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFontList.FormattingEnabled = true;
            this._comboFontList.Location = new System.Drawing.Point( 71, 21 );
            this._comboFontList.MaxDropDownItems = 20;
            this._comboFontList.Name = "_comboFontList";
            this._comboFontList.Size = new System.Drawing.Size( 188, 24 );
            this._comboFontList.Sorted = true;
            this._comboFontList.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 7, 22 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 40, 17 );
            this.label5.TabIndex = 28;
            this.label5.Text = "Font:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 7, 57 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 39, 17 );
            this.label6.TabIndex = 30;
            this.label6.Text = "Text:";
            // 
            // _txtActorText
            // 
            this._txtActorText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtActorText.Location = new System.Drawing.Point( 8, 83 );
            this._txtActorText.Multiline = true;
            this._txtActorText.Name = "_txtActorText";
            this._txtActorText.Size = new System.Drawing.Size( 250, 100 );
            this._txtActorText.TabIndex = 31;
            this._txtActorText.WordWrap = false;
            // 
            // NewActorWindow
            // 
            this.AcceptButton = this._btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size( 521, 406 );
            this.Controls.Add( this._checkIsTextActor );
            this.Controls.Add( this.textGroup );
            this.Controls.Add( this._btnCancel );
            this.Controls.Add( this._btnCreate );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.spriteGroup );
            this.Controls.Add( this._txtActorName );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewActorWindow";
            this.ShowInTaskbar = false;
            this.Text = "New Actor";
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout( );
            ((System.ComponentModel.ISupportInitialize)(this._upDownRotation)).EndInit( );
            ((System.ComponentModel.ISupportInitialize)(this._upDownScale)).EndInit( );
            this.spriteGroup.ResumeLayout( false );
            this.groupBox3.ResumeLayout( false );
            this.groupBox3.PerformLayout( );
            ((System.ComponentModel.ISupportInitialize)(this._imageSprite)).EndInit( );
            this._spriteListContextMenu.ResumeLayout( false );
            this.textGroup.ResumeLayout( false );
            this.textGroup.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _upDownRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _upDownScale;
        private System.Windows.Forms.GroupBox spriteGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtOriginY;
        private System.Windows.Forms.Label _lblOriginY;
        private System.Windows.Forms.TextBox _txtOriginX;
        private System.Windows.Forms.Label _lblOriginX;
        private System.Windows.Forms.CheckBox _checkOriginCenter;
        private System.Windows.Forms.PictureBox _imageSprite;
        private System.Windows.Forms.TextBox _txtActorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.ContextMenuStrip _spriteListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _itemNoSprite;
        private System.Windows.Forms.ComboBox _comboScriptList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.CheckBox _checkIsTextActor;
        private System.Windows.Forms.TextBox _txtActorText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _comboFontList;
        private System.Windows.Forms.Label label5;
    }
}