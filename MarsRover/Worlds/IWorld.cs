// <copyright file="IWorld.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Worlds
{
    using MarsRover.Types;

    public interface IWorld
    {
        bool CanMove(PositionVector newPosition);

        PositionVector Move(PositionVector currentPosition);
    }
}
