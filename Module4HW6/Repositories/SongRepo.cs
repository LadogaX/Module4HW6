using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6.Repositories
{
    public class SongRepo
    {
        private readonly ApplicationDbContext _context;

        public SongRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetCountRows()
        {
            try
            {
                return await _context.Songs.CountAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
