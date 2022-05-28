using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        private static StudentDAL instance;

        public static StudentDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentDAL();
                return instance;

            }
            private set { instance = value; }
        }

        private StudentDAL() { }

        public List<StudentDTO> GetAllStudent()
        {
            List<StudentDTO> productList = new List<StudentDTO>();
            string sql = "SELECT * FROM [Student]";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                StudentDTO product = new StudentDTO(item);
                productList.Add(product);
            }
            return productList;
        }

        public List<StudentDTO> GetStudentByID(int id)
        {
            List<StudentDTO> productList = new List<StudentDTO>();
            string sql = "SELECT * FROM [Student] WHERE StudentID = @StudentID ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                StudentDTO product = new StudentDTO(item);
                productList.Add(product);
            }
            return productList;
        }

        public bool AddStudent(StudentDTO student)
        {
            string sql = string.Format("INSERT INTO [Student](FullName, Gender, Email, Address,ImageUrl) VALUES(N'{0}', {1}, {2}, N'{3}', N'{4}')", student.FullName, student.Gender, student.Email, student.Address, student.ImageUrl);
            int result = DataProvider.Instance.ExcuteNonQuery(sql);
            return result > 0;
        }

        public bool EditStudent(StudentDTO student)
        {
            string sql = string.Format("UPDATE [Student] SET FullName = N'{0}', Gender = {1} , Email = {2}, Address = N'{3}', ImageUrl = {4}", student.FullName, student.Gender, student.Email, student.Address, student.ImageUrl);
            int result = DataProvider.Instance.ExcuteNonQuery(sql);
            return result > 0;
        }

        public bool DeleteStudent(string name)
        {
            string sql = "DELETE FROM [Student] WHERE FullName = @name ";
            int result = DataProvider.Instance.ExcuteNonQuery(sql, new object[] { name });
            return result > 0;
        }

    }
}
