namespace Factory.VehicleExample
{
    public class Helmet : SafetyEquipment
    {
        public override string Name { get; set ; }
        public override decimal Weight { get; set ; }
        
        public override void Equip()
        {
            Console.WriteLine($"Successfully equipped helmet with name: {Name} and Weight: {Weight}.");
        }
    }
}