namespace MovieApplication.Migrations
{
    using MovieApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieApplication.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieApplication.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "The Notebook",
                    ReleaseDate = DateTime.Parse("2004-6-25"),
                    Genre = "Romance",
                    Rating = "PG-13",
                    Price = 4.99M
                },

                 new Movie
                 {
                     Title = "P.S. I Love You",
                     ReleaseDate = DateTime.Parse("2007-12-21"),
                     Genre = "Romance",
                     Rating = "PG-13",
                     Price = 4.99M
                 },

                 new Movie
                 {
                     Title = "Bridesmaids",
                     ReleaseDate = DateTime.Parse("2011-4-28"),
                     Genre = "Comedy",
                     Rating = "R",
                     Price = 6.99M
                 },

               new Movie
               {
                   Title = "In Her Shoes",
                   ReleaseDate = DateTime.Parse("2005-9-14"),
                   Genre = "Drama",
                   Rating = "PG-13",
                   Price = 4.99M
               }
           );

        }
    }
}
