// See https://aka.ms/new-console-template for more information

using Factory.AlcoholicBeberageExample;
using Factory.VehicleExample;

Wine wineBeberage = (Wine)FactoryCreator.CreateBeberage(FactoryCreator.WINE);
Beer beerBeberage = (Beer)FactoryCreator.CreateBeberage(FactoryCreator.BEER);

Console.WriteLine($"Successful wine creation. Alcohol percentage: {wineBeberage.GetAlcoholPercentage()}");
Console.WriteLine($"Successful beer creation. Alcohol percentage: {beerBeberage.GetAlcoholPercentage()}");

Car car = (Car)VehicleFactory.CreateVehicle(VehicleFactory.CAR);
Bicycle bike = (Bicycle)VehicleFactory.CreateVehicle(VehicleFactory.BICYCLE);

bike.Move();
car.Move();