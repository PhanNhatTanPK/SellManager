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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = UserBLL.Instance.GetAllUser();

        }
        private void SaveBut_Click(object sender, EventArgs e)
        {

            UserDTO user = CreatUser();
            bool result = UserBLL.Instance.AddUser(user);
            if (result)
            {
                label7.Text = "Add successful user";
            }
            else
            {
                label7.Text = "Add failed user";
            }
            LoadData();
        }
        public UserDTO CreatUser()
        {
            UserDTO user = new UserDTO
            {
                FullName = UserNameTex.Text,
                Address = adressTex.Text,
                Phone = phoneTex.Text,
                Email = emailTex.Text,
                Birthday = DateTex.Text
            };
            return user;
        }
        public void FillData(UserDTO user)
        {
            UserNameTex.Text = user.FullName;
            adressTex.Text = user.Address;
            phoneTex.Text = user.Phone;
            emailTex.Text = user.Email;
        }
      

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            UserDTO user = CreatUser();
            int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["UserId"].Value;
            bool result = UserBLL.Instance.UpdateUser(user, id);
            if (result)
            {
                label7.Text = "Successful update information";
                LoadData();
            }
            else
            {
                label7.Text = "Update failed information";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameTex.DataBindings.Clear();
            adressTex.DataBindings.Clear();
            phoneTex.DataBindings.Clear();
            emailTex.DataBindings.Clear();
            DateTex.DataBindings.Clear();
            UserNameTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FullName"));
            adressTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Address"));
            phoneTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Phone"));
            emailTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email"));


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameTex.DataBindings.Clear();
            adressTex.DataBindings.Clear();
            phoneTex.DataBindings.Clear();
            emailTex.DataBindings.Clear();
            DateTex.DataBindings.Clear();
            UserNameTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FullName"));
            adressTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Address"));
            phoneTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Phone"));
            emailTex.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email"));
      
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["UserId"].Value;
            RecipeBLL.Instance.DeleteRecipeByUserId(id);
            bool result = UserBLL.Instance.DeleteUser(id);
            if (result)
            {
                label7.Text = "Successfully deleted the user";
                LoadData();
                UserNameTex.Text = "";
                adressTex.Text = "";
                phoneTex.Text = "";
                emailTex.Text = "";
            }
            else
            {
                label7.Text = "Delete a failed user";
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string name = UserNameTex.Text;
            dataGridView1.DataSource = UserBLL.Instance.GetUserByNameToFind(name);
         
        }

        private void DateTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void emailTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void phoneTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adressTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recipe recipe = new recipe();
            recipe.ShowDialog();
            this.Close();
        }
    }
}
