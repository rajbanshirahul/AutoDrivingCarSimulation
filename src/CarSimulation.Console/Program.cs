using CarSimulation.Application;
using CarSimulation.Domain;
using System;

var car = new Car { PositionX = 1, PositionY = 2, Direction = 'N' };
var carSimulationService = new CarSimulationService();
var appService = new CarSimulationAppService(carSimulationService);

appService.SimulateCarMovement(car, "FFRFFFRRLF", 10, 10);
Console.WriteLine($"{car.PositionX} {car.PositionY} {car.Direction}");

Console.ReadKey();