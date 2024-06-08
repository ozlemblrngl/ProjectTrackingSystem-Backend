using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.ProjectId).HasColumnName("ProjectId").IsRequired();
            builder.Property(b => b.Title).HasColumnName("Title").IsRequired();
            builder.Property(b => b.Description).HasColumnName("Description");
            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();

            builder.HasOne(c => c.Project).WithMany(s => s.Assignments).HasForeignKey(e => e.ProjectId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


        }
    }
}
