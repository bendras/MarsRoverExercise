﻿// <copyright file="RotateRight.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    public class RotateRight : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.Rotate(true);
        }
    }
}
