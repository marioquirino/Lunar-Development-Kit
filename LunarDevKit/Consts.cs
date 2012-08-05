using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit
{
    public static class Consts
    {
        public static class Camera
        {
            public const float ZOOM_IN_MAX = 4f;
            public const float ZOOM_OUT_MAX = 0.2f;
            public const float ZOOM_INCREMENT = 0.09f;
            public const float ZOOM_FACTOR = 0.01f;
        }

        public static class Editor
        {
            public const string TITLE = "Lunar Development Kit";
            public const string FILE_HEADER_ID = "LUNAR DEVELOPMENT KIT";
        }

        public static class Files
        {
            public const string PROJECT_EXTENSION = ".luworld";
            public const string LEVEL_EXTENSION = ".lulvl";
            public const string CSHARP_EXTENSION = ".cs";
            public const string LUVISUAL_EXTENSION = ".lugui";
            public const string ACTORTYPE_EXTENSION = ".luactor";
            public const string PACKAGE_EXTENSION = ".lupkg";
            public const string SPRITE_EXTENSION = ".lusprite";
            public const string FONT_EXTENSION = ".spritefont";
            public const string GAME_EXTENSION = ".lugame";
            public const string GAME_LEVEL_EXTENSION = ".lvl";
            public const string GAME_SCRIPT_EXTENSION = ".script";
            public const string GAME_ACTORTYPE_EXTENSION = ".actor";
        }

        public static class Folders
        {
            public const string BUILD =  @"Build\";
            public const string PACKAGES = @"Packages\";
            public const string ASSETS = @"Assets\";
            public const string SPRITES = "Sprites";
            public const string ACTORS = "Actors";
            public const string SCRIPTS = "Scripts";
            public const string FONTS = "Fonts";
            public const string LEVELS = "Levels";
            public static readonly string LUNAR_PROJECTS_PATH = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments ), "Lunar Dev Kit Projects" );
        }

        public static class Viewport
        {
            public static readonly Color ACTOR_BLUEPRINT_COLOR = new Color( 255, 255, 255, 125 );
            public static readonly Color BACKGROUND_COLOR = Color.CornflowerBlue;
            public static readonly Color SELECTION_BOX_BORDER_COLOR = Color.Black;
            public static readonly Color SELECTION_BOX_COLOR = new Color( 30, 250, 110, 120 );
            public const int ACTOR_SELECTION_BORDER_WIDTH = 2;
            public static readonly Color ACTOR_SELECTION_BORDER_COLOR = Color.Black;
            public static readonly Color ACTOR_SELECTION_COLOR = new Color( 30, 250, 110, 120 );
            public static readonly Color ACTOR_SELECTION_EDGE_COLOR = new Color( 255, 255, 0, 120 );
            public const int ACTOR_SELECTION_EDGE_WIDTH = 8;
            public const int ACTOR_SELECTION_EDGE_BORDER_WIDTH = 1;
            public static readonly Color ACTOR_SELECTION_BLUEPRINT_BORDER_COLOR = new Color( 0, 0, 0, 125 );
            public static readonly Color ACTOR_SELECTION_BLUEPRINT_COLOR = new Color( 30, 250, 110, 80 );
        }

        public static class Zones
        {
            public const float FILL_COLOR_OPACITY = 0.25f;
            public const int BORDER_WIDTH = 3;
        }


        public static class PropsDescriptions
        {
            public const string CategoryMain = "Main";
            public const string CategoryText = "Text";

            //Actor
            public const string ActorPosition = "Determines the position of the selected actor in the level.";
            public const string ActorRotation = "Determines the facing angle of the selected actor.";
            public const string ActorScale = "Determines the scale factor of the selected actor.";
            public const string ActorVisible = "Determines whether the actor will be visible in-game.";
            public const string ActorName = "Determines the name of the actor.";
            public const string ActorText = "Determines the text that will appear when drawing this actor. It will only appear if the actor is a Text Actor.";
            public const string ActorTextColor = "Determines the color of the text when drawing this actor. It only applies if the actor is a Text Actor.";

            //Actortype
            public const string ActorTypeName = "Determines the name of the selected actortype.";
            public const string ActorTypeScale = "Determines the scale of the selected actortype.";
            public const string ActorTypeRotation = "Determines the facing angle of the selected actortype.";
            public const string ActorTypeScript = "Assigns a script from the list or creates a new one for the selected actortype if a name is given.";
            public const string ActorTypeText = "Determines the text used by the selected actortype. It only applies if IsTextActor is set to true.";
            public const string ActorTypeTextColor = "Determines the color of the text used by the selected actortype. It only applies if the IsTextActor is set to true.";
            public const string ActorTypeIsTextActor = "Determines whether the selected actortype is a Text Actor. It's only valid if the selected actortype has a font assigned to it.";
            public const string ActorTypeFont = "Determines the font used to display the text.";
            public const string ActorTypeSprite = "Determines the sprite image used by the selected actortype. It will only display the sprite if IsTextActor is set to false.";

            //Font
            public const string FontName = "Determines the name of the font asset, as well as the name of the corresponding file. It doesn't determine the font being used yet.";

            //Script
            public const string ScriptName = "Determines the name of the script file. When changing the name be sure to change the class name, inside the script, as well, to avoid conflicts in-game.";

            //Layer
            public const string LayerName = "Determines the name of the selected layer.";
            public const string LayerVisible = "Determines if the selected layer is drawn to the screen, both in the editor and in-game.";
            public const string LayerLocked = "Determines if actors on the selected layer can be manipulated. Applies only in the editor.";

            //Level
            public const string LevelName = "Determines the name of the selected level.";
            public const string LevelScript = "Assigns a script from the list or creates a new one for the selected level if a name is given.";

            //Sprite
            public const string SpriteName = "Determines the name of the selected sprite.";
        }
    }
}
