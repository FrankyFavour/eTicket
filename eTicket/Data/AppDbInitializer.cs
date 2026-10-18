using eTicket.Models;

namespace eTicket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema 
                if (!context.Cinemas.Any())
                {

                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                         new Cinema()
                    {
                        Name = "Ozone Cinema",
                        Logo = "https://pin.it/7MzJxqjrB",
                        Description = "This is the closest to you"
                    },
                    new Cinema()
                    {
                        Name = "MaryLand Cinema",
                        Logo = "https://pin.it/5bOgq6hRR",
                        Description = "This is the most expensive to you"
                    },
                    new Cinema()
                    {
                        Name = "Disney Cinema",
                        Logo = "https://pin.it/7lgfViilH",
                        Description = "This is the most expensive to you"
                    },
                    new Cinema()
                    {
                        Name = "MovieLand Cinema",
                        Logo = "https://pin.it/7p2JCD5Ig",
                        Description = "This is the most 5/10 to you"
                    },
                    new Cinema()
                    {
                        Name = "Plantium Cinema",
                        Logo = "https://pin.it/5470ZoohH",
                        Description = "This is the most 5/10 to you"
                    },
                });
                    context.SaveChanges();
                }

                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                         new Actor()
                    {
                        FullName = "Miyano Mamoru",
                        Bio = "Death Note, Steins-Gate, Mobile Suit Gundam 00, Durarara!!, Soul Eater....",
                        ProfilePictureURL = "https://cdn.myanimelist.net/images/voiceactors/1/66414.jpg",
                        //ProfilePictureURL = "https://cdn.animenewsnetwork.com/thumbnails/crop150x150gH7/encyc/P4271-1911943507.1481073082.jpg",
                    },
                         new Actor()
                    {
                        FullName = "Nobuhiko Okamoto",
                        Bio = "My Hero, Wind Breaker, Tower of God, Blue Exorcist, Haikyuu ...",
                        ProfilePictureURL = "https://cdn.myanimelist.net/s/common/uploaded_files/1590762156-647ded7bac5bb1417c1a0fa72b345c09.jpeg",
                    },
                         new Actor()
                    {
                        FullName = "Mariya Ise",
                        Bio = "HunterxHunter, JJK, Made in Abyss, Fairytail, Chainsaw-Man...",
                        ProfilePictureURL = "https://cdn.myanimelist.net/images/voiceactors/1/77122.jpg",
                    },
                         new Actor()
                    {
                        FullName = "Marina Inoue",
                        Bio = "Attack on Titan, Date a Live, Highschool of the dead, Pokemon ...",
                        ProfilePictureURL = "https://cdn.myanimelist.net/r/100x140/images/voiceactors/1/68016.jpg?s=9c373186986ed2eef50f6afd0f20b441",
                    },
                         new Actor()
                    {
                        FullName = "Daisuke Sakaguchi",
                        Bio = "Gintama, Clannad, Fire Force, Guilty Crown ...",
                        ProfilePictureURL = "https://cdn.animenewsnetwork.com/thumbnails/crop150x150gH7/encyc/P4271-1911943507.1481073082.jpg",
                    },
                });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Tetsurō Araki",
                            Bio = "Attack on Titan, Guilty Crown, Death Note, Bubble....",
                            ProfilePictureURL = "https://cdn.myanimelist.net/r/100x140/images/voiceactors/3/42598.jpg?s=85d766e0dcd28deb70a825833b1f090d"
                        },
                        new Producer()
                        {
                            FullName = "Yoichi Fujita",
                            Bio = "Gintama, Charlotte, Bleach....",
                            ProfilePictureURL = "https://s4.anilist.co/file/anilistcdn/staff/large/n107437-tOtrCkQn1AFs.png"
                        },
                        new Producer()
                        {
                            FullName = "Takuya Igarashi ",
                            Bio = "Bungo Stray Dogs, Noragami, FMAB....",
                            ProfilePictureURL = "https://s4.anilist.co/file/anilistcdn/staff/large/n105087-aoj9RdnTaZ45.png"
                        },
                         new Producer()
                        {
                            FullName = "Hayato Date",
                            Bio = "Naruto, Road to Ninja, Hidden leaf....",
                            ProfilePictureURL = "https://cdn.myanimelist.net/r/100x140/images/voiceactors/2/10555.jpg?s=8e4c994e6fbf000d4530661d58b75930"
                        },
                          new Producer()
                        {
                            FullName = "Gorō Taniguchi",
                            Bio = "Code Geass, One Piece, Lelouch of the Re-Surrection....",
                            ProfilePictureURL = "https://cdn.myanimelist.net/r/100x140/images/voiceactors/3/38177.jpg?s=984c7a4de5d038b1e71b9a7c277dd3a6"
                        },
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Death Note",
                            Description = "A teenage boy took justice into his hand with a book and pen",
                            Price = 40.00,
                            ImageFile = "https://cdn.myanimelist.net/r/100x140/images/manga/3/226633.webp?s=673d2665889fc99e199be267d9627594",
                            StartDate = new DateTime(2006, 10, 4),
                            EndDate = new DateTime(2007, 06, 27),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Seinen,
                        },
                        new Movie()
                        {
                            Name = "Attack On Titan",
                            Description = "A teenage boy doesnt make the right choices",
                            Price = 40.00,
                            ImageFile = "https://cdn.myanimelist.net/images/anime/1173/92110.jpg",
                            StartDate = new DateTime(2013, 04, 7),
                            EndDate = new DateTime(2023, 11, 19),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action,
                        },
                         new Movie()
                        {
                            Name = "Gintama",
                            Description = "One of a kind",
                            Price = 40.00,
                            ImageFile = "https://cdn.myanimelist.net/r/100x140/images/anime/4/28803.webp?s=a50daffcdbc89cd0211e204f9f6c51de",
                            StartDate = new DateTime(2011, 04, 4),
                            EndDate = new DateTime(2018, 10, 07),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Parody,
                        },
                          new Movie()
                        {
                            Name = "Bungo Stray Dogs",
                            Description = "Bunch of organization with fighting for a book",
                            Price = 40.00,
                            ImageFile = "https://cdn.myanimelist.net/r/100x140/images/anime/1161/136691.webp?s=34cba5e18806bad40d366efc35e3904f",
                            StartDate = new DateTime(2016, 04, 7),
                            EndDate = new DateTime(2023, 01, 04),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Mystery,
                        },
                           new Movie()
                        {
                            Name = "Naruto",
                            Description = "Hokage Dattebayo!!",
                            Price = 40.00,
                            ImageFile = "https://cdn.myanimelist.net/r/100x140/images/anime/1565/111305.webp?s=f1c392f9051726fc437d0697bc87f4ee",
                            StartDate = new DateTime(2003, 10, 03),
                            EndDate = new DateTime(2007, 02, 08),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Shonen,
                        },
                    });
                    context.SaveChanges();
                }

                //Actors $ movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
