using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class StoreContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<Product> Products { get; set; }

}