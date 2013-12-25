using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using MySql.Data.MySqlClient;

namespace BaseLayout.Functions
{
    public partial class Database : IDisposable
    {
        private const bool Testing = true;

        private readonly MySqlConnection _con;

        public Database()
        {
            _con = Testing
                ? new MySqlConnection("Server=127.0.0.1;Database=UndeadCrypt;uid=root;password=;Pooling=true;Connection Timeout=30;MinimumPoolSize=10;MaximumPoolSize=1200;")
                : new MySqlConnection("Server=127.0.0.1;Database=UndeadCrypt;uid=root;password=;Pooling=true;Connection Timeout=30;MinimumPoolSize=10;MaximumPoolSize=1200;");
            _con.Open();
        }

        public void Dispose()
        {
            _con.Close();
        }

        public MySqlCommand CreateQuery()
        {
            return _con.CreateCommand();
        }

        public static int DataTimeToUnixTimestamp(DateTime dateTime)
        {
            return (int)(dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }

        public void GetProjects()
        {
            var cmd = CreateQuery();
            cmd.CommandText = "SELECT name, title, author, regTime, serial, desc FROM projects ORDER BY date LIMIT 9";
            
            Dispose();
        }
    }
}
