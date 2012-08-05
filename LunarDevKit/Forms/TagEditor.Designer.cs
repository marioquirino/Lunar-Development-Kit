﻿namespace LunarDevKit.Forms
{
    partial class TagEditor
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
            this._txtTags = new System.Windows.Forms.TextBox( );
            this._btnOK = new System.Windows.Forms.Button( );
            this._btnCancel = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 9 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 235, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the tags in the collection (one tag per line):";
            // 
            // _txtTags
            // 
            this._txtTags.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._txtTags.Location = new System.Drawing.Point( 12, 25 );
            this._txtTags.Multiline = true;
            this._txtTags.Name = "_txtTags";
            this._txtTags.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtTags.Size = new System.Drawing.Size( 429, 295 );
            this._txtTags.TabIndex = 1;
            this._txtTags.WordWrap = false;
            // 
            // _btnOK
            // 
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnOK.Location = new System.Drawing.Point( 285, 326 );
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size( 75, 23 );
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point( 366, 327 );
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler( this._btnCancel_Click );
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size( 453, 362 );
            this.Controls.Add( this._btnCancel );
            this.Controls.Add( this._btnOK );
            this.Controls.Add( this._txtTags );
            this.Controls.Add( this.label1 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TagEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Editor";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtTags;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
    }
}