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
    public partial class recipe : Form
    {
        public recipe()
        {
            InitializeComponent();

            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.ShowDialog();
            this.Close();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            RecipeDTO recipe = CreatRecipe();
            ProductDTO product = ProductBLL.Instance.GetProductById(recipe.ProductId);
            if (recipe.Amounts < product.Amount)
            {
                bool result = RecipeBLL.Instance.AddRecipe(recipe);
                if (result)
                {
                    label6.Text = "Add successful recipe";
                    LoadData();
                }
                else
                {
                    label6.Text = "Add failed recipe";
                }
            }
            else
            {
                label6.Text = "Not enough to provide";
            }
        }

        private void productNameTex_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void productNameTex_TextChanged(object sender, EventArgs e)
        {
          
        }
        public void LoadData()
        {
            dataGridView1.DataSource = RecipeBLL.Instance.GetAllRecipe();
        }

        private void recipe_Load(object sender, EventArgs e)
        {

                 comboBox1.DataSource = UserBLL.Instance.GetAllUser();
                 comboBox1.DisplayMember = "FullName";
                 comboBox1.ValueMember = "UserId";
 



                 comboBox2.DataSource = ProductBLL.Instance.GetAllProduct();
                 comboBox2.DisplayMember = "ProductName";
                 comboBox2.ValueMember = "ProductId";


            LoadData();
            

        }
       
        public RecipeDTO CreatRecipe()
        {
            RecipeDTO recipe = new RecipeDTO
            {
                UserId = Int32.Parse(comboBox1.SelectedValue.ToString()),
                ProductId = Int32.Parse(comboBox2.SelectedValue.ToString()),
                Amounts = Int32.Parse(AmountTex.Text)
            };
            return recipe;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.DataBindings.Clear();
            comboBox2.DataBindings.Clear();
            AmountTex.DataBindings.Clear();
           
            comboBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FullName"));
            comboBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ProductName"));
            AmountTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Amounts"));
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["RecipeId"].Value;
            bool result = RecipeBLL.Instance.DeleteRecipe(id);
            if (result)
            {
                label6.Text = "Successfully deleted the recipe";
                LoadData();
                AmountTex.Text = "";
            }
            else
            {
                label6.Text = "Delete a failed recipe";
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedValue;
            dataGridView1.DataSource =  RecipeBLL.Instance.GetRecipeByUserId(id);
        }
    }
}
