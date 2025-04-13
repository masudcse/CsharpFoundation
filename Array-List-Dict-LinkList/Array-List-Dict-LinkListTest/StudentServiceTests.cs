using Array_List_Dict_LinkList.Models;
using Array_List_Dict_LinkList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Array_List_Dict_LinkListTest
{
    public class StudentServiceTests
    {
        public readonly StudentService _studentService;
        public StudentServiceTests()
        {
            _studentService = new StudentService();
        }
        [Fact]
        public void AddStudent_ShouldIncreaseListCount()
        {
            var original = new List<Student> { new Student { Id = 1, Name = "Alice" } };
            var newOne = new List<Student> { new Student { Id = 2, Name = "Lane" } };
           
            var result = _studentService.AddStudent(original, newOne);
            
            Assert.Equal(2, result.Count);
        }
        [Fact]
        public void RemoveStudentByName_ShouldRemove()
        {
            var original = new List<Student>
            {
                new Student { Id = 1, Name = "Alice" },
                new Student { Id=2, Name="Lane"}
            };
            var result = _studentService.RemoveStudentByName(original, "Lane");

            Assert.Single(result);
            Assert.Equal("Alice", result[0].Name);
        }
        [Fact]
        public void ConvertToDictionary_ShouldConvert()
        {
            var original = new List<Student>
            {
                new Student { Id = 1, Name = "Alice" },
                new Student { Id=2, Name="Lane"}
            };
            var dict = _studentService.ConvertToDictionary(original);

            Assert.Equal("Lane", dict[2].Name);
        }
        [Fact]
        public void FindStudentById_ShouldFind()
        {
            var dictionary = new Dictionary<int, Student>
            {
                {1, new Student{Id=1,Name="Alice"} },
                {2,new Student{Id=2,Name="Lane"} }
            };


            var result = _studentService.FindStudentById(dictionary, 2);

            Assert.NotNull(result);
            Assert.Equal("Lane", result.Name);
        }
        [Fact]
        public void FindStudentById_ShouldReturnNullIfNotFound()
        {
            var dictionary = new Dictionary<int, Student>
            {
                {1,new Student{Id=1,Name="Alice"} },
                {2,new Student{Id=2,Name="Bob"} }
            };

            var result = _studentService.FindStudentById(dictionary, 3);

            Assert.Null(result);
        }
    }
}
