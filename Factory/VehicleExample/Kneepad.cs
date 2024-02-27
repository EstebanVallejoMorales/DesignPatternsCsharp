namespace Factory.VehicleExample
{
    public class Kneepad : SafetyEquipment
    {
        public override string Name { get; set ; }
        public override decimal Weight { get; set ; }
        public string Position { get; set; }

        public override void Equip()
        {
            Console.WriteLine("Successfully equipped Kneepads with Name: {Name}, Weight: {Weight} and Position: {Position}.");
        }
    }
}