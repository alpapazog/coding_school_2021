using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTrainingCourses.Model;
using System;

namespace OnlineTrainingCourses.EF.Configuration {
    public class StudentConfiguration : IEntityTypeConfiguration<Student> {
        public void Configure(EntityTypeBuilder<Student> builder) {
            builder.ToTable("Students");

            builder.HasKey(x => x.ID);
            
            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Birthdate).HasColumnType("date").IsRequired(true);
        }
    }
}
