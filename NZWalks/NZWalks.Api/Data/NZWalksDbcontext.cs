using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Data
{
    public class NZWalksDbcontext :DbContext
    {
        public NZWalksDbcontext(DbContextOptions<NZWalksDbcontext> options) : base(options)
        {
            
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Walkdifficulty> Walkdifficulty { get; set; }
    }
}
