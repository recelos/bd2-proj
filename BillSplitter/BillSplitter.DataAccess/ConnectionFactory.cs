using BillSplitter.DataAccess.Properties;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter.DataAccess
{
    internal static class ConnectionFactory
    {
        public static  MySqlConnection Create()
            => new MySqlConnection(Resources.ConnectionString);
    }
}
