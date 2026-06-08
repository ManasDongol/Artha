using ArthaInventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ArthaInventoryManagementSystem.Data;

public class ArthaDbContext(DbContextOptions<ArthaDbContext> options) : DbContext(options)
{
    
    public DbSet<AppUser> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Billing> Billings { get; set; }
    public DbSet<BillingItem> BillingItems { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}