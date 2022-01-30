using Module4HW6.Entities;

namespace Module4HW6.Helpers
{
    public class AddInitRows
    {
        private readonly ApplicationDbContext _context;

        public AddInitRows(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task FillGenres()
        {
            await _context.Genres.AddAsync(new Genre() { Title = "Jazz" });
            await _context.Genres.AddAsync(new Genre() { Title = "Hip - Hop" });
            await _context.Genres.AddAsync(new Genre() { Title = "Electronic" });
            await _context.Genres.AddAsync(new Genre() { Title = "Rock" });
            await _context.Genres.AddAsync(new Genre() { Title = "Disco" });
            await _context.Genres.AddAsync(new Genre() { Title = "Fusion" });
            await _context.Genres.AddAsync(new Genre() { Title = "Pop Music" });

            await _context.SaveChangesAsync();
        }

        public async Task FillArtistSongs()
        {
            var artist1 = new Artist() { Name = "Marvin", Email = "Marvin@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)132 - 67 - 71" };
            var artist2 = new Artist() { Name = "Vernon", Email = "Vernon@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)823 - 45 - 86" };
            var artist3 = new Artist() { Name = "Juan", Email = "Juan@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)707 - 24 - 27" };
            var artist4 = new Artist() { Name = "Rodney", Email = "Rodney@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)727 - 31 - 50" };
            var artist5 = new Artist() { Name = "Daniel", Email = "Daniel@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)396 - 31 - 05" };
            var artist6 = new Artist() { Name = "Danny", Email = "Danny@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)910 - 69 - 67" };
            var artist7 = new Artist() { Name = "Gilbert", Email = "Gilbert@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)710 - 96 - 58" };
            var artist8 = new Artist() { Name = "John", Email = "John@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)560 - 92 - 77" };
            var artist9 = new Artist() { Name = "James", Email = "James@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)524 - 47 - 15" };
            var artist10 = new Artist() { Name = "Robert", Email = "Robert@gmail.com", DateOfBirth = new DateTime(1985, 1, 1), Phone = "+380(063)693 - 80 - 45" };

            var item1 = new Song() { Title = "Like a Rolling Stone", Duration = new TimeSpan(0, 2, 10), ReleasedDate = new DateTime(1965, 1, 2), GenreId = 1, ArtistList = new List<Artist>() { artist1, artist3 } };
            var item2 = new Song() { Title = "I Can’t Get No) Satisfaction ", Duration = new TimeSpan(0, 2, 20), ReleasedDate = new DateTime(1961, 2, 12), GenreId = 2, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item3 = new Song() { Title = "Imagine", Duration = new TimeSpan(0, 3, 2), ReleasedDate = new DateTime(1970, 5, 6), GenreId = 3, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item4 = new Song() { Title = "What’s Going On ", Duration = new TimeSpan(0, 1, 10), ReleasedDate = new DateTime(1985, 3, 29), GenreId = 4, ArtistList = new List<Artist>() { artist10, artist3, artist7 } };
            var item5 = new Song() { Title = "Respect", Duration = new TimeSpan(0, 2, 10), ReleasedDate = new DateTime(1965, 7, 19), GenreId = 2, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item6 = new Song() { Title = "Good Vibrations", Duration = new TimeSpan(0, 5, 1), ReleasedDate = new DateTime(1951, 10, 28), GenreId = 5, ArtistList = new List<Artist>() { artist7, artist7, artist9 } };
            var item7 = new Song() { Title = "Johnny B. Goode", Duration = new TimeSpan(0, 4, 52), ReleasedDate = new DateTime(1948, 11, 30), GenreId = 6, ArtistList = new List<Artist>() { artist6, } };
            var item8 = new Song() { Title = "Hey Jude", Duration = new TimeSpan(0, 3, 59), ReleasedDate = new DateTime(1975, 8, 29), GenreId = 7, ArtistList = new List<Artist>() { artist1, artist2, artist4 } };
            var item9 = new Song() { Title = "Smells Like Teen Spirit", Duration = new TimeSpan(0, 3, 58), ReleasedDate = new DateTime(1969, 6, 25), GenreId = 1, ArtistList = new List<Artist>() { artist8, artist9 } };
            var item10 = new Song() { Title = "What’d I Say", Duration = new TimeSpan(0, 1, 10), ReleasedDate = new DateTime(1953, 11, 22), GenreId = 1, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item11 = new Song() { Title = "My Generation", Duration = new TimeSpan(0, 5, 10), ReleasedDate = new DateTime(1969, 12, 18), GenreId = 5, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item12 = new Song() { Title = "A Change Is Gonna Come", Duration = new TimeSpan(0, 6, 55), ReleasedDate = new DateTime(1961, 4, 17), GenreId = 3, ArtistList = new List<Artist>() { artist4, artist5, artist6 } };
            var item13 = new Song() { Title = "Yesterday", Duration = new TimeSpan(0, 2, 47), ReleasedDate = new DateTime(1985, 5, 25), GenreId = 2, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item14 = new Song() { Title = "Blowin’ in the Wind", Duration = new TimeSpan(0, 3, 15), ReleasedDate = new DateTime(1996, 6, 1), GenreId = 4, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item15 = new Song() { Title = "London Calling", Duration = new TimeSpan(0, 2, 58), ReleasedDate = new DateTime(1999, 8, 2), GenreId = 3, ArtistList = new List<Artist>() { artist10, artist9, artist5 } };
            var item16 = new Song() { Title = "I Want to Hold Your Hand", Duration = new TimeSpan(0, 2, 42), ReleasedDate = new DateTime(1965, 1, 17), GenreId = 4, ArtistList = new List<Artist>() { artist7, artist3, artist4 } };
            var item17 = new Song() { Title = "Purple Haze", Duration = new TimeSpan(0, 2, 05), ReleasedDate = new DateTime(1967, 12, 23), GenreId = 1, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item18 = new Song() { Title = "Maybellene", Duration = new TimeSpan(0, 2, 39), ReleasedDate = new DateTime(1981, 8, 12), GenreId = 2, ArtistList = new List<Artist>() { artist1, artist3, artist4 } };
            var item19 = new Song() { Title = "Hound Dog", Duration = new TimeSpan(0, 3, 45), ReleasedDate = new DateTime(1984, 5, 1), GenreId = 1, ArtistList = new List<Artist>() { artist1, artist3 } };
            var item20 = new Song() { Title = "Let It Be", Duration = new TimeSpan(0, 2, 49), ReleasedDate = new DateTime(1997, 12, 22), GenreId = 5, ArtistList = new List<Artist>() { artist1, artist3, artist5 } };

            await _context.Songs.AddRangeAsync(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20);

            await _context.SaveChangesAsync();
        }
    }
}
