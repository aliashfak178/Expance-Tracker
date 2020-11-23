using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Utility
{
    public class DBConfiguration
    {
        private static string connectionString;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["ExpDB"].ConnectionString;
            }
        }
    }
}
