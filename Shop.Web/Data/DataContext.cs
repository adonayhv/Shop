
namespace Shop.Web.Data
{
using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Entities;

    public class DataContext : DbContext
    {
      

      //  public DataContext(DbContextOptions<DataContext> options) : base(options)
        
            public DataContext (DbContextOptions<DataContext> options) :base(options)
            {

            }

            public DbSet<Product> Products { get; set; }
    }

    }

    

