using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Song").HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(t => t.Title).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(t => t.Duration).IsRequired();
            entityTypeBuilder.Property(t => t.ReleasedDate).IsRequired();

            entityTypeBuilder.HasOne(t => t.Genre)
                .WithMany(g => g.SongList)
                .HasForeignKey(t => t.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
