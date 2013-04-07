namespace MarsRover.Worlds
{
    using MarsRover.Types;

    public interface IWorld
    {
        bool CanMove(PositionVector newPosition);

        PositionVector Move(PositionVector currentPosition);
    }
}
