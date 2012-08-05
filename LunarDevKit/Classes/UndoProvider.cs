using System;
using System.Collections;

namespace LunarDevKit.Classes
{
    public class UndoProvider
    {
        private Stack _undoStack;
        private Stack _redoStack;
        private bool _undoing;
        private bool _redoing;
        private bool _enabled;

        /// <summary>
        /// Constructor for UndoProvider
        /// </summary>
        public UndoProvider( )
        {
            // Create the stacks to store actions
            _undoStack = new Stack( );
            _redoStack = new Stack( );
            // set current state
            _undoing = false;
            _redoing = false;
            _enabled = true;
        }

        /// <summary>
        /// Call this to save the action on the undo stack
        /// </summary>
        /// <param name="action">The action to save and make undoable</param>
        public void StoreAction( Action action )
        {
            // we only store when enabled and not currently inside and undo or redo operation
            if( _enabled && !_undoing && !_redoing )
            {
                // Store the action
                _undoStack.Push( action );
                // The redo stack has to be cleared now since we have pushed new data on
                _redoStack.Clear( );
                // Let the calling code know about the changes
                if( CanUndoChanged!=null ) CanUndoChanged( this, EventArgs.Empty );
                if( CanRedoChanged!=null ) CanRedoChanged( this, EventArgs.Empty );
            }
        }

        /// <summary>
        /// Get/set if the UndoProvider is collecting actions
        /// </summary>
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Undo the most recent action
        /// </summary>
        public void Undo( )
        {
            if( CanUndo )
            {
                // Set the undoing flag to stop StoreAction being called by other code
                // whilst setting values, etc
                _undoing = true;
                // Get the recent action
                Action action = (Action)_undoStack.Pop( );
                action.Undo( );
                // Put the action onto the redo stack
                _redoStack.Push( action );
                _undoing = false;

                // Tell the calling code that stuff has changed
                if( CanUndoChanged!=null ) CanUndoChanged( this, EventArgs.Empty );
                if( CanRedoChanged!=null ) CanRedoChanged( this, EventArgs.Empty );
            }
        }

        /// <summary>
        /// Event to raise with the CanUndo property is changed
        /// </summary>
        public event EventHandler CanUndoChanged;

        /// <summary>
        /// Get if the UndoProvider has an action to undo
        /// </summary>
        public bool CanUndo
        {
            get { return (_enabled && (_undoStack.Count > 0)); }
        }

        /// <summary>
        /// Redo the last undone action
        /// </summary>
        public void Redo( )
        {
            if( CanRedo )
            {
                // Set the flag to prevent StoreAction being called by other code
                // whilst setting values, etc
                _redoing = true;
                // Get the action to redo
                Action action = (Action)_redoStack.Pop( );
                action.Redo( );
                // Now move it to the undo stack
                _undoStack.Push( action );
                _redoing = false;

                // Let the calling code know the undo/redo state has changed
                if( CanUndoChanged!=null ) CanUndoChanged( this, EventArgs.Empty );
                if( CanRedoChanged!=null ) CanRedoChanged( this, EventArgs.Empty );
            }
        }

        /// <summary>
        /// Event to raise when the CanRedo property changed
        /// </summary>
        public event EventHandler CanRedoChanged;

        /// <summary>
        /// Gets if there is an action to redo
        /// </summary>
        public bool CanRedo
        {
            get { return (_enabled && (_redoStack.Count > 0)); }
        }
    }
}
