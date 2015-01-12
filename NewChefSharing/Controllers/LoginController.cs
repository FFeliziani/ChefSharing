using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security;
using System.Guid;

namespace NewChefSharing.Controllers
{
    public class LoginController : ApiController
    {
        public string Login(string username, string md5)
        {
            return "[INSERT HERE SESSION TOKEN!]";
        }
    }
}
