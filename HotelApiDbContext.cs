using LandonAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace LandonAPI2
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions Options)
            : base(Options) { }
        
        public DbSet<RoomEntity> Rooms { get; set; }
    }
}
