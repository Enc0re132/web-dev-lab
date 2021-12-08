using CountriesGame.Dal.Entities;
using CountriesGame.Dal.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CountriesGame.Dal.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CountryEntityTypeConfiguration())
                .ApplyConfiguration(new LinkEntityTypeConfiguration())
                .ApplyConfiguration(new UserEntityTypeConfiguration());
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Link> Links { get; set; } 
    }
}