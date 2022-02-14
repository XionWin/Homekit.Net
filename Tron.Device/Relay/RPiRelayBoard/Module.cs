using System;
using System.Collections.Generic;
using Tron.Hardware;

namespace Tron.Device.Relay.RPiRelayBoard
{
    public class Module : Hardware.GPIODevice<Dictionary<string, Hardware.IGPIO>>
    {
        public override Dictionary<string, IGPIO> PINS { get; } =
            new Dictionary<string, IGPIO>()
            {
                // {"Water", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_05, Hardware.GPIODirection.Out, PinState.High)},
                {"Stair", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_06, Hardware.GPIODirection.Out, PinState.High)},
                {"Light", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_13, Hardware.GPIODirection.Out, PinState.High)},
                {"Socket", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_16, Hardware.GPIODirection.Out, PinState.High)},
                {"Bathroom", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_19, Hardware.GPIODirection.Out, PinState.High)},
                {"Kitchen", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_20, Hardware.GPIODirection.Out, PinState.High)},
                {"Air", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_21, Hardware.GPIODirection.Out, PinState.High)},
                {"AC", Hardware.GPIO.CreatePin(Hardware.GPIOPins.GPIO_26, Hardware.GPIODirection.Out, PinState.High)},
            };

        public void Set(string pinName, bool isOpen)
        {
            if (this.PINS.ContainsKey(pinName) && this.PINS[pinName] is Hardware.GPIO gpio)
            {
                gpio.State = isOpen ? Hardware.PinState.Low : Hardware.PinState.High;
            }
        }
    }

}
