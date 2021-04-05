using DatabaseEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseDataAccess;
using DatabaseEntities.CustomModel;

namespace DatabaseBO
{
    public class StudentComponent : IStudentComponent
    {
        private readonly IStudentDataAccess _studentAccess;
        public StudentComponent(IStudentDataAccess studentAccess)
        {
            _studentAccess = studentAccess;
        }
        public List<StudentCustom> SearchStudents(String Name)
        {
            return _studentAccess.SearchStudents(Name);
        }
        public int DeleteStudent(int id)
        {
            return _studentAccess.DeleteStudent(id);
        }

        public Student GetStudentById(int id)
        {
            return _studentAccess.GetStudentById(id);
        }

        public List<StudentCustom> GetStudents()
        {
            return _studentAccess.GetStudents();
        }

        public long InsertUpdateStudent(Student model)
        {
            return _studentAccess.InsertUpdateStudent(model);
        }

        public List<College> GetCollege()
        {
            return _studentAccess.GetCollege();
        }

        public List<Teacher> GetTeacher()
        {
            return _studentAccess.GetTeacher();
        }
        public List<Employee> Pagination(int pageNo)
        {
            return _studentAccess.Pagination(pageNo);
        }
        public int TotalPages()
        {
            return _studentAccess.TotalPages();
        }
    }
}
