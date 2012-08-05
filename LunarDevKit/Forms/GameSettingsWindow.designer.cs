namespace LunarDevKit.Forms
{
    partial class GameSettingsWindow
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
            if ( disposing && ( components != null ) )
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
            this.fullscreenCheck = new System.Windows.Forms.CheckBox( );
            this.resolutionsComboBox = new System.Windows.Forms.ComboBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.widthUpDown = new System.Windows.Forms.NumericUpDown( );
            this.heightUpDown = new System.Windows.Forms.NumericUpDown( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.gameTitleText = new System.Windows.Forms.TextBox( );
            this.exitsWithEscCheck = new System.Windows.Forms.CheckBox( );
            this.saveButton = new System.Windows.Forms.Button( );
            this.cancelButton = new System.Windows.Forms.Button( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.radioButton2 = new System.Windows.Forms.RadioButton( );
            this.radioButton1 = new System.Windows.Forms.RadioButton( );
            this._tabControl = new System.Windows.Forms.TabControl( );
            this._tabMain = new System.Windows.Forms.TabPage( );
            this._tabInGame = new System.Windows.Forms.TabPage( );
            this._comboScriptList = new System.Windows.Forms.ComboBox( );
            this.label5 = new System.Windows.Forms.Label( );
            this._btnNewGameScript = new System.Windows.Forms.Button( );
            this._lblAudio = new System.Windows.Forms.Label( );
            this._btnAssignAudio = new System.Windows.Forms.Button( );
            ( (System.ComponentModel.ISupportInitialize)( this.widthUpDown ) ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)( this.heightUpDown ) ).BeginInit( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this._tabControl.SuspendLayout( );
            this._tabMain.SuspendLayout( );
            this._tabInGame.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // fullscreenCheck
            // 
            this.fullscreenCheck.AutoSize = true;
            this.fullscreenCheck.Location = new System.Drawing.Point( 12, 19 );
            this.fullscreenCheck.Name = "fullscreenCheck";
            this.fullscreenCheck.Size = new System.Drawing.Size( 104, 17 );
            this.fullscreenCheck.TabIndex = 0;
            this.fullscreenCheck.Text = "Fullscreen Mode";
            this.fullscreenCheck.UseVisualStyleBackColor = true;
            // 
            // resolutionsComboBox
            // 
            this.resolutionsComboBox.FormattingEnabled = true;
            this.resolutionsComboBox.Location = new System.Drawing.Point( 106, 48 );
            this.resolutionsComboBox.Name = "resolutionsComboBox";
            this.resolutionsComboBox.Size = new System.Drawing.Size( 94, 21 );
            this.resolutionsComboBox.TabIndex = 1;
            this.resolutionsComboBox.SelectionChangeCommitted += new System.EventHandler( this.resolutionsComboBox_SelectionChangeCommitted );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 9, 51 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 91, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Resolution:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 103, 72 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 38, 13 );
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 103, 95 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 41, 13 );
            this.label3.TabIndex = 4;
            this.label3.Text = "Height:";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point( 147, 70 );
            this.widthUpDown.Maximum = new decimal( new int[] {
            2000,
            0,
            0,
            0} );
            this.widthUpDown.Minimum = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size( 53, 20 );
            this.widthUpDown.TabIndex = 5;
            this.widthUpDown.Value = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point( 147, 93 );
            this.heightUpDown.Maximum = new decimal( new int[] {
            2000,
            0,
            0,
            0} );
            this.heightUpDown.Minimum = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size( 53, 20 );
            this.heightUpDown.TabIndex = 6;
            this.heightUpDown.Value = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.fullscreenCheck );
            this.groupBox1.Controls.Add( this.heightUpDown );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.widthUpDown );
            this.groupBox1.Controls.Add( this.resolutionsComboBox );
            this.groupBox1.Controls.Add( this.label3 );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Location = new System.Drawing.Point( 5, 147 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 210, 124 );
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Resolution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 5, 13 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 61, 13 );
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Title:";
            // 
            // gameTitleText
            // 
            this.gameTitleText.Location = new System.Drawing.Point( 72, 13 );
            this.gameTitleText.Name = "gameTitleText";
            this.gameTitleText.Size = new System.Drawing.Size( 143, 20 );
            this.gameTitleText.TabIndex = 9;
            this.gameTitleText.Text = "My Game";
            // 
            // exitsWithEscCheck
            // 
            this.exitsWithEscCheck.AutoSize = true;
            this.exitsWithEscCheck.Location = new System.Drawing.Point( 8, 113 );
            this.exitsWithEscCheck.Name = "exitsWithEscCheck";
            this.exitsWithEscCheck.Size = new System.Drawing.Size( 190, 17 );
            this.exitsWithEscCheck.TabIndex = 10;
            this.exitsWithEscCheck.Text = "Uses the ESC key to exit the game";
            this.exitsWithEscCheck.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.saveButton.Location = new System.Drawing.Point( 84, 395 );
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size( 75, 23 );
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler( this.saveButton_Click );
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 165, 395 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 75, 23 );
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.radioButton2 );
            this.groupBox2.Controls.Add( this.radioButton1 );
            this.groupBox2.Location = new System.Drawing.Point( 8, 39 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 85, 68 );
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platform";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point( 6, 42 );
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size( 70, 17 );
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Xbox 360";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point( 6, 19 );
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size( 69, 17 );
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Windows";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._tabControl.Controls.Add( this._tabMain );
            this._tabControl.Controls.Add( this._tabInGame );
            this._tabControl.Location = new System.Drawing.Point( 9, 10 );
            this._tabControl.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size( 227, 369 );
            this._tabControl.TabIndex = 14;
            // 
            // _tabMain
            // 
            this._tabMain.Controls.Add( this.label4 );
            this._tabMain.Controls.Add( this.groupBox2 );
            this._tabMain.Controls.Add( this.groupBox1 );
            this._tabMain.Controls.Add( this.gameTitleText );
            this._tabMain.Controls.Add( this.exitsWithEscCheck );
            this._tabMain.Location = new System.Drawing.Point( 4, 22 );
            this._tabMain.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabMain.Name = "_tabMain";
            this._tabMain.Padding = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabMain.Size = new System.Drawing.Size( 219, 343 );
            this._tabMain.TabIndex = 0;
            this._tabMain.Text = "Main";
            this._tabMain.UseVisualStyleBackColor = true;
            // 
            // _tabInGame
            // 
            this._tabInGame.Controls.Add( this._btnAssignAudio );
            this._tabInGame.Controls.Add( this._lblAudio );
            this._tabInGame.Controls.Add( this._btnNewGameScript );
            this._tabInGame.Controls.Add( this._comboScriptList );
            this._tabInGame.Controls.Add( this.label5 );
            this._tabInGame.Location = new System.Drawing.Point( 4, 22 );
            this._tabInGame.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabInGame.Name = "_tabInGame";
            this._tabInGame.Padding = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabInGame.Size = new System.Drawing.Size( 219, 343 );
            this._tabInGame.TabIndex = 2;
            this._tabInGame.Text = "In-Game";
            this._tabInGame.UseVisualStyleBackColor = true;
            // 
            // _comboScriptList
            // 
            this._comboScriptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboScriptList.FormattingEnabled = true;
            this._comboScriptList.Location = new System.Drawing.Point( 46, 5 );
            this._comboScriptList.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._comboScriptList.MaxDropDownItems = 20;
            this._comboScriptList.Name = "_comboScriptList";
            this._comboScriptList.Size = new System.Drawing.Size( 169, 21 );
            this._comboScriptList.TabIndex = 27;
            this._comboScriptList.SelectedIndexChanged += new System.EventHandler( this._comboScriptList_SelectedIndexChanged );
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 4, 7 );
            this.label5.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 37, 13 );
            this.label5.TabIndex = 26;
            this.label5.Text = "Script:";
            // 
            // _btnNewGameScript
            // 
            this._btnNewGameScript.Location = new System.Drawing.Point( 139, 31 );
            this._btnNewGameScript.Name = "_btnNewGameScript";
            this._btnNewGameScript.Size = new System.Drawing.Size( 75, 23 );
            this._btnNewGameScript.TabIndex = 28;
            this._btnNewGameScript.Text = "New Script";
            this._btnNewGameScript.UseVisualStyleBackColor = true;
            this._btnNewGameScript.Click += new System.EventHandler( this._btnNewGameScript_Click );
            // 
            // _lblAudio
            // 
            this._lblAudio.AutoSize = true;
            this._lblAudio.Location = new System.Drawing.Point( 6, 64 );
            this._lblAudio.Name = "_lblAudio";
            this._lblAudio.Size = new System.Drawing.Size( 37, 13 );
            this._lblAudio.TabIndex = 29;
            this._lblAudio.Text = "Audio:";
            // 
            // _btnAssignAudio
            // 
            this._btnAssignAudio.Location = new System.Drawing.Point( 128, 82 );
            this._btnAssignAudio.Name = "_btnAssignAudio";
            this._btnAssignAudio.Size = new System.Drawing.Size( 86, 23 );
            this._btnAssignAudio.TabIndex = 30;
            this._btnAssignAudio.Text = "Assign Audio";
            this._btnAssignAudio.UseVisualStyleBackColor = true;
            this._btnAssignAudio.Click += new System.EventHandler( this._btnAssignAudio_Click );
            // 
            // GameSettingsWindow
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size( 246, 426 );
            this.Controls.Add( this._tabControl );
            this.Controls.Add( this.cancelButton );
            this.Controls.Add( this.saveButton );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameSettingsWindow";
            this.Load += new System.EventHandler( this.GameSettingsWindow_Load );
            ( (System.ComponentModel.ISupportInitialize)( this.widthUpDown ) ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)( this.heightUpDown ) ).EndInit( );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout( );
            this._tabControl.ResumeLayout( false );
            this._tabMain.ResumeLayout( false );
            this._tabMain.PerformLayout( );
            this._tabInGame.ResumeLayout( false );
            this._tabInGame.PerformLayout( );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.CheckBox fullscreenCheck;
        private System.Windows.Forms.ComboBox resolutionsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gameTitleText;
        private System.Windows.Forms.CheckBox exitsWithEscCheck;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabMain;
        private System.Windows.Forms.TabPage _tabInGame;
        private System.Windows.Forms.ComboBox _comboScriptList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnNewGameScript;
        private System.Windows.Forms.Label _lblAudio;
        private System.Windows.Forms.Button _btnAssignAudio;
    }
}