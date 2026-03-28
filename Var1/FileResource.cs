using Week8;

namespace Var1;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name) { }
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