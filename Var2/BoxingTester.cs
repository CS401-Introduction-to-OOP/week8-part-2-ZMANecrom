namespace Var2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        Console.WriteLine($"початкове значення a = {a}; упаковане значення а = {b}; розпаковане значення а = {c}");
        
        // Що відбувається:
        // Boxing: створюється оболонка навколо інта.
        // Unboxing: Програма дістає число з коробки (оболонки).
    }
}