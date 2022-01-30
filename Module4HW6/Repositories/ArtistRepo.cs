using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6.Repositories
{
    public class ArtistRepo
    {
        private readonly ApplicationDbContext _context;

        public ArtistRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Artist artist)
        {
            await _context.Artists.AddAsync(artist);
        }

        public async Task<int> GetCountRows()
        {
            try
            {
                return await _context.Artists.CountAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
