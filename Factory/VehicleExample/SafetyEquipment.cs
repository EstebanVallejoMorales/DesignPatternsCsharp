namespace Factory.VehicleExample
{
    public abstract class SafetyEquipment
    {
        public abstract string Name { get; set; }
        public abstract decimal Weight { get; set; }
        public abstract void Equip();        
    }
}