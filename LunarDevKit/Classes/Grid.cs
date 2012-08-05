using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit.Classes
{
    using Controls;
    using Classes.Zones;

    public static class Grid
    {
        #region Consts

        public const int GRID_SPACING = 64;
        public const int GRID_LINE_WIDTH = 1;
        public static readonly Color GRID_COLOR = Color.Black;

        #endregion

        #region Fields

        private static Rectangle line = new Rectangle( );
        private static RectangleZone bounds = new RectangleZone( Color.White, -1024, -1024, 2048, 2048 );

        #endregion

        static Grid( )
        {
            bounds.DrawsFillColor = false;
            bounds.BorderColor = Color.White;
        }

        #region Methods

        public static void Draw( SpriteBatch spriteBatch, LevelEd level )
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle( bounds.X, bounds.Y, bounds.Width, bounds.Height );
            int gridSpacing;
            if( Global.Tools.DragSnapAmount < 16 )
                gridSpacing = 16;
            else
                gridSpacing = Global.Tools.DragSnapAmount;

            line.Width = GRID_LINE_WIDTH;
            line.Y = rect.Y;
            line.Height = rect.Height;

            for( line.X = rect.X; line.X < rect.Right; line.X += gridSpacing )
                spriteBatch.Draw( Global.Pixel, line, GRID_COLOR );

            line.X = rect.X;
            line.Width = rect.Width;
            line.Height = GRID_LINE_WIDTH;

            for( line.Y = rect.Y; line.Y < rect.Bottom; line.Y += gridSpacing )
                spriteBatch.Draw( Global.Pixel, line, GRID_COLOR );

            bounds.Draw( spriteBatch, 2 );
        }

        #endregion
    }
}
