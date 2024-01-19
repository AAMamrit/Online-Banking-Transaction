using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Online_Banking_Transaction
{
    public class Common
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BankingTransctionDBConnectionString"].ConnectionString;
        }
    }
}