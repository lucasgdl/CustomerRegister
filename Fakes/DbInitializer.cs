using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fakes
{
    public class DbInitializer
    {
        public static void Seed(DbContextOptions options = null)
        {
            var builder = new DbContextOptionsBuilder<QContext>();

            builder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Integrated Security = True; Initial Catalog = TestsDb");
            var context = new QContext(options ?? builder.Options);

            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
