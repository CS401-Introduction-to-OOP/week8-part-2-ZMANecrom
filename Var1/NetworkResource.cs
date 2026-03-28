using Week8;

namespace Var1;

public class NetworkResource: Resource, IDisposable
{
    public NetworkResource(string name) : base(name) { }
    
    public override void Open()
    {
        IsOpen = true;
    }
    public override void Close()
    {
        IsOpen = false;
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine("Network resource is closed");
    }
}