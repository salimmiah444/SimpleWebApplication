using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Application.Entities;

namespace Appliaction.DataAccess
{
    public class CountryMapping : EntityTypeConfiguration<Country>
    {
        public CountryMapping()
        {
            ToTable("Country");
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(
              DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired();

        }
    }
}