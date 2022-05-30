using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI_Web
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            GridView1.DataSource = StudentBLL.Instance.GetAllStudent();
            GridView1.DataBind();
        }

        public StudentDTO CreatStudent()
        {
            bool gender = Boolean.Parse(rbGender.SelectedValue.ToString());
            string extension = System.IO.Path.GetExtension(FileUpload.FileName);
            string fileName = txtFullName.Text + extension;
            StudentDTO student = new StudentDTO { 
                FullName = txtFullName.Text,
                Gender = gender,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                ImageUrl = fileName
            };
            return student;
        }     

        public void UploadImage(string fileName)
        {
            String filePath = "~/images/" + fileName;
            if (FileUpload.HasFile)
            {
                FileUpload.SaveAs(MapPath(filePath));
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            StudentDTO student = CreatStudent();
            StudentBLL.Instance.AddStudent(student);
            UploadImage(student.ImageUrl);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            StudentBLL.Instance.DeleteStudent(fullName);          
            LoadData();
            txtAddress.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            label.Text = "";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            StudentDTO student = CreatStudent();
            
            bool result = StudentBLL.Instance.UpdateStudent(student);
            if (result)
            {
                label.Text = "Bạn đã cập nhật thành công";
                UploadImage(student.ImageUrl);
                LoadData();
            }
            else
            {
                label.Text = "Có lỗi xảy ra";
            }

        }

        public void FillData(StudentDTO student)
        {
            txtFullName.Text = student.FullName;
            txtEmail.Text = student.Email;
            txtAddress.Text = student.Address;          
            rbGender.SelectedIndex = student.Gender ? 0 : 1;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridView1.SelectedRow.Cells[0].Text;
            StudentDTO student = StudentBLL.Instance.GetStudentByName(name);
            if(student != null)
            {
                FillData(student);
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            label.Text = "";
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;         
            GridView1.DataSource = StudentBLL.Instance.GetStudentByNameToFind(name);
            GridView1.DataBind();
        }
    }
}