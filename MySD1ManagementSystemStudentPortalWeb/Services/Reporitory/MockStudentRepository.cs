using MySD1ManagementSystemStudentPortalWeb.Models;
using MySD1ManagementSystemStudentPortalWeb.Services.Reporitory.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace MySD1ManagementSystemStudentPortalWeb.Services.Reporitory
{
    public class MockStudentRepository : IStudentMockRepository
    {
        private static List<Student> _listOfStudent;
        public MockStudentRepository()
        {
            _listOfStudent = new()
            {
                new()
                {
                    StudentId = 1,
                    Name = "Mike Simson",
                    Email = "mike@m.com",
                    Address = "Caldwell",
                    GenderId = 1
                },

                new()
                {
                    StudentId = 2,
                    Name = "Alex Smith",
                    Email = "alex@a.com",
                    Address = "Mamba Point",
                    GenderId = 1
                },

                new()
                {
                    StudentId = 3,
                    Name = "Princess Collins",
                    Email = "princess@p.com",
                    Address = "Broad Street",
                    GenderId = 2
                },

                new()
                {
                    StudentId = 4,
                    Name = "Sara Roberts",
                    Email = "sara@s.com",
                    Address = "ELWA",
                    GenderId = 2
                },

                new()
                {
                    StudentId = 5,
                    Name = "Alexa Johnson",
                    Email = "alexa@a.com",
                    Address = "Cargo Town",
                    GenderId = 2
                },

                new()
                {
                    StudentId = 6,
                    Name = "Test User",
                    Email = "testuser@t.com",
                    Address = "Test Address",
                    GenderId = 3
                }
            };
        }
        public Student AddStudent(Student student)
        {
            student.StudentId = _listOfStudent.Max(x => x.StudentId) + 1;
            _listOfStudent.Add(student);
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _listOfStudent
                        .OrderBy(x => x.Name)
                        .ToList();

        }

        public Student GetStudent(int id)
        {
            return _listOfStudent.FirstOrDefault(x => x.StudentId == id);
        }
    }
}
