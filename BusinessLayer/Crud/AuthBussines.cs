using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class AuthBussines
    {

        AuthData authData = new AuthData();

        public bool LoginUser(string email, string password)
        {
            return authData.Login(email, password);
        }

        public int RegisterUser(string Name, string email, string password)
        {
            return authData.Register(Name, email, password);
        }

        public string GetPasswordByUserName(string name)
        {
            return authData.GetPasswordByUserName(name);

        }
    }
}
