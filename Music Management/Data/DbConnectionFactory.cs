using System;
using System.Data.SQLite;

namespace Music_Management.Data
{
    public static class DbConnectionFactory
    {
        private static readonly string _connectionString = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\music.db";
        public static SQLiteConnection Create()
        {
            var newConnection = new SQLiteConnection(_connectionString);
            newConnection.Open();

            using var cmd = newConnection.CreateCommand();
            cmd.CommandText = "PRAGMA foreign_keys = ON;";
            cmd.ExecuteNonQuery();

            return newConnection;
        }
    }

}
