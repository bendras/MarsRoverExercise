// <copyright file="PositionVector.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Types
{
    using System;

    /// <summary>Describes Rover position and direction in the world.</summary>
    public struct PositionVector
    {
        /// <summary>Initializes a new instance of the <see cref="PositionVector" /> struct.</summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="direction">Direction rover faces.</param>
        public PositionVector(int x, int y, Direction direction) : this()
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        /// <summary>Gets X position in the world.</summary>
        public int X { get; private set; }

        /// <summary>Gets Y position in the world.</summary>
        public int Y { get; private set; }

        /// <summary>Gets Direction in the world.</summary>
        public Direction Direction { get; private set; }

        /// <summary>Transforms vector clockwise.</summary>
        /// <param name="clockwise">transforms clockwise if true.</param>
        /// <returns>transformed vector.</returns>
        public PositionVector Transform(bool clockwise)
        {
            int direction = (int)this.Direction;

            direction += clockwise ? 1 : -1;

            switch (direction)
            {
                case -1:
                    direction = 3;
                    break;
                case 4:
                    direction = 0;
                    break;
            }

            return new PositionVector(this.X, this.Y, (Direction)direction);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Direction);
        }
    }
}
