namespace MarsRover.Rovers.Concrete
{
    using System;
    using MarsRover.Types;

    /// <summary>Rover that runs on land.</summary>
    public class LandRover : IRover
    {
        /// <summary>Initializes LandRover class.</summary>
        /// <param name="initialPosition">initial position.</param>
        public LandRover(PositionVector initialPosition)
        {
            this.Position = initialPosition;
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
            int x = 0;
            int y = 0;

            switch (this.Position.Direction)
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

            var newPosition = new PositionVector(this.Position.X + x, this.Position.Y + y, this.Position.Direction);

            if (IsRecognised(newPosition))
            {
                this.Position = newPosition;
                return true;
            }

            return false;
        }

        public static bool IsRecognised(PositionVector newPosition)
        {
            return newPosition.X >= 0 && newPosition.X <= 4 && newPosition.Y >= 0 && newPosition.Y <= 4;
        }
    }
}
