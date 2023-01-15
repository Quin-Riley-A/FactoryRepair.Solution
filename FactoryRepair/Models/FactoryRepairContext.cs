using Microsoft.EntityFrameworkCore;

namespace FactoryRepair.Models
{
  public class FactoryRepairContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public FactoryRepairContext(DbContextOptions options) : base(options) { }
  }
}