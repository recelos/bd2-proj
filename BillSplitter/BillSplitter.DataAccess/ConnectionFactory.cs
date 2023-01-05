using BillSplitter.DataAccess.Properties;
using MySql.Data.MySqlClient;

namespace BillSplitter.DataAccess
{
    internal static class ConnectionFactory
    {
        public static MySqlConnection Create()
            => new MySqlConnection(Resources.ConnectionString);
    }
}
