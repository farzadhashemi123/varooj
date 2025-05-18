using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class VarojContext : DbContext
{
    public VarojContext(DbContextOptions<DbContext> options) : base(options){}

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}