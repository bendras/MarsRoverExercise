﻿namespace MarsRover
{
    using System;
    using System.Text;
    using MarsRover.Commands;
    using MarsRover.Rovers;
    using MarsRover.Types;

    /// <summary>Responsible for executing command string.</summary>
    public class RoverController : IRoverController
    {
        private readonly IRover rover;
        private readonly CommandFactory commandFactory;

        public RoverController(IRover rover, CommandFactory commandFactory)
        {
            this.rover = rover;
            this.commandFactory = commandFactory;
        }

        /// <summary>Executes commands in a sequence.</summary>
        /// <param name="commands">Command array.</param>
        /// <returns>Message if there were any errors.</returns>
        public string CommandRover(char[] commands)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var command in commands)
            {
                sb.Append(command);
                try
                {
                    var commandImplementation = this.commandFactory.CreateCommand(command);
                    commandImplementation.Execute(this.rover);
                }
                catch (Exception ex)
                {
                    return ex.Message + string.Format(" Command execution was cancelled after '{0}' steps.", sb);
                }
            }

            return null;
        }

        /// <summary>Gets current position.</summary>
        /// <returns>Rover position.</returns>
        public PositionVector GetPosition()
        {
            return this.rover.Position;
        }
    }
}