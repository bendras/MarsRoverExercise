// <copyright file="IRover.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Rovers
{
    using MarsRover.Types;

    /// <summary>Describes Rover moves.</summary>
    public interface IRover
    {
        /// <summary>Gets rover position.</summary>
        PositionVector Position { get; }

        /// <summary>Rotates rover</summary>
        /// <param name="right">rotate right.</param>
        /// <returns>true if successful.</returns>
        bool Rotate(bool right);

        /// <summary>Moves rover.</summary>
        /// <param name="forward">move forward.</param>
        /// <returns>true if successful.</returns>
        bool Move(bool forward);
    }
}
