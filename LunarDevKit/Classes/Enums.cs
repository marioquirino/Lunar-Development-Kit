using System;

namespace LunarDevKit.Classes
{
    public enum NodeType
    {
        Folder,
        ActorType,
        Sprite,
        Script
    }

    public enum AssetType
    {
        None,
        Actor,
        Sprite,
        Script,
        Font
    }

    public enum ScriptFormat
    {
        Blank,
        Game,
        Level,
        Actor,
        TextActor
    }

    public enum MouseMoveMode
    {
        None,
        Create,
        Actor,
        Camera,
        Zoom,
        Selection
    }

    public enum ActorMode
    {
        Move,
        ScaleLeft,
        ScaleTop,
        ScaleRight,
        ScaleBottom,
        Rotate
    }

    public enum ScriptType
    {
        Visual,
        CSharp,
    }

    public enum MouseButton
    {
        LeftButton=0,
        RightButton=1,
        MiddleButton=2
    }
}
