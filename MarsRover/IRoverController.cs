// <copyright file="IRoverController.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover
{
    using MarsRover.Types;

    /// <summary>Responsible for executing command string.</summary>
    public interface IRoverController
    {
        /// <summary>Executes commands in a sequence.</summary>
        /// <param name="commands">Command array.</param>
        /// <returns>Message if there were any errors.</returns>
        string CommandRover(char[] commands);

        /// <summary>Gets current position.</summary>
        /// <returns>Rover position.</returns>
        PositionVector GetPosition();
    }
}
