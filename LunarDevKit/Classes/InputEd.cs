using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace LunarDevKit.Classes
{
    public class InputEd
    {
        #region Fields

        private KeyboardState previousKey;
        private KeyboardState currentKey;

        private MouseState previousMouse;
        private MouseState currentMouse;

        private Vector2 position;

        #endregion

        #region Properties

        public Vector2 MousePosition
        {
            get
            {
                position.X = currentMouse.X;
                position.Y = currentMouse.Y;
                return position;
            }
            set
            {
                position = value;
                Mouse.SetPosition( (int)value.X, (int)value.Y );
            }
        }

        public int MouseX
        {
            get { return currentMouse.X; }
            set
            {
                position.X = value;
                Mouse.SetPosition( (int)position.X, (int)position.Y );
            }
        }

        public int MouseY
        {
            get { return currentMouse.Y; }
            set
            {
                position.Y = value;
                Mouse.SetPosition( (int)position.X, (int)position.Y );
            }
        }

        #endregion

        public InputEd( IntPtr windowHandle )
        {
            Mouse.WindowHandle = windowHandle;
            previousKey = currentKey = Keyboard.GetState( );
            previousMouse = currentMouse = Mouse.GetState( );
            position = new Vector2( currentMouse.X, currentMouse.Y );
        }

        public void Update( )
        {
            previousKey = currentKey;
            previousMouse = currentMouse;

            currentKey = Keyboard.GetState( );
            currentMouse = Mouse.GetState( );
        }

        #region Keyboard Methods

        public bool IsKeyPressOnce( Keys key )
        {
            return previousKey.IsKeyUp( key ) && currentKey.IsKeyDown( key );
        }

        public bool IsKeyPress( Keys key )
        {
            return currentKey.IsKeyDown( key );
        }

        #endregion

        #region Mouse Methods

        public bool IsMouseClick( MouseButton mouseButton )
        {
            switch( mouseButton )
            {
                case MouseButton.LeftButton:
                    return (previousMouse.LeftButton == ButtonState.Released && currentMouse.LeftButton == ButtonState.Pressed);
                case MouseButton.RightButton:
                    return (previousMouse.RightButton == ButtonState.Released && currentMouse.RightButton == ButtonState.Pressed);
                case MouseButton.MiddleButton:
                    return (previousMouse.MiddleButton == ButtonState.Released && currentMouse.MiddleButton == ButtonState.Pressed);
                default:
                    return false;
            }
        }

        public bool IsMousePress( MouseButton mouseButton )
        {
            switch( mouseButton )
            {
                case MouseButton.LeftButton:
                    return currentMouse.LeftButton == ButtonState.Pressed;
                case MouseButton.RightButton:
                    return currentMouse.RightButton == ButtonState.Pressed;
                case MouseButton.MiddleButton:
                    return currentMouse.MiddleButton == ButtonState.Pressed;
                default:
                    return false;
            }
        }

        #endregion
    }
}
