using Ahlatci.Eticaret.Domain.Entities;
using Ahlatci.Eticaret.PersistenceData.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ahlatci.Eticaret.Persistence.Mappings
{
    public class CategoryMapping : AuditableEntityMapping<Category>
    {
        public override void ConfigureDerivedEntityMapping(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(100)")
                .HasColumnName("CATEGORY_NAME")
                .HasColumnOrder(2);

            builder.ToTable("CATEGORIES");
        }
    }
}
