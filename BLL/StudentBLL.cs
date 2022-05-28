using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentBLL
    {
        private static StudentBLL instance;
        public static StudentBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentBLL();
                return instance;

            }
            private set { instance = value; }
        }
        public List<StudentDTO> GetAllStudent()
        {
            return StudentDAL.Instance.GetAllStudent();
        }
    }
}
