namespace Factory.VehicleExample
{
    public class Bicycle : IVehicle
    {
        public int AmountOfWheels { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public List<SafetyEquipment> SafetyEquipment { get; set; }

        public void Move()
        {
            Console.WriteLine("I am a bike and I am moving with my couple of wheels.");
        }

        public void Stop()
        {
            Console.WriteLine("Someone hit the right brake, so I'm stopping now.");
        }
    }
}