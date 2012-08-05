using System;

namespace LDKGameTester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main( string[] args )
        {
            string path = "";
            foreach( string arg in args )
            {
                path += " " + arg;
            }

            using( TestGame game = new TestGame( path ) )
            {
                game.Run( );
            }
        }
    }
}

