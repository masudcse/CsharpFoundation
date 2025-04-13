using Array_List_Dict_LinkList.Models;
using System.Linq.Expressions;

class ArrayListDict
{
    static void Main(string[] args)
    {
        var studentArray = new Student[3];
        studentArray[0] = new Student { Id = 1, Name = "Alam" };
        studentArray[1] = new Student { Id = 2, Name = "Rahim" };
        studentArray[2] = new Student { Id = 3, Name = "Kalam" };
        Console.WriteLine("Array Students:");
        foreach (var student in studentArray)
        {
            Console.Write(student.Name +' ');
        }

        //List add 3 more students

        var studentList = new List<Student>
        {
            new Student{Id=4,Name="Id4"},
            new Student{Id=5,Name="Id5"},
            new Student{Id=6,Name="Id6"}
        };
        Console.WriteLine();
        //remove a student by name
        studentList.RemoveAll(student => student.Name == "Id6");
        foreach(var student in studentList)
        {
            
            Console.Write(student.Name+' ');
        }

        //linked list
        var studentLinkedList = new LinkedList<Student>(studentList);
        studentLinkedList.AddFirst(new Student { Id = 7, Name = "Id7" });
        studentLinkedList.AddLast(new Student { Id = 8, Name = "Id8" });
        Console.WriteLine();
        foreach(var student in studentLinkedList)
        {
            Console.Write(student.Name+ ' ');
        }

        //Dictionary
        var studentDictionaryKey = new Dictionary<int, Student>();
        foreach (var studuent in studentLinkedList)
        {
            studentDictionaryKey[studuent.Id] = studuent;
        }

        //printing
        Console.WriteLine("\n Search into Dictionary");
        Console.Write("Ender Student Id:");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            if (studentDictionaryKey.TryGetValue(id, out var student))
            {
                Console.WriteLine("Id found");
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }

        
        
    }
}
