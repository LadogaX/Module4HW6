using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Genre").HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(t => t.Title).IsRequired().HasMaxLength(50);
        }
    }
}