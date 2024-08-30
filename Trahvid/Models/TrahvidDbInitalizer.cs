using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Trahvid.Models;

namespace Trahvid.Models
{
    public class TrahvidDbInitalizer : DropCreateDatabaseAlways<TrahvidContext>
    {
        protected override void Seed(TrahvidContext db)
        {
            db.Traahv.Add(new Traahv
            {
               SoidukeNumber = "AAA 777",
                OmanikuNimi = "Oleg NEchiparenko",
                OmanikuEpost = "OLeg@gmail.coleg",
                Rikkumisekuupaev = DateTime.Parse("12.12.2021"),
                KiiruseUletamine = 12,
                TrahviSuurus = 1
            });
            base.Seed(db);
        }
    }
}
