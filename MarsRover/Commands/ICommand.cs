using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Rovers;

namespace MarsRover.Commands
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
