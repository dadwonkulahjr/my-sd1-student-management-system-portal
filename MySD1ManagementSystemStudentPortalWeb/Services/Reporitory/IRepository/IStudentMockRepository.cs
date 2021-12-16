using MySD1ManagementSystemStudentPortalWeb.Models;
using System.Collections.Generic;

namespace MySD1ManagementSystemStudentPortalWeb.Services.Reporitory.IRepository
{
    public interface IStudentMockRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        Student AddStudent(Student student);

    }
}
