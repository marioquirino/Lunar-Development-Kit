using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarEngine
{
    public class TextActor : Actor
    {
        #region Fields

        private SpriteFont _font;
        internal SpriteFont Font
        {
            get { return _font; }
            set
            {
                _font = value;
                UpdateOrigin( );
            }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                UpdateOrigin( );
            }
        }

        private Color _textColor;
        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        #endregion


        #region Methods
        
        internal override void ActorDraw( SpriteBatch spriteBatch )
        {
            if( Visible && _font != null && !string.IsNullOrEmpty( _text ) )
            {
                try
                {
                    spriteBatch.DrawString( _font, _text, Position, _textColor, Rotation, Origin, Scale, SpriteEffects.None, 0f );
                }
                catch { }
                Draw( spriteBatch );
            }
        }

        private void UpdateOrigin( )
        {
            if( _font == null || string.IsNullOrEmpty( _text ) )
                return;
            try
            {
                Vector2 textSize = _font.MeasureString( _text );
                Origin = new Vector2( textSize.X * 0.5f, textSize.Y * 0.5f );
            }
            catch
            {
                return;
            }
        }

        #endregion
    }
}
