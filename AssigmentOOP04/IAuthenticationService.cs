﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP04
{
    internal interface IAuthenticationService
    {

        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);

    }
}
