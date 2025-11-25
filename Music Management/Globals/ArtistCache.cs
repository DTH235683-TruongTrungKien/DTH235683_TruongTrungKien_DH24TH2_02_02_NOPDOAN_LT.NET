using Music_Management.Data;
using Music_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Management.Globals
{
    public static class ArtistCache
    {
        public static List<Artist> Artists { get; set; } = new();
        public static List<(Artist artist, string action)> PendingActions { get; set; } = new();
        public static int ArtistIdCounter { get; set; } = DbGeneral.GetNextId("ARTISTS");
    }
}
