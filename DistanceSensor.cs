namespace phys_briefcase
{
    public class DistanceSensor
    {
        private readonly DistancePins _pins;

        public DistanceSensor(DistancePins pins)
        {
            _pins = pins;
        }

        public double Distance
        {
            get
            {
                using (var sensor = new Hcsr04(_pins.TriggerPin, _pins.EchoPin))
                {
                    System.Console.WriteLine(sensor.Distance);
                    return sensor.Distance;
                }
            }
        }
    }
}