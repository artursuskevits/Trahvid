using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trahvid.Models
{
    public class TrahvidContext : DbContext
    {
        public DbSet<Traahv> Traahv1 { get; set; }
        public DbSet<Login>  Login1 { get; set; }
    }
}