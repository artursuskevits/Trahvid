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
            base.Seed(db);
        }
    }
}
