using System.Data.Entity;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.FluentMappings;

namespace ProjectTemplate.Core.EF
{
    public class ProjectTemplateContext : DbContext
    {
        public ProjectTemplateContext()
            : base("ProjectTemplateContext")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectTemplateContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectTemplateContext, ProjectTemplateConfiguration>());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmType> FilmTypes { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //gerekli ise
            //modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}
