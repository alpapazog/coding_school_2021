using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTrainingCourses.Model;
using System;

namespace OnlineTrainingCourses.EF.Configuration {
    public class CourseConfiguration : IEntityTypeConfiguration<Course> {
        public void Configure(EntityTypeBuilder<Course> builder) {
            builder.ToTable("Courses");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(x => x.Title).HasMaxLength(200).IsRequired(true);

            builder.Property(x => x.Category).HasMaxLength(200).IsRequired(true);
        }
    }
}
