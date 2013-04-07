using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Commands;
using MarsRover.Rovers;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandParameter = Console.ReadLine();
            IRover rover = StartRover();
            IRoverController roverController = CreateController(rover);

            while (commandParameter != "x")
            {
                ICommand[] commands = ParseCommands(commandParameter);
                roverController.CommandRover(commands);
                Console.Out.WriteLine(rover.Position);
            }
        }

        private static IRoverController CreateController(IRover rover)
        {
            throw new NotImplementedException();
        }

        private static IRover StartRover()
        {
            return new Rovers.Concrete.LandRover(new MarsRover.Types.PositionVector(0, 0, Types.Direction.Notrh), new MarsRover.Worlds.Concrete.SmallWorld());
        }

        private static ICommand[] ParseCommands(string commandParameter)
        {
            throw new NotImplementedException();
        }
    }
}
