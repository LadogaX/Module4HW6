using Module4HW6.Helpers;
using Module4HW6.Repositories;

namespace Module4HW6
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                GoTransaction goTransaction = new GoTransaction();

                if (new ArtistRepo(context).GetCountRows().Result == 0 && new SongRepo(context).GetCountRows().Result == 0)
                {
                    await goTransaction.Start(() => new AddInitRows(context).FillArtistSongs());
                }

                if (new GenreRepo(context).GetCountRows().Result == 0)
                {
                    await goTransaction.Start(() => new AddInitRows(context).FillGenres());
                }

                var taskQuary = new TaskQuary(context);

                // await taskQuary.Task1a();
                // await taskQuary.Task1a();
                // await taskQuary.Task2();
                await taskQuary.Task3();
            }
        }
    }
}