using Music_Management.Models;
using Music_Management.Data;
using System.Data.SQLite;

namespace Music_Management.Repositories
{
    public class SongRepository
    {
        public static List<Song> GetAll()
        {
            var list = new List<Song>();

            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                SELECT s.id, s.title, s.album, s.releaseDate, s.duration, s.filePath,
                       a.id, a.name
                FROM SONGS s
                LEFT JOIN ARTISTS a ON s.artistId = a.id;
            ", conn);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                var song = new Song
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Album = rd.IsDBNull(2) ? null : rd.GetString(2),
                    ReleaseDate = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Duration = rd.IsDBNull(4) ? null : rd.GetString(4),
                    FilePath = rd.GetString(5),
                    Artist = rd.IsDBNull(6) ? null : new Artist
                    {
                        Id = rd.GetInt32(6),
                        Name = rd.GetString(7)
                    }
                };
                list.Add(song);
            }

            return list;
        }
        public static List<Song> GetSongByArtistId(int artistId)
        {
            var list = new List<Song>();

            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                SELECT id, title, album, releaseDate, duration, filePath
                FROM SONGS
                WHERE artistId=@artistId", conn);
            cmd.Parameters.AddWithValue("@artistId", artistId);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                var song = new Song
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Album = rd.IsDBNull(2) ? null : rd.GetString(2),
                    ReleaseDate = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Duration = rd.IsDBNull(4) ? null : rd.GetString(4),
                    FilePath = rd.GetString(5),
      
                };
                list.Add(song);
            }

            return list;
        }


        public static void Insert(Song s)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                INSERT INTO SONGS (id, title, artistId, album, releaseDate, duration, filePath)
                VALUES (@id, @title, @artistId, @album, @release, @duration, @file)
            ", conn);

            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@title", s.Title);
            cmd.Parameters.AddWithValue("@artistId", s.Artist?.Id);
            cmd.Parameters.AddWithValue("@album", s.Album);
            cmd.Parameters.AddWithValue("@release", s.ReleaseDate);
            cmd.Parameters.AddWithValue("@duration", s.Duration);
            cmd.Parameters.AddWithValue("@file", s.FilePath);

            cmd.ExecuteNonQuery();
        }

        public static void Update(Song s)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                UPDATE SONGS SET
                    title = @title,
                    artistId = @artistId,
                    album = @album,
                    releaseDate = @release,
                    duration = @duration,
                    filePath = @file
                WHERE id = @id
            ", conn);

            cmd.Parameters.AddWithValue("@title", s.Title);
            cmd.Parameters.AddWithValue("@artistId", (object?)s.Artist?.Id ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@album", s.Album);
            cmd.Parameters.AddWithValue("@release", s.ReleaseDate);
            cmd.Parameters.AddWithValue("@duration", s.Duration);
            cmd.Parameters.AddWithValue("@file", s.FilePath);
            cmd.Parameters.AddWithValue("@id", s.Id);

            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("DELETE FROM SONGS WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
