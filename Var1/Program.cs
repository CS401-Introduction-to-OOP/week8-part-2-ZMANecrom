using Week8;
using Var1;

namespace Var1;
class Program {
    static void Main(string[] args) {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        
        file.Dispose();
        
        manager.CloseAll();
        Console.WriteLine("Done");
    }
}


