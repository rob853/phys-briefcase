namespace phys_briefcase
{
    public class DistancePins
    {
        public int TriggerPin { get; }
        public int EchoPin { get; }

        public DistancePins(int triggerPin, int echoPin)
        {
            TriggerPin = triggerPin;
            EchoPin = echoPin;
        }
    }
}