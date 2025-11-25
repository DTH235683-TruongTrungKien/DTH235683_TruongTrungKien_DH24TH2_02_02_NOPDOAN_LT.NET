using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Management.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? SongQuantity { get; set; }
        public List<Song> Songs { get; set; } = new();
    }

}
