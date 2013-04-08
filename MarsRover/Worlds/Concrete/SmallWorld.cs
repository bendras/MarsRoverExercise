// <copyright file="SmallWorld.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Worlds.Concrete
{
    using System;
    using MarsRover.Types;

    /// <summary>Implementation of a smaller world.</summary>
    public class SmallWorld : IWorld
    {
        private readonly int min = 0;
        private readonly int max = 4;

        /// <summary>Calculates next coordinate moving forward from selected position.</summary>
        /// <param name="currentPosition">The selected position.</param>
        /// <returns>New position.</returns>
        public PositionVector Move(PositionVector currentPosition)
        {
            int x = 0;
            int y = 0;

            switch (currentPosition.Direction)
            {
                case Direction.Notrh:
                    x = 1;
                    break;
                case Direction.East:
                    y = 1;
                    break;
                case Direction.South:
                    x = -1;
                    break;
                case Direction.West:
                    y = -1;
                    break;
                default:
                    throw new Exception("This direction is not recognised.");
            }

            var newPosition = new PositionVector(currentPosition.X + x, currentPosition.Y + y, currentPosition.Direction);

            if (this.CanMove(newPosition))
            {
                return newPosition;
            }

            return currentPosition;
        }

        /// <summary>Indicated whether it is possible to go forward from location.</summary>
        /// <param name="newPosition">Location to check.</param>
        /// <returns><c>true</c> if going forward is allowed.</returns>
        public virtual bool CanMove(PositionVector newPosition)
        {
            return newPosition.X >= this.min && newPosition.X <= this.max && newPosition.Y >= this.min && newPosition.Y <= this.max;
        }
    }
}
