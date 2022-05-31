using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private int userId;
        private string fullName, address, phone, email;
        private string birthday;

        public UserDTO()
        {
            this.FullName = fullName;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Birthday = Birthday;
        }

        public int UserId { get => userId; set => userId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Birthday { get => birthday; set => birthday = value; }
    }
}
