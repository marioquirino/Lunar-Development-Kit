using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace LunarEngine
{
    public class Input : GameComponent
    {
        #region Fields

        private GameManager _gameManager;
        internal GameManager GameManager
        {
            get { return _gameManager; }
            set { _gameManager = value; }
        }

        private KeyboardState previousKey;
        private KeyboardState currentKey;

        private MouseState previousMouse;
        private MouseState currentMouse;

        private Vector2 position;

        #endregion

        #region Properties

        public Vector2 MousePosition
        {
            get { return Helper.ScreenToWorldPosition( GameManager.LunarGame.Camera, position ); }
            set
            {
                position = value;
                Mouse.SetPosition( (int)value.X, (int)value.Y );
            }
        }

        public float MouseX
        {
            get { return Helper.ScreenToWorldPosition( GameManager.LunarGame.Camera, position ).X; }
            set
            {
                position.X = value;
                Mouse.SetPosition( (int)position.X, (int)position.Y );
            }
        }

        public float MouseY
        {
            get { return Helper.ScreenToWorldPosition( GameManager.LunarGame.Camera, position ).Y; }
            set
            {
                position.Y = value;
                Mouse.SetPosition( (int)position.X, (int)position.Y );
            }
        }

        #endregion

        public Input( GameManager gameManager )
            : base( gameManager.Game )
        {
            _gameManager = gameManager;
            previousKey = currentKey = Keyboard.GetState( );
            previousMouse = currentMouse = Mouse.GetState( );
            position = new Vector2( currentMouse.X, currentMouse.Y );
        }

        public override void Update( GameTime gameTime )
        {
            base.Update( gameTime );

            previousKey = currentKey;
            previousMouse = currentMouse;

            currentKey = Keyboard.GetState( );
            currentMouse = Mouse.GetState( );

            position.X = currentMouse.X;
            position.Y = currentMouse.Y;
        }

        #region Keyboard Methods

        public bool IsKeyPress( Keys key )
        {
            return previousKey.IsKeyUp( key ) && currentKey.IsKeyDown( key );
        }

        public bool IsKeyDown( Keys key )
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

        public bool IsMouseDown( MouseButton mouseButton )
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
