using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Artist").HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(t => t.DateOfBirth).IsRequired();
            entityTypeBuilder.Property(t => t.Email).HasMaxLength(50);
            entityTypeBuilder.Property(t => t.Phone).HasMaxLength(50);
            entityTypeBuilder.Property(t => t.InstagramUrl).HasMaxLength(255);

            entityTypeBuilder.HasMany(a => a.SongList)
                .WithMany(s => s.ArtistList)
                .UsingEntity<Dictionary<string, object>>(
                "ArtistSong",
                j => j.HasOne<Song>().WithMany().HasForeignKey("SongId"),
                j => j.HasOne<Artist>().WithMany().HasForeignKey("ArtistId"));
        }
    }
}
