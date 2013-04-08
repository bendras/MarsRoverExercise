// <copyright file="MoveForward.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    /// <summary>Moves rover on a map.</summary>
    public class MoveForward : ICommand
    {
        /// <summary>Performs Move action on a rover.</summary>
        /// <param name="rover">The rover to use.</param>
        public void Execute(IRover rover)
        {
            var success = rover.Move(true);

            if (!success)
            {
                throw new Exception("Rover cannot move forward.");
            }
        }
    }
}
