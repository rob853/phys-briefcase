using System;

namespace phys_briefcase
{
    class Program
    {
        static void Main(string[] args)
        {
            var briefcaseHandler =
                new BriefcaseHandler(new DistanceSensor(new DistancePins(18, 24)),
                                     new LedStripHandler(new LedStripPins(20, 21, 16)));
            
            Console.CancelKeyPress += delegate
            {
                briefcaseHandler.StopSensing();
            };  
            
            briefcaseHandler.StartSensing();
        }
    }
}
