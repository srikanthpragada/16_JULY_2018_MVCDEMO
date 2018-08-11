using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MvcDemo.Models
{
    public class Database
    {
        public static string LocalDbConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            }
        }
    }
}