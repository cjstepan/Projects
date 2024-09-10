using Microsoft.EntityFrameworkCore;
using MusicShop.com.Data;

namespace MusicShop.com.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicShopcomContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicShopcomContext>>()))
            {

                // Look for any music.
                if (context.Music.Any() || context.Price.Any() || context.User.Any())
                {
                    return;   // DB has been seeded
                }

                // Seed Music data
                context.Music.AddRange(
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Taylor Swift",
                        Song = "Welcome to New York",
                        Price = 3.33M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Taylor Swift",
                        Song = "Blank Space",
                        Price = 2.99M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Taylor Swift",
                        Song = "Style",
                        Price = 5.49M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Taylor Swift",
                        Song = "Bad Blood",
                        Price = 2.29M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Taylor Swift",
                        Song = "Wildest Dreams",
                        Price = 1.19M
                    },
                    new Music
                    {
                        Genre = "Rock",
                        Performer = "Queen",
                        Song = "Bohemian Rhapsody",
                        Price = 2.99M
                    },
                    new Music
                    {
                        Genre = "Hip-Hop",
                        Performer = "Kendrick Lamar",
                        Song = "HUMBLE.",
                        Price = 3.49M
                    },
                    // Add more Music entries as needed
                    new Music
                    {
                        Genre = "Country",
                        Performer = "Johnny Cash",
                        Song = "Ring of Fire",
                        Price = 2.25M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Ed Sheeran",
                        Song = "Shape of You",
                        Price = 1.79M
                    },
                    new Music
                    {
                        Genre = "Rock",
                        Performer = "The Beatles",
                        Song = "Hey Jude",
                        Price = 2.89M
                    },
                    new Music
                    {
                        Genre = "Electronic",
                        Performer = "Daft Punk",
                        Song = "Get Lucky",
                        Price = 4.15M
                    },
                    new Music
                    {
                        Genre = "R&B",
                        Performer = "Beyoncé",
                        Song = "Crazy in Love",
                        Price = 3.99M
                    },
                    new Music
                    {
                        Genre = "Pop",
                        Performer = "Adele",
                        Song = "Hello",
                        Price = 2.49M
                    },
                    new Music
                    {
                        Genre = "Rock",
                        Performer = "Led Zeppelin",
                        Song = "Stairway to Heaven",
                        Price = 3.79M
                    }
                );

                // Seed Price data
                context.Price.AddRange(
                    new Price
                    {
                        digitalPrice = 0.99M,
                        vinylPrice = 15.99M,
                        cdPrice = 9.99M
                    },
                    // Add more Price entries as needed
                    new Price
                    {
                        digitalPrice = 1.25M,
                        vinylPrice = 18.99M,
                        cdPrice = 11.49M
                    },
                    new Price
                    {
                        digitalPrice = 1.49M,
                        vinylPrice = 21.99M,
                        cdPrice = 12.99M
                    },
                    new Price
                    {
                        digitalPrice = 1.75M,
                        vinylPrice = 24.99M,
                        cdPrice = 14.49M
                    },
                    new Price
                    {
                        digitalPrice = 1.99M,
                        vinylPrice = 27.99M,
                        cdPrice = 16.99M
                    },
                    new Price
                    {
                        digitalPrice = 1.25M,
                        vinylPrice = 18.99M,
                        cdPrice = 11.49M
                    },
                    new Price
                    {
                        digitalPrice = 1.49M,
                        vinylPrice = 21.99M,
                        cdPrice = 12.99M
                    },
                    new Price
                    {
                        digitalPrice = 1.75M,
                        vinylPrice = 24.99M,
                        cdPrice = 14.49M
                    },
                    new Price
                    {
                        digitalPrice = 1.99M,
                        vinylPrice = 27.99M,
                        cdPrice = 16.99M
                    },
                    new Price
                    {
                        digitalPrice = 2.25M,
                        vinylPrice = 30.99M,
                        cdPrice = 18.49M
                    },
                    new Price
                    {
                        digitalPrice = 2.49M,
                        vinylPrice = 33.99M,
                        cdPrice = 19.99M
                    },
                    new Price
                    {
                        digitalPrice = 2.75M,
                        vinylPrice = 36.99M,
                        cdPrice = 21.49M
                    },
                    new Price
                    {
                        digitalPrice = 2.99M,
                        vinylPrice = 39.99M,
                        cdPrice = 22.99M
                    },
                    new Price
                    {
                        digitalPrice = 3.25M,
                        vinylPrice = 42.99M,
                        cdPrice = 24.49M
                    }
                );

                context.User.AddRange(
                    new User
                    {
                        UserName = "calvin",
                        Password = "calvin",
                        UserType = "member"
                    },
                    new User
                    {
                        UserName = "admin",
                        Password = "admin",
                        UserType = "admin"
                    }
                ); ;

                context.SaveChanges();
            }
        }



    }
}
