using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MyMvcApp.Data;

namespace MyMvcApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcCelebrityContext(
                   serviceProvider.GetRequiredService<DbContextOptions<MvcCelebrityContext>>()))
        {
            // Look for any celebrities.
            if (context.Celebrity.Any())
            {
                return;   // DB has been seeded
            }

            context.Celebrity.AddRange(
                new Celebrity
                {
                    Name = "Daniel Radcliffe",
                    BirthDate = DateTime.Parse("1989-2-12"),
                    Movies = new List<Movie>
                    {
                        new Movie
                        {
                            Title = "Harry Potter and the Sorcerer's Stone",
                            ReleaseData = DateTime.Parse("2001-11-16"),
                            Genre = "Fantasy",
                            Price = 9.99m
                        },
                        new Movie
                        {
                            Title = "Harry Potter and the Chamber of Secrets",
                            ReleaseData = DateTime.Parse("2002-11-15"),
                            Genre = "Fantasy",
                            Price = 9.99m
                        }
                    }
                },
                new Celebrity
                {
                    Name = "Tom Cruise",
                    BirthDate = DateTime.Parse("1962-07-03"),
                    Movies = new List<Movie>
                    {
                        new Movie
                        {
                            Title = "Top Gun",
                            ReleaseData = DateTime.Parse("1986-05-16"),
                            Genre = "Action",
                            Price = 9.99m
                        },
                        new Movie
                        {
                            Title = "Mission: Impossible",
                            ReleaseData = DateTime.Parse("1996-05-22"),
                            Genre = "Action",
                            Price = 9.99m
                        }
                    }
                },
                new Celebrity
                {
                    Name = "Mike Leahy",
                    BirthDate = DateTime.Parse("1989-03-02"),
                    Movies = new List<Movie>()
                }
            );
            context.SaveChanges();
        }
        
        using (var context = new MvcMovieContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseData = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseData = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseData = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseData = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "John Schmoe",
                    ReleaseData = DateTime.Parse("1919-4-15"),
                    Genre = "Action",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "John Wick 40",
                    ReleaseData = DateTime.Parse("2019-4-15"),
                    Genre = "Action",
                    Price = 14.99M
                }
            );
            context.SaveChanges();
        }
    }
}