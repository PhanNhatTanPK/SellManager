using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI_Desktop
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
             User user = new User();
            user.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recipe recipe = new recipe();
            recipe.ShowDialog();
            this.Close();
        }
        public ProductDTO CreatProduct()
        {
            int amount = Int32.Parse(AmountTex.Text);
            int price = Int32.Parse(PriceTex.Text);
            ProductDTO product = new ProductDTO
            {
                ProductName = productTex.Text,
                Origin = OriginTex.Text,
                Amount = amount,
                Price = price,
            };
            return product;
        }
        private void SaveBut_Click(object sender, EventArgs e)
        {
            ProductDTO product = CreatProduct();
            bool result = ProductBLL.Instance.AddProduct(product);
            if (result)
            {
                label6.Text = "Add successful product";
                LoadData();
            }
            else
            {
                label6.Text = "Add failed product";
            }
        }
        public void LoadData()
        {
            dataGridView1.DataSource = ProductBLL.Instance.GetAllProduct();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productTex.DataBindings.Clear();
            OriginTex.DataBindings.Clear();
            AmountTex.DataBindings.Clear();
            PriceTex.DataBindings.Clear();
            productTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ProductName"));
            OriginTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Origin"));
            AmountTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Amount"));
            PriceTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Price"));
   
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {

            ProductDTO product = CreatProduct();
            int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["ProductId"].Value;

            bool result = ProductBLL.Instance.UpdateProduct(product, id);
            if (result)
            {
                label6.Text = "Successful update information";
                LoadData();
            }
            else
            {
                label6.Text = "Update failed information";
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["ProductId"].Value;
            RecipeBLL.Instance.DeleteRecipeByProductId(id);
            bool result = ProductBLL.Instance.DeleteProduct(id);
            if (result)
            {
                label6.Text = "Successfully deleted the product";
                LoadData();
                productTex.Text = "";
                OriginTex.Text = "";
                AmountTex.Text = "";
                PriceTex.Text = "";
            }
            else
            {
                label6.Text = "Delete a failed product";
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string name = productTex.Text;
            dataGridView1.DataSource = ProductBLL.Instance.GetProductByNameToFind(name);
        }
    }
}
