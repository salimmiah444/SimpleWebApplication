using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Application.Entities;

namespace Appliaction.DataAccess
{
    public class CompanyMapping: EntityTypeConfiguration<Company>
    {
        public CompanyMapping()
        {
            ToTable("Company");
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(
              DatabaseGeneratedOption.Identity);
     
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.CountryId).IsRequired();
            HasRequired(x => x.Country).WithMany().HasForeignKey(x => x.CountryId);
        }
    }
}