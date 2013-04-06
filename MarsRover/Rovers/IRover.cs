namespace MarsRover.Rovers
{
    using MarsRover.Types;

    /// <summary>Describes Rover moves.</summary>
    interface IRover
    {
        /// <summary>Describes rover position.</summary>
        PositionVector Position { get; }

        /// <summary>Rotates rover</summary>
        /// <param name="left">rotate right.</param>
        /// <returns>true if successful.</returns>
        bool Rotate(bool right);

        /// <summary>Moves rover.</summary>
        /// <param name="forward">move forward.</param>
        /// <returns>true if successful.</returns>
        bool Move(bool forward);
    }
}
