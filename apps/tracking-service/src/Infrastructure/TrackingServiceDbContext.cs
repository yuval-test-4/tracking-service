using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrackingService.Infrastructure.Models;

namespace TrackingService.Infrastructure;

public class TrackingServiceDbContext : IdentityDbContext<IdentityUser>
{
    public TrackingServiceDbContext(DbContextOptions<TrackingServiceDbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
