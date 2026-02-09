using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;


namespace FinanceTracker
{
    public static class Database
    {
        public static SqlConnection GetConnection()
        {
            // Absolute designer protection
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return null;

            var cs = ConfigurationManager.ConnectionStrings["DBConn"];

            // NEVER throw here — Designer must survive
            if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                return null;

            return new SqlConnection(cs.ConnectionString);
        }

    }
}
