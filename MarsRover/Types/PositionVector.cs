namespace MarsRover.Types
{
    using System;

    /// <summary>Describes Rover position and direction in the world.</summary>
    public struct PositionVector
    {
        /// <summary>Initializes Rover position class.</summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="direction">Direction rover faces.</param>
        public PositionVector(int x, int y, Direction direction) : this()
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        /// <summary>X position in the world.</summary>
        public int X { get; private set; }

        /// <summary>Y position in the world.</summary>
        public int Y { get; private set; }

        /// <summary>Direction in the world.</summary>
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
                case 0:
                    direction = 4;
                    break;
                case 5:
                    direction = 1;
                    break;
            }

            return new PositionVector(this.X, this.Y, (Direction)direction);
        }
    }
}
