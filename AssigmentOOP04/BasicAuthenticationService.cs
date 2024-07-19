using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP04
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
           
            return username == "user" && password == "password";
        }

        public bool AuthorizeUser(string username, string role)
        {
          
            return username == "admin" && role == "admin";
        }
    }
    }
