using BaigorriaJuan.Models;
using Microsoft.EntityFrameworkCore;

namespace BaigorriaJuan.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor que toma opciones de configuración para el contexto de la BD.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Método llamado al crear el modelo de la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la clave primaria compuesta para la tabla intermedia Actor_Movie.
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            // Configuración de la relación entre la tabla Actor_Movie y la tabla Movie.
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);

            // Configuración de la relación entre la tabla Actor_Movie y la tabla Actor.
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            // Llamada al método base para continuar con la configuración del modelo.
            base.OnModelCreating(modelBuilder);
        }

        // Definición de DbSet para las entidades Actor , Movie, Actor_Movie, Cinema y Producer .
        public DbSet<Actor> Actors { get; set; }

        public DbSet<NewMovieVM> Movies { get; set; }

        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }
    }

}
