// <copyright file="CommandFactory.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands
{
    using System;
    using MarsRover.Commands.Concrete;

    /// <summary>Factory method to construct commands.</summary>
    public class CommandFactory
    {
        /// <summary>Creates a command.</summary>
        /// <param name="commandParameter">Character representing a command.</param>
        /// <returns>A command.</returns>
        public ICommand CreateCommand(char commandParameter)
        {
            switch (commandParameter)
            {
                case 'f':
                case 'F':
                    return new MoveForward();

                case 'l':
                case 'L':
                    return new RotateLeft();

                case 'r':
                case 'R':
                    return new RotateRight();

                default:
                    throw new Exception("Unknown command.");
            }
        }
    }
}
