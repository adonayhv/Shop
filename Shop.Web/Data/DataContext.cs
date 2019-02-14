
namespace Shop.Web.Data
{
using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


    public class DataContext : IdentityDbContext<User>

    {


        //  public DataContext(DbContextOptions<DataContext> options) : base(options)

        public DataContext (DbContextOptions<DataContext> options) :base(options)
            {

            }

            public DbSet<Product> Products { get; set; }
    }

    }

    

