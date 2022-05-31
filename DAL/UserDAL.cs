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
    public class UserDAL
    {
        private static UserDAL instance;
        string connStr = @"Data Source=.\PHANNHATTAN;Initial Catalog=SaleManager;Integrated Security=True";

        public static UserDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllUser()
        {
            string sqlGet = "SELECT * FROM [User]";
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

        public UserDTO GetUserByName(string name)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlGet = string.Format(@"SELECT * FROM [User] WHERE FullName = N'{0}'", name);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGet, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserDTO user = new UserDTO
                    {
                        FullName = (string)reader["FullName"],
                        Address = (string)reader["Address"],
                        Phone = (string)reader["Phone"],
                        Email = (string)reader["Email"],
                        Birthday = (string)reader["Birthday"]
                    };
                    return user;
                }
                return null;
            }
        }

        public DataTable GetUserByNameToFind(string name)
        {
            DataTable table;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                string sqlGet = string.Format(@"SELECT * FROM [User] WHERE FullName LIKE N'%{0}%'", name);
                conn.Open();
                table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlGet, conn);
                sqlData.Fill(table);
            }
            return table;
        }

        public bool AddUser(UserDTO user)
        {
            string sqlAdd = @"INSERT INTO [User](FullName, Address, Phone, Email, Birthday) 
                            VALUES(@FullName, @Address, @Phone, @Email, @Birthday)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Birthday", user.Birthday);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }

        }

        public bool DeleteUser(int id)
        {
            string sqlDelete = "DELETE FROM [User] WHERE UserId = @UserId ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@UserId", id);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        public bool UpdateUser(UserDTO user, int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = string.Format(@"UPDATE [User] SET FullName = @FullName, Address = @Address, Phone = @Phone, Email = @Email, Birthday = @Birthday 
                                            WHERE UserId = @UserId");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Birthday", user.Birthday);
                cmd.Parameters.AddWithValue("@UserId", id);

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

