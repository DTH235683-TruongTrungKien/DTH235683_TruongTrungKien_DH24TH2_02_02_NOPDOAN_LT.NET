using Music_Management.Data;
using Music_Management.Models;

namespace Music_Management.Globals
{
    public static class PlaylistCache
    {
        // List playlist tạm
        public static List<Playlist> Playlists = new();

        // Queue CRUD playlist
        public static List<(Playlist Playlist, string Action)> PendingActions = new(); // CREATE | UPDATE | DELETE

        // List Playlist–Song link tạm
        public static List<PlaylistSong> PlaylistSongs = new();
        public static List<(PlaylistSong PlaylistSong, string Action)> PlaylistSongsActions = new();

        public static int PlaylistIdCounter = DbGeneral.GetNextId("PLAYLISTS");
    }
}
