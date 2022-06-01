using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        private static UserBLL instance;
        public static UserBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBLL();
                return instance;

            }
            private set { instance = value; }
        }

        public DataTable GetAllUser()
        {

            return UserDAL.Instance.GetAllUser();
        }

        public UserDTO GetUserByName(string name)
        {
            return UserDAL.Instance.GetUserByName(name);
        }

        public bool AddUser(UserDTO user)
        {
            return UserDAL.Instance.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            return UserDAL.Instance.DeleteUser(id);
        }

        public bool UpdateUser(UserDTO user, int id)
        {

            return UserDAL.Instance.UpdateUser(user, id);
        }

        public DataTable GetUserByNameToFind(string name)
        {
            return UserDAL.Instance.GetUserByNameToFind(name);
        }

        public DataSet GetUser()
        {
            return UserDAL.Instance.GetUser();
        }
    }
}
