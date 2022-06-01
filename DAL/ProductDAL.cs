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
    public class ProductDAL
    {
        private static ProductDAL instance;
        string connStr = @"Data Source=.\PHANNHATTAN;Initial Catalog=SaleManager;Integrated Security=True";

        public static ProductDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllProduct()
        {
            string sqlGet = "SELECT * FROM [Product]";
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

        public ProductDTO GetProductByName(string name)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlGet = string.Format(@"SELECT * FROM [Product] WHERE ProductName = N'{0}'", name);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGet, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ProductDTO product = new ProductDTO
                    {
                        ProductName = (string)reader["ProductName"],
                        Origin = (string)reader["Origin"],
                        Amount = (int)reader["Amount"],
                        Price = (int)reader["Price"],                        
                    };
                    return product;
                }
                return null;
            }
        }

        public ProductDTO GetProductById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlGet = string.Format(@"SELECT * FROM [Product] WHERE ProductId = '{0}'", id);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGet, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ProductDTO product = new ProductDTO
                    {
                        ProductName = (string)reader["ProductName"],
                        Origin = (string)reader["Origin"],
                        Amount = (int)reader["Amount"],
                        Price = (int)reader["Price"],
                    };
                    return product;
                }
                return null;
            }
        }

        public DataTable GetProductByNameToFind(string name)
        {
            DataTable table;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                string sqlGet = string.Format(@"SELECT * FROM [Product] WHERE ProductName LIKE N'%{0}%'", name);
                conn.Open();
                table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlGet, conn);
                sqlData.Fill(table);
            }
            return table;
        }

        public bool AddProduct(ProductDTO product)
        {
            string sqlAdd = @"INSERT INTO [Product](ProductName, Origin, Amount, Price) 
                            VALUES(@ProductName, @Origin, @Amount, @Price)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Origin", product.Origin);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);
                cmd.Parameters.AddWithValue("@Price", product.Price);               

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }

        }

        public bool DeleteProduct(int id)
        {
            string sqlDelete = "DELETE FROM [Product] WHERE [Product].ProductId = @ProductId";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@ProductId", id);

                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        public bool UpdateProduct(ProductDTO product, int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = string.Format(@"UPDATE Product SET ProductName = @ProductName, Origin = @Origin, Amount = @Amount, Price = @Price WHERE ProductId = @ProductId");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Origin", product.Origin);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@ProductId", id);
                conn.Open();
                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DataSet GetProduct()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [ProductId], [ProductName] FROM [Product]", conn);               
                da.Fill(ds, "Product");
            }
            return ds;
        }
    }
}
