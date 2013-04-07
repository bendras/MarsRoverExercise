using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Types;

namespace MarsRover.Worlds.Concrete
{
    public class SmallWorld : IWorld
    {
        private readonly int min = 0;
        private readonly int max = 4;

        /// <summary>Calculates new position.</summary>
        /// <returns>new position.</returns>
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

            if (CanMove(newPosition))
            {
                return newPosition;
            }

            return currentPosition;
        }

        public bool CanMove(PositionVector newPosition)
        {
            return newPosition.X >= this.min && newPosition.X <= this.max && newPosition.Y >= this.min && newPosition.Y <= this.max;
        }
    }
}
