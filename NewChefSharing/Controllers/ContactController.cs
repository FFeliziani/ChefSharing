﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewChefSharing.Controllers
{
    public class ContactController : ApiController
    {
        public string[] Get()
        {
            return new string[]
            {
                "hello",
                "world"
            };
        }
    }
}