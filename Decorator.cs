using static My.CommonTools;

namespace GoF;

public class UseDecorator
{
    public UseDecorator()
    {
        // instead of:
        //var d = new Device("radio", 220);
        // we use:
        var d = new DeviceDecorator("radio", 220);

        d.Show();
    }
}

public class DeviceDecorator(string name, decimal price)
{
    private readonly Device _device = new(name, price);

    public void Show()
    {
        print("[[[");
        print($"Show device at {DateTime.Now:yyyy-MM-dd_HH:mm:ss.fff}");
        
        _device.Show();

        print("]]]");
    }
}

public class Device(string name, decimal price)
{
    public void Show() => print($"Device {name}, price: {price}");
}
