namespace BeGirly.Infrastructure.Data
{
    public class BeGirlyDbContext:DbContext
    {
        public BeGirlyDbContext(DbContextOptions<BeGirlyDbContext> options):base(options)
        {
            
        }
    }
}
