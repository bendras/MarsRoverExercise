using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Commands;

namespace MarsRover
{
    interface IRoverController
    {
        void CommandRover(ICommand[] commands);
    }
}
