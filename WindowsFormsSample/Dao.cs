using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSample
{
    internal static class Dao
    {
        private static string test = Config.DBServerName;
        private static readonly string _conStr = $"Server={Config.DBServerName};Database={Config.DBDatabaseName};User ID={Config.DBUserID};Password={Config.DBPassword};";

        public static DataSet GetStadiums()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _conStr;
            var command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT ID, StadiumName, Prefecture FROM BoatRace.dbo.Stadiums ORDER BY ID";
            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            var ds = new DataSet();
            adapter.Fill(ds);

            return ds;
        }
    }
}
