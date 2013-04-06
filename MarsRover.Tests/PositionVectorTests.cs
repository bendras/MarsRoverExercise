namespace MarsRover.Tests
{
    using MarsRover.Types;
    using NUnit.Framework;

    [TestFixture]
    public class PositionVectorTests
    {
        [Test]
        public void TransformClockwiseFromNorth()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.Notrh);
            var result = vector.Transform(true);
            NUnit.Framework.Assert.AreEqual(Direction.East, result.Direction);
        }

        [Test]
        public void TransformAntiClockwiseFromNorth()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.Notrh);
            var result = vector.Transform(false);
            NUnit.Framework.Assert.AreEqual(Direction.West, result.Direction);
        }

        [Test]
        public void TransformClockwiseFromWest()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.West);
            var result = vector.Transform(true);
            NUnit.Framework.Assert.AreEqual(Direction.Notrh, result.Direction);
        }

        [Test]
        public void TransformAntiClockwiseFromWest()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.West);
            var result = vector.Transform(false);
            NUnit.Framework.Assert.AreEqual(Direction.South, result.Direction);
        }
    }
}
