using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI_Web
{
    public partial class ProductGUI : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            GridView1.DataSource = ProductBLL.Instance.GetAllProduct();
            GridView1.DataBind();
        }

        public ProductDTO CreatProduct()
        {
            int amount = Int32.Parse(txtAmount.Text);
            int price = Int32.Parse(txtPrice.Text);
            ProductDTO product = new ProductDTO
            {
                ProductName = txtProductName.Text,
                Origin = txtOrigin.Text,
                Amount = amount,
                Price = price,             
            };
            return product;
        }   

        public void FillData(ProductDTO product)
        {
            txtProductName.Text = product.ProductName;
            txtOrigin.Text = product.Origin;
            txtAmount.Text = product.Amount.ToString();
            txtPrice.Text = product.Price.ToString();
        }
       
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            ProductDTO product = CreatProduct();
            bool result = ProductBLL.Instance.AddProduct(product);
            if(result)
            {
                label.Text = "Add successful product";
                LoadData();
            }
            else
            {
                label.Text = "Add failed product";
            }         
        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {
            ProductDTO product = CreatProduct();
            int id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);

            bool result = ProductBLL.Instance.UpdateProduct(product, id);
            if (result)
            {
                label.Text = "Successful update information";              
                LoadData();
            }
            else
            {
                label.Text = "Update failed information";
            }
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            int id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);
            RecipeBLL.Instance.DeleteRecipeByProductId(id);
            bool result = ProductBLL.Instance.DeleteProduct(id);
            if(result)
            {
                label.Text = "Successfully deleted the product";
                LoadData();
                txtProductName.Text = "";
                txtOrigin.Text = "";
                txtAmount.Text = "";
                txtPrice.Text = "";
            }
            else
            {
                label.Text = "Delete a failed product";
            }
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtOrigin.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";
            label.Text = "";
        }

        protected void btnFind_Click1(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            GridView1.DataSource = ProductBLL.Instance.GetProductByNameToFind(name);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {          
            string name = GridView1.SelectedRow.Cells[1].Text;
            ProductDTO product = ProductBLL.Instance.GetProductByName(name);
            if (product != null)
            {
                FillData(product);
            }
        }
    }

}