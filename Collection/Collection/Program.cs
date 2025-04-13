class Program
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Subject { get; set; }
    }
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student{Name="Firoz",Grade=85,Subject="English"},
            new Student{Name="Bob",Grade=90,Subject="Science"},
            new Student{Name="Charlie",Grade=80,Subject="Math"},
            new Student{Name="Debid",Grade=75,Subject="History"},
            new Student{Name="Ele",Grade=70,Subject="Cumputer"},
            new Student{Name="Eve",Grade=65,Subject="Arts"},
        };
        Console.WriteLine("✅ All Students:");
        students.ForEach(s => Console.WriteLine($"Name:{s.Name}-{s.Grade}-{s.Subject}" ));
        Console.WriteLine("\n Student grade>80");
        var topStudents = students.Where(s => s.Grade >= 80);
        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.Name}-{student.Grade}");
        }

        Console.WriteLine("\n📈 Grades Squared (Select):");
        var squaredStudents = students.Select(s => new { s.Name, Squared = s.Grade * s.Grade, s.Subject });
        foreach (var s in squaredStudents)
        {
            Console.WriteLine($"{s.Name}-{s.Squared}");
        }

        Console.WriteLine("\n📚 Group by Subject:");
        
        var groupStudents= students.GroupBy(s => s.Subject);
        
        foreach(var grpStudents in groupStudents)
        {
            Console.WriteLine($"{grpStudents.Key}");
            foreach(var student in grpStudents)
            {
                Console.WriteLine($"{student.Name}-{student.Grade}");
            }
        }
        Console.WriteLine("\n📉 Total Grade (Aggregate):");
        int total = students.Select(s => s.Grade).Aggregate((acc, val) => acc + val);

        Console.WriteLine($"Total Greade:{total}");

        Console.WriteLine("\n🎯 Average Grade in Science:");

        var averageGrade = students.Where(s => s.Subject == "Science").Average(s => s.Grade);
        Console.WriteLine($"Average Science{averageGrade:F2}");

    }
}
