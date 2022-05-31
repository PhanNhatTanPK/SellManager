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
    public class ProductBLL
    {
        private static ProductBLL instance;
        public static ProductBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductBLL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllProduct()
        {

            return ProductDAL.Instance.GetAllProduct();
        }

        public ProductDTO GetProductByName(string name)
        {
            return ProductDAL.Instance.GetProductByName(name);
        }

        public bool AddProduct(ProductDTO product)
        {
            return ProductDAL.Instance.AddProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return ProductDAL.Instance.DeleteProduct(id);
        }

        public bool UpdateProduct(ProductDTO product, int id)
        {

            return ProductDAL.Instance.UpdateProduct(product, id);
        }

        public DataTable GetProductByNameToFind(string name)
        {
            return ProductDAL.Instance.GetProductByNameToFind(name);
        }
    }
}
