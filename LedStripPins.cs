namespace phys_briefcase
{
    public class LedStripPins
    {
        public int RedPin { get; }
        public int GreenPin { get; }
        public int BluePin { get; }

        public LedStripPins(int redPin, int bluePin, int greenPin)
        {
            RedPin = redPin;
            GreenPin = greenPin;
            BluePin = bluePin;
        }

    }
}