using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Resources;
using System.Configuration;

namespace Deypal
{
    public static class LocalDbSetup
    {
        public static void Initialize()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string test1;
            string test2;

            test1 = System.AppDomain.CurrentDomain.BaseDirectory;
            test2 = ConfigurationManager.ConnectionStrings[Properties.Resources.AppDataConnName].ToString();
            
        }

        public static bool TestConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings[Properties.Resources.AppDataConnName].ToString();
            SQLiteConnection conn = new SQLiteConnection(conStr);

            conn.Open();

            return true;
        }
    }
}
