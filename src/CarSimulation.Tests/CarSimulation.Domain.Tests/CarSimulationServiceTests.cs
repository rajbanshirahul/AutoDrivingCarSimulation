namespace CarSimulation.Domain.Tests
{
    public class CarSimulationServiceTests
    {
        [Fact]
        public void RotateLeft_ShouldRotateCorrectly()
        {
            var car = new Car { Direction = 'N' };
            var carSimulationService = new CarSimulationService();

            carSimulationService.RotateLeft(car);
            Assert.Equal('W', car.Direction);

            carSimulationService.RotateLeft(car);
            Assert.Equal('S', car.Direction);

            carSimulationService.RotateLeft(car);
            Assert.Equal('E', car.Direction);

            carSimulationService.RotateLeft(car);
            Assert.Equal('N', car.Direction);
        }

        [Fact]
        public void RotateRight_ShouldRotateCorrectly()
        {
            var car = new Car { Direction = 'N' };
            var carSimulationService = new CarSimulationService();

            carSimulationService.RotateRight(car);
            Assert.Equal('E', car.Direction);

            carSimulationService.RotateRight(car);
            Assert.Equal('S', car.Direction);

            carSimulationService.RotateRight(car);
            Assert.Equal('W', car.Direction);

            carSimulationService.RotateRight(car);
            Assert.Equal('N', car.Direction);
        }

        [Fact]
        public void MoveForward_ShouldMoveCorrectly()
        {
            var car = new Car { PositionX = 1, PositionY = 2, Direction = 'N' };
            var carSimulationService = new CarSimulationService();

            carSimulationService.MoveForward(car, 10, 10);
            Assert.Equal(1, car.PositionX);
            Assert.Equal(3, car.PositionY);

            carSimulationService.MoveForward(car, 10, 10);
            Assert.Equal(1, car.PositionX);
            Assert.Equal(4, car.PositionY);

            carSimulationService.RotateRight(car);
            carSimulationService.MoveForward(car, 10, 10);
            Assert.Equal(2, car.PositionX);
            Assert.Equal(4, car.PositionY);
        }
    }
}
