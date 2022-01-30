using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public virtual List<Song> SongList { get; set; } = new ();
    }
}
