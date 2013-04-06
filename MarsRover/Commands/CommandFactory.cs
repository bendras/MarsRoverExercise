using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Commands.Concrete;

namespace MarsRover.Commands
{
    class CommandFactory
    {
        ICommand CreateCommand(char commandParameter)
        {
            switch (commandParameter)
            {
                case 'f':
                case 'F':
                    return new MoveForward();

                default:
                    throw new Exception("Unknown command.");
            }
        }
    }
}
