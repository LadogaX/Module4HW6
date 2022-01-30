using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.Entities
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? InstagramUrl { get; set; }

        public virtual List<Song> SongList { get; set; } = new ();
    }
}
