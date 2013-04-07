using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Commands.Concrete;

namespace MarsRover.Commands
{
    public class CommandFactory
    {
        public ICommand CreateCommand(char commandParameter)
        {
            switch (commandParameter)
            {
                case 'f':
                case 'F':
                    return new MoveForward();

                case 'l':
                case 'L':
                    return new RotateLeft();

                case 'r':
                case 'R':
                    return new RotateRight();

                default:
                    throw new Exception("Unknown command.");
            }
        }
    }
}
