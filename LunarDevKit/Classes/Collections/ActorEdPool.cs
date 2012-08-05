using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarDevKit.Classes.Collections
{
    public class ActorEdPool : Pool<ActorEd>
    {
        public void DrawActors( SpriteBatch spriteBatch )
        {
            foreach( ActorEd actor in this )
                actor.Draw( spriteBatch );
        }

        //public ActorEdPool Clone( )
        //{
        //    ActorEdPool pool = new ActorEdPool( );

        //    foreach( ActorEd actor in this )
        //        pool.Add( actor.Clone( ) );

        //    return pool;
        //}
    }
}
