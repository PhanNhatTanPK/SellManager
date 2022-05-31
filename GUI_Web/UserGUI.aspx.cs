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
    public partial class UserGUI : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            GridView1.DataSource = UserBLL.Instance.GetAllUser();
            GridView1.DataBind();
        }

        public UserDTO CreatUser()
        {
            string date = Calendar1.SelectedDate.ToString("dd/MMM/yyyy");
            UserDTO user = new UserDTO
            {
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Birthday = date
            };
            return user;
        }

        public void FillData(UserDTO user)
        {
            txtFullName.Text = user.FullName;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            UserDTO user = CreatUser();
            bool result = UserBLL.Instance.AddUser(user);
            if(result)
            {
                label.Text = "Add successful user";
            }
            else
            {
                label.Text = "Add failed user";
            }
            LoadData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            UserDTO user = CreatUser();
            id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);

            bool result = UserBLL.Instance.UpdateUser(user, id);
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(GridView1.SelectedRow.Cells[0].Text);
            bool result = UserBLL.Instance.DeleteUser(id);
            if(result)
            {
                label.Text = "Successfully deleted the user";
                LoadData();
                txtFullName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";               
            }
            else
            {
                label.Text = "Delete a failed user";
            }
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            label.Text = "";
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            GridView1.DataSource = UserBLL.Instance.GetUserByNameToFind(name);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridView1.SelectedRow.Cells[1].Text;
            UserDTO product = UserBLL.Instance.GetUserByName(name);
            if (product != null)
            {
                FillData(product);
            }
        }
    }
}