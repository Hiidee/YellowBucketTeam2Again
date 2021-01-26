using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YellowBucket.Models;

namespace YellowBucket.Data
{
    public class YellowBucketContext : DbContext
    {
        public YellowBucketContext (DbContextOptions<YellowBucketContext> options)
            : base(options)
        {
        }

        public DbSet<YellowBucket.Models.Movie> Movie { get; set; }

        public DbSet<YellowBucket.Models.Genre> Genre { get; set; }

        public DbSet<YellowBucket.Models.Rating> Rating { get; set; }
    }
}
