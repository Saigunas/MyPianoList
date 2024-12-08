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
    }
}
