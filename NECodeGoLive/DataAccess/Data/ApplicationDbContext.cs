﻿namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Code First:
        // 1) add-migration initialCommit (or similar)
        // 2) update-database

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Auto> Autos { get; set; } = null;
    }
}
