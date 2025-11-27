using Music_Management.Data;
using Music_Management.Models;

namespace Music_Management.Globals
{
    public static class PlaylistCache
    {
        public static List<Playlist> Playlists = new();

        public static List<(Playlist Playlist, string Action)> PendingActions = new();

        public static List<PlaylistSong> PlaylistSongs = new();
        public static List<(PlaylistSong PlaylistSong, string Action)> PlaylistSongsActions = new();

        public static int PlaylistIdCounter = DbGeneral.GetNextId("PLAYLISTS");
    }
}
