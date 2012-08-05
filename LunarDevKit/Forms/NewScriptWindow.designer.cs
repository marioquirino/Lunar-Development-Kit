namespace LunarDevKit.Forms
{
    partial class NewScriptWindow
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
            this.label1 = new System.Windows.Forms.Label( );
            this._txtScriptName = new System.Windows.Forms.TextBox( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this._radioLunarGUI = new System.Windows.Forms.RadioButton( );
            this._radioCSharpScript = new System.Windows.Forms.RadioButton( );
            this._btnCreate = new System.Windows.Forms.Button( );
            this._btnCancel = new System.Windows.Forms.Button( );
            this.groupBox1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 16, 11 );
            this.label1.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 49, 17 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // _txtScriptName
            // 
            this._txtScriptName.Location = new System.Drawing.Point( 75, 7 );
            this._txtScriptName.Margin = new System.Windows.Forms.Padding( 4 );
            this._txtScriptName.Name = "_txtScriptName";
            this._txtScriptName.Size = new System.Drawing.Size( 168, 22 );
            this._txtScriptName.TabIndex = 1;
            this._txtScriptName.Text = "<Script Name>";
            this._txtScriptName.TextChanged += new System.EventHandler( this.scriptNameText_TextChanged );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this._radioLunarGUI );
            this.groupBox1.Controls.Add( this._radioCSharpScript );
            this.groupBox1.Location = new System.Drawing.Point( 20, 39 );
            this.groupBox1.Margin = new System.Windows.Forms.Padding( 4 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding( 4 );
            this.groupBox1.Size = new System.Drawing.Size( 141, 82 );
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scripting Type";
            // 
            // _radioLunarGUI
            // 
            this._radioLunarGUI.AutoSize = true;
            this._radioLunarGUI.Enabled = false;
            this._radioLunarGUI.Location = new System.Drawing.Point( 8, 23 );
            this._radioLunarGUI.Margin = new System.Windows.Forms.Padding( 4 );
            this._radioLunarGUI.Name = "_radioLunarGUI";
            this._radioLunarGUI.Size = new System.Drawing.Size( 104, 21 );
            this._radioLunarGUI.TabIndex = 1;
            this._radioLunarGUI.Text = "LunarVisual";
            this._radioLunarGUI.UseVisualStyleBackColor = true;
            // 
            // _radioCSharpScript
            // 
            this._radioCSharpScript.AutoSize = true;
            this._radioCSharpScript.Checked = true;
            this._radioCSharpScript.Location = new System.Drawing.Point( 8, 52 );
            this._radioCSharpScript.Margin = new System.Windows.Forms.Padding( 4 );
            this._radioCSharpScript.Name = "_radioCSharpScript";
            this._radioCSharpScript.Size = new System.Drawing.Size( 86, 21 );
            this._radioCSharpScript.TabIndex = 0;
            this._radioCSharpScript.TabStop = true;
            this._radioCSharpScript.Text = "C# Script";
            this._radioCSharpScript.UseVisualStyleBackColor = true;
            // 
            // _btnCreate
            // 
            this._btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCreate.Location = new System.Drawing.Point( 36, 131 );
            this._btnCreate.Margin = new System.Windows.Forms.Padding( 4 );
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size( 100, 28 );
            this._btnCreate.TabIndex = 3;
            this._btnCreate.Text = "Create";
            this._btnCreate.UseVisualStyleBackColor = true;
            this._btnCreate.Click += new System.EventHandler( this.createButton_Click );
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point( 144, 131 );
            this._btnCancel.Margin = new System.Windows.Forms.Padding( 4 );
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size( 100, 28 );
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // NewScriptWindow
            // 
            this.AcceptButton = this._btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size( 260, 174 );
            this.Controls.Add( this._btnCancel );
            this.Controls.Add( this._btnCreate );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this._txtScriptName );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding( 4 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewScriptWindow";
            this.Text = "New Script";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtScriptName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _radioLunarGUI;
        private System.Windows.Forms.RadioButton _radioCSharpScript;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.Button _btnCancel;
    }
}