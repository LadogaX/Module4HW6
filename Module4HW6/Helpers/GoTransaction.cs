using Microsoft.EntityFrameworkCore;

namespace Module4HW6.Helpers
{
    public class GoTransaction
    {
        public async Task Start(Func<Task> func)
        {
            string[] args = new string[1];
            await using (var transaction = await new SampleContextFactory().CreateDbContext(args).Database.BeginTransactionAsync())
            {
                try
                {
                    await func();
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                }
            }
        }
    }
}
