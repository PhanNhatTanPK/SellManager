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

       public StudentDTO ()
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Email = email;
            this.Address = address;
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
