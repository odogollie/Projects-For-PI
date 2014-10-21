using System;
using RaspberryPiDotNet;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GPIOMem led = new GPIOMem(GPIOPins.V2_GPIO_12)
            while(true)
            {
                led.Write(PinState.High);
                System.Threading.Thread.Sleep(500);
                led.Write(PinState.Low);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
