using System;

namespace CarSimulation.Domain
{
    public class CarSimulationService
    {
        private readonly char[] _directions = { 'N', 'E', 'S', 'W' };

        public void RotateLeft(Car car)
        {
            int currentIndex = Array.IndexOf(_directions, car.Direction);
            car.Direction = _directions[(currentIndex - 1 + _directions.Length) % _directions.Length];
        }

        public void RotateRight(Car car)
        {
            int currentIndex = Array.IndexOf(_directions, car.Direction);
            car.Direction = _directions[(currentIndex + 1) % _directions.Length];
        }

        public void MoveForward(Car car, int maxWidth, int maxHeight)
        {
            switch (car.Direction)
            {
                case 'N' when car.PositionY < maxHeight - 1:
                    car.PositionY++;
                    break;
                case 'E' when car.PositionX < maxWidth - 1:
                    car.PositionX++;
                    break;
                case 'S' when car.PositionY > 0:
                    car.PositionY--;
                    break;
                case 'W' when car.PositionX > 0:
                    car.PositionX--;
                    break;
            }
        }
    }
}
