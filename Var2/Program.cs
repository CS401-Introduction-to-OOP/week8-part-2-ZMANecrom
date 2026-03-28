namespace Var2;

using Var2;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        p2.X = 100;
        
        Console.Write("p1: ");
        p1.Print();
        Console.Write("p2: ");
        p2.Print();
        
        
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2.X = 25;
        
        Console.Write("r1: ");
        r1.Print();
        Console.Write("r2: ");
        r2.Print();

        BoxingTester.Test();
    }
    
    // class - він посилається на певний обєкт, тож коли ми кажемо r2 = r1 вони обоє посилаються на один обєкт
    // struct - це окрема структура, тож p1 і p2 це різні обєкти і зміни одного не впливають на іншого
}