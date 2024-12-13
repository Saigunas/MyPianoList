using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyPianoList.Domain;
using MyPianoList.Domain.AuthorizationModels;
using System.Data;

namespace MyPianoList.Infrastructure
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<PianoSheet> PianoSheet { get; set; } = default!;
        public DbSet<Tag> Tag { get; set; } = default!;
        public DbSet<PianoSheetTag> PianoSheetTag { get; set; } = default!;
        public DbSet<Status> Status { get; set; } = default!;
        public DbSet<Rating> Rating { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {        }



    }
}