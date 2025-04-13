class PointClass
{
    public int x;
    public int y;
}
struct PointStruct
{
    public int x; 
    public int y;
}
class Program
{
    static void Main(string[] args)
    {
        PointStruct p = new PointStruct { x = 10, y = 20 };
        PointStruct p2 = p;
        p2.x = 99;
        Console.WriteLine("Struct");
        Console.WriteLine($"p1.x={p.x},p2.x={p2.x}");

        PointClass c1 = new PointClass { x=30,y=50};
        PointClass c2 = c1;
        c2.x = 90;
        Console.WriteLine("\n Class");
        Console.WriteLine($"c1.x={c1.x},c2.x={c2.x}");

        var (name, grade, passed) = GetStudentInfo();
        Console.WriteLine($"[Decosntructed]{name} {grade} {passed}");
    }
    static (string Name, double grade, bool isPassed) GetStudentInfo()
    {
        string name = "Bob";
        double grade = 87.5;
        bool passed = grade > 50;
        return (name, grade, passed);
    }
}