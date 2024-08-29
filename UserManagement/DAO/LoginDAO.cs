using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; } 
            private set { instance = value; } 
        }

        private LoginDAO() { }

        public Tuple<bool, string> Login(string username, string password)
        {
            if (username == "" || password == "")
            {
                return Tuple.Create(false, "Please fill out all required fields");
            }
            else
            {
                DataProvider.Instance.setConStr(username, password);
                (bool, string) tp = DataProvider.Instance.CreateConnection();
                return Tuple.Create(tp.Item1, tp.Item2);
                //return Tuple.Create(false, "Connection error please check your username or password");
            }

        }
    }
}
