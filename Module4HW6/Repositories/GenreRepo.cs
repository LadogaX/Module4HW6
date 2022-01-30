using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6.Repositories
{
    public class GenreRepo
    {
        private readonly ApplicationDbContext _context;

        public GenreRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Genre artist)
        {
            await _context.Genres.AddAsync(artist);
        }

        public async Task<int> GetCountRows()
        {
            try
            {
                return await _context.Genres.CountAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
