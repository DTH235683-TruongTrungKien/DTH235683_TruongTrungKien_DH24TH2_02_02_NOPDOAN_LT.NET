using Music_Management.Data;
using Music_Management.Globals;
using Music_Management.Models;
using Music_Management.Repositories;

namespace Music_Management.Services
{
    public class ArtistService
    {
        // CREATE
        public static void Add(Artist a)
        {
            a.Id = ArtistCache.ArtistIdCounter++;
            ArtistCache.Artists.Add(a);
            ArtistCache.PendingActions.Add((a, "CREATE"));
        }

        // UPDATE
        public static void Edit(Artist a)
        {
            var index = ArtistCache.Artists.FindIndex(x => x.Id == a.Id);
            if (index >= 0)
                ArtistCache.Artists[index] = a;

            ArtistCache.PendingActions.Add((a, "UPDATE"));
        }

        // DELETE
        public static void Delete(int id)
        {
            ArtistCache.Artists.RemoveAll(a => a.Id == id);
            ArtistCache.PendingActions.Add((new Artist { Id = id }, "DELETE"));
        }

        // SAVE
        public static void SaveChanges()
        {
            foreach (var (artist, action) in ArtistCache.PendingActions)
            {
                if (action == "CREATE") ArtistRepository.Insert(artist);
                if (action == "UPDATE") ArtistRepository.Update(artist);
                if (action == "DELETE") ArtistRepository.Delete(artist.Id);
            }

            ArtistCache.Artists = ArtistRepository.GetAll();
            ArtistCache.PendingActions.Clear();
            ArtistCache.ArtistIdCounter = DbGeneral.GetNextId("ARTISTS");
        }

        // CANCEL
        public static void Cancel()
        {
            ArtistCache.Artists = ArtistRepository.GetAll();
            ArtistCache.PendingActions.Clear();
            ArtistCache.ArtistIdCounter = DbGeneral.GetNextId("ARTISTS");
        }
    }
}
