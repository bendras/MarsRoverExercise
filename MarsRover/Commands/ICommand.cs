// <copyright file="ICommand.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

namespace MarsRover.Commands
{
    using MarsRover.Rovers;

    /// <summary>Interface representing command to be executed on a rover.</summary>
    public interface ICommand
    {
        /// <summary>Performs command on a rover.</summary>
        /// <param name="rover">The rover to use.</param>
        void Execute(IRover rover);
    }
}
