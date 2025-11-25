using Music_Management.Data;
using Music_Management.Models;

namespace Music_Management.Globals
{
    public static class SongCache
    {
        public static List<Song> Songs = new();
        public static List<(Song Song, string Action)> PendingActions = new();
        public static int SongIdCounter = DbGeneral.GetNextId("SONGS");
    }
}
