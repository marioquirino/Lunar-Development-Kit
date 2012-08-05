using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine;

namespace LunarDevKit.Classes
{
    public static class ActorSelectionBox
    {
        #region Fields

        private static int _left;
        public static int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        private static int _top;
        public static int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        private static int _width;
        public static int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private static int _height;
        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public static int Right
        {
            get { return _left + _width; }
        }

        public static int Bottom
        {
            get { return _top + _height; }
        }

        private static SpriteBatch _spriteBatch;

        #endregion

        #region Constructor

        static ActorSelectionBox( )
        {
            _left = 0;
            _top = 0;
            _width = 1;
            _height = 1;
        }

        #endregion

        #region Methods

        public static void SetProperties( int X, int Y, int Width, int Height )
        {
            _left = X;
            _top = Y;
            _width = Width;
            _height = Height;
        }
        public static void SetProperties( Rectangle rect )
        {
            SetProperties( rect.X, rect.Y, rect.Width, rect.Height );
        }
        public static void SetProperties( RectangleF rect )
        {
            SetProperties( (int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height );
        }

        public static void Draw( SpriteBatch spriteBatch )
        {
            _spriteBatch = spriteBatch;

            DrawRectangle( );
            DrawEdges( );
            DrawBorders( );
        }

        private static void DrawRectangle( )
        {
            Rectangle rect = new Rectangle( _left, _top, _width, _height );
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_COLOR );
        }

        private static void DrawEdges( )
        {
            Rectangle rect = new Rectangle( );
            int edgeWidth = Consts.Viewport.ACTOR_SELECTION_EDGE_WIDTH;
            int borderWidth = Consts.Viewport.ACTOR_SELECTION_EDGE_BORDER_WIDTH;

            rect.X = _left;
            rect.Y = _top;
            rect.Width = edgeWidth;
            rect.Height = _height;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_EDGE_COLOR );

            rect.X = Right - edgeWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_EDGE_COLOR );

            rect.X = _left;
            rect.Y = _top;
            rect.Width = _width;
            rect.Height = edgeWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_EDGE_COLOR );

            rect.Y = Bottom - edgeWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_EDGE_COLOR );

            rect.X = _left + edgeWidth;
            rect.Y = _top;
            rect.Width = borderWidth;
            rect.Height = _height;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.X = Right - edgeWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.X = _left;
            rect.Y = _top + edgeWidth;
            rect.Width = _width;
            rect.Height = borderWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.Y = Bottom - edgeWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );
        }

        private static void DrawBorders( )
        {
            Rectangle rect =  new Rectangle( );
            int borderWidth = Consts.Viewport.ACTOR_SELECTION_BORDER_WIDTH;

            rect.X = _left;
            rect.Y = _top;
            rect.Width = borderWidth;
            rect.Height = _height;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.X = Right;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.X = _left;
            rect.Y = _top;
            rect.Width = _width;
            rect.Height = borderWidth;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );

            rect.Y = Bottom;
            _spriteBatch.Draw( Global.Pixel, rect, Consts.Viewport.ACTOR_SELECTION_BORDER_COLOR );
        }

        #endregion
    }
}
