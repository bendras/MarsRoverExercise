// <copyright file="RotateLeft.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    /// <summary>Rotates rover to the left.</summary>
    public class RotateLeft : ICommand
    {
        /// <summary>Performs rotate left action on a rover.</summary>
        /// <param name="rover">The rover to use.</param>
        public void Execute(IRover rover)
        {
            rover.Rotate(false);
        }
    }
}
