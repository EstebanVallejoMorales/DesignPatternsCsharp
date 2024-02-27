namespace Factory.VehicleExample
{
    public class Car : IVehicle
    {
        public void Move()
        {
            Console.WriteLine("I am a car and I am moving with my 4 wheels and faster than bike.");
        }

        public void Stop()
        {
            Console.WriteLine("Someone hit the brake, so I'm stopping now.");
        }
    }
}