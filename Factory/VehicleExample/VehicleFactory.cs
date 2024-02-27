namespace Factory.VehicleExample
{
    public class VehicleFactory
    {
        public const int CAR = 1;
        public const int BICYCLE = 2;

        public static IVehicle CreateVehicle(int vehicleType)
        {
            switch (vehicleType)
            {
                case CAR:
                    return new Car();
                case BICYCLE:
                    //Create mandatory parts of the bike:                    
                    var safetyEquipment = new List<SafetyEquipment>()
                    {
                        new Kneepad
                        {
                            Name="Premium Kneepad", 
                            Position = "Left",
                            Weight = 0.7m
                        },
                        new Kneepad
                        {
                            Name="Premium Kneepad", 
                            Position = "Right",
                            Weight = 0.7m
                        },
                        new Helmet
                        {
                            Name="Premium Helmet", 
                            Weight = 1.7m
                        }
                    };

                    Bicycle bike = new Bicycle()
                    {
                        AmountOfWheels = 2,
                        Brand = "Popular brand",
                        Color = "Red",
                        SafetyEquipment = safetyEquipment
                        
                    };                  

                    return bike;
                default:
                    return null;
            }
        }
    }
    
}