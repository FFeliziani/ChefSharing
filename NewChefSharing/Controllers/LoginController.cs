using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security;
using NewChefSharing.Models;

namespace NewChefSharing.Controllers
{
    public class LoginController : ApiController
    {
        public string Get()
        {
            return "assoreta";
        }

        public string Post(Login l)
        {
            return l.username + "|" + l.password;
        }
    }
}
