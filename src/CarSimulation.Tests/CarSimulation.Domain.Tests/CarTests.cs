namespace CarSimulation.Domain.Tests
{
    public class CarTests
    {
        [Fact]
        public void Car_ConstructedWithValues_ShouldHaveCorrectProperties()
        {
            var car = new Car { PositionX = 1, PositionY = 2, Direction = 'N' };

            Assert.Equal(1, car.PositionX);
            Assert.Equal(2, car.PositionY);
            Assert.Equal('N', car.Direction);
        }
    }
}
