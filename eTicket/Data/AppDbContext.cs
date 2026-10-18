using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data
{
    public class AppDbContext:DbContext //helps communicate or connect the model to the database 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //helps communicate the many to many model to the Db
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //Below is called Dbset
        //Defining the table name or database name for each model
        //the dbset represent an entity set that can be used for create read update or delete operations.
        //the context class must include the Db set type properties for the entities which mapped to the DB table and views.
        //if we dont add any of the DB set, those will not be mapped to the DB and migration will not add that entites to our Db
        // i think you add db set for all the models you have and name them
        // after this step you add migration
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet <Producer> Producers { get; set; }

    }
}
