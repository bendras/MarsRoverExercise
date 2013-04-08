﻿// <copyright file="MoveForward.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    public class MoveForward : ICommand
    {
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
