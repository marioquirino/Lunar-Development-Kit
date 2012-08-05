using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Color=Microsoft.Xna.Framework.Graphics.Color;
using Color2=System.Drawing.Color;

namespace LunarDevKit.Classes
{
    public static class Helper
    {
        public const float DEGTORAD = 0.01745329251994329576923690768489f;
        public const float RADTODEG = 57.295779513082320876798154814105f;

        #region Methods

        #region Math

        public static void DragSnap( ref Vector2 position )
        {
            position.X = (float)Math.Round( position.X / Global.Tools.DragSnapAmount ) * Global.Tools.DragSnapAmount;
            position.Y = (float)Math.Round( position.Y / Global.Tools.DragSnapAmount ) * Global.Tools.DragSnapAmount;
        }

        public static Vector2 DragSnap( Vector2 position )
        {
            DragSnap( ref position );
            return position;
        }

        public static Vector2 ScreenToWorldPosition( CameraEd cam, Vector2 point )
        {
            Matrix mx = Matrix.Invert( cam.View );
            return Vector2.Transform( point, mx );
        }

        public static Vector2 ScreenToWorldPosition( CameraEd cam, float x, float y )
        {
            return ScreenToWorldPosition( cam, new Vector2( x, y ) );
        }

        public static int Max( int value1, int value2 )
        {
            if( value1 >= value2 )
                return value1;
            return value2;
        }
        public static float Max( float value1, float value2 )
        {
            if( value1 >= value2 )
                return value1;
            return value2;
        }


        public static int Min( int value1, int value2 )
        {
            if( value1 <= value2 )
                return value1;
            return value2;
        }
        public static float Min( float value1, float value2 )
        {
            if( value1 <= value2 )
                return value1;
            return value2;
        }


        public static int Lerp( int value1, int value2, float amount )
        {
            return (int)(value1 + ( value2 - value1 ) * amount);
        }
        public static byte Lerp( byte value1, byte value2, float amount )
        {
            return (byte)( value1 + ( value2 - value1 ) * amount );
        }
        public static float Lerp( float value1, float value2, float amount )
        {
            return value1 + ( value2 - value1 ) * amount;
        }


        public static Color2 Lerp( Color2 color1, Color2 color2, float amount )
        {
            return Color2.FromArgb( Lerp( color1.R, color2.R, amount ), Lerp( color1.G, color2.G, amount ), Lerp( color1.B, color2.B, amount ) );
        }
        public static Color Lerp( Color color1, Color color2, float amount )
        {
            return new Color( Lerp( color1.R, color2.R, amount ), Lerp( color1.G, color2.G, amount ), Lerp( color1.B, color2.B, amount ) );
        }

        #endregion

        #region Text Manipulation

        /// <summary>
        /// Searches the string for any non-numeric character and returns a string with only numeric characters.
        /// </summary>
        public static string CheckNumericInput( string str )
        {
            string newStr = "";
            foreach ( char c in str )
                if ( char.IsNumber( c ) || c == '.' )
                    newStr += c;

            return newStr;
        }

        /// <summary>
        /// Searches the string for any special character and returns a string with only letters and numbers.
        /// </summary>
        public static string CheckLetterDigitInput( string str )
        {
            string newStr = "";
            foreach( char c in str )
            {
                if( ( c == ' ' && !str.StartsWith( " " ) ) || char.IsLetterOrDigit( c ) )
                {
                    newStr += c;
                }
            }

            return newStr;
        }

        public static string RemoveSpaces( string str )
        {
            string newStr = "";
            foreach( char c in str )
            {
                if( c != ' ' )
                {
                    newStr += c;
                }
            }

            return newStr;
        }

        public static string RemoveUnneededSpaces( string str )
        {
            string newStr = "";
            char prevChar = new char( );

            foreach( char c in str )
            {
                if( !( c == ' ' && prevChar == ' ' ) )
                {
                    newStr += c;
                    prevChar = c;
                }
            }

            if( newStr.EndsWith( " " ) )
                newStr = newStr.Substring( 0, newStr.Length - 1 );

            return newStr;
        }

        public static string RemoveIndents( string str )
        {
            string newStr = "";
            foreach( char c in str )
            {
                if( c != '\t' )
                {
                    newStr += c;
                }
            }

            return newStr;
        }

