using Microsoft.EntityFrameworkCore;
using StreamClass.Models;

namespace StreamClass.Context
{
    public static class SQLServerContextConnection
    {
        public static string GetInfosDatabaseConnection()
        {
            var databaseName = "StreamClass";
            var userName = "Streamclass";
            var password = "Ms2i76*";
            var host = "172.0.0.2\\SQLEXPRESS";

#if DEBUG
            host = "CSI9\\SQL2012";
            databaseName = "StreamClass";
            userName = "sa";
            password = "info";
#endif
            return $"Data Source={host};Initial Catalog={databaseName};User Id={userName};Password={password};";
        }
    }

    public class SQLServerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SQLServerContextConnection.GetInfosDatabaseConnection());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModuleTechnologie>().HasKey(x => new { x.IdModule, x.IdTechnologie });
            modelBuilder.Entity<ModuleVideo>().HasKey(x => new { x.IdModule, x.IdVideo });
            modelBuilder.Entity<ModuleUtilisateur>().HasKey(x => new { x.IdModule, x.IdUtilisateur });
            modelBuilder.Entity<ModuleCompetence>().HasKey(x => new { x.IdModule, x.IdCompetence });
            modelBuilder.Entity<SousThemeCompetence>().HasKey(x => new { x.IdSousTheme, x.IdCompetence });
        }

        public DbSet<Technologie> Technologies { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleTechnologie> ModulesTechnologies { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ModuleVideo> ModulesVideos { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<ModuleUtilisateur> ModulesUtilisateurs { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<ModuleCompetence> ModulesCompetences { get; set; }
        public DbSet<SousTheme> SousThemes { get; set; }
        public DbSet<ThemeCompetence> ThemesCompetences { get; set; }
        public DbSet<SousThemeCompetence> SousThemesCompetences { get; set; }
    }
}
