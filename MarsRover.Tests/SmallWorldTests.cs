namespace MarsRover.Tests
{
    using MarsRover.Rovers.Concrete;
    using MarsRover.Types;
    using MarsRover.Worlds.Concrete;
    using NUnit.Framework;

    [TestFixture]
    public class SmallWorldTests
    {
        private void PerformTest(PositionVector initialPosition, PositionVector expectedResult)
        {
            SmallWorld world = new SmallWorld();

            var result = world.Move(initialPosition);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Move00North()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.Notrh), new PositionVector(1, 0, Direction.Notrh));
        }

        [Test]
        public void Move00East()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.East), new PositionVector(0, 1, Direction.East));
        }

        [Test]
        public void Move00West()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.West), new PositionVector(0, 0, Direction.West));
        }

        [Test]
        public void Move00South()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.South), new PositionVector(0, 0, Direction.South));
        }
    }
}
