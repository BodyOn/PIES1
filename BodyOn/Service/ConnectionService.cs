using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BodyOn.Service
{
    public class ConnectionService
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=senha@123;Database=bodyon");

        public DataTable executeSql(string comm) {
            DataTable dt = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand(comm, this.connection);

            try {
                connection.Open();
                dt.Load(command.ExecuteReader());
                
                connection.Close();
            } catch (NpgsqlException e) {
                connection.Close();
                throw e;
            }

            return dt;
        }

        public ConnectionService() { 
            
        }
}
}
