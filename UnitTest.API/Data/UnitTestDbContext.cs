using Microsoft.EntityFrameworkCore;
using UnitTest.API.Models;

namespace UnitTest.API.Data
{
    public class UnitTestDbContext : DbContext
    {
        public UnitTestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }

        public override int SaveChanges()
        {

            trace();

            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            trace();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void trace()
        {
            var addEntity = ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
            foreach (var entity in addEntity)
            {
                Console.WriteLine("addEntity");
            }
            var modifiedEntity = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            foreach (var entity in modifiedEntity)
            {
                Console.WriteLine("modifiedEntity");
            }
            var deletedEntity = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);
            foreach (var entity in deletedEntity)
            {
                Console.WriteLine("deletedEntity");
            }
            var unchandedEntity = ChangeTracker.Entries().Where(x => x.State == EntityState.Unchanged);
            foreach (var entity in unchandedEntity)
            {
                Console.WriteLine("unchandedEntity");
            }
            var detachgedEntity = ChangeTracker.Entries().Where(x => x.State == EntityState.Detached);
            foreach (var entity in detachgedEntity)
            {
                Console.WriteLine("detachgedEntity");
            }
        }

    }
}
