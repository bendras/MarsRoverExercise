// <copyright file="LandRover.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Rovers.Concrete
{
    using System;
    using MarsRover.Types;
    using MarsRover.Worlds;

    /// <summary>Rover that runs on land.</summary>
    public class LandRover : IRover
    {
        private readonly IWorld world;

        /// <summary>Initializes a new instance of the <see cref="LandRover" /> class.</summary>
        /// <param name="initialPosition">initial position.</param>
        public LandRover(PositionVector initialPosition, IWorld world)
        {
            this.Position = initialPosition;
            this.world = world;
        }

        /// <summary>Current position on the map.</summary>
        public PositionVector Position { get; private set; }

        /// <summary>Rotates rover</summary>
        /// <param name="left">rotate right.</param>
        /// <returns>true if successful.</returns>
        public bool Rotate(bool right)
        {
            this.Position = this.Position.Transform(right);
            return true;
        }

        /// <summary>Moves rover.</summary>
        /// <param name="forward">move forward.</param>
        /// <returns>true if successful.</returns>
        public bool Move(bool forward)
        {
            if (forward)
            {
                var initialPosition = this.Position;
                this.Position = this.world.Move(this.Position);
                return !initialPosition.Equals(this.Position);
            }
            else
            {
                throw new NotImplementedException("Moving backwards is not implemented.");
            }
        }
    }
}
