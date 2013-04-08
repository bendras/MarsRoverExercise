// <copyright file="IWorld.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Worlds
{
    using MarsRover.Types;

    /// <summary>Describes world.</summary>
    public interface IWorld
    {
        /// <summary>Indicated whether it is possible to go forward from location.</summary>
        /// <param name="newPosition">Location to check.</param>
        /// <returns><c>true</c> if going forward is allowed.</returns>
        bool CanMove(PositionVector newPosition);

        /// <summary>Calculates next coordinate moving forward from selected position.</summary>
        /// <param name="currentPosition">The selected position.</param>
        /// <returns>New position.</returns>
        PositionVector Move(PositionVector currentPosition);
    }
}
