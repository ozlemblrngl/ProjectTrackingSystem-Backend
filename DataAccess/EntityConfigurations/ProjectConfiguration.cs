using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
            builder.Property(b => b.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(b => b.EndDate).HasColumnName("EndDate").IsRequired();

            builder.HasOne(c => c.User).WithMany(s => s.Projects).HasForeignKey(e => e.UserId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
