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
            var operas = new List<Opera>()
            {
                new Opera()
                {
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Mozart"
                }
            };

            operas.ForEach( s => context.Operas.Add(s) );

            context.SaveChanges();
        }
    }
}