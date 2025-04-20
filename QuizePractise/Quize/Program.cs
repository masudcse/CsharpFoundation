public class Quize
{
    public void Quize1()
    {
        int? x = null;
        var y = x ?? 5;
        Console.WriteLine(y);
    }

    public async Task<string> GetDataAsync()
    {
        await Task.Delay(1000);
        return "Data";
    }
    public record Person(string Name);
    public void Quize3()
    {
        var p1 = new Person("John");
        var p2 = new Person("John");
        Console.WriteLine(p1.Equals(p2));
    }

    public void Quize5()
    {
        object obj = "Hello";
        var result = obj switch
        {
            string s => s.Length,
            int i => i,
            _ => 0
        };
        Console.WriteLine(result);

    }
    public void LinqQuize()
    {
        var numbers = new[] { 1, 2, 3, 4 };
        var result = numbers.Aggregate(0, (a, b) => a + b * b);
        Console.WriteLine(result);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Quize quize = new Quize();
        quize.Quize1();

        var task =quize.GetDataAsync();
        Console.WriteLine(task.Status);

        quize.Quize3();
        quize.Quize5();
        quize.LinqQuize();

    }
}



