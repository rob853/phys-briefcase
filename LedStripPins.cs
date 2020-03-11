namespace phys_briefcase
{
    public class LedStripPins
    {
        public int RedPin { get; }
        public int GreenPin { get; }
        public int BluePin { get; }

        public LedStripPins(int redPin, int greenPin, int bluePin)
        {
            RedPin = redPin;
            GreenPin = greenPin;
            BluePin = bluePin;
        }

    }
}