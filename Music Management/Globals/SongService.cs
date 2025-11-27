using Music_Management.Globals;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Data;

namespace Music_Management.Services
{
    public class SongService
    {
        public static void Add(Song s)
        {
            s.Id = SongCache.SongIdCounter++;
            SongCache.Songs.Add(s);
            SongCache.PendingActions.Add((s, "CREATE"));
        }

        public static void Edit(Song s)
        {
            var index = SongCache.Songs.FindIndex(x => x.Id == s.Id);
            if (index >= 0)
                SongCache.Songs[index] = s;

            SongCache.PendingActions.Add((s, "UPDATE"));
        }
        public static void Delete(int id)
        {
            SongCache.Songs.RemoveAll(s => s.Id == id);
            SongCache.PendingActions.Add((new Song { Id = id }, "DELETE"));
        }
        public static void SaveChanges()
        {
            foreach (var (song, action) in SongCache.PendingActions)
            {
                if (action == "CREATE") SongRepository.Insert(song);
                if (action == "UPDATE") SongRepository.Update(song);
                if (action == "DELETE") SongRepository.Delete(song.Id);
            }
            SongCache.Songs = SongRepository.GetAll();
            SongCache.PendingActions.Clear();
            SongCache.SongIdCounter = DbGeneral.GetNextId("SONGS");
        }

        public static void Cancel()
        {
            SongCache.Songs = SongRepository.GetAll();
            SongCache.PendingActions.Clear();
            SongCache.SongIdCounter = DbGeneral.GetNextId("SONGS");
        }
    }
}
