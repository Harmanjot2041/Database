using DatabaseEntities.CustomModel;
using DatabaseEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseBO
{
    public interface IStudentComponent
    {
        List<StudentCustom> GetStudents();
        int DeleteStudent(int id);
        long InsertUpdateStudent(Student model);
        Student GetStudentById(int id);
        List<StudentCustom> SearchStudents(String Name);
        List<College> GetCollege();
        List<Teacher> GetTeacher();
        List<Employee> Pagination(int pageNo);
        int TotalPages();
    }
}
