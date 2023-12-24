using CarSimulation.Domain;

namespace CarSimulation.Application.Tests
{
    public class CarSimulationAppServiceTests
    {
        [Fact]
        public void SimulateCarMovement_ShouldMoveCorrectly()
        {
            var car = new Car { PositionX = 1, PositionY = 2, Direction = 'N' };
            var carSimulationService = new CarSimulationService();
            var appService = new CarSimulationAppService(carSimulationService);

            appService.SimulateCarMovement(car, "FFRFFFRRLF", 10, 10);

            Assert.Equal(4, car.PositionX);
            Assert.Equal(3, car.PositionY);
            Assert.Equal('S', car.Direction);
        }
    }
}
