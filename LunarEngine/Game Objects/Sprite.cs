using System;
using Microsoft.Xna.Framework.Graphics;

namespace LunarEngine
{
    internal class Sprite
    {
        private Texture2D _texture;
        public Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public Sprite( Texture2D texture )
        {
            _texture = texture;
        }
    }
}
