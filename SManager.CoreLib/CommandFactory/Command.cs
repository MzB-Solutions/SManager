﻿using SManager.CoreLib.System.Networking;

namespace SManager.CoreLib.CommandFactory
{
    /// <summary>
    /// All commands should be based of this class
    /// </summary>
    /// <remarks>Here's an <see cref="Commands">example</see>.</remarks>
    internal abstract class Command
    {
        #region Protected Fields

        /// <summary>
        /// A Reciver object to contain an Action() command
        /// </summary>
        protected Receiver Receiver;

        #endregion Protected Fields

        #region Public Constructors

        /// <summary>
        /// The Command Constructor
        /// </summary>
        /// <param name="receiver">
        /// Takes a Receiver object and upon construction uses it to fill the protected var
        /// </param>
        public Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        #endregion Public Constructors

        #region Public Methods

        public abstract void Execute();

        #endregion Public Methods
    }
}