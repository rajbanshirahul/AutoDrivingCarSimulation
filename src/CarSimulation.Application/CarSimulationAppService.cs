using CarSimulation.Domain;

namespace CarSimulation.Application
{
    public class CarSimulationAppService
    {
        private readonly CarSimulationService _carSimulationService;

        public CarSimulationAppService(CarSimulationService carSimulationService)
        {
            _carSimulationService = carSimulationService;
        }

        public void SimulateCarMovement(Car car, string commands, int maxWidth, int maxHeight)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'F':
                        _carSimulationService.MoveForward(car, maxWidth, maxHeight);
                        break;
                    case 'L':
                        _carSimulationService.RotateLeft(car);
                        break;
                    case 'R':
                        _carSimulationService.RotateRight(car);
                        break;
                }
            }
        }
    }
}
