using System;

namespace LunarDevKit.Classes
{
    /// <summary>
    /// Delegate for when we need to call code to undo or redo the specified action
    /// </summary>
    public delegate void ActionCallback( Action action );

    /// <summary>
    /// Represents an action that can be undone and redone
    /// </summary>
    public class Action
    {
        protected object _object;
        protected object _state;
        protected ActionCallback _undoCallback;
        protected ActionCallback _redoCallback;

        /// <summary>
        /// Constructor for an Action
        /// </summary>
        /// <param name="obj">The object for which we are saving state</param>
        /// <param name="state">The state to saved</param>
        /// <param name="undoCallback">The delegate to undo the action</param>
        /// <param name="redoCallback">The delegate to redo the action</param>
        public Action( object obj, object state, ActionCallback undoCallback, ActionCallback redoCallback )
        {
            _object = obj;
            _state = state;
            _undoCallback = undoCallback;
            _redoCallback = redoCallback;
        }

        /// <summary>
        /// Undo the action by calling the undo callback
        /// </summary>
        public virtual void Undo( )
        {
            if( _undoCallback!=null ) _undoCallback( this );
        }

        /// <summary>
        /// Redo the action by calling the redo callback
        /// </summary>
        public virtual void Redo( )
        {
            if( _redoCallback!=null ) _redoCallback( this );
        }

        /// <summary>
        /// The object to store state for
        /// </summary>
        public object Object
        {
            get { return _object; }
        }

        /// <summary>
        /// The state to store
        /// </summary>
        public object State
        {
            get { return _state; }
        }
    }

    /// <summary>
    /// Class to handle the changing of a property
    /// </summary>
    public class PropertyChangeAction : Action
    {
        /// <summary>
        /// Constructor for PropertyChangeAction
        /// </summary>
        /// <param name="obj">The object that has the property</param>
        /// <param name="propertyName">The name of the property</param>
        /// <param name="oldValue">The old value of the property</param>
        /// <param name="newValue">The new value of the property</param>
        public PropertyChangeAction( object obj, string propertyName, object oldValue, object newValue )
            : base( obj, new PropertyChange( propertyName, oldValue, newValue ), null, null )
        {
        }

        /// <summary>
        /// Restores the property of the object to its previous value
        /// </summary>
        public override void Undo( )
        {
            // Get the PropertyChange data from the State
            PropertyChange change = (PropertyChange)State;
            // Use reflection to change the property of the object
            Object.GetType( ).GetProperty( change.PropertyName ).SetValue( Object, change.OldValue, null );
        }

        /// <summary>
        /// Sets the property of the object to its new value
        /// </summary>
        public override void Redo( )
        {
            // Get the PropertyChange data from the State
            PropertyChange change = (PropertyChange)State;
            // Use reflection to change the property of the object
            Object.GetType( ).GetProperty( change.PropertyName ).SetValue( Object, change.NewValue, null );
        }
    }

    /// <summary>
    /// Stores the information about the property to change
    /// </summary>
    internal struct PropertyChange
    {
        public string PropertyName;
        public object OldValue;
        public object NewValue;

        public PropertyChange( string propertyName, object oldValue, object newValue )
        {
            PropertyName = propertyName;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
