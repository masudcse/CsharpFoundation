using Array_List_Dict_LinkList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Dict_LinkList.Services
{
    public class StudentService
    {
        public List<Student> AddStudent(List<Student> students, List<Student> newStudents)
        {
            students.AddRange(newStudents);
            return students;
        }
        public List<Student> RemoveStudentByName(List<Student> students, string name)
        {
            students.RemoveAll(x => x.Name == name);
            return students;
        }
        public Dictionary<int, Student> ConvertToDictionary(IEnumerable<Student> students)
        {
            return students.ToDictionary(s => s.Id, s => s);
        }
        public Student FindStudentById(Dictionary<int, Student> dict, int id)
        {
            return dict.TryGetValue(id, out var student) ? student : null;
        }
    }
}
