using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        private static StudentDAL instance;
        string connStr = @"Data Source=.\PHANNHATTAN;Initial Catalog=DemoThreeLayer;Integrated Security=True";

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

        public DataTable GetAllStudent()
        {          
            string sqlGet = "SELECT * FROM [Student]";
            DataTable table;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlGet, conn);
                sqlData.Fill(table);
            }
            return table;
        }

        public StudentDTO GetStudentByName(string name)
        {          
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlGet = string.Format(@"SELECT * FROM [Student] WHERE FullName = N'{0}'", name);
            
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGet, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    StudentDTO student = new StudentDTO
                    {
                        FullName = (string)reader["FullName"],
                        Gender = (Boolean)reader["Gender"],
                        Email = (string) reader["Email"],
                        Address = (string)reader["Address"],
                        ImageUrl = (string) reader["ImageUrl"]
                    };               
                    return student;
                }
                return null;
            }
        }

        public DataTable GetStudentByNameToFind(string name)
        {
            DataTable table;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
               
                string sqlGet = string.Format(@"SELECT * FROM [Student] WHERE FullName LIKE N'%{0}%'", name);
                conn.Open();
                table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlGet, conn);
                sqlData.Fill(table);
            }
            return table;
        }

        public bool AddStudent(StudentDTO student)
        {          
            string sqlAdd = @"INSERT INTO [Student](FullName, Gender, Email, Address, ImageUrl) 
                            VALUES(@FullName, @Gender, @Email, @Address, @ImageUrl)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.Parameters.AddWithValue("@FullName", student.FullName);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@ImageUrl", student.ImageUrl);
   
                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }

        }

        public bool DeleteStudent(string name)
        {
            string sqlDelete = "DELETE FROM [Student] WHERE FullName = @FullName ";
            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@FullName", name);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        public bool UpdateStudent(StudentDTO student)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = string.Format(@"UPDATE Student SET Gender = @Gender, Email = @Email, Address = @Address, ImageUrl = @ImageUrl 
                                            WHERE FullName = @FullName");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", student.FullName);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@ImageUrl", student.ImageUrl);
                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
