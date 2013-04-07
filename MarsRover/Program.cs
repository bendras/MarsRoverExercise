using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Commands;
using MarsRover.Rovers;
using MarsRover.Types;
using MarsRover.Worlds;
using Ninject;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = InitializeContainer(args);
            var roverController = container.Get<IRoverController>();

            string commandParameter = Console.ReadLine();
            while (commandParameter != "x")
            {
                string error = roverController.CommandRover(commandParameter.ToCharArray());
                var position = roverController.GetPosition();

                Console.Out.WriteLine(position + " " + error);
                commandParameter = Console.ReadLine();
            }
        }

        private static IKernel InitializeContainer(string[] args)
        {
            var container = new StandardKernel();

            if (args != null && args.Length > 0)
            {
                container.Bind<IWorld>().To<Worlds.Concrete.BigWorld>();
            }
            else
            {
                container.Bind<IWorld>().To<Worlds.Concrete.SmallWorld>();
            }

            container.Bind<IRover>().To<Rovers.Concrete.LandRover>().WithConstructorArgument("initialPosition", new PositionVector(0, 0, Direction.Notrh));
            container.Bind<IRoverController>().To<RoverController>();

            return container;
        }
    }
}
