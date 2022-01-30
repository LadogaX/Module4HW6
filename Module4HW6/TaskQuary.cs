namespace Module4HW6
{
    public class TaskQuary
    {
        private readonly ApplicationDbContext _context;

        public TaskQuary(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
