using System.Data;
using Microsoft.Data.SqlClient;

namespace iNFO.API
{
    public class DBConnection
    {
        private readonly IConfiguration _configuration;
        public DBConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("devConn");
            providerName = "System.Data.SqlClient";
        }

        public string ConnectionString { get; }
        public string providerName { get; }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }
    }
}
