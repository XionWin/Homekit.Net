// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
if (!Tron.Hardware.Library.Init())
    throw new Exception("Unable to initialize bcm2835 library");
var relay = new Tron.Device.Relay.RPiRelayBoard.Module();


