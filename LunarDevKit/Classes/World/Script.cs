using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public class Script
    {
        #region Fields

        //public int ID;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( !ScriptAdded )
                {
                    _name = value;
                    return;
                }

                if( string.IsNullOrEmpty( value ) )
                    return;

                if( Global.AssetsBrowser.ScriptItems.ContainsKey( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.ScriptWithSameNameExistsError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                _name = value;
                string newPath = Helper.ChangeFilePathName( FilePath, _name );
                if( File.Exists( FilePath ) )
                {
                    if( File.Exists( newPath ) )
                        File.Delete( newPath );
                    File.Move( FilePath, newPath );
                }

                FilePath = newPath;
                Global.MainWindow.OnWorldChanged( );
                Global.MainWindow.OnScriptChanged( );
                Global.Properties.UpdateTitle( );

                Parent.LabelName = _name;
            }
        }

        public string FilePath;
        public string ScriptText;
        public ScriptType ScriptType;
        public bool ScriptAdded = false;

        private ScriptAssetItem _parent;
        public ScriptAssetItem Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private ScriptProperties _properties;
        public ScriptProperties Properties
        {
            get { return _properties; }
        }

        #endregion

        public Script( )
            : this( "" ) { }

        public Script( string name )
        {
            this.Name = name;
            this.ScriptText = string.Empty;
            _properties.Script = this;
        }

        #region Methods

        /// <summary>
        /// Saves the script into the file.
        /// </summary>
        public void Save( )
        {
            FileManager.CreateScriptFile( this );
        }

        /// <summary>
        /// Builds this script and places the output file in the specified folder
        /// </summary>
        /// <param name="folderPath">Folder on which the built file will be created.</param>
        /// <returns>Returns whether the build of the script went successfully. If the value returned is false, it means an error occurred during the process.</returns>
        public bool BuildScript( string folderPath )
        {
            //The script builds depending if it's an assembly script, a lunar script or a lunarGUI script
            switch( ScriptType )
            {
                case ScriptType.Visual:

                    break;

                case ScriptType.CSharp:
                    try
                    {
                        //Define the location where the output script file will be created. 
                        string outputPath = Path.Combine( folderPath, this.Name + Consts.Files.CSHARP_EXTENSION );

                        File.Copy( this.FilePath, outputPath, true );
                    }
                    catch
                    {
                        return false;
                    }

                    break;
            }

            return true;
        }

        #endregion
    }



    public struct ScriptProperties : IEdObject
    {
        public Script Script;

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ScriptName )]
        public string Name
        {
            get { return Script.Name; }
            set { Script.Name = value; }
        }
    }
}
