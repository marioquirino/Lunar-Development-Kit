namespace LunarDevKit.Forms
{
    partial class ScriptErrorsDock
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
            this._tabWarnings = new System.Windows.Forms.TabPage( );
            this._listWarnings = new System.Windows.Forms.ListView( );
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader( );
            this._tabErrors = new System.Windows.Forms.TabPage( );
            this._listErrors = new System.Windows.Forms.ListView( );
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader( );
            this._columnNumber = new System.Windows.Forms.ColumnHeader( );
            this._columnDescription = new System.Windows.Forms.ColumnHeader( );
            this._columnFile = new System.Windows.Forms.ColumnHeader( );
            this._columnLine = new System.Windows.Forms.ColumnHeader( );
            this._columnColumn = new System.Windows.Forms.ColumnHeader( );
            this.tabControl1 = new System.Windows.Forms.TabControl( );
            this._tabWarnings.SuspendLayout( );
            this._tabErrors.SuspendLayout( );
            this.tabControl1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _tabWarnings
            // 
            this._tabWarnings.Controls.Add( this._listWarnings );
            this._tabWarnings.Location = new System.Drawing.Point( 4, 22 );
            this._tabWarnings.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabWarnings.Name = "_tabWarnings";
            this._tabWarnings.Padding = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabWarnings.Size = new System.Drawing.Size( 621, 124 );
            this._tabWarnings.TabIndex = 1;
            this._tabWarnings.Text = "Warnings";
            this._tabWarnings.UseVisualStyleBackColor = true;
            // 
            // _listWarnings
            // 
            this._listWarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._listWarnings.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5} );
            this._listWarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listWarnings.FullRowSelect = true;
            this._listWarnings.GridLines = true;
            this._listWarnings.Location = new System.Drawing.Point( 2, 2 );
            this._listWarnings.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._listWarnings.Name = "_listWarnings";
            this._listWarnings.Size = new System.Drawing.Size( 617, 120 );
            this._listWarnings.TabIndex = 1;
            this._listWarnings.UseCompatibleStateImageBehavior = false;
            this._listWarnings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 444;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Line";
            this.columnHeader4.Width = 43;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Column";
            // 
            // _tabErrors
            // 
            this._tabErrors.Controls.Add( this._listErrors );
            this._tabErrors.Location = new System.Drawing.Point( 4, 22 );
            this._tabErrors.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabErrors.Name = "_tabErrors";
            this._tabErrors.Padding = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._tabErrors.Size = new System.Drawing.Size( 621, 124 );
            this._tabErrors.TabIndex = 0;
            this._tabErrors.Text = "Errors";
            this._tabErrors.UseVisualStyleBackColor = true;
            // 
            // _listErrors
            // 
            this._listErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._listErrors.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this._columnNumber,
            this._columnDescription,
            this._columnFile,
            this._columnLine,
            this._columnColumn} );
            this._listErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listErrors.FullRowSelect = true;
            this._listErrors.GridLines = true;
            this._listErrors.Location = new System.Drawing.Point( 2, 2 );
            this._listErrors.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this._listErrors.Name = "_listErrors";
            this._listErrors.Size = new System.Drawing.Size( 617, 120 );
            this._listErrors.TabIndex = 0;
            this._listErrors.UseCompatibleStateImageBehavior = false;
            this._listErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 1;
            // 
            // _columnNumber
            // 
            this._columnNumber.Text = "";
            this._columnNumber.Width = 20;
            // 
            // _columnDescription
            // 
            this._columnDescription.Text = "Description";
            this._columnDescription.Width = 444;
            // 
            // _columnFile
            // 
            this._columnFile.Text = "File";
            this._columnFile.Width = 40;
            // 
            // _columnLine
            // 
            this._columnLine.Text = "Line";
            this._columnLine.Width = 43;
            // 
            // _columnColumn
            // 
            this._columnColumn.Text = "Column";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add( this._tabErrors );
            this.tabControl1.Controls.Add( this._tabWarnings );
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point( 0, 0 );
            this.tabControl1.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 629, 150 );
            this.tabControl1.TabIndex = 0;
            // 
            // ScriptErrorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 629, 150 );
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add( this.tabControl1 );
            this.DockAreas = ( (WeifenLuo.WinFormsUI.Docking.DockAreas)( ( ( ( ( WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop ) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom ) ) );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding( 2, 2, 2, 2 );
            this.Name = "ScriptErrorsWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide;
            this.Text = "Error List";
            this._tabWarnings.ResumeLayout( false );
            this._tabErrors.ResumeLayout( false );
            this.tabControl1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabPage _tabWarnings;
        private System.Windows.Forms.TabPage _tabErrors;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView _listErrors;
        private System.Windows.Forms.ColumnHeader _columnNumber;
        private System.Windows.Forms.ColumnHeader _columnDescription;
        private System.Windows.Forms.ColumnHeader _columnFile;
        private System.Windows.Forms.ColumnHeader _columnLine;
        private System.Windows.Forms.ColumnHeader _columnColumn;
        private System.Windows.Forms.ListView _listWarnings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;




    }
}