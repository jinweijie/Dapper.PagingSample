using System.Data;
using System.Data.SqlClient;

namespace Dapper.PagingSample.Repository
{
    public class RepositoryBase
    { /// <summary>
      /// The connection string
      /// </summary>
        protected string ConnectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        protected RepositoryBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

 
        /// <summary>
        /// Opens the connection.
        /// </summary>
        /// <returns></returns>
        protected virtual IDbConnection OpenConnection()
        {
            IDbConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
