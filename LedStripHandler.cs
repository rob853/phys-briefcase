using System;
using System.Device.Pwm.Drivers;

namespace phys_briefcase
{
    public class LedStripHandler : IDisposable
    {
        private SoftwarePwmChannel _redChannel;
        private SoftwarePwmChannel _greenChannel;
        private SoftwarePwmChannel _blueChannel;

        public LedStripHandler(LedStripPins pins)
        {
            _redChannel = new SoftwarePwmChannel(pins.RedPin, 400, 0.8, true);
            _greenChannel = new SoftwarePwmChannel(pins.GreenPin, 400, 0.8, true);
            _blueChannel = new SoftwarePwmChannel(pins.BluePin, 10, 0.8, true);
        }

        public void TurnOnStrip()
        {
            Console.WriteLine("Turning on");
            _redChannel.Start();
            _greenChannel.Start();
            //_blueChannel.Start();
        }

        public void TurnOffStrip()
        {
            Console.WriteLine("Turning off");
            _redChannel.Stop();
            _greenChannel.Stop();
            // _blueChannel.Stop();
        }

        public void Dispose()
        {
            _redChannel.Dispose();
            _greenChannel.Dispose();
            _blueChannel.Dispose();
        }
    }
}