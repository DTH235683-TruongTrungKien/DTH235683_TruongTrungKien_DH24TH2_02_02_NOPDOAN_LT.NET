using Music_Management.Data;
using System.Data.SQLite;

namespace Music_Management.Data
{
    public static class DbGeneral
    {
        public static void Initialize()
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS ARTISTS (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT UNIQUE NOT NULL,
                    birthDay DATE,
                    country TEXT,
                    imagePath TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS SONGS (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    title TEXT NOT NULL,
                    artistId INTEGER,
                    album TEXT,
                    releaseDate DATE,   
                    duration TEXT,
                    filePath TEXT NOT NULL,
                    FOREIGN KEY (artistId) REFERENCES ARTISTS(id) ON DELETE SET NULL
                );

                CREATE TABLE IF NOT EXISTS PLAYLISTS (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    title TEXT NOT NULL,
                    description TEXT,
                    songQuantity INTEGER   
                );

                CREATE TABLE IF NOT EXISTS PLAYLISTS_SONGS (
                    playlistId INTEGER,
                    songId INTEGER,
                    PRIMARY KEY (playlistId, songId),
                    FOREIGN KEY (playlistId) REFERENCES PLAYLISTS(id) ON DELETE CASCADE,
                    FOREIGN KEY (songId) REFERENCES SONGS(id) ON DELETE CASCADE
                );
            ";
            cmd.ExecuteNonQuery();
        }
        public static int GetNextId(string tableName)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT seq FROM sqlite_sequence WHERE name = @tableName;";
            cmd.Parameters.AddWithValue("@tableName", tableName);

            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result) + 1;
            }
            else
            {
                return 1;
            }
        }

    }
}
