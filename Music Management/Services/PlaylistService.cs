using Music_Management.Data;
using Music_Management.Globals;
using Music_Management.Models;
using Music_Management.Repositories;

namespace Music_Management.Services
{
    public class PlaylistService
    {
        public static void AddPlaylist(Playlist p)
        {
            p.Id = PlaylistCache.PlaylistIdCounter++;
            PlaylistCache.Playlists.Add(p);
            PlaylistCache.PendingActions.Add((p, "CREATE"));
        }

        public static void EditPlaylist(Playlist p)
        {
            var index = PlaylistCache.Playlists.FindIndex(x => x.Id == p.Id);
            if (index >= 0)
                PlaylistCache.Playlists[index] = p;
            PlaylistCache.PendingActions.Add((p, "UPDATE"));
        }

        public static void DeletePlaylist(int id)
        {
            PlaylistCache.Playlists.RemoveAll(p => p.Id == id);
            PlaylistCache.PendingActions.Add((new Playlist { Id = id }, "DELETE"));

            var links = PlaylistCache.PlaylistSongs.Where(x => x.PlaylistId == id).ToList();
            foreach (var link in links)
                PlaylistCache.PlaylistSongsActions.Add((link, "DELETE"));
            PlaylistCache.PlaylistSongs.RemoveAll(x => x.PlaylistId == id);
        }

        public static void AddSongToPlaylist(PlaylistSong ps)
        {
            PlaylistCache.PlaylistSongs.Add(ps);
            PlaylistCache.PlaylistSongsActions.Add((ps, "CREATE"));

            var playlist = PlaylistCache.Playlists.FirstOrDefault(p => p.Id == ps.PlaylistId);
            if (playlist != null)
                playlist.SongQuantity = PlaylistCache.PlaylistSongs.Count(x => x.PlaylistId == ps.PlaylistId);
        }

        public static void RemoveSongFromPlaylist(PlaylistSong ps)
        {
            PlaylistCache.PlaylistSongs.RemoveAll(x => x.SongId == ps.SongId);
            PlaylistCache.PlaylistSongsActions.Add((ps, "DELETE"));

            var playlist = PlaylistCache.Playlists.FirstOrDefault(p => p.Id == ps.PlaylistId);
            if (playlist != null)
                playlist.SongQuantity = PlaylistCache.PlaylistSongs.Count(x => x.PlaylistId == ps.PlaylistId);
        }

        public static void SaveChanges()
        {
            foreach (var (playlist, action) in PlaylistCache.PendingActions)
            {
                if (action == "CREATE") PlaylistRepository.Insert(playlist);
                if (action == "UPDATE") PlaylistRepository.Update(playlist);
                if (action == "DELETE") PlaylistRepository.Delete(playlist.Id);
            }

            foreach (var (link, action) in PlaylistCache.PlaylistSongsActions)
            {
                if (action == "CREATE") PlaylistRepository.InsertLink(link);
                if (action == "DELETE") PlaylistRepository.DeleteLink(link);
            }

            PlaylistCache.Playlists = PlaylistRepository.GetAll();
            PlaylistCache.PendingActions.Clear();
            PlaylistCache.PlaylistIdCounter = DbGeneral.GetNextId("Playlists");

            PlaylistCache.PlaylistSongsActions.Clear();
            PlaylistCache.PlaylistSongs = PlaylistRepository.GetPlaylistSongs();
        }

        public static void Cancel()
        {
            PlaylistCache.Playlists = PlaylistRepository.GetAll();
            PlaylistCache.PendingActions.Clear();
            PlaylistCache.PlaylistIdCounter = DbGeneral.GetNextId("Playlists");

            PlaylistCache.PlaylistSongsActions.Clear();
            PlaylistCache.PlaylistSongs = PlaylistRepository.GetPlaylistSongs();
        }
    }
}
