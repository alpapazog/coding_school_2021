using Microsoft.EntityFrameworkCore;
using OnlineTrainingCourses.EF.Configuration;
using OnlineTrainingCourses.Model;

namespace OnlineTrainingCourses.EF.Context {
    public class OnlineTrainingCoursesAppContext : DbContext {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public OnlineTrainingCoursesAppContext() : base() {

        }
        public OnlineTrainingCoursesAppContext(DbContextOptions options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9DVRBJG;Initial Catalog=OnlineTrainingCoursesApp;
Integrated Security=True;Connect Timeout=30;Encrypt=False;
TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.Entity<Student>()
                .HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students);
                //.Map(cs => {
                //    cs.MapLeftKey("StudentRefId");
                //    cs.MapRightKey("CourseRefId");
                //    cs.ToTable("StudentCourse");
                //});

            base.OnModelCreating(modelBuilder);
        }

    }
}
