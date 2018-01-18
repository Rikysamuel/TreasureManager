using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Npgsql;
using TreasureManager.Business.Utils;

namespace TreasureManager.Business.Manager
{
    public class DbContext
    {
        private static NpgsqlConnection _connection = null;

        public static NpgsqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection =
                    new NpgsqlConnection(
                        ConfigurationManager.ConnectionStrings[TMConstants.ConnectionString.NAME].ToString());

                _connection.Open();
            }

            return _connection;
        }

        public static void CloseCOnenction()
        {
            _connection.Close();
        }
    }
}
