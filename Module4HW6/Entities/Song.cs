﻿namespace Module4HW6.Entities
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public TimeSpan Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; } = null!;

        public virtual List<Artist> ArtistList { get; set; } = new ();
    }
}
