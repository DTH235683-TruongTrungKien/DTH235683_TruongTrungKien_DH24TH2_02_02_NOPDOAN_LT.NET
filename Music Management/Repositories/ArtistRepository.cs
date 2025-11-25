using Music_Management.Models;
using Music_Management.Data;
using System.Data.SQLite;

namespace Music_Management.Repositories
{
    public class ArtistRepository
    {
        public static List<Artist> GetAll()
        {
            var list = new List<Artist>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("SELECT id, name, birthDay, country, imagePath FROM ARTISTS", conn);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Artist
                {
                    Id = rd.GetInt32(0),
                    Name = rd.GetString(1),
                    BirthDay = rd.IsDBNull(2) ? null : rd.GetString(2),
                    Country = rd.IsDBNull(3) ? null : rd.GetString(3),
                    ImagePath = rd.GetString(4),
                });
            }
            return list;
        }

        public static int? GetArtistIdByName(string name)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("SELECT id FROM ARTISTS WHERE name=@name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : null;
        }

        public static void Insert(Artist a)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                INSERT INTO ARTISTS (id, name, birthDay, country, imagePath)
                VALUES (@id, @name, @bd, @country, @img)
            ", conn);

            cmd.Parameters.AddWithValue("@id", a.Id);
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@bd", a.BirthDay ?? "(Không có)");
            cmd.Parameters.AddWithValue("@country", a.Country ?? "(Không có)");
            cmd.Parameters.AddWithValue("@img", a.ImagePath);

            cmd.ExecuteNonQuery();
        }

        public static void Update(Artist a)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand(@"
                UPDATE ARTISTS
                SET name=@name, birthDay=@bd, country=@country, imagePath=@img
                WHERE id=@id
            ", conn);

            cmd.Parameters.AddWithValue("@id", a.Id);
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@bd", a.BirthDay ?? "(Không có)");
            cmd.Parameters.AddWithValue("@country", a.Country ?? "(Không có)");
            cmd.Parameters.AddWithValue("@img", a.ImagePath);

            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SQLiteCommand("DELETE FROM ARTISTS WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
