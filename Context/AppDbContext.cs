using LanchesBotelho.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesBotelho.Context
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Snack> Snacks { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
