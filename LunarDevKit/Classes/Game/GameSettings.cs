using System;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit.Classes
{
    public struct GameSettings
    {
        #region Fields

        public string Title;
        public int Width;
        public int Height;
        public bool Fullscreen;
        public bool EndWithEsc;
        public Color BackgroundColor;

        #endregion
    }
}
