using DatabaseEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseEntities.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using DatabaseEntities.CustomModel;
using AutoMapper;
namespace DatabaseDataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private readonly SchoolDbContext _context;
        public StudentDataAccess(SchoolDbContext context)
        {
            _context = context;
        }
        public List<StudentCustom> SearchStudents(String Name)
        {
            List<StudentCustom> StudentList = _context.StudentCustom.FromSqlRaw("exec [dbo].[SearchStudents] " + Name).ToList();

            return StudentList;
        }
        public int DeleteStudent(int id)
        {
            Student temp = _context.Student.FirstOrDefault(Students => Students.StudentId == id);
            _context.Student.Remove(temp);
            return _context.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            return _context.Student.FirstOrDefault(Student => Student.StudentId == id);
        }

        public List<StudentCustom> GetStudents()
        {
            List<StudentCustom> StudentList = _context.StudentCustom.FromSqlRaw("exec [dbo].[CustomModelDetails]").ToList();
            
            
            return StudentList;
            
        }

        public long InsertUpdateStudent(Student model)
        {
            long result = 0;
            SqlParameter resultParameter = new Microsoft.Data.SqlClient.SqlParameter();
            try
            {
                resultParameter.ParameterName = "@Result";
                resultParameter.Direction = System.Data.ParameterDirection.Output;
                resultParameter.SqlDbType = SqlDbType.BigInt;
                
                _context.Database.ExecuteSqlRaw("[dbo].[AddUpdateStudent] @StudentID,@CollegeID,@TeacherID,@FirstName,@LastName,@StudentAge,@Email,@FatherName,@StudentCity,@StudentState,@Gender,@Result out",
                    new SqlParameter("@StudentID", model.StudentId),
                    new SqlParameter("@CollegeID", model.CollegeId),
                    new SqlParameter("@TeacherID", model.TeacherId),
                    new SqlParameter("@FirstName", model.FirstName),
                    new SqlParameter("@LastName", model.LastName),
                    new SqlParameter("@StudentAge", model.StudentAge),
                    new SqlParameter("@Email", model.Email),
                    new SqlParameter("@FatherName", model.FatherName),
                    new SqlParameter("@StudentCity", model.StudentCity),
                    new SqlParameter("@StudentState", model.StudentState),
                    new SqlParameter("@Gender", model.Gender),

                    resultParameter
                    );
                if (Convert.ToInt32(resultParameter.Value) > 0)
                    result = Convert.ToInt32(resultParameter.Value);
            }
            catch (Exception e)
            {
                result = 0;
            }
            return result;
        }

        public List<College> GetCollege()
        {
            return _context.College.ToList();
        }

        public List<Teacher> GetTeacher()
        {
            return _context.Teacher.ToList();
        }

        public List<Employee> Pagination(int pageNo)
        {

            List<Employee> temp = _context.Employee.FromSqlRaw("exec [dbo].[PaginationOnEmployee] 5 , " + pageNo).ToList();
            return temp ;
        }
        public int TotalPages()
        {
           int total = _context.Employee.Count();
            int pageNos;
            if (total / 5 == 0)
                pageNos = total / 5;
            else
                pageNos = total / 5 + 1;
            return pageNos;
        }
    }
}
