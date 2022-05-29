using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentBLL
    {
        private static StudentBLL instance;
        public static StudentBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentBLL();
                return instance;

            }
            private set { instance = value; }
        }
        public DataTable GetAllStudent()
        {
            
            return StudentDAL.Instance.GetAllStudent();
        }

        public StudentDTO GetStudentByName(string name)
        {
            return StudentDAL.Instance.GetStudentByName(name);
        }

        public bool AddStudent(StudentDTO student)
        {
            return StudentDAL.Instance.AddStudent(student);
        }

        public bool DeleteStudent(string name)
        {
            return StudentDAL.Instance.DeleteStudent(name);
        }

        public bool UpdateStudent(StudentDTO student)
        {
            
            return StudentDAL.Instance.UpdateStudent(student);
        }

        public DataTable GetStudentByNameToFind(string name)
        {
            return StudentDAL.Instance.GetStudentByNameToFind(name);
        }
    }
}
