using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ClothStore2
{
    class DataBase
    {
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(@"Server = localhost; port = 5432; user id = postgres; password = sasha; database = store;");


        public void openConnection()
        {
            if(npgsqlConnection.State == System.Data.ConnectionState.Closed)
            {
                npgsqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgsqlConnection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return npgsqlConnection;
        }
    }
}
