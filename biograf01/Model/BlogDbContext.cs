using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace biograf01.Model
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) //den laver selv instanserne . det hedder dependensies 
        {
            Database.Migrate();
        }
       
        public DbSet<Users> User { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<seats> seats { get; set; }
        public DbSet<Theater> Theater { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ZipCode> zipCode { get; set; } //one to one 
        public DbSet<MovieGenre> MovieGenre { get; set; } //1 - m  //  m - 1
        public DbSet<TheaterSeats> theaterSeats { get; set; } //1 - m  //  m - 1
        public DbSet<UserZipCode> userZipCode { get; set; }
        public DbSet<Show> Show { get; set; }

        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
            //dette er 1 - m  m-1 her er samlingstabellenn
            modelbuilder.Entity<MovieGenre>().HasKey(t => new { t.MovieId, t.GenreId });
            modelbuilder.Entity<TheaterSeats>().HasKey(t => new { t.TheaterId, t.SeatId });
            modelbuilder.Entity<UserZipCode>().HasKey(t => new { t.UserId, t.ZipCode });
            modelbuilder.Entity<Show>().HasKey(t => new { t.movieId, t.theaterId });
        }

    }
    
}