        public static string RemoveEmptyLines( string str )
        {
            string newStr = "";

            using( StringReader reader = new StringReader( str ) )
            {
                string line;
                while( ( line = reader.ReadLine( ) ) != null )
                {
                    if( line != string.Empty )
                        newStr += line + Environment.NewLine;
                }
            }

            return newStr;
        }

        /// <summary>
        /// Remove the last N characters of a given string and returns the resulting string
        /// </summary>
        public static string RemoveLastNCharacters( string str, int num )
        {
            if( num <= 0 )
                return str;
            if( num >= str.Length )
                return "";

            return str.Substring( 0, str.Length - num );
        }

        public static bool IsFileImage( string path )
        {
            return path.EndsWith( ".bmp" ) || path.EndsWith( ".jpg" ) || path.EndsWith( ".png" ) || path.EndsWith( ".tga" ) || path.EndsWith( ".gif" );
        }

        public static bool IsFileSprite( string path )
        {
            return path.EndsWith( Consts.Files.SPRITE_EXTENSION );
        }

        public static bool IsFileArchetype( string path )
        {
            return path.EndsWith( Consts.Files.ACTORTYPE_EXTENSION );
        }

        /// <summary>
        /// Given a file path, replaces the current file name, with a given name and returns the new path.
        /// </summary>
        public static string ChangeFilePathName( string filePath, string newName )
        {
            return Path.Combine( Path.GetDirectoryName( filePath ), newName + Path.GetExtension( filePath ) );
        }

        #endregion

        #region Sprites

        public static Color ColorToXNAColor( System.Drawing.Color color )
        {
            return new Color( color.R, color.G, color.B, color.A );
        }

        public static SpriteEd GetSpriteFromImageFile( GraphicsDevice graphicsDevice, string filePath )
        {
            if( !File.Exists( filePath ) )
                return null;

            return GetSpriteFromImage( graphicsDevice, new Bitmap( Image.FromFile( filePath ) ) );
        }

        public static SpriteEd GetSpriteFromImage( GraphicsDevice graphicsDevice, Bitmap image )
        {
            try
            {
                SpriteEd sprite = new SpriteEd( graphicsDevice, image.Width, image.Height, 1, TextureUsage.None, SurfaceFormat.Color );
                Color[] colors = new Color[image.Width * image.Height];

                int x;
                int y = -1;

                for ( int i = 0; i < colors.Length; i++ )
                {
                    x = i % image.Width;
                    if ( x == 0 )
                        y++;

                    colors[i] = ColorToXNAColor( image.GetPixel( x, y ) );
                }

                sprite.SetData( colors );
                sprite.Bitmap = image;
                return sprite;
            }
            catch ( Exception e )
            {
                ErrorReport.Throw( e );
                return null;
            }
        }

        public static Bitmap GetImageFromSprite( SpriteEd sprite )
        {
            try
            {
                Bitmap img = new Bitmap( sprite.Width, sprite.Height );
                Color[] colors = new Color[sprite.Width * sprite.Height];

                sprite.GetData<Color>( colors );

                int x;
                int y = -1;

                for( int i = 0; i < colors.Length; i++ )
                {
                    x = i % sprite.Width;
                    if( x == 0 )
                        y++;

                    img.SetPixel( x, y, Color2.FromArgb( colors[i].A, colors[i].R, colors[i].G, colors[i].B ) );
                }

                return img;
            }
            catch( Exception e )
            {
                MessageBox.Show( e.Message );
                return null;
            }
        }

        #endregion

        #region Content



        #endregion

        #region InputBox

        public static DialogResult InputBox( string title, string promptText, ref string value )
        {
            Form form = new Form( );
            Label label = new Label( );
            TextBox textBox = new TextBox( );
            Button buttonOk = new Button( );
            Button buttonCancel = new Button( );

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds( 9, 20, 372, 13 );
            textBox.SetBounds( 12, 36, 372, 20 );
            buttonOk.SetBounds( 228, 72, 75, 23 );
            buttonCancel.SetBounds( 309, 72, 75, 23 );

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size( 396, 107 );
            form.Controls.AddRange( new Control[] { label, textBox, buttonOk, buttonCancel } );
            form.ClientSize = new Size( Math.Max( 300, label.Right + 10 ), form.ClientSize.Height );
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            form.TopMost = true;

            DialogResult dialogResult = form.ShowDialog( );
            value = textBox.Text;
            form.Dispose( );
            return dialogResult;
        }

        #endregion

        #endregion
    }
}
