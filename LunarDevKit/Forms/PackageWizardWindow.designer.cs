namespace LunarDevKit.Forms
{
    partial class PackageWizardWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.availablePackagesRadio = new System.Windows.Forms.RadioButton();
            this.ImportPackageRadio = new System.Windows.Forms.RadioButton();
            this.createPackageRadio = new System.Windows.Forms.RadioButton();
            this.CreatePackageGroup = new System.Windows.Forms.GroupBox();
            this.createPackageProgressBar = new System.Windows.Forms.ProgressBar();
            this.packageDescriptionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.packageNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createPackageButton = new System.Windows.Forms.Button();
            this.includeDependenciesCheckBox = new System.Windows.Forms.CheckBox();
            this.browseAssetsButton = new System.Windows.Forms.Button();
            this.assetsTree = new LunarDevKit.Controls.AssetsTreeView();
            this.computerAssetsRadio = new System.Windows.Forms.RadioButton();
            this.worldAssetsRadio = new System.Windows.Forms.RadioButton();
            this.ImportPackageGroup = new System.Windows.Forms.GroupBox();
            this.importPackagesButton = new System.Windows.Forms.Button();
            this.importPackageToProgramCheckBox = new System.Windows.Forms.CheckBox();
            this.importPackageToWorldCheckBox = new System.Windows.Forms.CheckBox();
            this.packagesToLoadList = new System.Windows.Forms.ListBox();
            this.browsePackageButton = new System.Windows.Forms.Button();
            this.LunarDevKitPackagesGroup = new System.Windows.Forms.GroupBox();
            this.importPackagesToWorldButton = new System.Windows.Forms.Button();
            this.packagesList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.CreatePackageGroup.SuspendLayout();
            this.ImportPackageGroup.SuspendLayout();
            this.LunarDevKitPackagesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.availablePackagesRadio);
            this.panel1.Controls.Add(this.ImportPackageRadio);
            this.panel1.Controls.Add(this.createPackageRadio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 29);
            this.panel1.TabIndex = 0;
            // 
            // availablePackagesRadio
            // 
            this.availablePackagesRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePackagesRadio.AutoSize = true;
            this.availablePackagesRadio.Location = new System.Drawing.Point(249, 3);
            this.availablePackagesRadio.Name = "availablePackagesRadio";
            this.availablePackagesRadio.Size = new System.Drawing.Size(103, 17);
            this.availablePackagesRadio.TabIndex = 2;
            this.availablePackagesRadio.TabStop = true;
            this.availablePackagesRadio.Text = "Show Packages";
            this.availablePackagesRadio.UseVisualStyleBackColor = true;
            this.availablePackagesRadio.CheckedChanged += new System.EventHandler(this.availablePackagesRadio_CheckedChanged);
            // 
            // ImportPackageRadio
            // 
            this.ImportPackageRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImportPackageRadio.AutoSize = true;
            this.ImportPackageRadio.Enabled = false;
            this.ImportPackageRadio.Location = new System.Drawing.Point(130, 3);
            this.ImportPackageRadio.Name = "ImportPackageRadio";
            this.ImportPackageRadio.Size = new System.Drawing.Size(100, 17);
            this.ImportPackageRadio.TabIndex = 1;
            this.ImportPackageRadio.TabStop = true;
            this.ImportPackageRadio.Text = "Import Package";
            this.ImportPackageRadio.UseVisualStyleBackColor = true;
            this.ImportPackageRadio.CheckedChanged += new System.EventHandler(this.ImportPackageRadio_CheckedChanged);
            // 
            // createPackageRadio
            // 
            this.createPackageRadio.AutoSize = true;
            this.createPackageRadio.Location = new System.Drawing.Point(3, 3);
            this.createPackageRadio.Name = "createPackageRadio";
            this.createPackageRadio.Size = new System.Drawing.Size(102, 17);
            this.createPackageRadio.TabIndex = 0;
            this.createPackageRadio.TabStop = true;
            this.createPackageRadio.Text = "Create Package";
            this.createPackageRadio.UseVisualStyleBackColor = true;
            this.createPackageRadio.CheckedChanged += new System.EventHandler(this.createPackageRadio_CheckedChanged);
            // 
            // CreatePackageGroup
            // 
            this.CreatePackageGroup.AutoSize = true;
            this.CreatePackageGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreatePackageGroup.Controls.Add(this.createPackageProgressBar);
            this.CreatePackageGroup.Controls.Add(this.packageDescriptionText);
            this.CreatePackageGroup.Controls.Add(this.label2);
            this.CreatePackageGroup.Controls.Add(this.packageNameText);
            this.CreatePackageGroup.Controls.Add(this.label1);
            this.CreatePackageGroup.Controls.Add(this.createPackageButton);
            this.CreatePackageGroup.Controls.Add(this.includeDependenciesCheckBox);
            this.CreatePackageGroup.Controls.Add(this.browseAssetsButton);
            this.CreatePackageGroup.Controls.Add(this.assetsTree);
            this.CreatePackageGroup.Controls.Add(this.computerAssetsRadio);
            this.CreatePackageGroup.Controls.Add(this.worldAssetsRadio);
            this.CreatePackageGroup.Location = new System.Drawing.Point(12, 47);
            this.CreatePackageGroup.Name = "CreatePackageGroup";
            this.CreatePackageGroup.Size = new System.Drawing.Size(355, 286);
            this.CreatePackageGroup.TabIndex = 1;
            this.CreatePackageGroup.TabStop = false;
            this.CreatePackageGroup.Text = "Create Package";
            this.CreatePackageGroup.Visible = false;
            // 
            // createPackageProgressBar
            // 
            this.createPackageProgressBar.Location = new System.Drawing.Point(9, 257);
            this.createPackageProgressBar.Name = "createPackageProgressBar";
            this.createPackageProgressBar.Size = new System.Drawing.Size(339, 10);
            this.createPackageProgressBar.TabIndex = 14;
            // 
            // packageDescriptionText
            // 
            this.packageDescriptionText.Location = new System.Drawing.Point(9, 61);
            this.packageDescriptionText.Multiline = true;
            this.packageDescriptionText.Name = "packageDescriptionText";
            this.packageDescriptionText.Size = new System.Drawing.Size(168, 77);
            this.packageDescriptionText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // packageNameText
            // 
            this.packageNameText.Location = new System.Drawing.Point(50, 16);
            this.packageNameText.Name = "packageNameText";
            this.packageNameText.Size = new System.Drawing.Size(127, 20);
            this.packageNameText.TabIndex = 11;
            this.packageNameText.Text = "<Package Name>";
            this.packageNameText.TextChanged += new System.EventHandler(this.packageNameText_TextChanged);
            this.packageNameText.GotFocus += new System.EventHandler(this.packageNameText_GotFocus);
            this.packageNameText.LostFocus += new System.EventHandler(this.packageNameText_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // createPackageButton
            // 
            this.createPackageButton.Enabled = false;
            this.createPackageButton.Location = new System.Drawing.Point(33, 215);
            this.createPackageButton.Name = "createPackageButton";
            this.createPackageButton.Size = new System.Drawing.Size(75, 23);
            this.createPackageButton.TabIndex = 9;
            this.createPackageButton.Text = "Create Package";
            this.createPackageButton.UseVisualStyleBackColor = true;
            this.createPackageButton.Click += new System.EventHandler(this.createPackageButton_Click);
            // 
            // includeDependenciesCheckBox
            // 
            this.includeDependenciesCheckBox.AutoSize = true;
            this.includeDependenciesCheckBox.Checked = true;
            this.includeDependenciesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeDependenciesCheckBox.Location = new System.Drawing.Point(183, 219);
            this.includeDependenciesCheckBox.Name = "includeDependenciesCheckBox";
            this.includeDependenciesCheckBox.Size = new System.Drawing.Size(133, 17);
            this.includeDependenciesCheckBox.TabIndex = 8;
            this.includeDependenciesCheckBox.Text = "Include Dependencies";
            this.includeDependenciesCheckBox.UseVisualStyleBackColor = true;
            // 
            // browseAssetsButton
            // 
            this.browseAssetsButton.Location = new System.Drawing.Point(274, 180);
            this.browseAssetsButton.Name = "browseAssetsButton";
            this.browseAssetsButton.Size = new System.Drawing.Size(75, 23);
            this.browseAssetsButton.TabIndex = 7;
            this.browseAssetsButton.Text = "Browse...";
            this.browseAssetsButton.UseVisualStyleBackColor = true;
            this.browseAssetsButton.Visible = false;
            // 
            // assetsTree
            // 
            this.assetsTree.Location = new System.Drawing.Point(183, 16);
            this.assetsTree.Name = "assetsTree";
            this.assetsTree.SelectedNode = null;
            this.assetsTree.Size = new System.Drawing.Size(166, 158);
            this.assetsTree.TabIndex = 2;
            // 
            // computerAssetsRadio
            // 
            this.computerAssetsRadio.AutoSize = true;
            this.computerAssetsRadio.Enabled = false;
            this.computerAssetsRadio.Location = new System.Drawing.Point(9, 180);
            this.computerAssetsRadio.Name = "computerAssetsRadio";
            this.computerAssetsRadio.Size = new System.Drawing.Size(114, 17);
            this.computerAssetsRadio.TabIndex = 1;
            this.computerAssetsRadio.Text = "From the Computer";
            this.computerAssetsRadio.UseVisualStyleBackColor = true;
            this.computerAssetsRadio.CheckedChanged += new System.EventHandler(this.computerAssetsRadio_CheckedChanged);
            // 
            // worldAssetsRadio
            // 
            this.worldAssetsRadio.AutoSize = true;
            this.worldAssetsRadio.Location = new System.Drawing.Point(9, 157);
            this.worldAssetsRadio.Name = "worldAssetsRadio";
            this.worldAssetsRadio.Size = new System.Drawing.Size(120, 17);
            this.worldAssetsRadio.TabIndex = 0;
            this.worldAssetsRadio.Text = "From World\'s Assets";
            this.worldAssetsRadio.UseVisualStyleBackColor = true;
            this.worldAssetsRadio.CheckedChanged += new System.EventHandler(this.worldAssetsRadio_CheckedChanged);
            // 
            // ImportPackageGroup
            // 
            this.ImportPackageGroup.AutoSize = true;
            this.ImportPackageGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportPackageGroup.Controls.Add(this.importPackagesButton);
            this.ImportPackageGroup.Controls.Add(this.importPackageToProgramCheckBox);
            this.ImportPackageGroup.Controls.Add(this.importPackageToWorldCheckBox);
            this.ImportPackageGroup.Controls.Add(this.packagesToLoadList);
            this.ImportPackageGroup.Controls.Add(this.browsePackageButton);
            this.ImportPackageGroup.Location = new System.Drawing.Point(12, 388);
            this.ImportPackageGroup.Name = "ImportPackageGroup";
            this.ImportPackageGroup.Size = new System.Drawing.Size(261, 218);
            this.ImportPackageGroup.TabIndex = 2;
            this.ImportPackageGroup.TabStop = false;
            this.ImportPackageGroup.Text = "Import Package";
            this.ImportPackageGroup.Visible = false;
            // 
            // importPackagesButton
            // 
            this.importPackagesButton.Location = new System.Drawing.Point(70, 176);
            this.importPackagesButton.Name = "importPackagesButton";
            this.importPackagesButton.Size = new System.Drawing.Size(96, 23);
            this.importPackagesButton.TabIndex = 6;
            this.importPackagesButton.Text = "Import Packages";
            this.importPackagesButton.UseVisualStyleBackColor = true;
            // 
            // importPackageToProgramCheckBox
            // 
            this.importPackageToProgramCheckBox.AutoSize = true;
            this.importPackageToProgramCheckBox.Location = new System.Drawing.Point(114, 143);
            this.importPackageToProgramCheckBox.Name = "importPackageToProgramCheckBox";
            this.importPackageToProgramCheckBox.Size = new System.Drawing.Size(135, 17);
            this.importPackageToProgramCheckBox.TabIndex = 5;
            this.importPackageToProgramCheckBox.Text = "Import to Lunar Dev Kit";
            this.importPackageToProgramCheckBox.UseVisualStyleBackColor = true;
            // 
            // importPackageToWorldCheckBox
            // 
            this.importPackageToWorldCheckBox.AutoSize = true;
            this.importPackageToWorldCheckBox.Location = new System.Drawing.Point(114, 120);
            this.importPackageToWorldCheckBox.Name = "importPackageToWorldCheckBox";
            this.importPackageToWorldCheckBox.Size = new System.Drawing.Size(98, 17);
            this.importPackageToWorldCheckBox.TabIndex = 4;
            this.importPackageToWorldCheckBox.Text = "Import to World";
            this.importPackageToWorldCheckBox.UseVisualStyleBackColor = true;
            // 
            // packagesToLoadList
            // 
            this.packagesToLoadList.FormattingEnabled = true;
            this.packagesToLoadList.Location = new System.Drawing.Point(114, 19);
            this.packagesToLoadList.Name = "packagesToLoadList";
            this.packagesToLoadList.Size = new System.Drawing.Size(141, 95);
            this.packagesToLoadList.TabIndex = 3;
            // 
            // browsePackageButton
            // 
            this.browsePackageButton.Location = new System.Drawing.Point(33, 19);
            this.browsePackageButton.Name = "browsePackageButton";
            this.browsePackageButton.Size = new System.Drawing.Size(75, 23);
            this.browsePackageButton.TabIndex = 1;
            this.browsePackageButton.Text = "Browse...";
            this.browsePackageButton.UseVisualStyleBackColor = true;
            // 
            // LunarDevKitPackagesGroup
            // 
            this.LunarDevKitPackagesGroup.AutoSize = true;
            this.LunarDevKitPackagesGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LunarDevKitPackagesGroup.Controls.Add(this.importPackagesToWorldButton);
            this.LunarDevKitPackagesGroup.Controls.Add(this.packagesList);
            this.LunarDevKitPackagesGroup.Location = new System.Drawing.Point(12, 611);
            this.LunarDevKitPackagesGroup.Name = "LunarDevKitPackagesGroup";
            this.LunarDevKitPackagesGroup.Size = new System.Drawing.Size(255, 196);
            this.LunarDevKitPackagesGroup.TabIndex = 3;
            this.LunarDevKitPackagesGroup.TabStop = false;
            this.LunarDevKitPackagesGroup.Text = "Packages";
            this.LunarDevKitPackagesGroup.Visible = false;
            // 
            // importPackagesToWorldButton
            // 
            this.importPackagesToWorldButton.Enabled = false;
            this.importPackagesToWorldButton.Location = new System.Drawing.Point(153, 88);
            this.importPackagesToWorldButton.Name = "importPackagesToWorldButton";
            this.importPackagesToWorldButton.Size = new System.Drawing.Size(96, 23);
            this.importPackagesToWorldButton.TabIndex = 5;
            this.importPackagesToWorldButton.Text = "Import To World";
            this.importPackagesToWorldButton.UseVisualStyleBackColor = true;
            this.importPackagesToWorldButton.Click += new System.EventHandler(this.importPackagesToWorldButton_Click);
            // 
            // packagesList
            // 
            this.packagesList.FormattingEnabled = true;
            this.packagesList.HorizontalScrollbar = true;
            this.packagesList.Location = new System.Drawing.Point(6, 17);
            this.packagesList.Name = "packagesList";
            this.packagesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.packagesList.Size = new System.Drawing.Size(141, 160);
            this.packagesList.Sorted = true;
            this.packagesList.TabIndex = 4;
            this.packagesList.SelectedIndexChanged += new System.EventHandler(this.packagesList_SelectedIndexChanged);
            // 
            // PackageWizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 748);
            this.Controls.Add(this.LunarDevKitPackagesGroup);
            this.Controls.Add(this.ImportPackageGroup);
            this.Controls.Add(this.CreatePackageGroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(362, 38);
            this.Name = "PackageWizardWindow";
            this.ShowInTaskbar = false;
            this.Text = "Package Wizard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CreatePackageGroup.ResumeLayout(false);
            this.CreatePackageGroup.PerformLayout();
            this.ImportPackageGroup.ResumeLayout(false);
            this.ImportPackageGroup.PerformLayout();
            this.LunarDevKitPackagesGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton createPackageRadio;
        private System.Windows.Forms.RadioButton availablePackagesRadio;
        private System.Windows.Forms.RadioButton ImportPackageRadio;
        private System.Windows.Forms.GroupBox CreatePackageGroup;
        private LunarDevKit.Controls.AssetsTreeView assetsTree;
        private System.Windows.Forms.RadioButton computerAssetsRadio;
        private System.Windows.Forms.RadioButton worldAssetsRadio;
        private System.Windows.Forms.GroupBox ImportPackageGroup;
        private System.Windows.Forms.CheckBox importPackageToProgramCheckBox;
        private System.Windows.Forms.CheckBox importPackageToWorldCheckBox;
        private System.Windows.Forms.ListBox packagesToLoadList;
        private System.Windows.Forms.Button browsePackageButton;
        private System.Windows.Forms.Button importPackagesButton;
        private System.Windows.Forms.GroupBox LunarDevKitPackagesGroup;
        private System.Windows.Forms.Button importPackagesToWorldButton;
        private System.Windows.Forms.ListBox packagesList;
        private System.Windows.Forms.Button browseAssetsButton;
        private System.Windows.Forms.CheckBox includeDependenciesCheckBox;
        private System.Windows.Forms.Button createPackageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox packageNameText;
        private System.Windows.Forms.TextBox packageDescriptionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar createPackageProgressBar;
    }
}