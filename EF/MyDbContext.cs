using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class MyDbContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        public MyDbContext()
        {
            Database.Connection.ConnectionString = @"Data Source=.;Initial Catalog=anlat;Integrated Security=True";
            Database.SetInitializer<MyDbContext>(null);
        }
        public DbSet<Uye> Uye { get; set; }

    }



}
