using System;
using System.Device.Gpio;
using System.Device.Pwm.Drivers;
using System.Threading;
using System.Threading.Tasks;

namespace phys_led
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PWM!");

            using(var pwmChannel = new SoftwarePwmChannel(16, 400, 0, true))
            {
                pwmChannel.Start();

                for (var loops = 0; loops < 10; loops++)
                {
                    for (double fill = 0.0; fill <= 1.0; fill += 0.1)
                    {
                        System.Console.WriteLine(fill);
                        pwmChannel.DutyCycle = fill;
                        Thread.Sleep(10);
                    }

                    for (double fill = 1.0; fill >= 0.0; fill -= 0.1)
                    {
                        System.Console.WriteLine(fill);
                        pwmChannel.DutyCycle = fill;
                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}