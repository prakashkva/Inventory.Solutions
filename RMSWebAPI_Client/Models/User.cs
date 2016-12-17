using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RMSWebAPI_Client.Models
{
    public class User
    {
        public long Oid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}