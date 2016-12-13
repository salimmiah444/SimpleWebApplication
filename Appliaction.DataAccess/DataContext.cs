using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;

namespace Appliaction.DataAccess
{
    public class DataContext: DbContext
    {
        public DataContext(): base("Name=SampleApplication")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder b)
        {
            b.Configurations.Add(new CompanyMapping());
            b.Configurations.Add(new CountryMapping());
           
        }
    }
}
