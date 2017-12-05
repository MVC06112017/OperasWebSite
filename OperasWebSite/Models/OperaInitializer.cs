using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperasWebSite.Models
{
    public class OperaInitializer : DropCreateDatabaseAlways<OperaDB>
    {
        protected override void Seed(OperaDB context)
        {
            var operas = new List<Opera>
            {
                new Opera {
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera {
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera {
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera {
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                }
            };

            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
                new Review {
                    OperaID = 1,
                    Date = new DateTime(2002, 4, 20),
                    Company = "Metropolitan Opera",
                    ReviewText = "Not a bad version, but a little unimaginative"
                },
                new Review {
                    OperaID = 1,
                    Date = new DateTime(2007, 11, 3),
                    Company = "Opera Company of Philadelphia",
                    ReviewText = "The best I've seen."
                },
                new Review {
                    OperaID = 1,
                    Date = new DateTime(2002, 4, 20),
                    Company = "Washington National Opera",
                    ReviewText = "Set in the modern world, which I think really detracted from the drama."
                }
            };

            reviews.ForEach(r => context.Reviews.Add(r));
            context.SaveChanges();

        }
    }
}