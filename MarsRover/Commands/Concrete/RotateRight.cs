// <copyright file="RotateRight.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    /// <summary>Rotate right command on a rover.</summary>
    public class RotateRight : ICommand
    {
        /// <summary>Performs rotate right action on a rover.</summary>
        /// <param name="rover">The rover to use.</param>
        public void Execute(IRover rover)
        {
            rover.Rotate(true);
        }
    }
}
