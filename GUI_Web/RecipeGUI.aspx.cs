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
    public partial class RecipeGUI : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            listUser.DataSource = UserBLL.Instance.GetUser();
            listUser.DataTextField = "FullName";
            listUser.DataValueField = "UserId";
            listUser.DataBind();

            listProduct.DataSource = ProductBLL.Instance.GetProduct();
            listProduct.DataTextField = "ProductName";
            listProduct.DataValueField = "ProductId";
            listProduct.DataBind();

            LoadData();
        }
        public void LoadData()
        {
            GridView1.DataSource = RecipeBLL.Instance.GetAllRecipe();
            GridView1.DataBind();
        }

        public RecipeDTO CreatRecipe()
        {

            RecipeDTO recipe = new RecipeDTO
            {
                UserId = Int32.Parse(listUser.SelectedValue.ToString()),
                ProductId = Int32.Parse(listProduct.SelectedValue.ToString()),
                Amounts = Int32.Parse(txtAmount.Text)
            };
            return recipe;
        }

        public void FillData(RecipeDTO recipe)
        {
            listProduct.Text = recipe.ProductId.ToString();
            listUser.Text = recipe.UserId.ToString();
            txtAmount.Text = recipe.Amounts.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            RecipeDTO recipe = CreatRecipe();
            ProductDTO product = ProductBLL.Instance.GetProductById(recipe.ProductId);
            if(recipe.Amounts < product.Amount)
            {
                bool result = RecipeBLL.Instance.AddRecipe(recipe);
                if (result)
                {
                    label.Text = "Add successful recipe";
                    LoadData();
                }
                else
                {
                    label.Text = "Add failed recipe";
                }               
            }
            else
            {
                label.Text = "Khong du so luong cung cap";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);
            bool result = RecipeBLL.Instance.DeleteRecipe(id);
            if (result)
            {
                label.Text = "Successfully deleted the recipe";
                LoadData();                
                txtAmount.Text = "";
            }
            else
            {
                label.Text = "Delete a failed recipe";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            label.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);
            RecipeDTO recipe = RecipeBLL.Instance.GetRecipeById(id);
            if (recipe != null)
            {
                FillData(recipe);
            }
        }
    }
}