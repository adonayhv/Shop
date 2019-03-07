
namespace Shop.Web.Data
{
using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using System.Linq;

    public class DataContext : IdentityDbContext<User>

    {


        //  public DataContext(DbContextOptions<DataContext> options) : base(options)
        public DbSet<Product> Products { get; set; }
        //ENTIDAD COUNTRY
        public DbSet<Country> Countries { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderDetailTemp> OrderDetailTemps { get; set; }


        public DataContext (DbContextOptions<DataContext> options) :base(options)
            {

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

            //para evitar el delete in cascade

            var cascadeFKs = modelBuilder.Model
           .G­etEntityTypes()
           .SelectMany(t => t.GetForeignKeys())
           .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }


            base.OnModelCreating(modelBuilder);
        }


    }

}

    

