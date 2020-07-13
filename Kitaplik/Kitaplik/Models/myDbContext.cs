using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kitaplik.Models
{
    public class myDbContext:DbContext
    {
        public DbSet<Kitap> Kitaps { get; set; }
    }
}