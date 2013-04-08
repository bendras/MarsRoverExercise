// <copyright file="BigWorld.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Worlds.Concrete
{
    using MarsRover.Types;

    /// <summary>Implementation of a bigger world.</summary>
    public class BigWorld : SmallWorld
    {
        private readonly int min = 0;
        private readonly int max = 6;

        /// <summary>Indicated whether it is possible to go forward from location.</summary>
        /// <param name="newPosition">Location to check.</param>
        /// <returns><c>true</c> if going forward is allowed.</returns>
        public override bool CanMove(PositionVector newPosition)
        {
            return newPosition.X >= this.min && newPosition.X <= this.max && newPosition.Y >= this.min && newPosition.Y <= this.max;
        }
    }
}
