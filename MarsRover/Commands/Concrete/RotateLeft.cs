namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    class RotateLeft : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.Rotate(false);
        }
    }
}
