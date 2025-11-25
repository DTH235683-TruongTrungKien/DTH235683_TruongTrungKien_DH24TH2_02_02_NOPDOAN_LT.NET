using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Management.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? BirthDay { get; set; }
        public string? Country { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public List<Song> Songs { get; set; } = new();
    }

}
