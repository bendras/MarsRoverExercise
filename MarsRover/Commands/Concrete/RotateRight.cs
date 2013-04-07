namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    class RotateRight : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.Rotate(true);
        }
    }
}
