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

            builder.HasOne(b => b.User).WithMany().HasForeignKey(b => b.UserId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
