using System;

namespace phys_briefcase
{
    public class BriefcaseHandler
    {
        private readonly DistanceSensor _distanceSensor;
        private readonly LedStripHandler _ledStripHandler;
        private const double LidTriggerDistance = 20;

        public BriefcaseHandler(DistanceSensor distanceSensor, LedStripHandler ledStripHandler)
        {
            _distanceSensor = distanceSensor;
            _ledStripHandler = ledStripHandler;
        }

        public void StartSensing()
        {
            System.Console.WriteLine("Starting sensing");
            while (true)
            {
                if (_distanceSensor.Distance > LidTriggerDistance)
                {
                    _ledStripHandler.TurnOnStrip();
                }
                else
                {
                    _ledStripHandler.TurnOffStrip();
                }
            }
        }

        public void StopSensing()
        {
            Console.WriteLine("Stopping sensing");
            _ledStripHandler.TurnOffStrip();
            _ledStripHandler.Dispose();
        }
    }
}