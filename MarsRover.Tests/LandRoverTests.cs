namespace MarsRover.Tests
{
    using MarsRover.Rovers.Concrete;
    using MarsRover.Types;
    using NUnit.Framework;

    [TestFixture]
    public class LandRoverTests
    {
        private void PerformTest(PositionVector initialPosition, PositionVector expectedResult)
        {
            LandRover rover = new LandRover(initialPosition);

            var result = rover.Move(true);

            bool isSuccess = !initialPosition.Equals(expectedResult);
            Assert.AreEqual(isSuccess, result);
            Assert.AreEqual(expectedResult, rover.Position);
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
