using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6
{
    public class TaskQuary
    {
        private readonly ApplicationDbContext _context;

        public TaskQuary(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Task1()
        {
            var task1 = await _context.Songs.Include(s => s.Genre)
                                    .SelectMany(s => s.ArtistList, (s, a) => new { Title = s.Title, Genre = s.Genre.Title, Artist = a.Name })
                                    .Where(r => (r.Genre != null && r.Artist != null)).ToListAsync();

            int counter = 0;
            foreach (var item in task1)
            {
                Console.WriteLine($"{++counter}) Song: {item.Title} Genre:{item.Genre} Artist: {item.Artist}");
            }
        }

        public async Task Task1a()
        {
            var task1 = await _context.Songs.Include(s => s.Genre)
                                      .Include(s => s.ArtistList)
                                      .Select(s => new
                                      {
                                          Title = s.Title,
                                          Genre = s.Genre.Title,
                                          Artist = s.ArtistList.FirstOrDefault() !.Name ?? string.Empty
                                      })
                                      .Where(r => (r.Genre != null && r.Artist != null))
                                      .ToListAsync();

            int counter = 0;
            foreach (var item in task1)
            {
                Console.WriteLine($"{++counter}) Song: {item.Title} Genre:{item.Genre} Artist: {item.Artist}");
            }
        }

        public async Task Task2()
        {
            var task2 = await _context.Songs
                .Include(h => h.Genre)
                .GroupBy(g => g.Genre.Title)
                .Select(ss => new
                {
                    Genre = ss.Key,
                    Count = ss.Count()
                }).ToListAsync();

            foreach (var item in task2)
            {
                Console.WriteLine($"Genre:{item.Genre} Count: {item.Count}");
            }
        }

        public async Task Task3()
        {
            var yongArtist = _context.Artists.Min(m => m.DateOfBirth);

            var listSong = await _context.Songs.Where(s => s.ReleasedDate < yongArtist).ToListAsync();
            Console.WriteLine($"birthday of the youngest artist: {yongArtist.ToString("dd-mm-yyyy")}");
            foreach (var item in listSong)
            {
                Console.WriteLine($"Song: {item.Title} date:{item.ReleasedDate.ToString("dd-mm-yyyy")} ");
            }
        }
    }
}
