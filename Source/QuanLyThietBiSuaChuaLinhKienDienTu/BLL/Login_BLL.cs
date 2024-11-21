using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Login_BLL
    {
        private readonly Login_DAL Login_DAL;
        public Login_BLL()
        {
            Login_DAL = new Login_DAL();
        }
        public bool CheckLogin(string userName, string passWord)
        {
            try
            {
                return Login_DAL.CheckLogin(userName, passWord);
            }
            catch (Exception ex)
            {
                throw new Exception("Đăng Nhập Không Thành Công: " + ex.Message);
            }
        }

    }
}
