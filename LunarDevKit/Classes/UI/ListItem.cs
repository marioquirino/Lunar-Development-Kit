using System;

namespace LunarDevKit.Classes
{
    public struct ListItem
    {
        public string FilePath;
        private string name;

        public ListItem( string path )
        {
            FilePath = path;
            name = path.Substring( Consts.Folders.PACKAGES.Length, path.Length - Consts.Folders.PACKAGES.Length - Consts.Files.PACKAGE_EXTENSION.Length );
        }

        public override string ToString( )
        {
            return name;
        }
    }
}
