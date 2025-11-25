using System.Data.SQLite;
using Music_Management.Data;
using Music_Management.Models;

namespace Music_Management.Repositories
{
    public class PlaylistRepository
    {
        public static List<Playlist> GetAll()
        {
            var list = new List<Playlist>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("SELECT id, title, description, songQuantity FROM PLAYLISTS", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Playlist
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Description = rd.IsDBNull(2) ? null : rd.GetString(2),
                    SongQuantity = rd.IsDBNull(3) ? 0 : rd.GetInt32(3)
                });
            }
            return list;
        }

        public static void Insert(Playlist p)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                INSERT INTO PLAYLISTS (id, title, description, songQuantity)
                VALUES (@id, @title, @desc, @qty)
            ", conn);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@title", p.Title);
            cmd.Parameters.AddWithValue("@desc", p.Description);
            cmd.Parameters.AddWithValue("@qty", p.SongQuantity);
            cmd.ExecuteNonQuery();
        }

        public static void Update(Playlist p)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                UPDATE PLAYLISTS
                SET title = @title, description = @desc, songQuantity = @qty
                WHERE id = @id
            ", conn);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@title", p.Title);
            cmd.Parameters.AddWithValue("@desc", p.Description);
            cmd.Parameters.AddWithValue("@qty", p.SongQuantity);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("DELETE FROM PLAYLISTS WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        // PlaylistSongs
        public static void InsertLink(PlaylistSong ps)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                INSERT INTO PLAYLISTS_SONGS (playlistId, songId) VALUES (@p, @s)
            ", conn);
            cmd.Parameters.AddWithValue("@p", ps.PlaylistId);
            cmd.Parameters.AddWithValue("@s", ps.SongId);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteLink(PlaylistSong ps)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                DELETE FROM PLAYLISTS_SONGS WHERE playlistId=@p AND songId=@s
            ", conn);
            cmd.Parameters.AddWithValue("@p", ps.PlaylistId);
            cmd.Parameters.AddWithValue("@s", ps.SongId);
            cmd.ExecuteNonQuery();
        }

        public static List<PlaylistSong> GetPlaylistSongs()
        {
            var list = new List<PlaylistSong>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("SELECT playlistId, songId FROM PLAYLISTS_SONGS", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
                list.Add(new PlaylistSong
                {
                    PlaylistId = rd.GetInt32(0),
                    SongId = rd.GetInt32(1)
                });
            return list;
        }
        public static List<Song> GetSongsInPlaylist(int playlistId)
        {
            var list = new List<Song>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                SELECT s.id, s.title, s.album, s.releaseDate, s.duration, s.filePath,
                       a.id, a.name
                FROM SONGS s
                JOIN PLAYLISTS_SONGS ps ON s.id = ps.songId
                LEFT JOIN ARTISTS a ON s.artistId = a.id
                WHERE ps.playlistId = @p
            ", conn);
            cmd.Parameters.AddWithValue("@p", playlistId);
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
    }
}
