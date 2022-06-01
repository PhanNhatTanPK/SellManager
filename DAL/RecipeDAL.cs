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
    public class RecipeDAL
    {
        private static RecipeDAL instance;
        string connStr = @"Data Source=.\PHANNHATTAN;Initial Catalog=SaleManager;Integrated Security=True";

        public static RecipeDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new RecipeDAL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllRecipe()
        {
            string sqlGet = @"SELECT [Recipe].RecipeId, [Recipe].Amounts, [User].FullName, [Product].ProductName FROM [Recipe], [User], [Product] WHERE [Recipe].UserId = [User].UserId AND [Recipe].ProductId = [Product].ProductId";
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
        
        public RecipeDTO GetRecipeById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlGet = string.Format(@"SELECT * FROM [Recipe] WHERE RecipeId = {0}", id);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGet, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    RecipeDTO recipe = new RecipeDTO
                    {
                        UserId = (int)reader["UserId"],
                        ProductId = (int)reader["ProductId"],
                        Amounts = (int)reader["Amounts"],
                       
                    };
                    return recipe;
                }
                return null;
            }
        }

        public bool AddRecipe(RecipeDTO recipe)
        {
            string sqlAdd = @"INSERT INTO [Recipe](UserId, ProductId, Amounts) 
                            VALUES(@UserId, @ProductId, @Amounts)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.Parameters.AddWithValue("@UserId", recipe.UserId);
                cmd.Parameters.AddWithValue("@ProductId", recipe.ProductId);
                cmd.Parameters.AddWithValue("@Amounts", recipe.Amounts);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }

        }

        public bool DeleteRecipe(int id)
        {
            string sqlDelete = "DELETE FROM [Recipe] WHERE RecipeId = @RecipeId ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@RecipeId", id);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        public bool DeleteRecipeWithProduct(int id)
        {
            string sqlDelete = "DELETE FROM [Recipe] WHERE ProductId = @ProductId ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@ProductId", id);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        public bool DeleteRecipeWithUser(int id)
        {
            string sqlDelete = "DELETE FROM [Recipe] WHERE UserId = @UserId ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@UserId", id);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }
    }
}
