namespace LunarDevKit.Forms
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( HelpWindow ) );
            this.label1 = new System.Windows.Forms.Label( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.packagesRadio = new System.Windows.Forms.RadioButton( );
            this.viewportRadio = new System.Windows.Forms.RadioButton( );
            this.assetsRadio = new System.Windows.Forms.RadioButton( );
            this.levelsRadio = new System.Windows.Forms.RadioButton( );
            this.worldsRadio = new System.Windows.Forms.RadioButton( );
            this.PackageWizardGroup = new System.Windows.Forms.GroupBox( );
            this.textBox1 = new System.Windows.Forms.TextBox( );
            this.ViewportGroup = new System.Windows.Forms.GroupBox( );
            this.textBox6 = new System.Windows.Forms.TextBox( );
            this.AssetsBrowserGroup = new System.Windows.Forms.GroupBox( );
            this.textBox5 = new System.Windows.Forms.TextBox( );
            this.LevelsGroup = new System.Windows.Forms.GroupBox( );
            this.textBox4 = new System.Windows.Forms.TextBox( );
            this.textBox2 = new System.Windows.Forms.TextBox( );
            this.WorldGroup = new System.Windows.Forms.GroupBox( );
            this.textBox3 = new System.Windows.Forms.TextBox( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.PackageWizardGroup.SuspendLayout( );
            this.ViewportGroup.SuspendLayout( );
            this.AssetsBrowserGroup.SuspendLayout( );
            this.LevelsGroup.SuspendLayout( );
            this.WorldGroup.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 97, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 229, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the second release of LDK";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add( this.groupBox2 );
            this.groupBox1.Controls.Add( this.LevelsGroup );
            this.groupBox1.Controls.Add( this.PackageWizardGroup );
            this.groupBox1.Controls.Add( this.ViewportGroup );
            this.groupBox1.Controls.Add( this.AssetsBrowserGroup );
            this.groupBox1.Controls.Add( this.textBox2 );
            this.groupBox1.Controls.Add( this.WorldGroup );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Location = new System.Drawing.Point( 12, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 426, 2559 );
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.packagesRadio );
            this.groupBox2.Controls.Add( this.viewportRadio );
            this.groupBox2.Controls.Add( this.assetsRadio );
            this.groupBox2.Controls.Add( this.levelsRadio );
            this.groupBox2.Controls.Add( this.worldsRadio );
            this.groupBox2.Location = new System.Drawing.Point( 9, 95 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 411, 79 );
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // packagesRadio
            // 
            this.packagesRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.packagesRadio.AutoSize = true;
            this.packagesRadio.Location = new System.Drawing.Point( 213, 49 );
            this.packagesRadio.Name = "packagesRadio";
            this.packagesRadio.Size = new System.Drawing.Size( 123, 17 );
            this.packagesRadio.TabIndex = 4;
            this.packagesRadio.TabStop = true;
            this.packagesRadio.Text = "5: Packages Tutorial";
            this.packagesRadio.UseVisualStyleBackColor = true;
            this.packagesRadio.Click += new System.EventHandler( this.Radios_Click );
            // 
            // viewportRadio
            // 
            this.viewportRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewportRadio.AutoSize = true;
            this.viewportRadio.Location = new System.Drawing.Point( 77, 49 );
            this.viewportRadio.Name = "viewportRadio";
            this.viewportRadio.Size = new System.Drawing.Size( 116, 17 );
            this.viewportRadio.TabIndex = 3;
            this.viewportRadio.TabStop = true;
            this.viewportRadio.Text = "4: Viewport Tutorial";
            this.viewportRadio.UseVisualStyleBackColor = true;
            this.viewportRadio.Click += new System.EventHandler( this.Radios_Click );
            // 
            // assetsRadio
            // 
            this.assetsRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assetsRadio.AutoSize = true;
            this.assetsRadio.Location = new System.Drawing.Point( 291, 19 );
            this.assetsRadio.Name = "assetsRadio";
            this.assetsRadio.Size = new System.Drawing.Size( 106, 17 );
            this.assetsRadio.TabIndex = 2;
            this.assetsRadio.TabStop = true;
            this.assetsRadio.Text = "3: Assets Tutorial";
            this.assetsRadio.UseVisualStyleBackColor = true;
            this.assetsRadio.Click += new System.EventHandler( this.Radios_Click );
            // 
            // levelsRadio
            // 
            this.levelsRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelsRadio.AutoSize = true;
            this.levelsRadio.Location = new System.Drawing.Point( 155, 19 );
            this.levelsRadio.Name = "levelsRadio";
            this.levelsRadio.Size = new System.Drawing.Size( 106, 17 );
            this.levelsRadio.TabIndex = 1;
            this.levelsRadio.TabStop = true;
            this.levelsRadio.Text = "2: Levels Tutorial";
            this.levelsRadio.UseVisualStyleBackColor = true;
            this.levelsRadio.Click += new System.EventHandler( this.Radios_Click );
            // 
            // worldsRadio
            // 
            this.worldsRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worldsRadio.AutoSize = true;
            this.worldsRadio.Location = new System.Drawing.Point( 16, 19 );
            this.worldsRadio.Name = "worldsRadio";
            this.worldsRadio.Size = new System.Drawing.Size( 108, 17 );
            this.worldsRadio.TabIndex = 0;
            this.worldsRadio.TabStop = true;
            this.worldsRadio.Text = "1: Worlds Tutorial";
            this.worldsRadio.UseVisualStyleBackColor = true;
            this.worldsRadio.Click += new System.EventHandler( this.Radios_Click );
            // 
            // PackageWizardGroup
            // 
            this.PackageWizardGroup.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.PackageWizardGroup.Controls.Add( this.textBox1 );
            this.PackageWizardGroup.Location = new System.Drawing.Point( 41, 2062 );
            this.PackageWizardGroup.Name = "PackageWizardGroup";
            this.PackageWizardGroup.Size = new System.Drawing.Size( 335, 478 );
            this.PackageWizardGroup.TabIndex = 8;
            this.PackageWizardGroup.TabStop = false;
            this.PackageWizardGroup.Text = "Package Wizard";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point( 9, 19 );
            this.textBox1.MaxLength = 65534;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size( 320, 447 );
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString( "textBox1.Text" );
            // 
            // ViewportGroup
            // 
            this.ViewportGroup.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.ViewportGroup.Controls.Add( this.textBox6 );
            this.ViewportGroup.Location = new System.Drawing.Point( 41, 1592 );
            this.ViewportGroup.Name = "ViewportGroup";
            this.ViewportGroup.Size = new System.Drawing.Size( 335, 462 );
            this.ViewportGroup.TabIndex = 7;
            this.ViewportGroup.TabStop = false;
            this.ViewportGroup.Text = "Viewport";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point( 9, 19 );
            this.textBox6.MaxLength = 65534;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size( 320, 431 );
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = resources.GetString( "textBox6.Text" );
            // 
            // AssetsBrowserGroup
            // 
            this.AssetsBrowserGroup.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.AssetsBrowserGroup.Controls.Add( this.textBox5 );
            this.AssetsBrowserGroup.Location = new System.Drawing.Point( 41, 908 );
            this.AssetsBrowserGroup.Name = "AssetsBrowserGroup";
            this.AssetsBrowserGroup.Size = new System.Drawing.Size( 335, 668 );
            this.AssetsBrowserGroup.TabIndex = 6;
            this.AssetsBrowserGroup.TabStop = false;
            this.AssetsBrowserGroup.Text = "Assets Browser";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.HideSelection = false;
            this.textBox5.Location = new System.Drawing.Point( 9, 19 );
            this.textBox5.MaxLength = 65534;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size( 320, 637 );
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = resources.GetString( "textBox5.Text" );
            // 
            // LevelsGroup
            // 
            this.LevelsGroup.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.LevelsGroup.Controls.Add( this.textBox4 );
            this.LevelsGroup.Location = new System.Drawing.Point( 41, 583 );
            this.LevelsGroup.Name = "LevelsGroup";
            this.LevelsGroup.Size = new System.Drawing.Size( 335, 404 );
            this.LevelsGroup.TabIndex = 5;
            this.LevelsGroup.TabStop = false;
            this.LevelsGroup.Text = "Levels";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.HideSelection = false;
            this.textBox4.Location = new System.Drawing.Point( 9, 19 );
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size( 320, 373 );
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = resources.GetString( "textBox4.Text" );
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point( 9, 41 );
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size( 399, 48 );
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "This new release brings a lot of improvements and a few new implementations like " +
    "actor dragging, deleting and rotation (beta) and a Package Wizard.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WorldGroup
            // 
            this.WorldGroup.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.WorldGroup.Controls.Add( this.textBox3 );
            this.WorldGroup.Location = new System.Drawing.Point( 41, 180 );
            this.WorldGroup.Name = "WorldGroup";
            this.WorldGroup.Size = new System.Drawing.Size( 335, 397 );
            this.WorldGroup.TabIndex = 2;
            this.WorldGroup.TabStop = false;
            this.WorldGroup.Text = "Worlds";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point( 9, 19 );
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size( 314, 365 );
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = resources.GetString( "textBox3.Text" );
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size( 464, 600 );
            this.Controls.Add( this.groupBox1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HelpWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.HelpWindow_FormClosing );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout( );
            this.PackageWizardGroup.ResumeLayout( false );
            this.PackageWizardGroup.PerformLayout( );
            this.ViewportGroup.ResumeLayout( false );
            this.ViewportGroup.PerformLayout( );
            this.AssetsBrowserGroup.ResumeLayout( false );
            this.AssetsBrowserGroup.PerformLayout( );
            this.LevelsGroup.ResumeLayout( false );
            this.LevelsGroup.PerformLayout( );
            this.WorldGroup.ResumeLayout( false );
            this.WorldGroup.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox WorldGroup;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox LevelsGroup;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox AssetsBrowserGroup;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox ViewportGroup;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox PackageWizardGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton worldsRadio;
        private System.Windows.Forms.RadioButton levelsRadio;
        private System.Windows.Forms.RadioButton packagesRadio;
        private System.Windows.Forms.RadioButton viewportRadio;
        private System.Windows.Forms.RadioButton assetsRadio;
    }
}