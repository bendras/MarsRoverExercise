namespace MarsRover.Commands.Concrete
{
    using System;
    using MarsRover.Rovers;

    class MoveForward : ICommand
    {
        public void Execute(IRover rover)
        {
            var success = rover.Move(true);

            if (!success)
            {
                throw new Exception("Rover cannot move forward.");
            }
        }
    }
}
