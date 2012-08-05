using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarEngine
{
    internal class ActorType
    {
        public string Name;

        public Vector2 Origin = Vector2.Zero;

        public float Scale;

        public float Rotation;

        public string SpriteName;

        public string ScriptName;

        public List<string> Tags = new List<string>( );


        public bool IsTextActor;

        public string FontName;

        public string Text;

        public Color TextColor;



        public bool HasTag( string tag )
        {
            return Tags.Contains( tag );
        }
    }
}
