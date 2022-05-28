using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        private int studentID;
        private string fullName, email, imageUrl, address;
        private bool gender;

        public StudentDTO(DataRow row)
        {
            this.StudentID = (int)row["StudentID"];
            this.FullName = (string)row["FullName"];
            this.Gender = (bool)row["Gender"];
            this.Address = (string)row["Address"];
            this.Email = (string)row["Email"];
            this.ImageUrl = (string)row["ImageUrl"];
        }

        public StudentDTO(int studentID, string fullName, bool gender, string address, string email, string imageUrl)
        {
            this.StudentID = studentID;
            this.FullName = fullName;
            this.Gender = gender;
            this.Address = address;
            this.Email = email;
            this.ImageUrl = imageUrl;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Address { get => address; set => address = value; }
        public bool Gender { get => gender; set => gender = value; }
    }
}
