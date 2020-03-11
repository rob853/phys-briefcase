using System;

namespace phys_briefcase
{
    class Program
    {
        static void Main(string[] args)
        {
            var briefcaseHandler =
                new BriefcaseHandler(new DistanceSensor(new DistancePins(4, 17)),
                                     new LedStripHandler(new LedStripPins(1, 2, 3)));
            
            Console.CancelKeyPress += delegate
            {
                briefcaseHandler.StopSensing();
            };  
            
            briefcaseHandler.StartSensing();
        }
    }
}
